/* Copyright (c) Microsoft Corporation. All rights reserved.
   Licensed under the MIT License. */

using log4net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Polly;
using Quartz;
using RecurringIntegrationsScheduler.Common.Contracts;
using RecurringIntegrationsScheduler.Common.Helpers;
using RecurringIntegrationsScheduler.Common.JobSettings;
using RecurringIntegrationsScheduler.Job.Properties;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml;

namespace RecurringIntegrationsScheduler.Job
{
    /// <summary>
    /// Job that checks execution status of import jobs
    /// </summary>
    /// <seealso cref="IJob" />
    [DisallowConcurrentExecution]
    public class ExecutionMonitor : IJob
    {
        /// <summary>
        /// The log
        /// </summary>
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// The settings
        /// </summary>
        private readonly ExecutionJobSettings _settings = new ExecutionJobSettings();

        /// <summary>
        /// The context
        /// </summary>
        private IJobExecutionContext _context;

        /// <summary>
        /// The HTTP client helper
        /// </summary>
        private HttpClientHelper _httpClientHelper;

        /// <summary>
        /// Gets or sets the enqueued jobs.
        /// </summary>
        /// <value>
        /// The enqueued jobs.
        /// </value>
        private ConcurrentQueue<DataMessage> EnqueuedJobs { get; set; }

        private StreamWriter _streamWriter;

        /// <summary>
        /// Retry policy for IO operations
        /// </summary>
        private Policy _retryPolicyForIo;

        /// <summary>
        /// Retry policy for HTTP operations
        /// </summary>
        private Polly.Retry.AsyncRetryPolicy _retryPolicyForHttp;

        /// <summary>
        /// Called by the <see cref="T:Quartz.IScheduler" /> when a <see cref="T:Quartz.ITrigger" />
        /// fires that is associated with the <see cref="T:Quartz.IJob" />.
        /// </summary>
        /// <param name="context">The execution context.</param>
        /// <exception cref="JobExecutionException">false</exception>
        /// <remarks>
        /// The implementation may wish to set a  result object on the
        /// JobExecutionContext before this method exits.  The result itself
        /// is meaningless to Quartz, but may be informative to
        /// <see cref="T:Quartz.IJobListener" />s or
        /// <see cref="T:Quartz.ITriggerListener" />s that are watching the job's
        /// execution.
        /// </remarks>
        public async Task Execute(IJobExecutionContext context)
        {
            try
            {
                log4net.Config.XmlConfigurator.Configure();
                _context = context;
                _settings.Initialize(context);

                if (_settings.IndefinitePause)
                {
                    await context.Scheduler.PauseJob(context.JobDetail.Key);
                    Log.InfoFormat(CultureInfo.InvariantCulture,
                        string.Format(Resources.Job_0_was_paused_indefinitely, _context.JobDetail.Key));
                    return;
                }

                _retryPolicyForIo = Policy.Handle<IOException>().WaitAndRetry(
                    retryCount: _settings.RetryCount, 
                    sleepDurationProvider: attempt => TimeSpan.FromSeconds(_settings.RetryDelay),
                    onRetry: (exception, calculatedWaitDuration) => 
                    {
                        Log.WarnFormat(CultureInfo.InvariantCulture, string.Format(Resources.Job_0_Retrying_IO_operation_Exception_1, _context.JobDetail.Key, exception.Message));
                    });
                _retryPolicyForHttp = Policy.Handle<HttpRequestException>().WaitAndRetryAsync(
                    retryCount: _settings.RetryCount, 
                    sleepDurationProvider: attempt => TimeSpan.FromSeconds(_settings.RetryDelay),
                    onRetry: (exception, calculatedWaitDuration) => 
                    {
                        Log.WarnFormat(CultureInfo.InvariantCulture, string.Format(Resources.Job_0_Retrying_Http_operation_Exception_1, _context.JobDetail.Key, exception.Message));
                    });
                if (Log.IsDebugEnabled)
                    Log.DebugFormat(CultureInfo.InvariantCulture, string.Format(Resources.Job_0_starting, _context.JobDetail.Key));

                await Process();

                if (Log.IsDebugEnabled)
                    Log.DebugFormat(CultureInfo.InvariantCulture, string.Format(Resources.Job_0_ended, _context.JobDetail.Key));
            }
            catch (Exception ex)
            {
                if (_settings.PauseJobOnException)
                {
                    await context.Scheduler.PauseJob(context.JobDetail.Key);
                    Log.WarnFormat(CultureInfo.InvariantCulture,
                        string.Format(Resources.Job_0_was_paused_because_of_error, _context.JobDetail.Key));
                }
                if (Log.IsDebugEnabled)
                {
                    if (!string.IsNullOrEmpty(ex.Message))
                    {
                        Log.Error(ex.Message, ex);
                    }
                    else
                    {
                        Log.Error("Uknown exception", ex);
                    }

                    while (ex.InnerException != null)
                    {
                        if (!string.IsNullOrEmpty(ex.InnerException.Message))
                            Log.Error(ex.InnerException.Message, ex.InnerException);

                        ex = ex.InnerException;
                    }
                }
                if (context.Scheduler.SchedulerName != "Private")
                    throw new JobExecutionException(string.Format(Resources.Execution_monitor_job_0_failed, _context.JobDetail.Key), ex, false);

                if (!Log.IsDebugEnabled)
                    Log.Error(string.Format(Resources.Job_0_thrown_an_error_1, _context.JobDetail.Key, ex.Message));
            }
        }

