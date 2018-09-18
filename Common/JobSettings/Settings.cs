/* Copyright (c) Microsoft Corporation. All rights reserved.
   Licensed under the MIT License. */

using Quartz;
using RecurringIntegrationsScheduler.Common.Contracts;
using RecurringIntegrationsScheduler.Common.Helpers;
using RecurringIntegrationsScheduler.Common.Properties;
using System;
using System.Globalization;

namespace RecurringIntegrationsScheduler.Common.JobSettings
{
    /// <summary>
    /// Serialize/deserialize common job settings
    /// </summary>
    public class Settings
    {
        /// <summary>
        /// Initialize and verify settings for job
        /// </summary>
        /// <param name="context">The context.</param>
        /// <exception cref="JobExecutionException">
        /// </exception>
        public virtual void Initialize(IJobExecutionContext context)
        {
            var dataMap = context.JobDetail.JobDataMap;

            AosUri = dataMap.GetString(SettingsConstants.AosUri);
            if (string.IsNullOrEmpty(AosUri))
            {
                throw new JobExecutionException(string.Format(CultureInfo.InvariantCulture, Resources.AOS_URL_is_missing_in_job_configuration));
            }
            //remove trailing slash if any
            AosUri = AosUri.TrimEnd('/');

            AzureAuthEndpoint = dataMap.GetString(SettingsConstants.AzureAuthEndpoint);
            if (string.IsNullOrEmpty(AzureAuthEndpoint))
            {
                throw new JobExecutionException(string.Format(CultureInfo.InvariantCulture, Resources.Azure_authentication_endpoint_URL_is_missing_in_job_configuration));
            }

            AadTenant = dataMap.GetString(SettingsConstants.AadTenant);
            if (string.IsNullOrEmpty(AadTenant))
            {
                throw new JobExecutionException(string.Format(CultureInfo.InvariantCulture, Resources.AAD_tenant_id_is_missing_in_job_configuration));
            }

            UseServiceAuthentication = Convert.ToBoolean(dataMap.GetString(SettingsConstants.UseServiceAuthentication));

            var aadClientIdStr = dataMap.GetString(SettingsConstants.AadClientId);
            if (!Guid.TryParse(aadClientIdStr, out Guid aadClientGuid) || (Guid.Empty == aadClientGuid))
            {
                throw new JobExecutionException(string.Format(CultureInfo.InvariantCulture, Resources.Azure_application_client_id_is_missing_or_is_not_a_GUID_in_job_configuration));
            }
            AadClientId = aadClientGuid;

            if (UseServiceAuthentication)
            {
                AadClientSecret = dataMap.GetString(SettingsConstants.AadClientSecret);
                if (string.IsNullOrEmpty(AadClientSecret))
                {
                    throw new JobExecutionException(string.Format(CultureInfo.InvariantCulture, Resources.Azure_web_application_secret_is_missing_in_job_configuration));
                }
                AadClientSecret = EncryptDecrypt.Decrypt(AadClientSecret);
            }
            else
            {
                UserName = dataMap.GetString(SettingsConstants.UserName);
                if (string.IsNullOrEmpty(UserName))
                {
                    throw new JobExecutionException(string.Format(CultureInfo.InvariantCulture, Resources.User_principal_name_is_missing_in_job_configuration));
                }

                UserPassword = dataMap.GetString(SettingsConstants.UserPassword);
                if (string.IsNullOrEmpty(UserPassword))
                {
                    throw new JobExecutionException(string.Format(CultureInfo.InvariantCulture, Resources.User_password_is_missing_in_job_configuration));
                }
                UserPassword = EncryptDecrypt.Decrypt(UserPassword);
            }

            Interval = dataMap.GetInt(SettingsConstants.Interval);
            if (Interval < 100) //Default execution interval is 100 ms.
            {
                Interval = 100;
            }

            RetryCount = dataMap.GetInt(SettingsConstants.RetryCount);
            if (RetryCount == 0) 
            {
                RetryCount = 1;
            }

            RetryDelay = dataMap.GetInt(SettingsConstants.RetryDelay);
            if (RetryDelay == 0) 
            {
                RetryDelay = 60; //seconds
            }

            PauseJobOnException = Convert.ToBoolean(dataMap.GetString(SettingsConstants.PauseJobOnException));

            IndefinitePause = Convert.ToBoolean(dataMap.GetString(SettingsConstants.IndefinitePause));

            ImportFromPackageActionPath = dataMap.GetString(SettingsConstants.ImportFromPackageActionPath);
            if (string.IsNullOrEmpty(ImportFromPackageActionPath))
            {
                ImportFromPackageActionPath = OdataActionsConstants.ImportFromPackageActionPath;
            }

            GetAzureWriteUrlActionPath = dataMap.GetString(SettingsConstants.GetAzureWriteUrlActionPath);
            if (string.IsNullOrEmpty(GetAzureWriteUrlActionPath))
            {
                GetAzureWriteUrlActionPath = OdataActionsConstants.GetAzureWriteUrlActionPath;
            }

            GetExecutionSummaryStatusActionPath = dataMap.GetString(SettingsConstants.GetExecutionSummaryStatusActionPath);
            if (string.IsNullOrEmpty(GetExecutionSummaryStatusActionPath))
            {
                GetExecutionSummaryStatusActionPath = OdataActionsConstants.GetExecutionSummaryStatusActionPath;
            }

            GetExportedPackageUrlActionPath = dataMap.GetString(SettingsConstants.GetExportedPackageUrlActionPath);
            if (string.IsNullOrEmpty(GetExportedPackageUrlActionPath))
            {
                GetExportedPackageUrlActionPath = OdataActionsConstants.GetExportedPackageUrlActionPath;
            }

            GetExecutionSummaryPageUrlActionPath = dataMap.GetString(SettingsConstants.GetExecutionSummaryPageUrlActionPath);
            if (string.IsNullOrEmpty(GetExecutionSummaryPageUrlActionPath))
            {
                GetExecutionSummaryPageUrlActionPath = OdataActionsConstants.GetExecutionSummaryPageUrlActionPath;
            }

            DeleteExecutionHistoryJobActionPath = dataMap.GetString(SettingsConstants.DeleteExecutionHistoryJobActionPath);
            if (string.IsNullOrEmpty(DeleteExecutionHistoryJobActionPath))
            {
                DeleteExecutionHistoryJobActionPath = OdataActionsConstants.DeleteExecutionHistoryJobActionPath;
            }

            ExportToPackageActionPath = dataMap.GetString(SettingsConstants.ExportToPackageActionPath);
            if (string.IsNullOrEmpty(ExportToPackageActionPath))
            {
                ExportToPackageActionPath = OdataActionsConstants.ExportToPackageActionPath;
            }

            ExportFromPackageActionPath = dataMap.GetString(SettingsConstants.ExportFromPackageActionPath);
            if (string.IsNullOrEmpty(ExportFromPackageActionPath))
            {
                ExportFromPackageActionPath = OdataActionsConstants.ExportFromPackageActionPath;
            }

            GetMessageStatusActionPath = dataMap.GetString(SettingsConstants.GetMessageStatusActionPath);
            if (string.IsNullOrEmpty(GetMessageStatusActionPath))
            {
                GetMessageStatusActionPath = OdataActionsConstants.GetMessageStatusActionPath;
            }
        }

