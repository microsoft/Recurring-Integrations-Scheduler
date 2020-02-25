/* Copyright (c) Microsoft Corporation. All rights reserved.
   Licensed under the MIT License. */

using log4net;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Polly;
using Quartz;
using RecurringIntegrationsScheduler.Common.Contracts;
using RecurringIntegrationsScheduler.Common.Helpers;
using RecurringIntegrationsScheduler.Common.JobSettings;
using RecurringIntegrationsScheduler.Job.Properties;
using System;
using System.Collections.Concurrent;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;

namespace RecurringIntegrationsScheduler.Job
{
    /// <summary>
    /// Job that checks processing status of recurring data job
    /// </summary>
    /// <seealso cref="IJob" />
    [DisallowConcurrentExecution]
    public class ProcessingMonitor : IJob
    {
        /// <summary>
        /// The log
        /// </summary>
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// The settings
        /// </summary>
        private readonly ProcessingJobSettings _settings = new ProcessingJobSettings();

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
                    throw new JobExecutionException(string.Format(Resources.Processing_monitor_job_0_failed, _context.JobDetail.Key), ex, false);
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
                if (fileCount > 0 && _settings.StatusCheckInterval > 0) //Only delay after first file and never after last.
                {
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(_settings.StatusCheckInterval));
                }
                fileCount++;

                // Check status for current item with message id - item.Key
                var jobStatusDetail = await GetStatus(dataMessage.MessageId);

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
        /// <param name="jobStatusDetail">DataJobStatusDetail object</param>
        /// <param name="dataMessage">Name of the file whose status is being processed</param>
        private async Task PostProcessMessage(DataJobStatusDetail jobStatusDetail, DataMessage dataMessage)
        {
            if (jobStatusDetail?.DataJobStatus == null)
            {
                return;
            }
            dataMessage.DataJobState = jobStatusDetail.DataJobStatus.DataJobState;

            _retryPolicyForIo.Execute(() => FileOperationsHelper.WriteStatusFile(dataMessage, _settings.StatusFileExtension));

            switch (dataMessage.DataJobState)
            {
                case DataJobState.Processed:
                {
                    // Move message file and delete processing status file
                    _retryPolicyForIo.Execute(() => FileOperationsHelper.MoveDataToTarget(dataMessage.FullPath, Path.Combine(_settings.ProcessingSuccessDir, dataMessage.Name), true));
                }
                break;

                case DataJobState.PostProcessError:
                case DataJobState.PreProcessError:
                case DataJobState.ProcessedWithErrors:
                {
                    var targetDataMessage = new DataMessage(dataMessage)
                    {
                        FullPath = Path.Combine(_settings.ProcessingErrorsDir, dataMessage.Name),
                        MessageStatus = MessageStatus.Failed
                    };
                    _retryPolicyForIo.Execute(() => FileOperationsHelper.MoveDataToTarget(dataMessage.FullPath, targetDataMessage.FullPath));
                    _retryPolicyForIo.Execute(() => FileOperationsHelper.WriteStatusLogFile(jobStatusDetail, targetDataMessage, null, _settings.StatusFileExtension));

                    if (_settings.GetExecutionErrors)
                    {
                        if (_settings.LogVerbose || Log.IsDebugEnabled)
                        {
                            Log.DebugFormat(CultureInfo.InvariantCulture, string.Format(Resources.Job_0_Trying_to_download_execution_errors, _context.JobDetail.Key));
                        }
                        var response = await _httpClientHelper.GetExecutionErrors(dataMessage.MessageId);
                        if (!response.IsSuccessStatusCode)
                        {
                            throw new JobExecutionException(string.Format(Resources.Job_0_download_of_execution_errors_failed_1, _context.JobDetail.Key, string.Format($"Status: {response.StatusCode}. Message: {response.Content}")));
                        }
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
                }
                break;
            }
        }

        /// <summary>
        /// Get submitted job status using the Enqueue response -
        /// MessageId
        /// </summary>
        /// <param name="message">Correlation identifier for the submitted job returned as the Enqueue response</param>
        /// <returns>
        /// DataJobStatusDetail object that includes detailed job status
        /// </returns>
        private async Task<DataJobStatusDetail> GetStatus(string message)
        {
            //send a request to get the message status
            var response = await _httpClientHelper.GetRequestAsync(_httpClientHelper.GetJobStatusUri(message));

            if (response.IsSuccessStatusCode)
            {
                // Deserialize response to the DataJobStatusDetail object
                if (Log.IsDebugEnabled)
                    Log.DebugFormat(CultureInfo.InvariantCulture, string.Format(Resources.Job_0_Successfully_received_job_status_for_message_id_1, _context.JobDetail.Key, message));
                return JsonConvert.DeserializeObject<DataJobStatusDetail>(response.Content.ReadAsStringAsync().Result, new StringEnumConverter());
            }
            else
            {
                Log.ErrorFormat(CultureInfo.InvariantCulture, string.Format(Resources.Job_0_data_job_status_check_request_failed_Status_code_1_Reason_2, _context.JobDetail.Key, response.StatusCode, response.ReasonPhrase));
                return null;
            }
        }
    }
}