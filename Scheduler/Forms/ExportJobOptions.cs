/* Copyright (c) Microsoft Corporation. All rights reserved.
   Licensed under the MIT License. */

using System;
using System.Windows.Forms;

namespace RecurringIntegrationsScheduler.Forms
{
    public partial class ExportJobOptions : Form
    {
        public ExportJobOptions()
        {
            InitializeComponent();
        }

        public bool Cancelled { get; private set; }
        public string ExportToPackagePath;
        public string GetExecutionSummaryStatusPath;
        public string GetExportedPackageUrlPath;

        private bool InputIsValid()
        {
            return true;
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            Cancelled = false;
            if (InputIsValid())
            {
                ExportToPackagePath = ExportToPackageTextBox.Text;
                GetExecutionSummaryStatusPath = GetExecutionSummaryStatusTextBox.Text;
                GetExportedPackageUrlPath = GetExportedPackageUrlTextBox.Text;
    }
            else
            {
                DialogResult = DialogResult.None;
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Cancelled = true;
            Close();
        }

        private void ImportJobOptions_Load(object sender, EventArgs e)
        {
            Cancelled = false;
            ExportToPackageTextBox.Text = ExportToPackagePath;
            GetExecutionSummaryStatusTextBox.Text = GetExecutionSummaryStatusPath;
            GetExportedPackageUrlTextBox.Text = GetExportedPackageUrlPath;
        }
    }
}