        /// <summary>
        /// Processes this instance.
        /// </summary>
        /// <returns></returns>
        private async Task Process()
        {
            EnqueuedJobs = new ConcurrentQueue<DataMessage>();
            foreach (var dataMessage in FileOperationsHelper.GetStatusFiles(MessageStatus.InProcess, _settings.UploadSuccessDir, "*" + _settings.StatusFileExtension))
            {
                if (Log.IsDebugEnabled)
                    Log.DebugFormat(CultureInfo.InvariantCulture,
                        string.Format(Resources.Job_0_File_1_found_in_processing_location_and_added_to_queue_for_status_check, _context.JobDetail.Key, dataMessage.FullPath.Replace(@"{", @"{{").Replace(@"}", @"}}")));

                EnqueuedJobs.Enqueue(dataMessage);
            }

            if (!EnqueuedJobs.IsEmpty)
                await ProcessEnqueuedQueue();
        }

        /// <summary>
        /// Process enqueued files
        /// </summary>
        /// <returns></returns>
        private async Task ProcessEnqueuedQueue()
        {
            _httpClientHelper = new HttpClientHelper(_settings, _retryPolicyForHttp);

            while (EnqueuedJobs.TryDequeue(out DataMessage dataMessage))
            {
                // Check status for current item with message id - item.Key
                var jobStatusDetail = await _httpClientHelper.GetExecutionSummaryStatus(dataMessage.MessageId);

                // If status was found and is not null,
                if (jobStatusDetail != null)
                    await PostProcessMessage(jobStatusDetail, dataMessage);

                System.Threading.Thread.Sleep(_settings.Interval);
            }
        }

