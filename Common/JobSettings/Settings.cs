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
        /// <exception cref="Quartz.JobExecutionException">
        /// </exception>
        public virtual void Initialize(IJobExecutionContext context)
        {
            var dataMap = context.JobDetail.JobDataMap;

            AosUri = dataMap.GetString(SettingsConstants.AosUri);
            if (string.IsNullOrEmpty(AosUri))
            {
                throw new JobExecutionException(string.Format(CultureInfo.InvariantCulture,
                    string.Format(Resources.AOS_URL_is_missing_in_job_configuration, context.JobDetail.Key)));
            }
            //remove trailing slash if any
            AosUri = AosUri.TrimEnd('/');

            AzureAuthEndpoint = dataMap.GetString(SettingsConstants.AzureAuthEndpoint);
            if (string.IsNullOrEmpty(AzureAuthEndpoint))
            {
                throw new JobExecutionException(string.Format(CultureInfo.InvariantCulture,
                    string.Format(Resources.Azure_authentication_endpoint_URL_is_missing_in_job_configuration,
                        context.JobDetail.Key)));
            }

            AadTenant = dataMap.GetString(SettingsConstants.AadTenant);
            if (string.IsNullOrEmpty(AadTenant))
            {
                throw new JobExecutionException(string.Format(CultureInfo.InvariantCulture,
                    string.Format(Resources.AAD_tenant_id_is_missing_in_job_configuration, context.JobDetail.Key)));
            }

            UseServiceAuthentication = Convert.ToBoolean(dataMap.GetString(SettingsConstants.UseServiceAuthentication));

            var aadClientIdStr = dataMap.GetString(SettingsConstants.AadClientId);
            if (!Guid.TryParse(aadClientIdStr, out Guid aadClientGuid) || (Guid.Empty == aadClientGuid))
            {
                throw new JobExecutionException(string.Format(CultureInfo.InvariantCulture,
                    string.Format(
                        Resources.Azure_application_client_id_is_missing_or_is_not_a_GUID_in_job_configuration,
                        context.JobDetail.Key)));
            }
            AadClientId = aadClientGuid;

            if (UseServiceAuthentication)
            {
                AadClientSecret = dataMap.GetString(SettingsConstants.AadClientSecret);
                if (string.IsNullOrEmpty(AadClientSecret))
                {
                    throw new JobExecutionException(string.Format(CultureInfo.InvariantCulture,
                        string.Format(Resources.Azure_web_application_secret_is_missing_in_job_configuration,
                            context.JobDetail.Key)));
                }
                AadClientSecret = EncryptDecrypt.Decrypt(AadClientSecret);
            }
            else
            {
                UserName = dataMap.GetString(SettingsConstants.UserName);
                if (string.IsNullOrEmpty(UserName))
                {
                    throw new JobExecutionException(string.Format(CultureInfo.InvariantCulture,
                        string.Format(Resources.User_principal_name_is_missing_in_job_configuration,
                            context.JobDetail.Key)));
                }

                UserPassword = dataMap.GetString(SettingsConstants.UserPassword);
                if (string.IsNullOrEmpty(UserPassword))
                {
                    throw new JobExecutionException(string.Format(CultureInfo.InvariantCulture,
                        string.Format(Resources.User_password_is_missing_in_job_configuration, context.JobDetail.Key)));
                }
                UserPassword = EncryptDecrypt.Decrypt(UserPassword);
            }

            Interval = dataMap.GetInt(SettingsConstants.Interval);
            if (Interval < 2000) //Default execution interval is 2 seconds.
            {
                Interval = 2000;
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

        #endregion
    }
}