        #region Members

        /// <summary>
        /// Gets or sets the aos URI.
        /// </summary>
        /// <value>
        /// The aos URI.
        /// </value>
        public string AosUri { get; set; }

        /// <summary>
        /// Gets or sets the azure authentication endpoint.
        /// </summary>
        /// <value>
        /// The azure authentication endpoint.
        /// </value>
        public string AzureAuthEndpoint { get; set; }

        /// <summary>
        /// Gets or sets the aad tenant.
        /// </summary>
        /// <value>
        /// The aad tenant.
        /// </value>
        public string AadTenant { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [use service authentication].
        /// </summary>
        /// <value>
        /// <c>true</c> if [use service authentication]; otherwise, <c>false</c>.
        /// </value>
        public bool UseServiceAuthentication { get; set; }

        /// <summary>
        /// Gets or sets the aad client identifier.
        /// </summary>
        /// <value>
        /// The aad client identifier.
        /// </value>
        public Guid AadClientId { get; set; }

        /// <summary>
        /// Gets or sets the aad client secret.
        /// </summary>
        /// <value>
        /// The aad client secret.
        /// </value>
        public string AadClientSecret { get; set; }

        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        /// <value>
        /// The name of the user.
        /// </value>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the user password.
        /// </summary>
        /// <value>
        /// The user password.
        /// </value>
        public string UserPassword { get; set; }

        /// <summary>
        /// Gets or sets execution interval.
        /// </summary>
        /// <value>
        /// The execution interval.
        /// </value>
        public int Interval { get; private set; }

        /// <summary>
        /// Gets or sets retry count.
        /// </summary>
        /// <value>
        /// Retry count.
        /// </value>
        public int RetryCount { get; private set; }

        /// <summary>
        /// Gets or sets delay between retries.
        /// </summary>
        /// <value>
        /// Delay between retries in seconds.
        /// </value>
        public int RetryDelay { get; private set; }

        /// <summary>
        /// Gets or sets a value indicating whether [pause job when exception occurs].
        /// </summary>
        /// <value>
        /// <c>true</c> if [pause job when exception occurs]; otherwise, <c>false</c>.
        /// </value>
        public bool PauseJobOnException { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the job is paused indefinitely or not.
        /// </summary>
        /// <value>
        /// <c>true</c> if [pause job indefinitely]; otherwise, <c>false</c>.
        /// </value>
        public bool IndefinitePause { get; set; }

        /// <summary>
        /// Get the ImportFromPackage Odata action relative path
        /// </summary>
        /// <value>
        /// The relative path to the ImportFromPackage Odata action
        /// </value>
        public string ImportFromPackageActionPath { get; private set; } = OdataActionsConstants.ImportFromPackageActionPath;

        /// <summary>
        /// Get the GetAzureWriteUrl Odata action relative path
        /// </summary>
        /// <value>
        /// The relative path to the GetAzureWriteUrl Odata action
        /// </value>
        public string GetAzureWriteUrlActionPath { get; private set; } = OdataActionsConstants.GetAzureWriteUrlActionPath;

        /// <summary>
        /// Get the GetExecutionSummaryStatus Odata action relative path
        /// </summary>
        /// <value>
        /// The relative path to the GetExecutionSummaryStatus Odata action
        /// </value>
        public string GetExecutionSummaryStatusActionPath { get; private set; } = OdataActionsConstants.GetExecutionSummaryStatusActionPath;

        /// <summary>
        /// Get the GetExportedPackageUrl Odata action relative path
        /// </summary>
        /// <value>
        /// The relative path to the GetExportedPackageUrl Odata action
        /// </value>
        public string GetExportedPackageUrlActionPath { get; private set; } = OdataActionsConstants.GetExportedPackageUrlActionPath;

        /// <summary>
        /// Get the GetExecutionSummaryPageUrl Odata action relative path
        /// </summary>
        /// <value>
        /// The relative path to the GetExecutionSummaryPageUrl Odata action
        /// </value>
        public string GetExecutionSummaryPageUrlActionPath { get; private set; } = OdataActionsConstants.GetExecutionSummaryPageUrlActionPath;

        /// <summary>
        /// Get the DeleteExecutionHistoryJob Odata action relative path
        /// </summary>
        /// <value>
        /// The relative path to the DeleteExecutionHistoryJob Odata action
        /// </value>
        public string DeleteExecutionHistoryJobActionPath { get; private set; } = OdataActionsConstants.DeleteExecutionHistoryJobActionPath;

        /// <summary>
        /// Get the ExportToPackage Odata action relative path
        /// </summary>
        /// <value>
        /// The relative path to the ExportToPackage Odata action
        /// </value>
        public string ExportToPackageActionPath { get; private set; } = OdataActionsConstants.ExportToPackageActionPath;

        /// <summary>
        /// Get the ExportFromPackage Odata action relative path
        /// </summary>
        /// <value>
        /// The relative path to the ExportFromPackage Odata action
        /// </value>
        public string ExportFromPackageActionPath { get; private set; } = OdataActionsConstants.ExportFromPackageActionPath;

        /// <summary>
        /// Get the GetMessageStatus Odata action relative path
        /// </summary>
        /// <value>
        /// The relative path to the GetMessageStatus Odata action
        /// </value>
        public string GetMessageStatusActionPath { get; private set; } = OdataActionsConstants.GetMessageStatusActionPath;

        #endregion
    }
}