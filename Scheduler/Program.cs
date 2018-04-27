/* Copyright (c) Microsoft Corporation. All rights reserved.
   Licensed under the MIT License. */

using Bluegrams.Application;
using RecurringIntegrationsScheduler.Forms;
using System;
using System.Windows.Forms;

namespace RecurringIntegrationsScheduler
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            PortableSettingsProvider.ApplyProvider(Properties.Settings.Default);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}