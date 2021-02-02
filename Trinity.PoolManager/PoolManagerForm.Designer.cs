
namespace Trinity.PoolManager
{
    partial class PoolManagerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.tsStatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.pgStatus = new System.Windows.Forms.ToolStripProgressBar();
            this.tbMain = new System.Windows.Forms.TabControl();
            this.tpOverview = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnLoad = new System.Windows.Forms.Button();
            this.tvOverview = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tpPoolConversion = new System.Windows.Forms.TabPage();
            this.tpPoolDesigner = new System.Windows.Forms.TabPage();
            this.tpConfig = new System.Windows.Forms.TabPage();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveConfig = new System.Windows.Forms.Button();
            this.grpDBCLocationConfig = new System.Windows.Forms.GroupBox();
            this.btnDBCBrowse = new System.Windows.Forms.Button();
            this.txtTrinityDBCFolder = new System.Windows.Forms.TextBox();
            this.lblTrinityDBCFolder = new System.Windows.Forms.Label();
            this.grpSqlConfig = new System.Windows.Forms.GroupBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblSqlDatabase = new System.Windows.Forms.Label();
            this.lblSqlPassword = new System.Windows.Forms.Label();
            this.lblSqlUsername = new System.Windows.Forms.Label();
            this.cbSqlDatabase = new System.Windows.Forms.ComboBox();
            this.txtSqlPassword = new System.Windows.Forms.TextBox();
            this.txtSqlUsername = new System.Windows.Forms.TextBox();
            this.txtSqlServerHost = new System.Windows.Forms.TextBox();
            this.lblSqlServerHost = new System.Windows.Forms.Label();
            this.ssStatus.SuspendLayout();
            this.tbMain.SuspendLayout();
            this.tpOverview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tpConfig.SuspendLayout();
            this.grpDBCLocationConfig.SuspendLayout();
            this.grpSqlConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // ssStatus
            // 
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStatusText,
            this.pgStatus});
            this.ssStatus.Location = new System.Drawing.Point(0, 428);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(800, 22);
            this.ssStatus.TabIndex = 3;
            this.ssStatus.Resize += new System.EventHandler(this.statusStrip1_Resize);
            // 
            // tsStatusText
            // 
            this.tsStatusText.AutoSize = false;
            this.tsStatusText.Name = "tsStatusText";
            this.tsStatusText.Size = new System.Drawing.Size(200, 17);
            this.tsStatusText.Text = "Status Text";
            this.tsStatusText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pgStatus
            // 
            this.pgStatus.AutoSize = false;
            this.pgStatus.Name = "pgStatus";
            this.pgStatus.Size = new System.Drawing.Size(580, 16);
            this.pgStatus.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // tbMain
            // 
            this.tbMain.Controls.Add(this.tpOverview);
            this.tbMain.Controls.Add(this.tpPoolConversion);
            this.tbMain.Controls.Add(this.tpPoolDesigner);
            this.tbMain.Controls.Add(this.tpConfig);
            this.tbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMain.Location = new System.Drawing.Point(0, 0);
            this.tbMain.Name = "tbMain";
            this.tbMain.SelectedIndex = 0;
            this.tbMain.Size = new System.Drawing.Size(800, 428);
            this.tbMain.TabIndex = 4;
            // 
            // tpOverview
            // 
            this.tpOverview.Controls.Add(this.splitContainer1);
            this.tpOverview.Location = new System.Drawing.Point(4, 24);
            this.tpOverview.Name = "tpOverview";
            this.tpOverview.Padding = new System.Windows.Forms.Padding(3);
            this.tpOverview.Size = new System.Drawing.Size(792, 400);
            this.tpOverview.TabIndex = 0;
            this.tpOverview.Text = "Overview";
            this.tpOverview.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnLoad);
            this.splitContainer1.Panel1.Controls.Add(this.tvOverview);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(786, 394);
            this.splitContainer1.SplitterDistance = 202;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 10;
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.Location = new System.Drawing.Point(3, 363);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(196, 28);
            this.btnLoad.TabIndex = 11;
            this.btnLoad.Text = "Load Data";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // tvOverview
            // 
            this.tvOverview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvOverview.Location = new System.Drawing.Point(3, 3);
            this.tvOverview.Name = "tvOverview";
            this.tvOverview.Size = new System.Drawing.Size(196, 354);
            this.tvOverview.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 195);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Object Data";
            // 
            // tpPoolConversion
            // 
            this.tpPoolConversion.Location = new System.Drawing.Point(4, 24);
            this.tpPoolConversion.Name = "tpPoolConversion";
            this.tpPoolConversion.Padding = new System.Windows.Forms.Padding(3);
            this.tpPoolConversion.Size = new System.Drawing.Size(792, 400);
            this.tpPoolConversion.TabIndex = 1;
            this.tpPoolConversion.Text = "Legacy Pool Conversion";
            this.tpPoolConversion.UseVisualStyleBackColor = true;
            // 
            // tpPoolDesigner
            // 
            this.tpPoolDesigner.Location = new System.Drawing.Point(4, 24);
            this.tpPoolDesigner.Name = "tpPoolDesigner";
            this.tpPoolDesigner.Size = new System.Drawing.Size(792, 400);
            this.tpPoolDesigner.TabIndex = 2;
            this.tpPoolDesigner.Text = "Pool Designer";
            this.tpPoolDesigner.UseVisualStyleBackColor = true;
            // 
            // tpConfig
            // 
            this.tpConfig.Controls.Add(this.btnCancel);
            this.tpConfig.Controls.Add(this.btnSaveConfig);
            this.tpConfig.Controls.Add(this.grpDBCLocationConfig);
            this.tpConfig.Controls.Add(this.grpSqlConfig);
            this.tpConfig.Location = new System.Drawing.Point(4, 24);
            this.tpConfig.Name = "tpConfig";
            this.tpConfig.Size = new System.Drawing.Size(792, 400);
            this.tpConfig.TabIndex = 3;
            this.tpConfig.Text = "Config";
            this.tpConfig.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(605, 374);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveConfig.Location = new System.Drawing.Point(700, 374);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(89, 23);
            this.btnSaveConfig.TabIndex = 2;
            this.btnSaveConfig.Text = "Save";
            this.btnSaveConfig.UseVisualStyleBackColor = true;
            this.btnSaveConfig.Click += new System.EventHandler(this.btnSaveConfig_Click);
            // 
            // grpDBCLocationConfig
            // 
            this.grpDBCLocationConfig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDBCLocationConfig.Controls.Add(this.btnDBCBrowse);
            this.grpDBCLocationConfig.Controls.Add(this.txtTrinityDBCFolder);
            this.grpDBCLocationConfig.Controls.Add(this.lblTrinityDBCFolder);
            this.grpDBCLocationConfig.Location = new System.Drawing.Point(8, 146);
            this.grpDBCLocationConfig.Name = "grpDBCLocationConfig";
            this.grpDBCLocationConfig.Size = new System.Drawing.Size(776, 54);
            this.grpDBCLocationConfig.TabIndex = 1;
            this.grpDBCLocationConfig.TabStop = false;
            this.grpDBCLocationConfig.Text = "DBC Location";
            // 
            // btnDBCBrowse
            // 
            this.btnDBCBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDBCBrowse.Location = new System.Drawing.Point(652, 16);
            this.btnDBCBrowse.Name = "btnDBCBrowse";
            this.btnDBCBrowse.Size = new System.Drawing.Size(118, 23);
            this.btnDBCBrowse.TabIndex = 3;
            this.btnDBCBrowse.Text = "Browse";
            this.btnDBCBrowse.UseVisualStyleBackColor = true;
            this.btnDBCBrowse.Click += new System.EventHandler(this.btnDBCBrowse_Click);
            // 
            // txtTrinityDBCFolder
            // 
            this.txtTrinityDBCFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTrinityDBCFolder.Location = new System.Drawing.Point(130, 16);
            this.txtTrinityDBCFolder.Name = "txtTrinityDBCFolder";
            this.txtTrinityDBCFolder.Size = new System.Drawing.Size(516, 23);
            this.txtTrinityDBCFolder.TabIndex = 2;
            // 
            // lblTrinityDBCFolder
            // 
            this.lblTrinityDBCFolder.Location = new System.Drawing.Point(6, 19);
            this.lblTrinityDBCFolder.Name = "lblTrinityDBCFolder";
            this.lblTrinityDBCFolder.Size = new System.Drawing.Size(118, 23);
            this.lblTrinityDBCFolder.TabIndex = 0;
            this.lblTrinityDBCFolder.Text = "Trinity DBC Folder";
            // 
            // grpSqlConfig
            // 
            this.grpSqlConfig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSqlConfig.Controls.Add(this.btnConnect);
            this.grpSqlConfig.Controls.Add(this.lblSqlDatabase);
            this.grpSqlConfig.Controls.Add(this.lblSqlPassword);
            this.grpSqlConfig.Controls.Add(this.lblSqlUsername);
            this.grpSqlConfig.Controls.Add(this.cbSqlDatabase);
            this.grpSqlConfig.Controls.Add(this.txtSqlPassword);
            this.grpSqlConfig.Controls.Add(this.txtSqlUsername);
            this.grpSqlConfig.Controls.Add(this.txtSqlServerHost);
            this.grpSqlConfig.Controls.Add(this.lblSqlServerHost);
            this.grpSqlConfig.Location = new System.Drawing.Point(8, 3);
            this.grpSqlConfig.Name = "grpSqlConfig";
            this.grpSqlConfig.Size = new System.Drawing.Size(776, 137);
            this.grpSqlConfig.TabIndex = 0;
            this.grpSqlConfig.TabStop = false;
            this.grpSqlConfig.Text = "SQL Configuration";
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.Location = new System.Drawing.Point(652, 74);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(118, 23);
            this.btnConnect.TabIndex = 8;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblSqlDatabase
            // 
            this.lblSqlDatabase.Location = new System.Drawing.Point(6, 103);
            this.lblSqlDatabase.Name = "lblSqlDatabase";
            this.lblSqlDatabase.Size = new System.Drawing.Size(118, 23);
            this.lblSqlDatabase.TabIndex = 7;
            this.lblSqlDatabase.Text = "SQL Database";
            // 
            // lblSqlPassword
            // 
            this.lblSqlPassword.Location = new System.Drawing.Point(6, 74);
            this.lblSqlPassword.Name = "lblSqlPassword";
            this.lblSqlPassword.Size = new System.Drawing.Size(118, 23);
            this.lblSqlPassword.TabIndex = 6;
            this.lblSqlPassword.Text = "SQL Password";
            // 
            // lblSqlUsername
            // 
            this.lblSqlUsername.Location = new System.Drawing.Point(6, 45);
            this.lblSqlUsername.Name = "lblSqlUsername";
            this.lblSqlUsername.Size = new System.Drawing.Size(118, 23);
            this.lblSqlUsername.TabIndex = 5;
            this.lblSqlUsername.Text = "SQL Username";
            // 
            // cbSqlDatabase
            // 
            this.cbSqlDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSqlDatabase.FormattingEnabled = true;
            this.cbSqlDatabase.Location = new System.Drawing.Point(130, 103);
            this.cbSqlDatabase.Name = "cbSqlDatabase";
            this.cbSqlDatabase.Size = new System.Drawing.Size(516, 23);
            this.cbSqlDatabase.TabIndex = 4;
            // 
            // txtSqlPassword
            // 
            this.txtSqlPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSqlPassword.Location = new System.Drawing.Point(130, 74);
            this.txtSqlPassword.Name = "txtSqlPassword";
            this.txtSqlPassword.Size = new System.Drawing.Size(516, 23);
            this.txtSqlPassword.TabIndex = 3;
            // 
            // txtSqlUsername
            // 
            this.txtSqlUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSqlUsername.Location = new System.Drawing.Point(130, 45);
            this.txtSqlUsername.Name = "txtSqlUsername";
            this.txtSqlUsername.Size = new System.Drawing.Size(516, 23);
            this.txtSqlUsername.TabIndex = 2;
            // 
            // txtSqlServerHost
            // 
            this.txtSqlServerHost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSqlServerHost.Location = new System.Drawing.Point(130, 16);
            this.txtSqlServerHost.Name = "txtSqlServerHost";
            this.txtSqlServerHost.Size = new System.Drawing.Size(516, 23);
            this.txtSqlServerHost.TabIndex = 1;
            // 
            // lblSqlServerHost
            // 
            this.lblSqlServerHost.Location = new System.Drawing.Point(6, 19);
            this.lblSqlServerHost.Name = "lblSqlServerHost";
            this.lblSqlServerHost.Size = new System.Drawing.Size(118, 23);
            this.lblSqlServerHost.TabIndex = 0;
            this.lblSqlServerHost.Text = "SQL Server Host/IP";
            // 
            // PoolManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbMain);
            this.Controls.Add(this.ssStatus);
            this.Name = "PoolManagerForm";
            this.Text = "Trinity Pool Manager";
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            this.tbMain.ResumeLayout(false);
            this.tpOverview.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tpConfig.ResumeLayout(false);
            this.grpDBCLocationConfig.ResumeLayout(false);
            this.grpDBCLocationConfig.PerformLayout();
            this.grpSqlConfig.ResumeLayout(false);
            this.grpSqlConfig.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.ToolStripStatusLabel tsStatusText;
        private System.Windows.Forms.ToolStripProgressBar pgStatus;
        private System.Windows.Forms.TabControl tbMain;
        private System.Windows.Forms.TabPage tpOverview;
        private System.Windows.Forms.TabPage tpPoolConversion;
        private System.Windows.Forms.TabPage tpPoolDesigner;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TreeView tvOverview;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tpConfig;
        private System.Windows.Forms.GroupBox grpSqlConfig;
        private System.Windows.Forms.Label lblSqlDatabase;
        private System.Windows.Forms.Label lblSqlPassword;
        private System.Windows.Forms.Label lblSqlUsername;
        private System.Windows.Forms.ComboBox cbSqlDatabase;
        private System.Windows.Forms.TextBox txtSqlPassword;
        private System.Windows.Forms.TextBox txtSqlUsername;
        private System.Windows.Forms.TextBox txtSqlServerHost;
        private System.Windows.Forms.Label lblSqlServerHost;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox grpDBCLocationConfig;
        private System.Windows.Forms.Button btnDBCBrowse;
        private System.Windows.Forms.TextBox txtTrinityDBCFolder;
        private System.Windows.Forms.Label lblTrinityDBCFolder;
        private System.Windows.Forms.Button btnSaveConfig;
        private System.Windows.Forms.Button btnCancel;
    }
}

