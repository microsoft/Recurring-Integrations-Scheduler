/* Copyright (c) Microsoft Corporation. All rights reserved.
   Licensed under the MIT License. */

using System;
using System.Windows.Forms;

namespace RecurringIntegrationsScheduler.Forms
{
    public partial class ImportJobOptions : Form
    {
        public ImportJobOptions()
        {
            InitializeComponent();
        }

        public bool Cancelled { get; private set; }
        public string ImportFromPackagePath;
        public string GetAzureWriteUrlPath;
        public string GetExecutionSummaryStatusPath;
        public string GetExecutionSummaryPageUrlPath;

        private bool InputIsValid()
        {
            return true;
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            Cancelled = false;
            if (InputIsValid())
            {
                ImportFromPackagePath = ImportFromPackageTextBox.Text;
                GetAzureWriteUrlPath = GetAzureWriteUrlTextBox.Text;
                GetExecutionSummaryStatusPath = GetExecutionSummaryStatusTextBox.Text;
                GetExecutionSummaryPageUrlPath = GetExecutionSummaryPageUrlTextBox.Text;
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
            ImportFromPackageTextBox.Text = ImportFromPackagePath;
            GetAzureWriteUrlTextBox.Text = GetAzureWriteUrlPath;
            GetExecutionSummaryStatusTextBox.Text = GetExecutionSummaryStatusPath;
            GetExecutionSummaryPageUrlTextBox.Text = GetExecutionSummaryPageUrlPath;
        }
    }
}