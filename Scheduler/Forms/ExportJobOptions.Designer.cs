using RecurringIntegrationsScheduler.Properties;

namespace RecurringIntegrationsScheduler.Forms
{
    partial class ExportJobOptions
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
            this.GetExportedPackageUrlLabel = new System.Windows.Forms.Label();
            this.GetExportedPackageUrlTextBox = new System.Windows.Forms.TextBox();
            this.GetExecutionSummaryStatusLabel = new System.Windows.Forms.Label();
            this.GetExecutionSummaryStatusTextBox = new System.Windows.Forms.TextBox();
            this.ExportToPackageLabel = new System.Windows.Forms.Label();
            this.ExportToPackageTextBox = new System.Windows.Forms.TextBox();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.GetExportedPackageUrlLabel);
            this.panel1.Controls.Add(this.GetExportedPackageUrlTextBox);
            this.panel1.Controls.Add(this.GetExecutionSummaryStatusLabel);
            this.panel1.Controls.Add(this.GetExecutionSummaryStatusTextBox);
            this.panel1.Controls.Add(this.ExportToPackageLabel);
            this.panel1.Controls.Add(this.ExportToPackageTextBox);
            this.panel1.Controls.Add(this.ButtonCancel);
            this.panel1.Controls.Add(this.ButtonOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 160);
            this.panel1.TabIndex = 0;
            // 
            // GetExportedPackageUrlLabel
            // 
            this.GetExportedPackageUrlLabel.AutoSize = true;
            this.GetExportedPackageUrlLabel.Location = new System.Drawing.Point(50, 84);
            this.GetExportedPackageUrlLabel.Name = "GetExportedPackageUrlLabel";
            this.GetExportedPackageUrlLabel.Size = new System.Drawing.Size(182, 20);
            this.GetExportedPackageUrlLabel.TabIndex = 15;
            this.GetExportedPackageUrlLabel.Text = "GetExportedPackageUrl";
            // 
            // GetExportedPackageUrlTextBox
            // 
            this.GetExportedPackageUrlTextBox.Location = new System.Drawing.Point(238, 81);
            this.GetExportedPackageUrlTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GetExportedPackageUrlTextBox.Name = "GetExportedPackageUrlTextBox";
            this.GetExportedPackageUrlTextBox.Size = new System.Drawing.Size(528, 26);
            this.GetExportedPackageUrlTextBox.TabIndex = 14;
            // 
            // GetExecutionSummaryStatusLabel
            // 
            this.GetExecutionSummaryStatusLabel.AutoSize = true;
            this.GetExecutionSummaryStatusLabel.Location = new System.Drawing.Point(13, 50);
            this.GetExecutionSummaryStatusLabel.Name = "GetExecutionSummaryStatusLabel";
            this.GetExecutionSummaryStatusLabel.Size = new System.Drawing.Size(220, 20);
            this.GetExecutionSummaryStatusLabel.TabIndex = 13;
            this.GetExecutionSummaryStatusLabel.Text = "GetExecutionSummaryStatus";
            // 
            // GetExecutionSummaryStatusTextBox
            // 
            this.GetExecutionSummaryStatusTextBox.Location = new System.Drawing.Point(238, 47);
            this.GetExecutionSummaryStatusTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GetExecutionSummaryStatusTextBox.Name = "GetExecutionSummaryStatusTextBox";
            this.GetExecutionSummaryStatusTextBox.Size = new System.Drawing.Size(528, 26);
            this.GetExecutionSummaryStatusTextBox.TabIndex = 12;
            // 
            // ExportToPackageLabel
            // 
            this.ExportToPackageLabel.AutoSize = true;
            this.ExportToPackageLabel.Location = new System.Drawing.Point(97, 16);
            this.ExportToPackageLabel.Name = "ExportToPackageLabel";
            this.ExportToPackageLabel.Size = new System.Drawing.Size(135, 20);
            this.ExportToPackageLabel.TabIndex = 11;
            this.ExportToPackageLabel.Text = "ExportToPackage";
            // 
            // ExportToPackageTextBox
            // 
            this.ExportToPackageTextBox.Location = new System.Drawing.Point(238, 13);
            this.ExportToPackageTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ExportToPackageTextBox.Name = "ExportToPackageTextBox";
            this.ExportToPackageTextBox.Size = new System.Drawing.Size(528, 26);
            this.ExportToPackageTextBox.TabIndex = 10;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(373, 115);
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
            this.ButtonOK.Location = new System.Drawing.Point(265, 115);
            this.ButtonOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(102, 32);
            this.ButtonOK.TabIndex = 8;
            this.ButtonOK.Text = global::RecurringIntegrationsScheduler.Properties.Resources.OK;
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // ExportJobOptions
            // 
            this.AcceptButton = this.ButtonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonCancel;
            this.ClientSize = new System.Drawing.Size(778, 160);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 300);
            this.MinimizeBox = false;
            this.Name = "ExportJobOptions";
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
        private System.Windows.Forms.Label ExportToPackageLabel;
        private System.Windows.Forms.TextBox ExportToPackageTextBox;
        private System.Windows.Forms.Label GetExportedPackageUrlLabel;
        private System.Windows.Forms.TextBox GetExportedPackageUrlTextBox;
        private System.Windows.Forms.Label GetExecutionSummaryStatusLabel;
        private System.Windows.Forms.TextBox GetExecutionSummaryStatusTextBox;
    }
}