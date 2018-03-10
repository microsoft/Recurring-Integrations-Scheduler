/* Copyright (c) Microsoft Corporation. All rights reserved.
   Licensed under the MIT License. */

namespace RecurringIntegrationsScheduler.Common.Contracts
{
    /// <summary>
    /// Recurring data job state
    /// </summary>
    public enum DataJobState
    {
        Enqueued = 0,
        Dequeued = 1,
        Downloaded = 2,
        Acked = 3,
        InProcess = 4,
        Processed = 5,
        ProcessedWithErrors = 6,
        PostProcessError = 7,
        PreProcessError = 8
    }

    /// <summary>
    /// Entity execution status
    /// </summary>
    public enum EntityExecutionStateEnum
    {
        NotStarted,
        Waiting,
        Executing,
        Error,
        Finished,
        Ready,
        NotRun,
        Cancelling,
        Canceled,
        Hold
    }

    /// <summary>
    /// Message status
    /// </summary>
    public enum MessageStatus
    {
        Input,
        InProcess,
        Enqueued,
        Failed,
        Succeeded
    }

    /// <summary>
    /// Order by options
    /// </summary>
    public enum OrderByOptions
    {
        Created,
        Modified,
        FileName,
        Size
    }

    /// <summary>
    /// IntegrationActivityMessageStatus
    /// </summary>
    public enum IntegrationActivityMessageStatus
    {
        Enqueued = 0,
        Dequeued = 1,
        Downloaded = 2,
        Acked = 3,
        Processing = 4,
        Processed = 5,
        ProcessedWithErrors = 6,
        PostProcessingError = 7,
        PreProcessingError = 8,
        PreProcessing = 9
    }
}