﻿namespace PuppetMaster
{
    partial class PuppetMasterForm
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
            this.openConfig = new System.Windows.Forms.OpenFileDialog();
            this.text_file = new System.Windows.Forms.TextBox();
            this.button_browse = new System.Windows.Forms.Button();
            this.button_run_all = new System.Windows.Forms.Button();
            this.button_slow_parse = new System.Windows.Forms.Button();
            this.text_config = new System.Windows.Forms.Label();
            this.text_log = new System.Windows.Forms.TextBox();
            this.button_clear_log = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Config File:";
            // 
            // openConfig
            // 
            this.openConfig.FileName = "config.cfg";
            // 
            // text_file
            // 
            this.text_file.Location = new System.Drawing.Point(79, 13);
            this.text_file.Name = "text_file";
            this.text_file.Size = new System.Drawing.Size(317, 20);
            this.text_file.TabIndex = 1;
            // 
            // button_browse
            // 
            this.button_browse.Location = new System.Drawing.Point(402, 12);
            this.button_browse.Name = "button_browse";
            this.button_browse.Size = new System.Drawing.Size(75, 23);
            this.button_browse.TabIndex = 2;
            this.button_browse.Text = "Browse";
            this.button_browse.UseVisualStyleBackColor = true;
            this.button_browse.Click += new System.EventHandler(this.button_browse_Click);
            // 
            // button_run_all
            // 
            this.button_run_all.Enabled = false;
            this.button_run_all.Location = new System.Drawing.Point(79, 39);
            this.button_run_all.Name = "button_run_all";
            this.button_run_all.Size = new System.Drawing.Size(75, 23);
            this.button_run_all.TabIndex = 3;
            this.button_run_all.Text = "Run Config File";
            this.button_run_all.UseVisualStyleBackColor = true;
            this.button_run_all.Click += new System.EventHandler(this.button_run_all_Click);
            // 
            // button_slow_parse
            // 
            this.button_slow_parse.Enabled = false;
            this.button_slow_parse.Location = new System.Drawing.Point(160, 39);
            this.button_slow_parse.Name = "button_slow_parse";
            this.button_slow_parse.Size = new System.Drawing.Size(75, 23);
            this.button_slow_parse.TabIndex = 4;
            this.button_slow_parse.Text = "Step by step";
            this.button_slow_parse.UseVisualStyleBackColor = true;
            this.button_slow_parse.Click += new System.EventHandler(this.button_slow_parse_Click);
            // 
            // text_config
            // 
            this.text_config.AutoSize = true;
            this.text_config.Location = new System.Drawing.Point(13, 43);
            this.text_config.Name = "text_config";
            this.text_config.Size = new System.Drawing.Size(63, 13);
            this.text_config.TabIndex = 5;
            this.text_config.Text = "Run Config:";
            // 
            // text_log
            // 
            this.text_log.Location = new System.Drawing.Point(16, 69);
            this.text_log.Multiline = true;
            this.text_log.Name = "text_log";
            this.text_log.ReadOnly = true;
            this.text_log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.text_log.Size = new System.Drawing.Size(461, 281);
            this.text_log.TabIndex = 6;
            // 
            // button_clear_log
            // 
            this.button_clear_log.Location = new System.Drawing.Point(241, 39);
            this.button_clear_log.Name = "button_clear_log";
            this.button_clear_log.Size = new System.Drawing.Size(75, 23);
            this.button_clear_log.TabIndex = 7;
            this.button_clear_log.Text = "Clear";
            this.button_clear_log.UseVisualStyleBackColor = true;
            this.button_clear_log.Click += new System.EventHandler(this.button_clear_log_Click);
            // 
            // PuppetMasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 362);
            this.Controls.Add(this.button_clear_log);
            this.Controls.Add(this.text_log);
            this.Controls.Add(this.text_config);
            this.Controls.Add(this.button_slow_parse);
            this.Controls.Add(this.button_run_all);
            this.Controls.Add(this.button_browse);
            this.Controls.Add(this.text_file);
            this.Controls.Add(this.label1);
            this.Name = "PuppetMasterForm";
            this.Text = "PuppetMaster";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PuppetMasterForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openConfig;
        private System.Windows.Forms.TextBox text_file;
        private System.Windows.Forms.Button button_browse;
        private System.Windows.Forms.Button button_run_all;
        private System.Windows.Forms.Button button_slow_parse;
        private System.Windows.Forms.Label text_config;
        private System.Windows.Forms.TextBox text_log;
        private System.Windows.Forms.Button button_clear_log;
    }
}

