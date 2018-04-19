using RecurringIntegrationsScheduler.Properties;

namespace RecurringIntegrationsScheduler.Forms
{
    partial class ImportJobOptions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.GetExecutionSummaryPageUrlLabel = new System.Windows.Forms.Label();
            this.GetExecutionSummaryPageUrlTextBox = new System.Windows.Forms.TextBox();
            this.GetExecutionSummaryStatusLabel = new System.Windows.Forms.Label();
            this.GetExecutionSummaryStatusTextBox = new System.Windows.Forms.TextBox();
            this.ImportFromPackageLabel = new System.Windows.Forms.Label();
            this.ImportFromPackageTextBox = new System.Windows.Forms.TextBox();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.GetAzureWriteUrlLabel = new System.Windows.Forms.Label();
            this.GetAzureWriteUrlTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.GetExecutionSummaryPageUrlLabel);
            this.panel1.Controls.Add(this.GetExecutionSummaryPageUrlTextBox);
            this.panel1.Controls.Add(this.GetExecutionSummaryStatusLabel);
            this.panel1.Controls.Add(this.GetExecutionSummaryStatusTextBox);
            this.panel1.Controls.Add(this.ImportFromPackageLabel);
            this.panel1.Controls.Add(this.ImportFromPackageTextBox);
            this.panel1.Controls.Add(this.ButtonCancel);
            this.panel1.Controls.Add(this.ButtonOK);
            this.panel1.Controls.Add(this.GetAzureWriteUrlLabel);
            this.panel1.Controls.Add(this.GetAzureWriteUrlTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 201);
            this.panel1.TabIndex = 0;
            // 
            // GetExecutionSummaryPageUrlLabel
            // 
            this.GetExecutionSummaryPageUrlLabel.AutoSize = true;
            this.GetExecutionSummaryPageUrlLabel.Location = new System.Drawing.Point(3, 127);
            this.GetExecutionSummaryPageUrlLabel.Name = "GetExecutionSummaryPageUrlLabel";
            this.GetExecutionSummaryPageUrlLabel.Size = new System.Drawing.Size(230, 20);
            this.GetExecutionSummaryPageUrlLabel.TabIndex = 15;
            this.GetExecutionSummaryPageUrlLabel.Text = "GetExecutionSummaryPageUrl";
            // 
            // GetExecutionSummaryPageUrlTextBox
            // 
            this.GetExecutionSummaryPageUrlTextBox.Location = new System.Drawing.Point(238, 124);
            this.GetExecutionSummaryPageUrlTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GetExecutionSummaryPageUrlTextBox.Name = "GetExecutionSummaryPageUrlTextBox";
            this.GetExecutionSummaryPageUrlTextBox.Size = new System.Drawing.Size(528, 26);
            this.GetExecutionSummaryPageUrlTextBox.TabIndex = 14;
            // 
            // GetExecutionSummaryStatusLabel
            // 
            this.GetExecutionSummaryStatusLabel.AutoSize = true;
            this.GetExecutionSummaryStatusLabel.Location = new System.Drawing.Point(13, 93);
            this.GetExecutionSummaryStatusLabel.Name = "GetExecutionSummaryStatusLabel";
            this.GetExecutionSummaryStatusLabel.Size = new System.Drawing.Size(220, 20);
            this.GetExecutionSummaryStatusLabel.TabIndex = 13;
            this.GetExecutionSummaryStatusLabel.Text = "GetExecutionSummaryStatus";
            // 
            // GetExecutionSummaryStatusTextBox
            // 
            this.GetExecutionSummaryStatusTextBox.Location = new System.Drawing.Point(238, 90);
            this.GetExecutionSummaryStatusTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GetExecutionSummaryStatusTextBox.Name = "GetExecutionSummaryStatusTextBox";
            this.GetExecutionSummaryStatusTextBox.Size = new System.Drawing.Size(528, 26);
            this.GetExecutionSummaryStatusTextBox.TabIndex = 12;
            // 
            // ImportFromPackageLabel
            // 
            this.ImportFromPackageLabel.AutoSize = true;
            this.ImportFromPackageLabel.Location = new System.Drawing.Point(79, 59);
            this.ImportFromPackageLabel.Name = "ImportFromPackageLabel";
            this.ImportFromPackageLabel.Size = new System.Drawing.Size(154, 20);
            this.ImportFromPackageLabel.TabIndex = 11;
            this.ImportFromPackageLabel.Text = "ImportFromPackage";
            // 
            // ImportFromPackageTextBox
            // 
            this.ImportFromPackageTextBox.Location = new System.Drawing.Point(238, 56);
            this.ImportFromPackageTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ImportFromPackageTextBox.Name = "ImportFromPackageTextBox";
            this.ImportFromPackageTextBox.Size = new System.Drawing.Size(528, 26);
            this.ImportFromPackageTextBox.TabIndex = 10;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(370, 158);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(102, 32);
            this.ButtonCancel.TabIndex = 9;
            this.ButtonCancel.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Cancel;
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonOK
            // 
            this.ButtonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonOK.Location = new System.Drawing.Point(262, 158);
            this.ButtonOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(102, 32);
            this.ButtonOK.TabIndex = 8;
            this.ButtonOK.Text = global::RecurringIntegrationsScheduler.Properties.Resources.OK;
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // GetAzureWriteUrlLabel
            // 
            this.GetAzureWriteUrlLabel.AutoSize = true;
            this.GetAzureWriteUrlLabel.Location = new System.Drawing.Point(97, 25);
            this.GetAzureWriteUrlLabel.Name = "GetAzureWriteUrlLabel";
            this.GetAzureWriteUrlLabel.Size = new System.Drawing.Size(135, 20);
            this.GetAzureWriteUrlLabel.TabIndex = 1;
            this.GetAzureWriteUrlLabel.Text = "GetAzureWriteUrl";
            // 
            // GetAzureWriteUrlTextBox
            // 
            this.GetAzureWriteUrlTextBox.Location = new System.Drawing.Point(238, 22);
            this.GetAzureWriteUrlTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GetAzureWriteUrlTextBox.Name = "GetAzureWriteUrlTextBox";
            this.GetAzureWriteUrlTextBox.Size = new System.Drawing.Size(528, 26);
            this.GetAzureWriteUrlTextBox.TabIndex = 0;
            // 
            // ImportJobOptions
            // 
            this.AcceptButton = this.ButtonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonCancel;
            this.ClientSize = new System.Drawing.Size(778, 201);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 300);
            this.MinimizeBox = false;
            this.Name = "ImportJobOptions";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Custom Odata actions relative paths";
            this.Load += new System.EventHandler(this.ImportJobOptions_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.Label GetAzureWriteUrlLabel;
        private System.Windows.Forms.TextBox GetAzureWriteUrlTextBox;
        private System.Windows.Forms.Label ImportFromPackageLabel;
        private System.Windows.Forms.TextBox ImportFromPackageTextBox;
        private System.Windows.Forms.Label GetExecutionSummaryPageUrlLabel;
        private System.Windows.Forms.TextBox GetExecutionSummaryPageUrlTextBox;
        private System.Windows.Forms.Label GetExecutionSummaryStatusLabel;
        private System.Windows.Forms.TextBox GetExecutionSummaryStatusTextBox;
    }
}