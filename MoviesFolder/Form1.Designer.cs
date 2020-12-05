﻿namespace MoviesFolder
{
    partial class Form1
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
            this.appDesc = new System.Windows.Forms.Label();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.textBoxFolder = new System.Windows.Forms.TextBox();
            this.folderDirectory = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonGo = new System.Windows.Forms.Button();
            this.labelFileList = new System.Windows.Forms.Label();
            this.checkBoxWatched = new System.Windows.Forms.CheckBox();
            this.buttonExport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // appDesc
            // 
            this.appDesc.AutoSize = true;
            this.appDesc.Location = new System.Drawing.Point(12, 9);
            this.appDesc.Name = "appDesc";
            this.appDesc.Size = new System.Drawing.Size(140, 13);
            this.appDesc.TabIndex = 0;
            this.appDesc.Text = "App for sorting movies folder";
            this.appDesc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.Location = new System.Drawing.Point(15, 99);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(235, 251);
            this.listBoxFiles.TabIndex = 1;
            this.listBoxFiles.SelectedIndexChanged += new System.EventHandler(this.listBoxFiles_SelectedIndexChanged);
            // 
            // textBoxFolder
            // 
            this.textBoxFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFolder.Location = new System.Drawing.Point(87, 46);
            this.textBoxFolder.Name = "textBoxFolder";
            this.textBoxFolder.Size = new System.Drawing.Size(118, 20);
            this.textBoxFolder.TabIndex = 2;
            // 
            // folderDirectory
            // 
            this.folderDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.folderDirectory.AutoSize = true;
            this.folderDirectory.Location = new System.Drawing.Point(12, 49);
            this.folderDirectory.Name = "folderDirectory";
            this.folderDirectory.Size = new System.Drawing.Size(69, 13);
            this.folderDirectory.TabIndex = 3;
            this.folderDirectory.Text = "Select Folder";
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(211, 46);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(39, 20);
            this.buttonGo.TabIndex = 4;
            this.buttonGo.Text = "Go";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // labelFileList
            // 
            this.labelFileList.AutoSize = true;
            this.labelFileList.Location = new System.Drawing.Point(12, 83);
            this.labelFileList.Name = "labelFileList";
            this.labelFileList.Size = new System.Drawing.Size(42, 13);
            this.labelFileList.TabIndex = 6;
            this.labelFileList.Text = "File List";
            // 
            // checkBoxWatched
            // 
            this.checkBoxWatched.AutoSize = true;
            this.checkBoxWatched.Location = new System.Drawing.Point(256, 99);
            this.checkBoxWatched.Name = "checkBoxWatched";
            this.checkBoxWatched.Size = new System.Drawing.Size(70, 17);
            this.checkBoxWatched.TabIndex = 8;
            this.checkBoxWatched.Text = "Watched";
            this.checkBoxWatched.UseVisualStyleBackColor = true;
            this.checkBoxWatched.CheckedChanged += new System.EventHandler(this.checkBoxWatched_CheckedChanged);
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(256, 327);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(75, 23);
            this.buttonExport.TabIndex = 9;
            this.buttonExport.Text = "Export ";
            this.buttonExport.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 362);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.checkBoxWatched);
            this.Controls.Add(this.labelFileList);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.folderDirectory);
            this.Controls.Add(this.textBoxFolder);
            this.Controls.Add(this.listBoxFiles);
            this.Controls.Add(this.appDesc);
            this.Name = "Form1";
            this.Text = "Movies Folder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label appDesc;
        private System.Windows.Forms.ListBox listBoxFiles;
        private System.Windows.Forms.TextBox textBoxFolder;
        private System.Windows.Forms.Label folderDirectory;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Label labelFileList;
        private System.Windows.Forms.CheckBox checkBoxWatched;
        private System.Windows.Forms.Button buttonExport;
    }
}
