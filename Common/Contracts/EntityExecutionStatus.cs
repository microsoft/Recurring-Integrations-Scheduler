/* Copyright (c) Microsoft Corporation. All rights reserved.
   Licensed under the MIT License. */

using System;

namespace RecurringIntegrationsScheduler.Common.Contracts
{
    public class EntityExecutionStatus
    {
        /// <summary>
        /// Gets or sets the name of the entity.
        /// </summary>
        /// <value>
        /// The name of the entity.
        /// </value>
        public string EntityName { get; set; }
        /// <summary>
        /// Gets or sets the company.
        /// </summary>
        /// <value>
        /// The company.
        /// </value>
        public string Company { get; set; }
        /// <summary>
        /// Gets or sets the staging records.
        /// </summary>
        /// <value>
        /// The staging records.
        /// </value>
        public int StagingRecords { get; set; }
        /// <summary>
        /// Gets or sets the staging status.
        /// </summary>
        /// <value>
        /// The staging status.
        /// </value>
        public EntityExecutionStateEnum StagingStatus { get; set; }
        /// <summary>
        /// Gets or sets the staging error count.
        /// </summary>
        /// <value>
        /// The staging error count.
        /// </value>
        public int StagingErrorCount { get; set; }
        /// <summary>
        /// Gets or sets the target records.
        /// </summary>
        /// <value>
        /// The target records.
        /// </value>
        public int TargetRecords { get; set; }
        /// <summary>
        /// Gets or sets the target status.
        /// </summary>
        /// <value>
        /// The target status.
        /// </value>
        public EntityExecutionStateEnum TargetStatus { get; set; }
        /// <summary>
        /// Gets or sets the target error count.
        /// </summary>
        /// <value>
        /// The target error count.
        /// </value>
        public int TargetErrorCount { get; set; }
        /// <summary>
        /// Gets or sets the execution started date time.
        /// </summary>
        /// <value>
        /// The execution started date time.
        /// </value>
        public DateTime ExecutionStartedDateTime { get; set; }
        /// <summary>
        /// Gets or sets the execution completed date time.
        /// </summary>
        /// <value>
        /// The execution completed date time.
        /// </value>
        public DateTime ExecutionCompletedDateTime { get; set; }
    }
}