        /// <summary>
        /// Process message once status is received by moving document to the
        /// appropriate folder and writing out a log for the processed document
        /// </summary>
        /// <param name="executionStatus">Execution status</param>
        /// <param name="dataMessage">Name of the file whose status is being processed</param>
        private async Task PostProcessMessage(string executionStatus, DataMessage dataMessage)
        {
            if (Log.IsDebugEnabled)
                Log.DebugFormat(CultureInfo.InvariantCulture,
                    string.Format(Resources.Job_0_Execution_1_status_check_returned_2, _context.JobDetail.Key, dataMessage.MessageId, executionStatus));
            switch (executionStatus)
            {
                case "Succeeded":
                    {
                        // Move message file and delete processing status file
                        var processingSuccessDestination = Path.Combine(_settings.ProcessingSuccessDir, dataMessage.Name);
                        _retryPolicyForIo.Execute(() => FileOperationsHelper.MoveDataToTarget(dataMessage.FullPath, processingSuccessDestination, true, _settings.StatusFileExtension));
                        await CreateLinkToExecutionSummaryPage(dataMessage.MessageId, processingSuccessDestination);
                    }
                    break;
                case "Unknown":
                case "PartiallySucceeded":
                case "Failed":
                case "Canceled":
                    {
                        var processingErrorDestination = Path.Combine(_settings.ProcessingErrorsDir, dataMessage.Name);
                        _retryPolicyForIo.Execute(() => FileOperationsHelper.MoveDataToTarget(dataMessage.FullPath, processingErrorDestination, true, _settings.StatusFileExtension));
                        await CreateLinkToExecutionSummaryPage(dataMessage.MessageId, processingErrorDestination);
                        if (_settings.GetImportTargetErrorKeysFile)
                        {
                            var entitiesInPackage = GetEntitiesNamesInPackage(processingErrorDestination);
                            foreach(var entity in entitiesInPackage)
                            {
                                var errorsExist = await _httpClientHelper.GenerateImportTargetErrorKeysFile(dataMessage.MessageId, entity);
                                if (errorsExist)
                                {
                                    var errorFileUrl = "";
                                    while (errorFileUrl == "")
                                    {
                                        errorFileUrl = await _httpClientHelper.GetImportTargetErrorKeysFileUrl(dataMessage.MessageId, entity);
                                        if (errorFileUrl == "")
                                        {
                                            System.Threading.Thread.Sleep(_settings.Interval);
                                        }
                                    }
                                    var response = await _httpClientHelper.GetRequestAsync(new UriBuilder(errorFileUrl).Uri, false);
                                    if (!response.IsSuccessStatusCode)
                                        throw new JobExecutionException(string.Format(Resources.Job_0_download_of_error_keys_file_failed_1, _context.JobDetail.Key, string.Format($"Status: {response.StatusCode}. Message: {response.Content}")));

                                    using (Stream downloadedStream = await response.Content.ReadAsStreamAsync())
                                    {
                                        var errorsFileName = $"{Path.GetFileNameWithoutExtension(dataMessage.Name)}-{entity}-ErrorKeys-{DateTime.Now:yyyy-MM-dd_HH-mm-ss-ffff}.txt";
                                        var errorsFilePath = Path.Combine(_settings.ProcessingErrorsDir, errorsFileName);
                                        var dataMessageForErrorsFile = new DataMessage()
                                        {
                                            FullPath = errorsFilePath,
                                            Name = errorsFileName,
                                            MessageStatus = MessageStatus.Failed
                                        };
                                        _retryPolicyForIo.Execute(() => FileOperationsHelper.Create(downloadedStream, dataMessageForErrorsFile.FullPath));
                                    }
                                }
                            }
                        }
                    }
                    break;
                default: //"NotRun", "Executing"
                    break;
            }
        }

        private async Task CreateLinkToExecutionSummaryPage(string messageId, string filePath)
        {
            var directoryName = Path.GetDirectoryName(filePath);
            if (directoryName == null)
                throw new NullReferenceException();

            var logFilePath = Path.Combine(directoryName, Path.GetFileNameWithoutExtension(filePath) + ".url");

            var linkUrl = await _httpClientHelper.GetExecutionSummaryPageUrl(messageId);

            using (_streamWriter = new StreamWriter(logFilePath))
            {
                _streamWriter.WriteLine("[InternetShortcut]");
                _streamWriter.WriteLine("URL=" + linkUrl);
                _streamWriter.Flush();
            }
        }

        /// <summary>
        /// Reads the Manifest.xml file of the datapackage to get entity names to query for error key file
        /// </summary>
        /// <param name="filename">The data package file</param>
        /// <returns>Entities list</returns>
        private List<string> GetEntitiesNamesInPackage(string fileName)
        {
            var manifestPath = "";
            using (var package = ZipFile.OpenRead(fileName))
            {
                foreach (var entry in package.Entries)
                {
                    if (entry.FullName.Equals("Manifest.xml", StringComparison.OrdinalIgnoreCase))
                    {
                        manifestPath = Path.Combine(Path.GetTempPath(), $"{_context.JobDetail.Key}-{entry.FullName}");
                        entry.ExtractToFile(manifestPath, true);
                    }
                }
            }
            var doc = new XmlDocument();
            XmlNodeList entities;
            using (var manifestFile = new StreamReader(manifestPath))
            {
                doc.Load(new XmlTextReader(manifestFile) { Namespaces = false });
                entities = doc.SelectNodes("//EntityName");
            }
            var enitiesList = new List<string>();
            foreach(XmlNode node in entities)
            {
                enitiesList.Add(node.InnerText);
            }
            return enitiesList;
        }
    }
}