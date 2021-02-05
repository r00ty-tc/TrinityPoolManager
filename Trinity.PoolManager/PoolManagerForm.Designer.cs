
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
            this.tbOverviewObjectInfo = new System.Windows.Forms.TabControl();
            this.tpCreatureObject = new System.Windows.Forms.TabPage();
            this.txtCreatureEntry = new System.Windows.Forms.TextBox();
            this.txtCreatureId = new System.Windows.Forms.TextBox();
            this.lblCreatureIdEntry = new System.Windows.Forms.Label();
            this.txtCreaturePositionZ = new System.Windows.Forms.TextBox();
            this.lblCreaturePositionZ = new System.Windows.Forms.Label();
            this.txtCreatureAreaName = new System.Windows.Forms.TextBox();
            this.txtCreatureAreaId = new System.Windows.Forms.TextBox();
            this.lblCreatureArea = new System.Windows.Forms.Label();
            this.txtCreaturePositionX = new System.Windows.Forms.TextBox();
            this.lblCreaturePositionX = new System.Windows.Forms.Label();
            this.txtCreatureMapName = new System.Windows.Forms.TextBox();
            this.txtCreatureMapId = new System.Windows.Forms.TextBox();
            this.lblCreatureMap = new System.Windows.Forms.Label();
            this.txtCreaturePositionY = new System.Windows.Forms.TextBox();
            this.lblCreaturePositionY = new System.Windows.Forms.Label();
            this.txtCreatureZoneName = new System.Windows.Forms.TextBox();
            this.txtCreatureZoneId = new System.Windows.Forms.TextBox();
            this.lblCreatureZone = new System.Windows.Forms.Label();
            this.tpCreatureTemplate = new System.Windows.Forms.TabPage();
            this.tpGameObject = new System.Windows.Forms.TabPage();
            this.tpGameObjectTemplate = new System.Windows.Forms.TabPage();
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
            this.tbOverviewObjectInfo.SuspendLayout();
            this.tpCreatureObject.SuspendLayout();
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
            this.splitContainer1.Panel2.Controls.Add(this.tbOverviewObjectInfo);
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
            this.tvOverview.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvOverview_AfterSelect);
            // 
            // tbOverviewObjectInfo
            // 
            this.tbOverviewObjectInfo.Controls.Add(this.tpCreatureObject);
            this.tbOverviewObjectInfo.Controls.Add(this.tpCreatureTemplate);
            this.tbOverviewObjectInfo.Controls.Add(this.tpGameObject);
            this.tbOverviewObjectInfo.Controls.Add(this.tpGameObjectTemplate);
            this.tbOverviewObjectInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbOverviewObjectInfo.Enabled = false;
            this.tbOverviewObjectInfo.Location = new System.Drawing.Point(0, 0);
            this.tbOverviewObjectInfo.Name = "tbOverviewObjectInfo";
            this.tbOverviewObjectInfo.SelectedIndex = 0;
            this.tbOverviewObjectInfo.Size = new System.Drawing.Size(582, 394);
            this.tbOverviewObjectInfo.TabIndex = 0;
            // 
            // tpCreatureObject
            // 
            this.tpCreatureObject.Controls.Add(this.txtCreatureEntry);
            this.tpCreatureObject.Controls.Add(this.txtCreatureId);
            this.tpCreatureObject.Controls.Add(this.lblCreatureIdEntry);
            this.tpCreatureObject.Controls.Add(this.txtCreaturePositionZ);
            this.tpCreatureObject.Controls.Add(this.lblCreaturePositionZ);
            this.tpCreatureObject.Controls.Add(this.txtCreatureAreaName);
            this.tpCreatureObject.Controls.Add(this.txtCreatureAreaId);
            this.tpCreatureObject.Controls.Add(this.lblCreatureArea);
            this.tpCreatureObject.Controls.Add(this.txtCreaturePositionX);
            this.tpCreatureObject.Controls.Add(this.lblCreaturePositionX);
            this.tpCreatureObject.Controls.Add(this.txtCreatureMapName);
            this.tpCreatureObject.Controls.Add(this.txtCreatureMapId);
            this.tpCreatureObject.Controls.Add(this.lblCreatureMap);
            this.tpCreatureObject.Controls.Add(this.txtCreaturePositionY);
            this.tpCreatureObject.Controls.Add(this.lblCreaturePositionY);
            this.tpCreatureObject.Controls.Add(this.txtCreatureZoneName);
            this.tpCreatureObject.Controls.Add(this.txtCreatureZoneId);
            this.tpCreatureObject.Controls.Add(this.lblCreatureZone);
            this.tpCreatureObject.Location = new System.Drawing.Point(4, 24);
            this.tpCreatureObject.Name = "tpCreatureObject";
            this.tpCreatureObject.Padding = new System.Windows.Forms.Padding(3);
            this.tpCreatureObject.Size = new System.Drawing.Size(574, 366);
            this.tpCreatureObject.TabIndex = 0;
            this.tpCreatureObject.Text = "Creature";
            this.tpCreatureObject.UseVisualStyleBackColor = true;
            // 
            // txtCreatureEntry
            // 
            this.txtCreatureEntry.Location = new System.Drawing.Point(146, 97);
            this.txtCreatureEntry.Name = "txtCreatureEntry";
            this.txtCreatureEntry.Size = new System.Drawing.Size(74, 23);
            this.txtCreatureEntry.TabIndex = 17;
            // 
            // txtCreatureId
            // 
            this.txtCreatureId.Location = new System.Drawing.Point(66, 97);
            this.txtCreatureId.Name = "txtCreatureId";
            this.txtCreatureId.Size = new System.Drawing.Size(74, 23);
            this.txtCreatureId.TabIndex = 16;
            // 
            // lblCreatureIdEntry
            // 
            this.lblCreatureIdEntry.AutoSize = true;
            this.lblCreatureIdEntry.Location = new System.Drawing.Point(10, 100);
            this.lblCreatureIdEntry.Name = "lblCreatureIdEntry";
            this.lblCreatureIdEntry.Size = new System.Drawing.Size(50, 15);
            this.lblCreatureIdEntry.TabIndex = 15;
            this.lblCreatureIdEntry.Text = "ID/Entry";
            // 
            // txtCreaturePositionZ
            // 
            this.txtCreaturePositionZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCreaturePositionZ.Location = new System.Drawing.Point(451, 68);
            this.txtCreaturePositionZ.Name = "txtCreaturePositionZ";
            this.txtCreaturePositionZ.Size = new System.Drawing.Size(120, 23);
            this.txtCreaturePositionZ.TabIndex = 14;
            // 
            // lblCreaturePositionZ
            // 
            this.lblCreaturePositionZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCreaturePositionZ.AutoSize = true;
            this.lblCreaturePositionZ.Location = new System.Drawing.Point(431, 71);
            this.lblCreaturePositionZ.Name = "lblCreaturePositionZ";
            this.lblCreaturePositionZ.Size = new System.Drawing.Size(14, 15);
            this.lblCreaturePositionZ.TabIndex = 13;
            this.lblCreaturePositionZ.Text = "Z";
            // 
            // txtCreatureAreaName
            // 
            this.txtCreatureAreaName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCreatureAreaName.Location = new System.Drawing.Point(146, 68);
            this.txtCreatureAreaName.Name = "txtCreatureAreaName";
            this.txtCreatureAreaName.Size = new System.Drawing.Size(279, 23);
            this.txtCreatureAreaName.TabIndex = 12;
            // 
            // txtCreatureAreaId
            // 
            this.txtCreatureAreaId.Location = new System.Drawing.Point(66, 68);
            this.txtCreatureAreaId.Name = "txtCreatureAreaId";
            this.txtCreatureAreaId.Size = new System.Drawing.Size(74, 23);
            this.txtCreatureAreaId.TabIndex = 11;
            // 
            // lblCreatureArea
            // 
            this.lblCreatureArea.AutoSize = true;
            this.lblCreatureArea.Location = new System.Drawing.Point(10, 71);
            this.lblCreatureArea.Name = "lblCreatureArea";
            this.lblCreatureArea.Size = new System.Drawing.Size(31, 15);
            this.lblCreatureArea.TabIndex = 10;
            this.lblCreatureArea.Text = "Area";
            // 
            // txtCreaturePositionX
            // 
            this.txtCreaturePositionX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCreaturePositionX.Location = new System.Drawing.Point(451, 10);
            this.txtCreaturePositionX.Name = "txtCreaturePositionX";
            this.txtCreaturePositionX.Size = new System.Drawing.Size(120, 23);
            this.txtCreaturePositionX.TabIndex = 9;
            // 
            // lblCreaturePositionX
            // 
            this.lblCreaturePositionX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCreaturePositionX.AutoSize = true;
            this.lblCreaturePositionX.Location = new System.Drawing.Point(431, 13);
            this.lblCreaturePositionX.Name = "lblCreaturePositionX";
            this.lblCreaturePositionX.Size = new System.Drawing.Size(14, 15);
            this.lblCreaturePositionX.TabIndex = 8;
            this.lblCreaturePositionX.Text = "X";
            // 
            // txtCreatureMapName
            // 
            this.txtCreatureMapName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCreatureMapName.Location = new System.Drawing.Point(146, 10);
            this.txtCreatureMapName.Name = "txtCreatureMapName";
            this.txtCreatureMapName.Size = new System.Drawing.Size(279, 23);
            this.txtCreatureMapName.TabIndex = 7;
            // 
            // txtCreatureMapId
            // 
            this.txtCreatureMapId.Location = new System.Drawing.Point(66, 10);
            this.txtCreatureMapId.Name = "txtCreatureMapId";
            this.txtCreatureMapId.Size = new System.Drawing.Size(74, 23);
            this.txtCreatureMapId.TabIndex = 6;
            // 
            // lblCreatureMap
            // 
            this.lblCreatureMap.AutoSize = true;
            this.lblCreatureMap.Location = new System.Drawing.Point(10, 13);
            this.lblCreatureMap.Name = "lblCreatureMap";
            this.lblCreatureMap.Size = new System.Drawing.Size(31, 15);
            this.lblCreatureMap.TabIndex = 5;
            this.lblCreatureMap.Text = "Map";
            // 
            // txtCreaturePositionY
            // 
            this.txtCreaturePositionY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCreaturePositionY.Location = new System.Drawing.Point(451, 39);
            this.txtCreaturePositionY.Name = "txtCreaturePositionY";
            this.txtCreaturePositionY.Size = new System.Drawing.Size(120, 23);
            this.txtCreaturePositionY.TabIndex = 4;
            // 
            // lblCreaturePositionY
            // 
            this.lblCreaturePositionY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCreaturePositionY.AutoSize = true;
            this.lblCreaturePositionY.Location = new System.Drawing.Point(431, 42);
            this.lblCreaturePositionY.Name = "lblCreaturePositionY";
            this.lblCreaturePositionY.Size = new System.Drawing.Size(14, 15);
            this.lblCreaturePositionY.TabIndex = 3;
            this.lblCreaturePositionY.Text = "Y";
            // 
            // txtCreatureZoneName
            // 
            this.txtCreatureZoneName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCreatureZoneName.Location = new System.Drawing.Point(146, 39);
            this.txtCreatureZoneName.Name = "txtCreatureZoneName";
            this.txtCreatureZoneName.Size = new System.Drawing.Size(279, 23);
            this.txtCreatureZoneName.TabIndex = 2;
            // 
            // txtCreatureZoneId
            // 
            this.txtCreatureZoneId.Location = new System.Drawing.Point(66, 39);
            this.txtCreatureZoneId.Name = "txtCreatureZoneId";
            this.txtCreatureZoneId.Size = new System.Drawing.Size(74, 23);
            this.txtCreatureZoneId.TabIndex = 1;
            // 
            // lblCreatureZone
            // 
            this.lblCreatureZone.AutoSize = true;
            this.lblCreatureZone.Location = new System.Drawing.Point(10, 42);
            this.lblCreatureZone.Name = "lblCreatureZone";
            this.lblCreatureZone.Size = new System.Drawing.Size(34, 15);
            this.lblCreatureZone.TabIndex = 0;
            this.lblCreatureZone.Text = "Zone";
            // 
            // tpCreatureTemplate
            // 
            this.tpCreatureTemplate.Location = new System.Drawing.Point(4, 24);
            this.tpCreatureTemplate.Name = "tpCreatureTemplate";
            this.tpCreatureTemplate.Padding = new System.Windows.Forms.Padding(3);
            this.tpCreatureTemplate.Size = new System.Drawing.Size(574, 366);
            this.tpCreatureTemplate.TabIndex = 1;
            this.tpCreatureTemplate.Text = "Creature Template";
            this.tpCreatureTemplate.UseVisualStyleBackColor = true;
            // 
            // tpGameObject
            // 
            this.tpGameObject.Location = new System.Drawing.Point(4, 24);
            this.tpGameObject.Name = "tpGameObject";
            this.tpGameObject.Size = new System.Drawing.Size(574, 366);
            this.tpGameObject.TabIndex = 2;
            this.tpGameObject.Text = "GameObject";
            this.tpGameObject.UseVisualStyleBackColor = true;
            // 
            // tpGameObjectTemplate
            // 
            this.tpGameObjectTemplate.Location = new System.Drawing.Point(4, 24);
            this.tpGameObjectTemplate.Name = "tpGameObjectTemplate";
            this.tpGameObjectTemplate.Size = new System.Drawing.Size(574, 366);
            this.tpGameObjectTemplate.TabIndex = 3;
            this.tpGameObjectTemplate.Text = "GameObject Template";
            this.tpGameObjectTemplate.UseVisualStyleBackColor = true;
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
            this.tbOverviewObjectInfo.ResumeLayout(false);
            this.tpCreatureObject.ResumeLayout(false);
            this.tpCreatureObject.PerformLayout();
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
        private System.Windows.Forms.TabControl tbOverviewObjectInfo;
        private System.Windows.Forms.TabPage tpCreatureObject;
        private System.Windows.Forms.TextBox txtCreaturePositionY;
        private System.Windows.Forms.Label lblCreaturePositionY;
        private System.Windows.Forms.TextBox txtCreatureZoneName;
        private System.Windows.Forms.TextBox txtCreatureZoneId;
        private System.Windows.Forms.Label lblCreatureZone;
        private System.Windows.Forms.TabPage tpCreatureTemplate;
        private System.Windows.Forms.TabPage tpGameObject;
        private System.Windows.Forms.TabPage tpGameObjectTemplate;
        private System.Windows.Forms.TextBox txtCreaturePositionX;
        private System.Windows.Forms.Label lblCreaturePositionX;
        private System.Windows.Forms.TextBox txtCreatureMapName;
        private System.Windows.Forms.TextBox txtCreatureMapId;
        private System.Windows.Forms.Label lblCreatureMap;
        private System.Windows.Forms.TextBox txtCreaturePositionZ;
        private System.Windows.Forms.Label lblCreaturePositionZ;
        private System.Windows.Forms.TextBox txtCreatureAreaName;
        private System.Windows.Forms.TextBox txtCreatureAreaId;
        private System.Windows.Forms.Label lblCreatureArea;
        private System.Windows.Forms.TextBox txtCreatureEntry;
        private System.Windows.Forms.TextBox txtCreatureId;
        private System.Windows.Forms.Label lblCreatureIdEntry;
    }
}

