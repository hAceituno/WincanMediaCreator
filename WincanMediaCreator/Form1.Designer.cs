namespace WincanMediaCreator
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
            this.textBoxSourceDB = new System.Windows.Forms.TextBox();
            this.buttonSourceDB = new System.Windows.Forms.Button();
            this.labelSourceDB = new System.Windows.Forms.Label();
            this.buttonRun = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonChangeDirectory = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxVidFolder = new System.Windows.Forms.TextBox();
            this.buttonVidFolderBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPicFolder = new System.Windows.Forms.TextBox();
            this.buttonPicFolderBrowse = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSampleVidFolder = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSamplePicFolder = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxSourceDB
            // 
            this.textBoxSourceDB.Location = new System.Drawing.Point(137, 15);
            this.textBoxSourceDB.Name = "textBoxSourceDB";
            this.textBoxSourceDB.Size = new System.Drawing.Size(629, 22);
            this.textBoxSourceDB.TabIndex = 0;
            // 
            // buttonSourceDB
            // 
            this.buttonSourceDB.Location = new System.Drawing.Point(772, 12);
            this.buttonSourceDB.Name = "buttonSourceDB";
            this.buttonSourceDB.Size = new System.Drawing.Size(61, 28);
            this.buttonSourceDB.TabIndex = 1;
            this.buttonSourceDB.Text = "...";
            this.buttonSourceDB.UseVisualStyleBackColor = true;
            this.buttonSourceDB.Click += new System.EventHandler(this.buttonSourceDB_Click);
            // 
            // labelSourceDB
            // 
            this.labelSourceDB.AutoSize = true;
            this.labelSourceDB.Location = new System.Drawing.Point(13, 18);
            this.labelSourceDB.Name = "labelSourceDB";
            this.labelSourceDB.Size = new System.Drawing.Size(122, 17);
            this.labelSourceDB.TabIndex = 2;
            this.labelSourceDB.Text = "Source Database:";
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(707, 277);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(149, 71);
            this.buttonRun.TabIndex = 3;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 64);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(896, 400);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBoxSampleVidFolder);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBoxSamplePicFolder);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.buttonRun);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(888, 371);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Copy Sample Media";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonChangeDirectory);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.textBoxVidFolder);
            this.tabPage2.Controls.Add(this.buttonVidFolderBrowse);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.textBoxPicFolder);
            this.tabPage2.Controls.Add(this.buttonPicFolderBrowse);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(888, 371);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Change Media Directory";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonChangeDirectory
            // 
            this.buttonChangeDirectory.Location = new System.Drawing.Point(695, 274);
            this.buttonChangeDirectory.Name = "buttonChangeDirectory";
            this.buttonChangeDirectory.Size = new System.Drawing.Size(149, 71);
            this.buttonChangeDirectory.TabIndex = 9;
            this.buttonChangeDirectory.Text = "Run";
            this.buttonChangeDirectory.UseVisualStyleBackColor = true;
            this.buttonChangeDirectory.Click += new System.EventHandler(this.buttonChangeDirectory_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Video Folder:";
            // 
            // textBoxVidFolder
            // 
            this.textBoxVidFolder.Location = new System.Drawing.Point(136, 85);
            this.textBoxVidFolder.Name = "textBoxVidFolder";
            this.textBoxVidFolder.Size = new System.Drawing.Size(629, 22);
            this.textBoxVidFolder.TabIndex = 6;
            // 
            // buttonVidFolderBrowse
            // 
            this.buttonVidFolderBrowse.Location = new System.Drawing.Point(771, 82);
            this.buttonVidFolderBrowse.Name = "buttonVidFolderBrowse";
            this.buttonVidFolderBrowse.Size = new System.Drawing.Size(61, 28);
            this.buttonVidFolderBrowse.TabIndex = 7;
            this.buttonVidFolderBrowse.Text = "...";
            this.buttonVidFolderBrowse.UseVisualStyleBackColor = true;
            this.buttonVidFolderBrowse.Click += new System.EventHandler(this.buttonVidFolderBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Picture Folder:";
            // 
            // textBoxPicFolder
            // 
            this.textBoxPicFolder.Location = new System.Drawing.Point(136, 34);
            this.textBoxPicFolder.Name = "textBoxPicFolder";
            this.textBoxPicFolder.Size = new System.Drawing.Size(629, 22);
            this.textBoxPicFolder.TabIndex = 3;
            // 
            // buttonPicFolderBrowse
            // 
            this.buttonPicFolderBrowse.Location = new System.Drawing.Point(771, 31);
            this.buttonPicFolderBrowse.Name = "buttonPicFolderBrowse";
            this.buttonPicFolderBrowse.Size = new System.Drawing.Size(61, 28);
            this.buttonPicFolderBrowse.TabIndex = 4;
            this.buttonPicFolderBrowse.Text = "...";
            this.buttonPicFolderBrowse.UseVisualStyleBackColor = true;
            this.buttonPicFolderBrowse.Click += new System.EventHandler(this.buttonPicFolderBrowse_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Video Folder:";
            // 
            // textBoxSampleVidFolder
            // 
            this.textBoxSampleVidFolder.Location = new System.Drawing.Point(143, 72);
            this.textBoxSampleVidFolder.Name = "textBoxSampleVidFolder";
            this.textBoxSampleVidFolder.Size = new System.Drawing.Size(629, 22);
            this.textBoxSampleVidFolder.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(778, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 28);
            this.button1.TabIndex = 13;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Picture Folder:";
            // 
            // textBoxSamplePicFolder
            // 
            this.textBoxSamplePicFolder.Location = new System.Drawing.Point(143, 21);
            this.textBoxSamplePicFolder.Name = "textBoxSamplePicFolder";
            this.textBoxSamplePicFolder.Size = new System.Drawing.Size(629, 22);
            this.textBoxSamplePicFolder.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(778, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 28);
            this.button2.TabIndex = 10;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 636);
            this.Controls.Add(this.labelSourceDB);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBoxSourceDB);
            this.Controls.Add(this.buttonSourceDB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSourceDB;
        private System.Windows.Forms.Button buttonSourceDB;
        private System.Windows.Forms.Label labelSourceDB;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonChangeDirectory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxVidFolder;
        private System.Windows.Forms.Button buttonVidFolderBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPicFolder;
        private System.Windows.Forms.Button buttonPicFolderBrowse;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSampleVidFolder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSamplePicFolder;
        private System.Windows.Forms.Button button2;
    }
}

