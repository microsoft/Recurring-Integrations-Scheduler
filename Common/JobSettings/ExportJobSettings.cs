/* Copyright (c) Microsoft Corporation. All rights reserved.
   Licensed under the MIT License. */
   
using Quartz;
using RecurringIntegrationsScheduler.Common.Contracts;
using RecurringIntegrationsScheduler.Common.Properties;
using System;
using System.Globalization;
using System.IO;

namespace RecurringIntegrationsScheduler.Common.JobSettings
{
    /// <summary>
    /// Serialize/deserialize download job settings
    /// </summary>
    /// <seealso cref="RecurringIntegrationsScheduler.Common.JobSettings" />
    public class ExportJobSettings : Settings
    {
        /// <summary>
        /// Initialize and verify settings for job
        /// </summary>
        /// <param name="context">The context.</param>
        /// <exception cref="Quartz.JobExecutionException">
        /// </exception>
        public override void Initialize(IJobExecutionContext context)
        {
            var dataMap = context.JobDetail.JobDataMap;

            base.Initialize(context);

            DownloadSuccessDir = dataMap.GetString(SettingsConstants.DownloadSuccessDir);
            if (!string.IsNullOrEmpty(DownloadSuccessDir))
            {
                try
                {
                    Directory.CreateDirectory(DownloadSuccessDir);
                }
                catch (Exception ex)
                {
                    throw new JobExecutionException(string.Format(CultureInfo.InvariantCulture, Resources.Download_success_directory_does_not_exist_or_cannot_be_accessed), ex);
                }
            }
            else
            {
                throw new JobExecutionException(string.Format(CultureInfo.InvariantCulture, Resources.Download_success_directory_is_missing_in_job_configuration));
            }

            DownloadErrorsDir = dataMap.GetString(SettingsConstants.DownloadErrorsDir);
            if (!string.IsNullOrEmpty(DownloadErrorsDir))
            {
                try
                {
                    Directory.CreateDirectory(DownloadErrorsDir);
                }
                catch (Exception ex)
                {
                    throw new JobExecutionException(string.Format(CultureInfo.InvariantCulture, Resources.Download_errors_directory_does_not_exist_or_cannot_be_accessed), ex);
                }
            }
            else
            {
                throw new JobExecutionException(string.Format(CultureInfo.InvariantCulture, Resources.Download_errors_directory_is_missing_in_job_configuration));
            }

            UnzipPackage = Convert.ToBoolean(dataMap.GetString(SettingsConstants.UnzipPackage));

            AddTimestamp = Convert.ToBoolean(dataMap.GetString(SettingsConstants.AddTimestamp));

            DeletePackage = Convert.ToBoolean(dataMap.GetString(SettingsConstants.DeletePackage));

            DataProject = dataMap.GetString(SettingsConstants.DataProject);

            if (string.IsNullOrEmpty(DataProject))
            {
                throw new JobExecutionException(string.Format(CultureInfo.InvariantCulture, Resources.Data_project_is_missing_in_job_configuration));
            }

            Company = dataMap.GetString(SettingsConstants.Company);

            if (string.IsNullOrEmpty(Company))
            {
                throw new JobExecutionException(string.Format(CultureInfo.InvariantCulture, Resources.Company_is_missing_in_job_configuration));
            }
        }

        #region Members

        /// <summary>
        /// Gets the download success dir.
        /// </summary>
        /// <value>
        /// The download success dir.
        /// </value>
        public string DownloadSuccessDir { get; private set; }

        /// <summary>
        /// Gets the download errors dir.
        /// </summary>
        /// <value>
        /// The download errors dir.
        /// </value>
        public string DownloadErrorsDir { get; private set; }

        /// <summary>
        /// Gets a value indicating whether [unzip package].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [unzip package]; otherwise, <c>false</c>.
        /// </value>
        public bool UnzipPackage { get; private set; }

        /// <summary>
        /// Gets a value indicating whether [add timestamp].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [add timestamp]; otherwise, <c>false</c>.
        /// </value>
        public bool AddTimestamp { get; private set; }

        /// <summary>
        /// Gets a value indicating whether [delete package].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [delete package]; otherwise, <c>false</c>.
        /// </value>
        public bool DeletePackage { get; private set; }

        /// <summary>
        /// Gets data project.
        /// </summary>
        /// <value>
        /// Data project.
        /// </value>
        public string DataProject { get; private set; }

        /// <summary>
        /// Gets legal entity id.
        /// </summary>
        /// <value>
        /// Legal entity id.
        /// </value>
        public string Company { get; private set; }

        #endregion
    }
}