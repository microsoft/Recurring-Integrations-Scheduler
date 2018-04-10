/* Copyright (c) Microsoft Corporation. All rights reserved.
   Licensed under the MIT License. */


using System;

/// <summary>
/// Binding to store relative service path
/// </summary>
/// <remarks>
/// 20180210 - mehrdadg : created
/// </remarks>
namespace RecurringIntegrationsScheduler.Settings
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class ServicePath
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the relative path.
        /// </summary>
        /// <value>
        /// The relative path of the service.
        /// </value>
        public string RelativePath { get; set; }
    }
}