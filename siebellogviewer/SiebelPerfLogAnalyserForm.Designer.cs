namespace SiebelPerfLogAnalyser
{
    partial class SiebLogForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiebLogForm));
            this.logFileName = new System.Windows.Forms.TextBox();
            this.openFile = new System.Windows.Forms.Button();
            this.openLogFile = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openLogFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logContMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.automaticUpdaterMain = new wyDay.Controls.AutomaticUpdater();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.objectListViewPerfItems = new BrightIdeasSoftware.ObjectListView();
            this.olvColumnLineNum = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnSqlId = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnPhase = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnTime = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.radioButtonClient = new System.Windows.Forms.RadioButton();
            this.radioButtonServer = new System.Windows.Forms.RadioButton();
            this.logFileContent = new ScintillaNET.Scintilla();
            this.buttonAnalyse = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.statusStrip.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.logContMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.automaticUpdaterMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectListViewPerfItems)).BeginInit();
            this.SuspendLayout();
            // 
            // logFileName
            // 
            this.logFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.logFileName.Location = new System.Drawing.Point(82, 50);
            this.logFileName.Name = "logFileName";
            this.logFileName.Size = new System.Drawing.Size(228, 20);
            this.logFileName.TabIndex = 2;
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(12, 48);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(64, 23);
            this.openFile.TabIndex = 3;
            this.openFile.Text = "Log File";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // openLogFile
            // 
            this.openLogFile.Filter = "Log file|*.log";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 637);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(995, 22);
            this.statusStrip.TabIndex = 4;
            this.statusStrip.Text = "statusStripMain";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel.Text = "toolStripStatusLabel1";
            // 
            // menuStripMain
            // 
            this.menuStripMain.BackColor = System.Drawing.SystemColors.Control;
            this.menuStripMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStripMain.Size = new System.Drawing.Size(995, 24);
            this.menuStripMain.TabIndex = 8;
            this.menuStripMain.Text = "menuStripMain";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openLogFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openLogFileToolStripMenuItem
            // 
            this.openLogFileToolStripMenuItem.Image = global::SiebelPerfLogAnalyser.Properties.Resources.PERFLOG_document_text_import_16;
            this.openLogFileToolStripMenuItem.Name = "openLogFileToolStripMenuItem";
            this.openLogFileToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.openLogFileToolStripMenuItem.Text = "Open Log File...";
            this.openLogFileToolStripMenuItem.Click += new System.EventHandler(this.openLogFileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::SiebelPerfLogAnalyser.Properties.Resources.PERFLOG_close_window_16;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemHelp,
            this.toolStripMenuItemUpdate,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // toolStripMenuItemHelp
            // 
            this.toolStripMenuItemHelp.Image = global::SiebelPerfLogAnalyser.Properties.Resources.PERFLOG_help2;
            this.toolStripMenuItemHelp.Name = "toolStripMenuItemHelp";
            this.toolStripMenuItemHelp.Size = new System.Drawing.Size(121, 22);
            this.toolStripMenuItemHelp.Text = "Help";
            this.toolStripMenuItemHelp.Click += new System.EventHandler(this.toolStripMenuItemHelp_Click);
            // 
            // toolStripMenuItemUpdate
            // 
            this.toolStripMenuItemUpdate.Image = global::SiebelPerfLogAnalyser.Properties.Resources.PERFLOG_application_update;
            this.toolStripMenuItemUpdate.Name = "toolStripMenuItemUpdate";
            this.toolStripMenuItemUpdate.Size = new System.Drawing.Size(121, 22);
            this.toolStripMenuItemUpdate.Text = "Update...";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::SiebelPerfLogAnalyser.Properties.Resources.PERFLOG_NEWCASE_info_16;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // logContMenuStrip
            // 
            this.logContMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemCopy});
            this.logContMenuStrip.Name = "logContMenuStrip";
            this.logContMenuStrip.Size = new System.Drawing.Size(103, 26);
            // 
            // toolStripMenuItemCopy
            // 
            this.toolStripMenuItemCopy.Name = "toolStripMenuItemCopy";
            this.toolStripMenuItemCopy.Size = new System.Drawing.Size(102, 22);
            this.toolStripMenuItemCopy.Text = "Copy";
            this.toolStripMenuItemCopy.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // automaticUpdaterMain
            // 
            this.automaticUpdaterMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.automaticUpdaterMain.ContainerForm = this;
            this.automaticUpdaterMain.Location = new System.Drawing.Point(967, 3);
            this.automaticUpdaterMain.Name = "automaticUpdaterMain";
            this.automaticUpdaterMain.Size = new System.Drawing.Size(16, 16);
            this.automaticUpdaterMain.TabIndex = 10;
            this.automaticUpdaterMain.ToolStripItem = this.toolStripMenuItemUpdate;
            this.automaticUpdaterMain.wyUpdateCommandline = null;
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // objectListViewPerfItems
            // 
            this.objectListViewPerfItems.AllColumns.Add(this.olvColumnLineNum);
            this.objectListViewPerfItems.AllColumns.Add(this.olvColumnSqlId);
            this.objectListViewPerfItems.AllColumns.Add(this.olvColumnPhase);
            this.objectListViewPerfItems.AllColumns.Add(this.olvColumnTime);
            this.objectListViewPerfItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.objectListViewPerfItems.CellEditUseWholeCell = false;
            this.objectListViewPerfItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnLineNum,
            this.olvColumnSqlId,
            this.olvColumnPhase,
            this.olvColumnTime});
            this.objectListViewPerfItems.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListViewPerfItems.FullRowSelect = true;
            this.objectListViewPerfItems.Location = new System.Drawing.Point(12, 130);
            this.objectListViewPerfItems.Name = "objectListViewPerfItems";
            this.objectListViewPerfItems.ShowGroups = false;
            this.objectListViewPerfItems.Size = new System.Drawing.Size(298, 504);
            this.objectListViewPerfItems.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.objectListViewPerfItems.TabIndex = 11;
            this.objectListViewPerfItems.TintSortColumn = true;
            this.objectListViewPerfItems.UseCompatibleStateImageBehavior = false;
            this.objectListViewPerfItems.View = System.Windows.Forms.View.Details;
            this.objectListViewPerfItems.SelectedIndexChanged += new System.EventHandler(this.objectListViewPerfItems_SelectedIndexChanged);
            this.objectListViewPerfItems.MouseUp += new System.Windows.Forms.MouseEventHandler(this.objectListViewPerfItems_MouseUp);
            // 
            // olvColumnLineNum
            // 
            this.olvColumnLineNum.AspectName = "LineNum";
            this.olvColumnLineNum.Text = "Line #";
            // 
            // olvColumnSqlId
            // 
            this.olvColumnSqlId.AspectName = "SqlId";
            this.olvColumnSqlId.Text = "SQL ID";
            // 
            // olvColumnPhase
            // 
            this.olvColumnPhase.AspectName = "Phase";
            this.olvColumnPhase.Text = "Phase";
            this.olvColumnPhase.Width = 80;
            // 
            // olvColumnTime
            // 
            this.olvColumnTime.AspectName = "Time";
            this.olvColumnTime.Text = "Time";
            // 
            // radioButtonClient
            // 
            this.radioButtonClient.AutoSize = true;
            this.radioButtonClient.Location = new System.Drawing.Point(12, 77);
            this.radioButtonClient.Name = "radioButtonClient";
            this.radioButtonClient.Size = new System.Drawing.Size(91, 17);
            this.radioButtonClient.TabIndex = 12;
            this.radioButtonClient.Text = "Client Log File";
            this.radioButtonClient.UseVisualStyleBackColor = true;
            // 
            // radioButtonServer
            // 
            this.radioButtonServer.AutoSize = true;
            this.radioButtonServer.Checked = true;
            this.radioButtonServer.Location = new System.Drawing.Point(109, 77);
            this.radioButtonServer.Name = "radioButtonServer";
            this.radioButtonServer.Size = new System.Drawing.Size(96, 17);
            this.radioButtonServer.TabIndex = 13;
            this.radioButtonServer.TabStop = true;
            this.radioButtonServer.Text = "Server Log File";
            this.radioButtonServer.UseVisualStyleBackColor = true;
            // 
            // logFileContent
            // 
            this.logFileContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logFileContent.CaretLineVisible = true;
            this.logFileContent.Location = new System.Drawing.Point(317, 28);
            this.logFileContent.Name = "logFileContent";
            this.logFileContent.Size = new System.Drawing.Size(666, 606);
            this.logFileContent.TabIndex = 14;
            // 
            // buttonAnalyse
            // 
            this.buttonAnalyse.Location = new System.Drawing.Point(211, 74);
            this.buttonAnalyse.Name = "buttonAnalyse";
            this.buttonAnalyse.Size = new System.Drawing.Size(98, 23);
            this.buttonAnalyse.TabIndex = 15;
            this.buttonAnalyse.Text = "Analyse";
            this.buttonAnalyse.UseVisualStyleBackColor = true;
            this.buttonAnalyse.Click += new System.EventHandler(this.buttonAnalyse_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(13, 101);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(297, 23);
            this.progressBar.TabIndex = 16;
            // 
            // SiebLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 659);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.buttonAnalyse);
            this.Controls.Add(this.logFileContent);
            this.Controls.Add(this.radioButtonServer);
            this.Controls.Add(this.radioButtonClient);
            this.Controls.Add(this.objectListViewPerfItems);
            this.Controls.Add(this.automaticUpdaterMain);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStripMain);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.logFileName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "SiebLogForm";
            this.Text = "Siebel Perf Log Analyser";
            this.Load += new System.EventHandler(this.SiebLogForm_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.logContMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.automaticUpdaterMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectListViewPerfItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox logFileName;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.OpenFileDialog openLogFile;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openLogFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip logContMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopy;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemUpdate;
        private wyDay.Controls.AutomaticUpdater automaticUpdaterMain;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private BrightIdeasSoftware.ObjectListView objectListViewPerfItems;
        private BrightIdeasSoftware.OLVColumn olvColumnLineNum;
        private BrightIdeasSoftware.OLVColumn olvColumnSqlId;
        private BrightIdeasSoftware.OLVColumn olvColumnPhase;
        private BrightIdeasSoftware.OLVColumn olvColumnTime;
        private System.Windows.Forms.RadioButton radioButtonServer;
        private System.Windows.Forms.RadioButton radioButtonClient;
        private ScintillaNET.Scintilla logFileContent;
        private System.Windows.Forms.Button buttonAnalyse;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

