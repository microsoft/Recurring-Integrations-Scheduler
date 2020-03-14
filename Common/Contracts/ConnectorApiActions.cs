/* Copyright (c) Microsoft Corporation. All rights reserved.
   Licensed under the MIT License. */

namespace RecurringIntegrationsScheduler.Common.Contracts
{
    /// <summary>
    /// Class holding all requests paths related to Connector API
    /// </summary>
    public static class ConnectorApiActions
    {
        public const string EnqueuePath = "api/connector/enqueue/";
        public const string DequeuePath = "api/connector/dequeue/";
        public const string AckPath = "api/connector/ack/";
        public const string JobStatusPath = "api/connector/jobstatus/";
    }
}
