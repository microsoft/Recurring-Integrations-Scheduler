/* Copyright (c) Microsoft Corporation. All rights reserved.
   Licensed under the MIT License. */

using System;

namespace RecurringIntegrationsScheduler.Common.Contracts
{
    /// <summary>
    /// Recurring data job status object
    /// </summary>
    public class DataJobStatus
    {
        /// <summary>
        /// Gets or sets the data project.
        /// </summary>
        /// <value>
        /// The data project.
        /// </value>
        public string DataProject { get; set; }
        /// <summary>
        /// Gets or sets the data job identifier.
        /// </summary>
        /// <value>
        /// The data job identifier.
        /// </value>
        public string DataJobIdentifier { get; set; }
        /// <summary>
        /// Gets or sets the external identifier.
        /// </summary>
        /// <value>
        /// The external identifier.
        /// </value>
        public string ExternalIdentifier { get; set; }
        /// <summary>
        /// Gets or sets the execution identifier.
        /// </summary>
        /// <value>
        /// The execution identifier.
        /// </value>
        public string ExecutionIdentifier { get; set; }
        /// <summary>
        /// Gets or sets the data job started date time.
        /// </summary>
        /// <value>
        /// The data job started date time.
        /// </value>
        public DateTime DataJobStartedDateTime { get; set; }
        /// <summary>
        /// Gets or sets the data job completed date time.
        /// </summary>
        /// <value>
        /// The data job completed date time.
        /// </value>
        public DateTime DataJobCompletedDateTime { get; set; }
        /// <summary>
        /// Gets or sets the state of the data job.
        /// </summary>
        /// <value>
        /// The state of the data job.
        /// </value>
        public DataJobState DataJobState { get; set; }
    }
}