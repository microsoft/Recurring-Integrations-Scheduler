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
using System.Globalization;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace RecurringIntegrationsScheduler.Job
{
    /// <summary>
    /// Job that is used to request export of data using new method introduced in platform update 5
    /// </summary>
    /// <seealso cref="IJob" />
    [DisallowConcurrentExecution]
    public class Export : IJob
    {
        /// <summary>
        /// The log
        /// </summary>
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// The settings
        /// </summary>
        private readonly ExportJobSettings _settings = new ExportJobSettings();

        /// <summary>
        /// The HTTP client helper
        /// </summary>
        private HttpClientHelper _httpClientHelper;

        /// <summary>
        /// Job execution context
        /// </summary>
        private IJobExecutionContext _context;

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
                    Log.InfoFormat(CultureInfo.InvariantCulture, string.Format(Resources.Job_0_was_paused_indefinitely, _context.JobDetail.Key));
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
                    throw new JobExecutionException(string.Format(Resources.Job_0_failed, _context.JobDetail.Key), ex, false);
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
            using (_httpClientHelper = new HttpClientHelper(_settings))
            {
                var executionId = $"{_settings.DataProject}-{DateTime.Now:yyyy-MM-dd_HH-mm-ss}-{Guid.NewGuid()}";
                
                var responseExportToPackage = await _httpClientHelper.ExportToPackage(_settings.DataProject, executionId, executionId, _settings.Company);

                if (!responseExportToPackage.IsSuccessStatusCode)
                {
                    throw new JobExecutionException($@"Job: {_settings.JobKey}. ExportToPackage request failed.");
                }

                string executionStatus;
                var attempt = 0;
                do
                {
                    if (attempt > 0 && _settings.DelayBetweenStatusCheck > 0) //Only delay after first file and never after last.
                    {
                        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(_settings.DelayBetweenStatusCheck));
                    }
                    attempt++;

                    var responseGetExecutionSummaryStatus = await _httpClientHelper.GetExecutionSummaryStatus(executionId);
                    if (!responseGetExecutionSummaryStatus.IsSuccessStatusCode)
                    {
                        throw new JobExecutionException($@"Job: {_settings.JobKey}. GetExecutionSummaryStatus request failed.");
                    }
                    executionStatus = HttpClientHelper.ReadResponseString(responseGetExecutionSummaryStatus);

                    if (_settings.LogVerbose || Log.IsDebugEnabled)
                    {
                        Log.Debug(string.Format(Resources.Job_0_Checking_if_export_is_completed_Try_1_Status_2, _context.JobDetail.Key, attempt, executionStatus));
                    }
                    if (attempt == 100)//TODO hardcoded
                    {
                        throw new JobExecutionException(string.Format(Resources.Job_0_Checking_for_status_reached_1_attempts_Status_is_2_Exiting, _context.JobDetail.Key, attempt, executionStatus));
                    }
                }
                while (executionStatus == "NotRun" || executionStatus == "Executing" || executionStatus == "Bad request");

                if (executionStatus == "Succeeded" || executionStatus == "PartiallySucceeded")
                {
                    attempt = 0;//Reset for get url request attempts
                    HttpResponseMessage packageUrlResponse;
                    do
                    {
                        if (attempt > 0 && _settings.DelayBetweenFiles > 0) //Only delay after first file and never after last.
                        {
                            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(_settings.DelayBetweenFiles));
                        }
                        attempt++;

                        packageUrlResponse = await _httpClientHelper.GetExportedPackageUrl(executionId);
                        if (!packageUrlResponse.IsSuccessStatusCode)
                        {
                            throw new JobExecutionException($"Job: {_context.JobDetail.Key}. GetExportedPackageUrl request failed.");
                        }
                        if (_settings.LogVerbose || Log.IsDebugEnabled)
                        {
                            Log.Debug(string.Format(Resources.Job_0_Trying_to_get_exported_package_URL_Try_1, _context.JobDetail.Key, attempt));
                        }
                        if (attempt == 100)//TODO hardcoded
                        {
                            throw new JobExecutionException(string.Format(Resources.Job_0_Request_to_download_exported_package_reached_1_attempts_Exiting, _context.JobDetail.Key, attempt));
                        }
                    }
                    while (string.IsNullOrEmpty(HttpClientHelper.ReadResponseString(packageUrlResponse)));

                    var packageUri = new Uri(HttpClientHelper.ReadResponseString(packageUrlResponse));             
                    var response = await _httpClientHelper.GetRequestAsync(packageUri, false);
                    if (!response.IsSuccessStatusCode)
                    {
                        throw new JobExecutionException(string.Format(Resources.Job_0_Download_failure_1, _context.JobDetail.Key, string.Format($"Status: {response.StatusCode}. Message: {response.Content}")));
                    }
                    using Stream downloadedStream = await response.Content.ReadAsStreamAsync();

                    var fileName = $"{DateTime.Now:yyyy-MM-dd_HH-mm-ss-ffff}.zip";
                    var dataMessage = new DataMessage()
                    {
                        FullPath = Path.Combine(_settings.DownloadSuccessDir, fileName),
                        Name = fileName,
                        MessageStatus = MessageStatus.Succeeded
                    };
                    _retryPolicyForIo.Execute(() => FileOperationsHelper.Create(downloadedStream, dataMessage.FullPath));

                    if (_settings.UnzipPackage)
                    {
                        _retryPolicyForIo.Execute(() => FileOperationsHelper.UnzipPackage(dataMessage.FullPath, _settings.DeletePackage, _settings.AddTimestamp));
                    }
                }
                else if (executionStatus == "Unknown" || executionStatus == "Failed" || executionStatus == "Canceled")
                {
                    throw new JobExecutionException(string.Format(Resources.Export_execution_failed_for_job_0_Status_1, _context.JobDetail.Key, executionStatus));
                }
                else
                {
                    Log.Error(string.Format(Resources.Job_0_Execution_status_1_Execution_Id_2, _context.JobDetail.Key, executionStatus, executionId));
                }
            }
        }
    }
}