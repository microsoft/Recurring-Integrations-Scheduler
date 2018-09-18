/* Copyright (c) Microsoft Corporation. All rights reserved.
   Licensed under the MIT License. */

using log4net;
using Newtonsoft.Json;
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
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace RecurringIntegrationsScheduler.Job
{
    /// <summary>
    /// Job that uses enqueue/dequeue API to download exported data from D365FO
    /// </summary>
    /// <seealso cref="IJob" />
    [DisallowConcurrentExecution]
    public class Download : IJob
    {
        /// <summary>
        /// The log
        /// </summary>
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        /// <summary>
        /// The settings
        /// </summary>
        private readonly DownloadJobSettings _settings = new DownloadJobSettings();

        /// <summary>
        /// File download acknowledgement URL
        /// </summary>
        private Uri _acknowledgeDownloadUri;

        /// <summary>
        /// Job execution context
        /// </summary>
        private IJobExecutionContext _context;

        /// <summary>
        /// File dequeue URL
        /// </summary>
        private Uri _dequeueUri;

        /// <summary>
        /// The HTTP client helper
        /// </summary>
        private HttpClientHelper _httpClientHelper;

        /// <summary>
        /// Gets or sets the download queue.
        /// </summary>
        /// <value>
        /// The download queue.
        /// </value>
        private ConcurrentQueue<DataMessage> DownloadQueue { get; set; }

        /// <summary>
        /// Retry policy for IO operations
        /// </summary>
        private Policy _retryPolicyForIo;

        /// <summary>
        /// Retry policy for HTTP operations
        /// </summary>
        private Policy _retryPolicyForHttp;

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
                if (context.Scheduler.SchedulerName != "Private")//only throw error when running as service
                    throw new JobExecutionException(string.Format(Resources.Download_job_0_failed, _context.JobDetail.Key), ex, false);

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
            DownloadQueue = new ConcurrentQueue<DataMessage>();
            _httpClientHelper = new HttpClientHelper(_settings, _retryPolicyForHttp);
            _dequeueUri = _httpClientHelper.GetDequeueUri();
            _acknowledgeDownloadUri = _httpClientHelper.GetAckUri();

            var contentPresent = true;

            while (contentPresent)
            {
                var response = await _httpClientHelper.GetRequestAsync(_dequeueUri);

                switch (response.StatusCode)
                {
                    case HttpStatusCode.OK:
                        // Log success and add to Dequeued jobs for further processing
                        var message = await response.Content.ReadAsStringAsync();
                        var dataMessage = JsonConvert.DeserializeObject<DataMessage>(message);

                        //Ensure that we download over https (fix for multiboxes)
                        var newDownloadLocation = new UriBuilder(dataMessage.DownloadLocation)
                        {
                            Scheme = Uri.UriSchemeHttps,
                            Port = -1
                        };
                        dataMessage.DownloadLocation = newDownloadLocation.Uri.AbsoluteUri;
                        dataMessage.DataJobState = DataJobState.Dequeued;

                        DownloadQueue.Enqueue(dataMessage);

                        if (Log.IsDebugEnabled)
                            Log.DebugFormat(CultureInfo.InvariantCulture, string.Format(Resources.Job_0_File_dequeued_successfully_Download_location_1, _context.JobDetail.Key, dataMessage.DownloadLocation));
                        break;
                    case HttpStatusCode.NoContent:
                        contentPresent = false;
                        break;
                    default:
                        // Dequeue failed. Log error.
                        throw new JobExecutionException(string.Format(CultureInfo.InvariantCulture, string.Format(Resources.Job_0_Failure_response_Status_1_2_Reason_3, _context.JobDetail.Key, response.StatusCode, response.StatusCode, response.ReasonPhrase)));
                        
                }
                System.Threading.Thread.Sleep(_settings.Interval);
            }
            if (!DownloadQueue.IsEmpty)
            {
                Log.InfoFormat(CultureInfo.InvariantCulture, string.Format(Resources.Job_0_Dequeued_1_file, _context.JobDetail.Key, DownloadQueue.Count));
                await ProcessDownloadQueue();
            }
        }

        /// <summary>
        /// Processes download queue by downloading each
        /// file to download success location.
        /// </summary>
        /// <returns>
        /// Task object for continuation
        /// </returns>
        /// <exception cref="System.Exception"></exception>
        private async Task ProcessDownloadQueue()
        {
            //Stream downloadedStream = null;
            var fileCount = 0;
            while (DownloadQueue.TryDequeue(out DataMessage dataMessage))
            {
                var response = await _httpClientHelper.GetRequestAsync(new UriBuilder(dataMessage.DownloadLocation).Uri);

                if (!response.IsSuccessStatusCode)
                    throw new Exception(string.Format(Resources.Job_0_Download_failure_1, _context.JobDetail.Key, response.StatusCode));

                using (var downloadedStream = await response.Content.ReadAsStreamAsync())
                {
                    fileCount++;
                    //Downloaded file has no file name. We need to create it.
                    //It will be timestamp followed by number in this download batch.
                    var fileName = $"{DateTime.Now:yyyy-MM-dd_HH-mm-ss-ffff}-{fileCount:D6}";
                    fileName = Path.ChangeExtension(fileName, "zip");

                    dataMessage.FullPath = Path.Combine(_settings.DownloadSuccessDir, fileName);
                    dataMessage.Name = fileName;
                    dataMessage.MessageStatus = MessageStatus.Succeeded;

                    _retryPolicyForIo.Execute(() => FileOperationsHelper.Create(downloadedStream, dataMessage.FullPath));
                }
                if (Log.IsDebugEnabled)
                    Log.DebugFormat(CultureInfo.InvariantCulture, string.Format(Resources.Job_0_File_1_was_downloaded, _context.JobDetail.Key, dataMessage.FullPath.Replace(@"{", @"{{").Replace(@"}", @"}}")));

                await AcknowledgeDownload(dataMessage);

                if (_settings.UnzipPackage)
                    _retryPolicyForIo.Execute(() => FileOperationsHelper.UnzipPackage(dataMessage.FullPath, _settings.DeletePackage, _settings.AddTimestamp));

                System.Threading.Thread.Sleep(_settings.Interval);
            }
        }

        /// <summary>
        /// Acknowledges the download.
        /// </summary>
        /// <param name="dataMessage">The data message.</param>
        /// <returns></returns>
        private async Task AcknowledgeDownload(DataMessage dataMessage)
        {
            var content = JsonConvert.SerializeObject((DequeueResponse) dataMessage);

            var response = await _httpClientHelper.PostStringRequestAsync(_acknowledgeDownloadUri, content);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                if (Log.IsDebugEnabled)
                    Log.DebugFormat(CultureInfo.InvariantCulture, string.Format(Resources.Job_0_File_1_was_acknowledged_successfully, _context.JobDetail.Key, dataMessage.FullPath.Replace(@"{", @"{{").Replace(@"}", @"}}")));
            }
            else
            {
                // Acknowledgment failed. Log error.
                Log.ErrorFormat(CultureInfo.InvariantCulture, string.Format(Resources.Job_0_Acknowledgment_failure_response, _context.JobDetail.Key, response.StatusCode, response.StatusCode, response.ReasonPhrase));

                // Move message file
                _retryPolicyForIo.Execute(() => FileOperationsHelper.Move(dataMessage.FullPath, Path.Combine(_settings.DownloadErrorsDir, dataMessage.Name)));
            }
        }
    }
}