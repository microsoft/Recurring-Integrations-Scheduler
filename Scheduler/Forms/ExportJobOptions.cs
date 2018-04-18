/* Copyright (c) Microsoft Corporation. All rights reserved.
   Licensed under the MIT License. */

using Quartz;
using RecurringIntegrationsScheduler.Common.Contracts;
using RecurringIntegrationsScheduler.Properties;
using RecurringIntegrationsScheduler.Settings;
using System;
using System.Text;
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
        public JobDataMap OptionsMap {get; set;} 

        private bool InputIsValid()
        {
            return true;
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            Cancelled = false;
            if (InputIsValid())
            {
                OptionsMap = new JobDataMap
                {               
                    {SettingsConstants.OdataActionRelativePath, odataActionRelativePathTextBox.Text}
                };
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

        private void ExportJobOptions_Load(object sender, EventArgs e)
        {
            Cancelled = false;

            string odataActionRelativePath = OptionsMap.GetString(SettingsConstants.OdataActionRelativePath);
            odataActionRelativePathTextBox.Text = string.IsNullOrEmpty(odataActionRelativePath) ? OdataActionsConstants.ExportToPackageActionPath : odataActionRelativePath;
        }
    }
}