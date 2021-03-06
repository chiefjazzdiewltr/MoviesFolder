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
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.textBoxFolder = new System.Windows.Forms.TextBox();
            this.folderDirectory = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonGo = new System.Windows.Forms.Button();
            this.labelFileList = new System.Windows.Forms.Label();
            this.checkBoxWatched = new System.Windows.Forms.CheckBox();
            this.menuStripBrowser = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.buttonClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStripBrowser.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxFiles.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.Location = new System.Drawing.Point(15, 76);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(329, 277);
            this.listBoxFiles.TabIndex = 1;
            this.listBoxFiles.SelectedIndexChanged += new System.EventHandler(this.listBoxFiles_SelectedIndexChanged);
            // 
            // textBoxFolder
            // 
            this.textBoxFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFolder.Location = new System.Drawing.Point(87, 32);
            this.textBoxFolder.Name = "textBoxFolder";
            this.textBoxFolder.Size = new System.Drawing.Size(133, 20);
            this.textBoxFolder.TabIndex = 2;
            this.textBoxFolder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFolder_KeyPress);
            // 
            // folderDirectory
            // 
            this.folderDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.folderDirectory.AutoSize = true;
            this.folderDirectory.Location = new System.Drawing.Point(12, 35);
            this.folderDirectory.Name = "folderDirectory";
            this.folderDirectory.Size = new System.Drawing.Size(69, 13);
            this.folderDirectory.TabIndex = 3;
            this.folderDirectory.Text = "Select Folder";
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(226, 32);
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
            this.labelFileList.Location = new System.Drawing.Point(12, 60);
            this.labelFileList.Name = "labelFileList";
            this.labelFileList.Size = new System.Drawing.Size(42, 13);
            this.labelFileList.TabIndex = 6;
            this.labelFileList.Text = "File List";
            // 
            // checkBoxWatched
            // 
            this.checkBoxWatched.AutoSize = true;
            this.checkBoxWatched.Location = new System.Drawing.Point(350, 76);
            this.checkBoxWatched.Name = "checkBoxWatched";
            this.checkBoxWatched.Size = new System.Drawing.Size(70, 17);
            this.checkBoxWatched.TabIndex = 8;
            this.checkBoxWatched.Text = "Watched";
            this.checkBoxWatched.UseVisualStyleBackColor = true;
            this.checkBoxWatched.CheckedChanged += new System.EventHandler(this.checkBoxWatched_CheckedChanged);
            // 
            // menuStripBrowser
            // 
            this.menuStripBrowser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStripBrowser.Location = new System.Drawing.Point(0, 0);
            this.menuStripBrowser.Name = "menuStripBrowser";
            this.menuStripBrowser.Size = new System.Drawing.Size(439, 24);
            this.menuStripBrowser.TabIndex = 11;
            this.menuStripBrowser.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.browseToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // browseToolStripMenuItem
            // 
            this.browseToolStripMenuItem.Name = "browseToolStripMenuItem";
            this.browseToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.browseToolStripMenuItem.Text = "Browse";
            this.browseToolStripMenuItem.Click += new System.EventHandler(this.browseToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // saveFile
            // 
            this.saveFile.DefaultExt = "csv";
            this.saveFile.Filter = "Comma Seperated Values|*.csv|Excel Spreadsheet|*.xlsx|All Files|*.*";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(271, 32);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(43, 20);
            this.buttonClear.TabIndex = 12;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "G = Watched";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Key:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "R = Not Watched";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 366);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.checkBoxWatched);
            this.Controls.Add(this.labelFileList);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.folderDirectory);
            this.Controls.Add(this.textBoxFolder);
            this.Controls.Add(this.listBoxFiles);
            this.Controls.Add(this.menuStripBrowser);
            this.MainMenuStrip = this.menuStripBrowser;
            this.MaximumSize = new System.Drawing.Size(455, 405);
            this.MinimumSize = new System.Drawing.Size(455, 405);
            this.Name = "Form1";
            this.Text = "Movies Folder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStripBrowser.ResumeLayout(false);
            this.menuStripBrowser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxFiles;
        private System.Windows.Forms.TextBox textBoxFolder;
        private System.Windows.Forms.Label folderDirectory;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Label labelFileList;
        private System.Windows.Forms.CheckBox checkBoxWatched;
        private System.Windows.Forms.MenuStrip menuStripBrowser;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

