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
    /// Serialize/deserialize DMImport job settings
    /// </summary>
    /// <seealso cref="RecurringIntegrationsScheduler.Common.JobSettings" />
    public class ImportJobSettings : Settings
    {
        /// <summary>
        /// Initialize and verify settings for job
        /// </summary>
        /// <param name="context"></param>
        /// <exception cref="Quartz.JobExecutionException">
        /// </exception>
        public override void Initialize(IJobExecutionContext context)
        {
            var dataMap = context.JobDetail.JobDataMap;

            base.Initialize(context);

            InputDir = dataMap.GetString(SettingsConstants.InputDir);
            if (!string.IsNullOrEmpty(InputDir))
            {
                try
                {
                    Directory.CreateDirectory(InputDir);
                }
                catch (Exception ex)
                {
                    throw new JobExecutionException(string.Format(CultureInfo.InvariantCulture, Resources.Input_directory_does_not_exist_or_cannot_be_accessed), ex);
                }
            }
            else
            {
                throw new JobExecutionException(string.Format(CultureInfo.InvariantCulture, Resources.Input_directory_is_missing_in_job_configuration));
            }

            UploadSuccessDir = dataMap.GetString(SettingsConstants.UploadSuccessDir);
            if (!string.IsNullOrEmpty(UploadSuccessDir))
            {
                try
                {
                    Directory.CreateDirectory(UploadSuccessDir);
                }
                catch (Exception ex)
                {
                    throw new JobExecutionException(string.Format(CultureInfo.InvariantCulture, Resources.Upload_success_directory_does_not_exist_or_cannot_be_accessed), ex);
                }
            }
            else
            {
                throw new JobExecutionException(string.Format(CultureInfo.InvariantCulture, Resources.Upload_success_directory_is_missing_in_job_configuration));
            }

            UploadErrorsDir = dataMap.GetString(SettingsConstants.UploadErrorsDir);
            if (!string.IsNullOrEmpty(UploadErrorsDir))
            {
                try
                {
                    Directory.CreateDirectory(UploadErrorsDir);
                }
                catch (Exception ex)
                {
                    throw new JobExecutionException(string.Format(CultureInfo.InvariantCulture, Resources.Upload_errors_directory_does_not_exist_or_cannot_be_accessed), ex);
                }
            }
            else
            {
                throw new JobExecutionException(string.Format(CultureInfo.InvariantCulture, Resources.Upload_errors_directory_is_missing_in_job_configuration));
            }

            ExecutionJobPresent = Convert.ToBoolean(dataMap.GetString(SettingsConstants.ExecutionJobPresent));

            Company = dataMap.GetString(SettingsConstants.Company);
            if (string.IsNullOrEmpty(Company))
            {
                throw new JobExecutionException(string.Format(CultureInfo.InvariantCulture, Resources.Company_is_missing_in_job_configuration));
            }

            StatusFileExtension = dataMap.GetString(SettingsConstants.StatusFileExtension);
            if (string.IsNullOrEmpty(StatusFileExtension))
            {
                throw new JobExecutionException(string.Format(CultureInfo.InvariantCulture, Resources.Extension_of_status_files_is_missing_in_job_configuration));
            }

            SearchPattern = dataMap.GetString(SettingsConstants.SearchPattern);
            if (string.IsNullOrEmpty(SearchPattern))
            {
                SearchPattern = "*.*";
            }

            try
            {
                OrderBy = (OrderByOptions)Enum.Parse(typeof(OrderByOptions), dataMap.GetString(SettingsConstants.OrderBy));
            }
            catch
            {
                OrderBy = OrderByOptions.Created;
            }

            ReverseOrder = Convert.ToBoolean(dataMap.GetString(SettingsConstants.ReverseOrder));

            DataProject = dataMap.GetString(SettingsConstants.DataProject);
            if (string.IsNullOrEmpty(DataProject))
            {
                throw new JobExecutionException(string.Format(CultureInfo.InvariantCulture, Resources.Data_project_is_missing_in_job_configuration));
            }

            OverwriteDataProject = Convert.ToBoolean(dataMap.GetString(SettingsConstants.OverwriteDataProject));

            ExecuteImport = Convert.ToBoolean(dataMap.GetString(SettingsConstants.ExecuteImport));

            PackageTemplate = dataMap.GetString(SettingsConstants.PackageTemplate);
            if (!string.IsNullOrEmpty(PackageTemplate))
            {
                try
                {
                    if (!File.Exists(PackageTemplate))
                    {
                        throw new JobExecutionException(string.Format(CultureInfo.InvariantCulture, Resources.Package_template_0_not_found, PackageTemplate));
                    }
                }
                catch (Exception ex)
                {
                    throw new JobExecutionException(string.Format(CultureInfo.InvariantCulture, Resources.Verification_of_package_template_location_failed_0, PackageTemplate), ex);
                }
            }
        }

        #region Members

        /// <summary>
        /// Gets the input dir.
        /// </summary>
        /// <value>
        /// The input dir.
        /// </value>
        public string InputDir { get; private set; }

        /// <summary>
        /// Gets the upload success dir.
        /// </summary>
        /// <value>
        /// The upload success dir.
        /// </value>
        public string UploadSuccessDir { get; private set; }

        /// <summary>
        /// Gets the upload errors dir.
        /// </summary>
        /// <value>
        /// The upload errors dir.
        /// </value>
        public string UploadErrorsDir { get; private set; }

        /// <summary>
        /// Gets the company.
        /// </summary>
        /// <value>
        /// The company.
        /// </value>
        public string Company { get; private set; }

        /// <summary>
        /// Gets the status file extension.
        /// </summary>
        /// <value>
        /// The status file extension.
        /// </value>
        public string StatusFileExtension { get; private set; }

        /// <summary>
        /// Gets a value indicating whether [execution job present].
        /// </summary>
        /// <value>
        /// <c>true</c> if [execution job present]; otherwise, <c>false</c>.
        /// </value>
        public bool ExecutionJobPresent { get; private set; }

        /// <summary>
        /// Gets the search pattern.
        /// </summary>
        /// <value>
        /// The search pattern.
        /// </value>
        public string SearchPattern { get; private set; }

        /// <summary>
        /// Gets the order by.
        /// </summary>
        /// <value>
        /// The order by.
        /// </value>
        public OrderByOptions OrderBy { get; private set; }

        /// <summary>
        /// Gets a value indicating whether [reverse order].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [reverse order]; otherwise, <c>false</c>.
        /// </value>
        public bool ReverseOrder { get; private set; }

        /// <summary>
        /// Gets data project.
        /// </summary>
        /// <value>
        /// Data project.
        /// </value>
        public string DataProject { get; private set; }

        /// <summary>
        /// Gets a value indicating whether to overwrite existing data project.
        /// </summary>
        /// <value>
        ///   <c>true</c> if [overwrite]; otherwise, <c>false</c>.
        /// </value>
        public bool OverwriteDataProject { get; private set; }

        /// <summary>
        /// Gets a value indicating whether to execute import.
        /// </summary>
        /// <value>
        ///   <c>true</c> if [execute]; otherwise, <c>false</c>.
        /// </value>
        public bool ExecuteImport { get; private set; }

        /// <summary>
        /// Package template location.
        /// </summary>
        /// <value>
        /// Package template location.
        /// </value>
        public string PackageTemplate { get; private set; }

        #endregion
    }
}