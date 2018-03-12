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
    /// Serialize/deserialize Upload job settings
    /// </summary>
    /// <seealso cref="RecurringIntegrationsScheduler.Common.JobSettings" />
    public class UploadJobSettings : Settings
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

            var activityIdStr = dataMap.GetString(SettingsConstants.ActivityId);
            if (!Guid.TryParse(activityIdStr, out Guid activityIdGuid) || (Guid.Empty == activityIdGuid))
            {
                throw new JobExecutionException(string.Format(CultureInfo.InvariantCulture, Resources.Activity_Id_of_recurring_job_is_missing_or_is_not_a_GUID_in_job_configuration));
            }
            ActivityId = activityIdGuid;

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

            IsDataPackage = Convert.ToBoolean(dataMap.GetString(SettingsConstants.IsDataPackage));

            EntityName = dataMap.GetString(SettingsConstants.EntityName);
            if (!IsDataPackage && string.IsNullOrEmpty(EntityName))
            {
                throw new JobExecutionException(string.Format(CultureInfo.InvariantCulture, Resources.Entity_name_is_missing_in_job_configuration));
            }

            ProcessingJobPresent = Convert.ToBoolean(dataMap.GetString(SettingsConstants.ProcessingJobPresent));

            //Company is not mandatory
            Company = dataMap.GetString(SettingsConstants.Company);

            StatusFileExtension = dataMap.GetString(SettingsConstants.StatusFileExtension);
            if (string.IsNullOrEmpty(StatusFileExtension))
            {
                throw new JobExecutionException(string.Format(CultureInfo.InvariantCulture, Resources.Extension_of_status_files_is_missing_in_job_configuration));
            }

            ProcessingJobPresent = Convert.ToBoolean(dataMap.GetString(SettingsConstants.ProcessingJobPresent));

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

            UploadInOrder = Convert.ToBoolean(dataMap.GetString(SettingsConstants.UploadInOrder));
        }

        #region Members

        /// <summary>
        /// Gets or sets the activity identifier.
        /// </summary>
        /// <value>
        /// The activity identifier.
        /// </value>
        public Guid ActivityId { get; private set; }

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
        /// Gets the name of the entity.
        /// </summary>
        /// <value>
        /// The name of the entity.
        /// </value>
        public string EntityName { get; private set; }

        /// <summary>
        /// Gets a value indicating whether this instance is data package.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is data package; otherwise, <c>false</c>.
        /// </value>
        public bool IsDataPackage { get; private set; }

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
        /// Gets a value indicating whether [processing job present].
        /// </summary>
        /// <value>
        /// <c>true</c> if [processing job present]; otherwise, <c>false</c>.
        /// </value>
        public bool ProcessingJobPresent { get; private set; }

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
        /// Gets a value indicating whether files should be uploaded in order.
        /// </summary>
        /// <value>
        /// <c>true</c> if file should be uploaded only when previous was successfully processed; otherwise, <c>false</c>.
        /// </value>
        public bool UploadInOrder { get; private set; }

        #endregion
    }
}