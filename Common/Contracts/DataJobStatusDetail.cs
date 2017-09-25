/* Copyright (c) Microsoft Corporation. All rights reserved.
   Licensed under the MIT License. */

using System.Collections.Generic;

namespace RecurringIntegrationsScheduler.Common.Contracts
{
    /// <summary>
    /// Recurring data job status detail object
    /// </summary>
    public class DataJobStatusDetail
    {
        /// <summary>
        /// The data job status
        /// </summary>
        public DataJobStatus DataJobStatus;

        /// <summary>
        /// The execution log
        /// </summary>
        public string ExecutionLog;

        /// <summary>
        /// Gets or sets the execution detail.
        /// </summary>
        /// <value>
        /// The execution detail.
        /// </value>
        public List<EntityExecutionStatus> ExecutionDetail { get; set; }
    }
}