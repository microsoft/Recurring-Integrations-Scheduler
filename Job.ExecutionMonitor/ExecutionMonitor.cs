/* Copyright (c) Microsoft Corporation. All rights reserved.
   Licensed under the MIT License. */

using log4net;
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

                if (_settings.LogVerbose || Log.IsDebugEnabled)
                {
                    Log.DebugFormat(CultureInfo.InvariantCulture, string.Format(Resources.Job_0_starting, _context.JobDetail.Key));
                }
                await Process();

                if (_settings.LogVerbose || Log.IsDebugEnabled)
                {
                    Log.DebugFormat(CultureInfo.InvariantCulture, string.Format(Resources.Job_0_ended, _context.JobDetail.Key));
                }
            }
            catch (Exception ex)
            {
                if (_settings.PauseJobOnException)
                {
                    await context.Scheduler.PauseJob(context.JobDetail.Key);
                    Log.WarnFormat(CultureInfo.InvariantCulture, string.Format(Resources.Job_0_was_paused_because_of_error, _context.JobDetail.Key));
                }
                if (_settings.LogVerbose || Log.IsDebugEnabled)
                {
                    if (!string.IsNullOrEmpty(ex.Message))
                    {
                        Log.Error(ex.Message, ex);
                    }
                }
                if (context.Scheduler.SchedulerName != "Private")
                {
                    throw new JobExecutionException(string.Format(Resources.Execution_monitor_job_0_failed, _context.JobDetail.Key), ex, false);
                }
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
                if (_settings.LogVerbose || Log.IsDebugEnabled)
                {
                    Log.DebugFormat(CultureInfo.InvariantCulture, string.Format(Resources.Job_0_File_1_found_in_processing_location_and_added_to_queue_for_status_check, _context.JobDetail.Key, dataMessage.FullPath.Replace(@"{", @"{{").Replace(@"}", @"}}")));
                }
                EnqueuedJobs.Enqueue(dataMessage);
            }

            if (!EnqueuedJobs.IsEmpty)
            {
                await ProcessEnqueuedQueue();
            }
        }

        /// <summary>
        /// Process enqueued files
        /// </summary>
        /// <returns></returns>
        private async Task ProcessEnqueuedQueue()
        {
            var fileCount = 0;
            _httpClientHelper = new HttpClientHelper(_settings);

            while (EnqueuedJobs.TryDequeue(out DataMessage dataMessage))
            {
                if (fileCount > 0 && _settings.DelayBetweenStatusCheck > 0) //Only delay after first file and never after last.
                {
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(_settings.DelayBetweenStatusCheck));
                }
                fileCount++;

                // Check status for current item with message id - item.Key
                var responseGetExecutionSummaryStatus = await _httpClientHelper.GetExecutionSummaryStatus(dataMessage.MessageId);
                if(!responseGetExecutionSummaryStatus.IsSuccessStatusCode)
                {
                    throw new JobExecutionException($@"Job: {_settings.JobKey}. GetExecutionSummaryStatus request failed.");
                }
                var jobStatusDetail = HttpClientHelper.ReadResponseString(responseGetExecutionSummaryStatus);

                // If status was found and is not null,
                if (jobStatusDetail != null)
                {
                    await PostProcessMessage(jobStatusDetail, dataMessage);
                }
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
            if (_settings.LogVerbose || Log.IsDebugEnabled)
            {
                Log.DebugFormat(CultureInfo.InvariantCulture, string.Format(Resources.Job_0_ExecutionId_1_status_check_returned_2, _context.JobDetail.Key, dataMessage.MessageId, executionStatus));
            }
            switch (executionStatus)
            {
                case "Succeeded":
                    {
                        // Move message file and delete processing status file
                        var processingSuccessDestination = dataMessage.FullPath.Replace(_settings.UploadSuccessDir, _settings.ProcessingSuccessDir);
                        _retryPolicyForIo.Execute(() => FileOperationsHelper.MoveDataToTarget(dataMessage.FullPath, processingSuccessDestination, true, _settings.StatusFileExtension));
                        await CreateLinkToExecutionSummaryPage(dataMessage.MessageId, processingSuccessDestination);
                    }
                    break;
                case "Unknown":
                case "PartiallySucceeded":
                case "Failed":
                case "Canceled":
                    {
                        var processingErrorDestination = dataMessage.FullPath.Replace(_settings.UploadSuccessDir, _settings.ProcessingErrorsDir);
                        _retryPolicyForIo.Execute(() => FileOperationsHelper.MoveDataToTarget(dataMessage.FullPath, processingErrorDestination, true, _settings.StatusFileExtension));
                        await CreateLinkToExecutionSummaryPage(dataMessage.MessageId, processingErrorDestination);
                        if (_settings.GetImportTargetErrorKeysFile)
                        {
                            if (_settings.LogVerbose || Log.IsDebugEnabled)
                            {
                                Log.DebugFormat(CultureInfo.InvariantCulture, string.Format(Resources.Job_0_Checking_if_error_keys_file_was_generated, _context.JobDetail.Key));
                            }
                            var fileWithManifest = processingErrorDestination;
                            if(!string.IsNullOrEmpty(_settings.PackageTemplate))
                            {
                                fileWithManifest = _settings.PackageTemplate;
                            }
                            var entitiesInPackage = GetEntitiesNamesInPackage(fileWithManifest);
                            foreach(var entity in entitiesInPackage)
                            {
                                if (_settings.LogVerbose || Log.IsDebugEnabled)
                                {
                                    Log.DebugFormat(CultureInfo.InvariantCulture, string.Format(Resources.Job_0_Checking_for_error_keys_for_data_entity_1, _context.JobDetail.Key, entity));
                                }
                                var errorsExistResponse = await _httpClientHelper.GenerateImportTargetErrorKeysFile(dataMessage.MessageId, entity);
                                if (errorsExistResponse.IsSuccessStatusCode && Convert.ToBoolean(HttpClientHelper.ReadResponseString(errorsExistResponse)))
                                {
                                    var errorFileUrl = string.Empty;
                                    HttpResponseMessage errorFileUrlResponse;
                                    do
                                    {
                                        errorFileUrlResponse = await _httpClientHelper.GetImportTargetErrorKeysFileUrl(dataMessage.MessageId, entity);
                                        if(errorFileUrlResponse.IsSuccessStatusCode)
                                        {
                                            errorFileUrl = HttpClientHelper.ReadResponseString(errorFileUrlResponse);
                                            if (errorFileUrl.Length == 0)
                                            {
                                                System.Threading.Thread.Sleep(TimeSpan.FromSeconds(_settings.DelayBetweenStatusCheck));
                                            }
                                        }
                                    }
                                    while (errorFileUrlResponse.IsSuccessStatusCode && string.IsNullOrEmpty(errorFileUrl));

                                    var response = await _httpClientHelper.GetRequestAsync(new UriBuilder(errorFileUrl).Uri, false);
                                    if (response.IsSuccessStatusCode)
                                    {
                                        using Stream downloadedStream = await response.Content.ReadAsStreamAsync();
                                        var errorsFileName = $"{Path.GetFileNameWithoutExtension(dataMessage.Name)}-{entity}-ErrorKeys-{DateTime.Now:yyyy-MM-dd_HH-mm-ss-ffff}.txt";
                                        var errorsFilePath = Path.Combine(Path.GetDirectoryName(dataMessage.FullPath.Replace(_settings.UploadSuccessDir, _settings.ProcessingErrorsDir)), errorsFileName);
                                        var dataMessageForErrorsFile = new DataMessage()
                                        {
                                            FullPath = errorsFilePath,
                                            Name = errorsFileName,
                                            MessageStatus = MessageStatus.Failed
                                        };
                                        _retryPolicyForIo.Execute(() => FileOperationsHelper.Create(downloadedStream, dataMessageForErrorsFile.FullPath));
                                    }
                                    else
                                    {
                                        Log.Warn($@"Job: {_settings.JobKey}. Download of error keys file failed. Job will continue processing other packages.
Uploaded file: {dataMessage.FullPath}
Execution status: {executionStatus}
Error file URL: {errorFileUrl}");
                                    }
                                }
                            }
                        }

                        if (_settings.GetExecutionErrors)
                        {
                            if (_settings.LogVerbose || Log.IsDebugEnabled)
                            {
                                Log.DebugFormat(CultureInfo.InvariantCulture, string.Format(Resources.Job_0_Trying_to_download_execution_errors, _context.JobDetail.Key));
                            }
                            var response = await _httpClientHelper.GetExecutionErrors(dataMessage.MessageId);
                            if (response.IsSuccessStatusCode)
                            {
                                using Stream downloadedStream = await response.Content.ReadAsStreamAsync();
                                var errorsFileName = $"{Path.GetFileNameWithoutExtension(dataMessage.Name)}-ExecutionErrors-{DateTime.Now:yyyy-MM-dd_HH-mm-ss-ffff}.txt";
                                var errorsFilePath = Path.Combine(Path.GetDirectoryName(dataMessage.FullPath.Replace(_settings.UploadSuccessDir, _settings.ProcessingErrorsDir)), errorsFileName);
                                var dataMessageForErrorsFile = new DataMessage()
                                {
                                    FullPath = errorsFilePath,
                                    Name = errorsFileName,
                                    MessageStatus = MessageStatus.Failed
                                };
                                _retryPolicyForIo.Execute(() => FileOperationsHelper.Create(downloadedStream, dataMessageForErrorsFile.FullPath));
                            }
                            else
                            {
                                Log.Warn($@"Job: {_settings.JobKey}. Download of execution error details failed. Job will continue processing other packages.
Uploaded file: {dataMessage.FullPath}
Execution status: {executionStatus}
Message Id: {dataMessage.MessageId}");
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
            if (_settings.LogVerbose || Log.IsDebugEnabled)
            {
                Log.DebugFormat(CultureInfo.InvariantCulture, string.Format(Resources.Job_0_Looking_for_data_entities_in_manifest_file_1, _context.JobDetail.Key, fileName));
            }

            var enitiesList = new List<string>();

            using (var package = ZipFile.OpenRead(fileName))
            {
                foreach (var entry in package.Entries)
                {
                    if (entry.FullName.Equals("Manifest.xml", StringComparison.OrdinalIgnoreCase))
                    {
                        var manifestPath = Path.Combine(Path.GetTempPath(), $"{_context.JobDetail.Key}-{entry.FullName}");
                        entry.ExtractToFile(manifestPath, true);

                        var doc = new XmlDocument();
                        XmlNodeList entities;
                        using (var manifestFile = new StreamReader(manifestPath))
                        {
                            doc.Load(new XmlTextReader(manifestFile) { Namespaces = false });
                            entities = doc.SelectNodes("//EntityName");
                        }

                        foreach (XmlNode node in entities)
                        {
                            enitiesList.Add(node.InnerText);
                        }
                    }
                }
            }
            return enitiesList;
        }
    }
}