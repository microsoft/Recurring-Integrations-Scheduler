/* Copyright (c) Microsoft Corporation. All rights reserved.
   Licensed under the MIT License. */

using Common.Logging;
using Quartz;
using RecurringIntegrationsScheduler.Common.Contracts;
using RecurringIntegrationsScheduler.Common.Helpers;
using RecurringIntegrationsScheduler.Common.JobSettings;
using RecurringIntegrationsScheduler.Job.Properties;
using System;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;

namespace RecurringIntegrationsScheduler.Job
{
    /// <summary>
    /// Job that is used to request export of data using new mothod introduced in platform update 5
    /// </summary>
    /// <seealso cref="Quartz.IJob" />
    [DisallowConcurrentExecution]
    public class Export : IJob
    {
        /// <summary>
        /// The log
        /// </summary>
        private static readonly ILog Log = LogManager.GetLogger(typeof(Export));

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
        /// Called by the <see cref="T:Quartz.IScheduler" /> when a <see cref="T:Quartz.ITrigger" />
        /// fires that is associated with the <see cref="T:Quartz.IJob" />.
        /// </summary>
        /// <param name="context">The execution context.</param>
        /// <exception cref="Quartz.JobExecutionException">false</exception>
        /// <remarks>
        /// The implementation may wish to set a  result object on the
        /// JobExecutionContext before this method exits.  The result itself
        /// is meaningless to Quartz, but may be informative to
        /// <see cref="T:Quartz.IJobListener" />s or
        /// <see cref="T:Quartz.ITriggerListener" />s that are watching the job's
        /// execution.
        /// </remarks>
        public void Execute(IJobExecutionContext context)
        {
            try
            {
                _context = context;
                _settings.Initialize(context);

                Log.DebugFormat(CultureInfo.InvariantCulture, string.Format(Resources.Job_0_starting, _context.JobDetail.Key));

                var t = Task.Run(Process);
                t.Wait();

                Log.DebugFormat(CultureInfo.InvariantCulture, string.Format(Resources.Job_0_ended, _context.JobDetail.Key));
            }
            catch (Exception ex)
            {
                //Pause this job
                context.Scheduler.PauseJob(context.JobDetail.Key);
                Log.WarnFormat(CultureInfo.InvariantCulture, string.Format(Resources.Job_0_was_paused_because_of_error, _context.JobDetail.Key));

                if (!string.IsNullOrEmpty(ex.Message))
                    Log.Error(ex.Message, ex);

                while (ex.InnerException != null)
                {
                    if (!string.IsNullOrEmpty(ex.InnerException.Message))
                        Log.Error(ex.InnerException.Message, ex.InnerException);

                    ex = ex.InnerException;
                }
                if (context.Scheduler.SchedulerName != "Private")
                    throw new JobExecutionException(string.Format(Resources.Download_job_0_failed, _context.JobDetail.Key), ex, false);
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
                var executionId = CreateExecutionId(_settings.DataProject);
                var responseExportToPackage = await _httpClientHelper.ExportToPackage(_settings.DataProject, executionId, executionId, _settings.Company);

                if (!responseExportToPackage.IsSuccessStatusCode)
                    throw new Exception(string.Format(Resources.Job_0_Download_failure_1, _context.JobDetail.Key, responseExportToPackage.StatusCode));

                var executionStatus = "";
                const int RETRIES = 10;
                var i = 0;
                do
                {
                    executionStatus = await _httpClientHelper.GetExecutionSummaryStatus(executionId);
                    if (executionStatus == "NotRun" || executionStatus == "Executing")
                    {
                        System.Threading.Thread.Sleep(_settings.Interval);
                    }
                    i++;
                    Log.Debug(string.Format(Resources.Job_0_Checking_if_export_is_completed_Try_1, _context.JobDetail.Key, i));
                }
                while ((executionStatus == "NotRun" || executionStatus == "Executing") && i <= RETRIES);

                if (executionStatus == "Succeeded" || executionStatus == "PartiallySucceeded")
                {
                    Uri packageUrl = await _httpClientHelper.GetExportedPackageUrl(executionId);

                    var response = await _httpClientHelper.GetRequestAsync(new UriBuilder(packageUrl).Uri, false);
                    if (!response.IsSuccessStatusCode)
                        throw new Exception(string.Format(Resources.Job_0_Download_failure_1, _context.JobDetail.Key, string.Format($"Status: {response.StatusCode}. Message: {response.Content}")));

                    using (Stream downloadedStream = await response.Content.ReadAsStreamAsync())
                    {
                        var fileName = $"{DateTime.Now:yyyy-MM-dd_HH-mm-ss-ffff}.zip";
                        var successPath = Path.Combine(_settings.DownloadSuccessDir, fileName);
                        var dataMessage = new DataMessage()
                        {
                            FullPath = successPath,
                            Name = fileName,
                            MessageStatus = MessageStatus.Succeeded
                        };
                        FileOperationsHelper.Create(downloadedStream, dataMessage.FullPath);

                        if (_settings.UnzipPackage)
                            FileOperationsHelper.UnzipPackage(dataMessage.FullPath, _settings.DeletePackage, _settings.AddTimestamp);
                    }
                }
                else if (executionStatus == "Unknown" || executionStatus == "Failed" || executionStatus == "Canceled")
                {
                    throw new Exception(string.Format(Resources.Export_execution_failed_for_job_0_Status_1, _context.JobDetail.Key, executionStatus));
                }
                else
                {
                    Log.Error(string.Format(Resources.Job_0_Execution_status_1_Execution_Id_2, _context.JobDetail.Key, executionStatus, executionId));
                }
            }
        }

        private string CreateExecutionId(string dataProject)
        {
            return $"{dataProject}-{DateTime.Now:yyyy-MM-dd_HH-mm-ss}-{Guid.NewGuid().ToString()}";
        }
    }
}