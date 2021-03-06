﻿namespace ScreenSaver
{
    partial class SettingsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.chkDifferentMonitorMovies = new System.Windows.Forms.CheckBox();
            this.chkUseTimeOfDay = new System.Windows.Forms.CheckBox();
            this.chkMultiscreenDisabled = new System.Windows.Forms.CheckBox();
            this.chkCacheVideos = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.txtCacheFolderPath = new System.Windows.Forms.TextBox();
            this.changeCacheLocationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aerial Settings";
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(20, 191);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelButton.CausesValidation = false;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(101, 191);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // chkDifferentMonitorMovies
            // 
            this.chkDifferentMonitorMovies.AutoSize = true;
            this.chkDifferentMonitorMovies.Checked = true;
            this.chkDifferentMonitorMovies.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDifferentMonitorMovies.Location = new System.Drawing.Point(20, 56);
            this.chkDifferentMonitorMovies.Name = "chkDifferentMonitorMovies";
            this.chkDifferentMonitorMovies.Size = new System.Drawing.Size(195, 17);
            this.chkDifferentMonitorMovies.TabIndex = 6;
            this.chkDifferentMonitorMovies.Text = "Play different Aerial on each monitor";
            this.chkDifferentMonitorMovies.UseVisualStyleBackColor = true;
            // 
            // chkUseTimeOfDay
            // 
            this.chkUseTimeOfDay.AutoSize = true;
            this.chkUseTimeOfDay.Checked = true;
            this.chkUseTimeOfDay.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUseTimeOfDay.Location = new System.Drawing.Point(19, 78);
            this.chkUseTimeOfDay.Name = "chkUseTimeOfDay";
            this.chkUseTimeOfDay.Size = new System.Drawing.Size(240, 17);
            this.chkUseTimeOfDay.TabIndex = 7;
            this.chkUseTimeOfDay.Text = "Use time of day to show day/night videos first";
            this.chkUseTimeOfDay.UseVisualStyleBackColor = true;
            // 
            // chkMultiscreenDisabled
            // 
            this.chkMultiscreenDisabled.AutoSize = true;
            this.chkMultiscreenDisabled.Checked = true;
            this.chkMultiscreenDisabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMultiscreenDisabled.Location = new System.Drawing.Point(20, 100);
            this.chkMultiscreenDisabled.Name = "chkMultiscreenDisabled";
            this.chkMultiscreenDisabled.Size = new System.Drawing.Size(251, 17);
            this.chkMultiscreenDisabled.TabIndex = 8;
            this.chkMultiscreenDisabled.Text = "Disable all but main screen on 3+ screen setups";
            this.chkMultiscreenDisabled.UseVisualStyleBackColor = true;
            // 
            // chkCacheVideos
            // 
            this.chkCacheVideos.AutoSize = true;
            this.chkCacheVideos.Location = new System.Drawing.Point(19, 122);
            this.chkCacheVideos.Name = "chkCacheVideos";
            this.chkCacheVideos.Size = new System.Drawing.Size(91, 17);
            this.chkCacheVideos.TabIndex = 9;
            this.chkCacheVideos.Text = "Cache videos";
            this.chkCacheVideos.UseVisualStyleBackColor = true;
            this.chkCacheVideos.CheckedChanged += new System.EventHandler(this.chkCacheVideos_CheckedChanged);
            // 
            // txtCacheFolderPath
            // 
            this.txtCacheFolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCacheFolderPath.Enabled = false;
            this.txtCacheFolderPath.Location = new System.Drawing.Point(182, 147);
            this.txtCacheFolderPath.Name = "txtCacheFolderPath";
            this.txtCacheFolderPath.Size = new System.Drawing.Size(240, 20);
            this.txtCacheFolderPath.TabIndex = 11;
            // 
            // changeCacheLocationButton
            // 
            this.changeCacheLocationButton.Enabled = false;
            this.changeCacheLocationButton.Location = new System.Drawing.Point(20, 145);
            this.changeCacheLocationButton.Name = "changeCacheLocationButton";
            this.changeCacheLocationButton.Size = new System.Drawing.Size(156, 23);
            this.changeCacheLocationButton.TabIndex = 12;
            this.changeCacheLocationButton.Text = "Change Cache Location...";
            this.changeCacheLocationButton.UseVisualStyleBackColor = true;
            this.changeCacheLocationButton.Click += new System.EventHandler(this.changeCacheLocationButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 226);
            this.Controls.Add(this.changeCacheLocationButton);
            this.Controls.Add(this.txtCacheFolderPath);
            this.Controls.Add(this.chkCacheVideos);
            this.Controls.Add(this.chkMultiscreenDisabled);
            this.Controls.Add(this.chkUseTimeOfDay);
            this.Controls.Add(this.chkDifferentMonitorMovies);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "Aerial Screen Saver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.CheckBox chkDifferentMonitorMovies;
        private System.Windows.Forms.CheckBox chkUseTimeOfDay;
        private System.Windows.Forms.CheckBox chkMultiscreenDisabled;
        private System.Windows.Forms.CheckBox chkCacheVideos;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TextBox txtCacheFolderPath;
        private System.Windows.Forms.Button changeCacheLocationButton;
    }
}
