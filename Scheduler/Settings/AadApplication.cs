/* Copyright (c) Microsoft Corporation. All rights reserved.
   Licensed under the MIT License. */

using System;

namespace RecurringIntegrationsScheduler.Settings
{
    /// <summary>
    /// 
    /// </summary>
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
}