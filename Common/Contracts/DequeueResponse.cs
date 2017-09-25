/* Copyright (c) Microsoft Corporation. All rights reserved.
   Licensed under the MIT License. */

namespace RecurringIntegrationsScheduler.Common.Contracts
{
    public class DequeueResponse
    {
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

        /// <summary>
        /// Converter from DataMessage
        /// </summary>
        /// <param name="dataMessage">The data message.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static explicit operator DequeueResponse(DataMessage dataMessage)
        {
            return new DequeueResponse
            {
                CorrelationId = dataMessage.CorrelationId,
                PopReceipt = dataMessage.PopReceipt,
                DownloadLocation = dataMessage.DownloadLocation
            };
        }
    }
}