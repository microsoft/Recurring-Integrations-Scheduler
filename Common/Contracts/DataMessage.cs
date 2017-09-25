/* Copyright (c) Microsoft Corporation. All rights reserved.
   Licensed under the MIT License. */

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace RecurringIntegrationsScheduler.Common.Contracts
{
    /// <summary>
    /// Contract to abstract the input data file
    /// and its processing status (on the client)
    /// </summary>
    public class DataMessage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataMessage"/> class.
        /// </summary>
        public DataMessage()
        {
        }

        /// <summary>
        /// Initiate new dataMessage object based on existing one
        /// </summary>
        /// <param name="dataMessage"></param>
        public DataMessage(DataMessage dataMessage)
        {
            Name = dataMessage.Name;
            FullPath = dataMessage.FullPath;
            MessageId = dataMessage.MessageId;
            MessageStatus = dataMessage.MessageStatus;
            DataJobState = dataMessage.DataJobState;
            CorrelationId = dataMessage.CorrelationId;
            PopReceipt = dataMessage.PopReceipt;
            DownloadLocation = dataMessage.DownloadLocation;
        }

        /// <summary>
        /// Name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Full path of the message
        /// </summary>
        /// <value>
        /// The full path.
        /// </value>
        public string FullPath { get; set; }

        /// <summary>
        /// Id of the message in data job queue
        /// </summary>
        /// <value>
        /// The message identifier.
        /// </value>
        public string MessageId { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        /// <value>
        /// The message status.
        /// </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public MessageStatus MessageStatus { get; set; }

        /// <summary>
        /// Data job state
        /// </summary>
        /// <value>
        /// The state of the data job.
        /// </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public DataJobState DataJobState { get; set; }

        /// <summary>
        /// Gets or sets the correlation identifier.
        /// </summary>
        /// <value>
        /// The correlation identifier.
        /// </value>
        public string CorrelationId { get; set; }

        /// <summary>
        /// Gets or sets the pop receipt.
        /// </summary>
        /// <value>
        /// The pop receipt.
        /// </value>
        public string PopReceipt { get; set; }

        /// <summary>
        /// Gets or sets the download location.
        /// </summary>
        /// <value>
        /// The download location.
        /// </value>
        public string DownloadLocation { get; set; }
    }
}