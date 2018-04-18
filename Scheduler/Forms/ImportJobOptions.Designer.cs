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
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.odataActionRelativePathLabel = new System.Windows.Forms.Label();
            this.odataActionRelativePathTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ButtonCancel);
            this.panel1.Controls.Add(this.ButtonOK);
            this.panel1.Controls.Add(this.odataActionRelativePathLabel);
            this.panel1.Controls.Add(this.odataActionRelativePathTextBox);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 138);
            this.panel1.TabIndex = 0;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(258, 95);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(91, 35);
            this.ButtonCancel.TabIndex = 9;
            this.ButtonCancel.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Cancel;
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonOK
            // 
            this.ButtonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonOK.Location = new System.Drawing.Point(161, 95);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(91, 35);
            this.ButtonOK.TabIndex = 8;
            this.ButtonOK.Text = global::RecurringIntegrationsScheduler.Properties.Resources.OK;
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // odataActionRelativePathLabel
            // 
            this.odataActionRelativePathLabel.AutoSize = true;
            this.odataActionRelativePathLabel.Location = new System.Drawing.Point(16, 21);
            this.odataActionRelativePathLabel.Name = "odataActionRelativePathLabel";
            this.odataActionRelativePathLabel.Size = new System.Drawing.Size(79, 17);
            this.odataActionRelativePathLabel.TabIndex = 1;
            this.odataActionRelativePathLabel.Text = "Action path";
            // 
            // odataActionRelativePathTextBox
            // 
            this.odataActionRelativePathTextBox.Location = new System.Drawing.Point(119, 18);
            this.odataActionRelativePathTextBox.Name = "odataActionRelativePathTextBox";
            this.odataActionRelativePathTextBox.Size = new System.Drawing.Size(353, 22);
            this.odataActionRelativePathTextBox.TabIndex = 0;
            this.odataActionRelativePathTextBox.Text = "data/DataManagementDefinitionGroups/Microsoft.Dynamics.DataEntities.ExportToPacka" +
    "ge";
            // 
            // ImportJobOptions
            // 
            this.AcceptButton = this.ButtonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonCancel;
            this.ClientSize = new System.Drawing.Size(521, 152);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(539, 251);
            this.MinimizeBox = false;
            this.Name = "ImportJobOptions";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Import job options";
            this.Load += new System.EventHandler(this.ImportJobOptions_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.Label odataActionRelativePathLabel;
        private System.Windows.Forms.TextBox odataActionRelativePathTextBox;
    }
}