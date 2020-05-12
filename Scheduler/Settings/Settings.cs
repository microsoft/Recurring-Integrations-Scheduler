/* Copyright (c) Microsoft Corporation. All rights reserved.
   Licensed under the MIT License. */

using System;
using System.ComponentModel;

namespace RecurringIntegrationsScheduler.Settings
{
    [Serializable]
    public class AadApplication
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the client identifier.
        /// </summary>
        /// <value>
        /// The client identifier.
        /// </value>
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or sets the secret.
        /// </summary>
        /// <value>
        /// The secret.
        /// </value>
        public string Secret { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        public AuthenticationType AuthenticationType { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public enum AuthenticationType
    {
        User,
        Service
    }

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="System.ComponentModel.BindingList{AadApplication}" />
    public class AadApplications : BindingList<AadApplication>
    {
    }

    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class DataJob
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the activity identifier.
        /// </summary>
        /// <value>
        /// The activity identifier.
        /// </value>
        public string ActivityId { get; set; }

        /// <summary>
        /// Gets or sets the name of the entity.
        /// </summary>
        /// <value>
        /// The name of the entity.
        /// </value>
        public string EntityName { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        public DataJobType Type { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public enum DataJobType
    {
        Download,
        Upload
    }

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="System.ComponentModel.BindingList{DataJob}" />
    public class DataJobs : BindingList<DataJob>
    {
    }

    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class Instance
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

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
        /// Gets or sets the use ADAL.
        /// </summary>
        /// <value>
        /// The aad tenant.
        /// </value>
        public bool UseADAL { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="System.ComponentModel.BindingList{Instance}" />
    public class Instances : BindingList<Instance>
    {
    }

    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class JobGroup
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="System.ComponentModel.BindingList{JobGroup}" />
    public class JobGroups : BindingList<JobGroup>
    {
    }

    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class User
    {
        /// <summary>
        /// Gets or sets the login.
        /// </summary>
        /// <value>
        /// The login.
        /// </value>
        public string Login { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        public string Password { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="System.ComponentModel.BindingList{User}" />
    public class Users : BindingList<User>
    {
    }
}
