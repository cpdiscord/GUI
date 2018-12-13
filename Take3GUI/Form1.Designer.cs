namespace Take3GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainTabs = new System.Windows.Forms.TabControl();
            this.Users = new System.Windows.Forms.TabPage();
            this.userList = new System.Windows.Forms.CheckedListBox();
            this.Programs = new System.Windows.Forms.TabPage();
            this.selectedPrograms = new System.Windows.Forms.ListBox();
            this.deleteEXE = new System.Windows.Forms.Button();
            this.checkEXE = new System.Windows.Forms.TextBox();
            this.applyVersion = new System.Windows.Forms.Button();
            this.programVersion = new System.Windows.Forms.TextBox();
            this.browseEXE = new System.Windows.Forms.Button();
            this.versionBox = new System.Windows.Forms.ListBox();
            this.ProgramList = new System.Windows.Forms.CheckedListBox();
            this.Files = new System.Windows.Forms.TabPage();
            this.fileClear = new System.Windows.Forms.Button();
            this.fileRemove = new System.Windows.Forms.Button();
            this.fileBrowser = new System.Windows.Forms.ListBox();
            this.fileBrowse = new System.Windows.Forms.Button();
            this.Credits = new System.Windows.Forms.TabPage();
            this.MainTabs.SuspendLayout();
            this.Users.SuspendLayout();
            this.Programs.SuspendLayout();
            this.Files.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabs
            // 
            this.MainTabs.Controls.Add(this.Users);
            this.MainTabs.Controls.Add(this.Programs);
            this.MainTabs.Controls.Add(this.Files);
            this.MainTabs.Controls.Add(this.Credits);
            this.MainTabs.Location = new System.Drawing.Point(0, -2);
            this.MainTabs.Name = "MainTabs";
            this.MainTabs.SelectedIndex = 0;
            this.MainTabs.Size = new System.Drawing.Size(802, 456);
            this.MainTabs.TabIndex = 0;
            this.MainTabs.SelectedIndexChanged += new System.EventHandler(this.MainTabs_SelectedIndexChanged);
            // 
            // Users
            // 
            this.Users.Controls.Add(this.userList);
            this.Users.Location = new System.Drawing.Point(4, 22);
            this.Users.Name = "Users";
            this.Users.Padding = new System.Windows.Forms.Padding(3);
            this.Users.Size = new System.Drawing.Size(794, 430);
            this.Users.TabIndex = 0;
            this.Users.Text = "Users";
            this.Users.UseVisualStyleBackColor = true;
            this.Users.Click += new System.EventHandler(this.Users_Click);
            // 
            // userList
            // 
            this.userList.CheckOnClick = true;
            this.userList.FormattingEnabled = true;
            this.userList.Location = new System.Drawing.Point(6, 6);
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(206, 154);
            this.userList.TabIndex = 0;
            this.userList.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged_1);
            // 
            // Programs
            // 
            this.Programs.Controls.Add(this.selectedPrograms);
            this.Programs.Controls.Add(this.deleteEXE);
            this.Programs.Controls.Add(this.checkEXE);
            this.Programs.Controls.Add(this.applyVersion);
            this.Programs.Controls.Add(this.programVersion);
            this.Programs.Controls.Add(this.browseEXE);
            this.Programs.Controls.Add(this.versionBox);
            this.Programs.Controls.Add(this.ProgramList);
            this.Programs.Location = new System.Drawing.Point(4, 22);
            this.Programs.Name = "Programs";
            this.Programs.Padding = new System.Windows.Forms.Padding(3);
            this.Programs.Size = new System.Drawing.Size(794, 430);
            this.Programs.TabIndex = 1;
            this.Programs.Text = "Programs";
            this.Programs.UseVisualStyleBackColor = true;
            this.Programs.Click += new System.EventHandler(this.Programs_Click);
            // 
            // selectedPrograms
            // 
            this.selectedPrograms.FormattingEnabled = true;
            this.selectedPrograms.Location = new System.Drawing.Point(219, 3);
            this.selectedPrograms.Name = "selectedPrograms";
            this.selectedPrograms.Size = new System.Drawing.Size(210, 134);
            this.selectedPrograms.TabIndex = 7;
            this.selectedPrograms.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // deleteEXE
            // 
            this.deleteEXE.Location = new System.Drawing.Point(567, 143);
            this.deleteEXE.Name = "deleteEXE";
            this.deleteEXE.Size = new System.Drawing.Size(75, 23);
            this.deleteEXE.TabIndex = 6;
            this.deleteEXE.Text = "Clear";
            this.deleteEXE.UseVisualStyleBackColor = true;
            this.deleteEXE.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // checkEXE
            // 
            this.checkEXE.Enabled = false;
            this.checkEXE.Location = new System.Drawing.Point(488, 172);
            this.checkEXE.Name = "checkEXE";
            this.checkEXE.Size = new System.Drawing.Size(235, 20);
            this.checkEXE.TabIndex = 5;
            this.checkEXE.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // applyVersion
            // 
            this.applyVersion.Location = new System.Drawing.Point(648, 143);
            this.applyVersion.Name = "applyVersion";
            this.applyVersion.Size = new System.Drawing.Size(75, 23);
            this.applyVersion.TabIndex = 4;
            this.applyVersion.Text = "Apply";
            this.applyVersion.UseVisualStyleBackColor = true;
            this.applyVersion.Click += new System.EventHandler(this.applyVersion_Click);
            // 
            // programVersion
            // 
            this.programVersion.Location = new System.Drawing.Point(488, 198);
            this.programVersion.Name = "programVersion";
            this.programVersion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.programVersion.Size = new System.Drawing.Size(73, 20);
            this.programVersion.TabIndex = 3;
            this.programVersion.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // browseEXE
            // 
            this.browseEXE.Location = new System.Drawing.Point(488, 143);
            this.browseEXE.Name = "browseEXE";
            this.browseEXE.Size = new System.Drawing.Size(75, 23);
            this.browseEXE.TabIndex = 2;
            this.browseEXE.Text = "Browse";
            this.browseEXE.UseVisualStyleBackColor = true;
            this.browseEXE.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // versionBox
            // 
            this.versionBox.FormattingEnabled = true;
            this.versionBox.Location = new System.Drawing.Point(488, 16);
            this.versionBox.Name = "versionBox";
            this.versionBox.Size = new System.Drawing.Size(235, 121);
            this.versionBox.TabIndex = 1;
            this.versionBox.SelectedIndexChanged += new System.EventHandler(this.versionBox_SelectedIndexChanged);
            // 
            // ProgramList
            // 
            this.ProgramList.CheckOnClick = true;
            this.ProgramList.FormattingEnabled = true;
            this.ProgramList.Location = new System.Drawing.Point(0, 1);
            this.ProgramList.Name = "ProgramList";
            this.ProgramList.Size = new System.Drawing.Size(213, 424);
            this.ProgramList.Sorted = true;
            this.ProgramList.TabIndex = 0;
            this.ProgramList.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // Files
            // 
            this.Files.Controls.Add(this.fileClear);
            this.Files.Controls.Add(this.fileRemove);
            this.Files.Controls.Add(this.fileBrowser);
            this.Files.Controls.Add(this.fileBrowse);
            this.Files.Location = new System.Drawing.Point(4, 22);
            this.Files.Name = "Files";
            this.Files.Size = new System.Drawing.Size(794, 430);
            this.Files.TabIndex = 2;
            this.Files.Text = "Files";
            this.Files.UseVisualStyleBackColor = true;
            this.Files.Click += new System.EventHandler(this.Files_Click);
            // 
            // fileClear
            // 
            this.fileClear.Location = new System.Drawing.Point(209, 157);
            this.fileClear.Name = "fileClear";
            this.fileClear.Size = new System.Drawing.Size(75, 23);
            this.fileClear.TabIndex = 3;
            this.fileClear.Text = "Clear";
            this.fileClear.UseVisualStyleBackColor = true;
            this.fileClear.Click += new System.EventHandler(this.fileClear_Click);
            // 
            // fileRemove
            // 
            this.fileRemove.Location = new System.Drawing.Point(114, 157);
            this.fileRemove.Name = "fileRemove";
            this.fileRemove.Size = new System.Drawing.Size(75, 23);
            this.fileRemove.TabIndex = 2;
            this.fileRemove.Text = "Remove";
            this.fileRemove.UseVisualStyleBackColor = true;
            this.fileRemove.Click += new System.EventHandler(this.fileRemove_Click);
            // 
            // fileBrowser
            // 
            this.fileBrowser.FormattingEnabled = true;
            this.fileBrowser.Location = new System.Drawing.Point(20, 17);
            this.fileBrowser.Name = "fileBrowser";
            this.fileBrowser.Size = new System.Drawing.Size(264, 134);
            this.fileBrowser.TabIndex = 1;
            this.fileBrowser.SelectedIndexChanged += new System.EventHandler(this.fileBrowser_SelectedIndexChanged);
            // 
            // fileBrowse
            // 
            this.fileBrowse.Location = new System.Drawing.Point(20, 157);
            this.fileBrowse.Name = "fileBrowse";
            this.fileBrowse.Size = new System.Drawing.Size(75, 23);
            this.fileBrowse.TabIndex = 0;
            this.fileBrowse.Text = "Browse";
            this.fileBrowse.UseVisualStyleBackColor = true;
            this.fileBrowse.Click += new System.EventHandler(this.button1_Click);
            // 
            // Credits
            // 
            this.Credits.Location = new System.Drawing.Point(4, 22);
            this.Credits.Name = "Credits";
            this.Credits.Size = new System.Drawing.Size(794, 430);
            this.Credits.TabIndex = 3;
            this.Credits.Text = "Credits";
            this.Credits.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainTabs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "DyNaMiX";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainTabs.ResumeLayout(false);
            this.Users.ResumeLayout(false);
            this.Programs.ResumeLayout(false);
            this.Programs.PerformLayout();
            this.Files.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabs;
        private System.Windows.Forms.TabPage Users;
        private System.Windows.Forms.TabPage Programs;
        private System.Windows.Forms.TabPage Files;
        private System.Windows.Forms.TabPage Credits;
        private System.Windows.Forms.CheckedListBox ProgramList;
        private System.Windows.Forms.Button fileBrowse;
        private System.Windows.Forms.ListBox fileBrowser;
        private System.Windows.Forms.Button fileRemove;
        private System.Windows.Forms.Button fileClear;
        private System.Windows.Forms.CheckedListBox userList;
        private System.Windows.Forms.Button browseEXE;
        private System.Windows.Forms.ListBox versionBox;
        private System.Windows.Forms.TextBox programVersion;
        private System.Windows.Forms.Button applyVersion;
        private System.Windows.Forms.TextBox checkEXE;
        private System.Windows.Forms.Button deleteEXE;
        private System.Windows.Forms.ListBox selectedPrograms;
    }
}

