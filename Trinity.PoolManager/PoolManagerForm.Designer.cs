
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
            this.pnlMaster = new System.Windows.Forms.Panel();
            this.tbMain = new System.Windows.Forms.TabControl();
            this.tpOverview = new System.Windows.Forms.TabPage();
            this.pnlOverview = new System.Windows.Forms.Panel();
            this.scOverview = new System.Windows.Forms.SplitContainer();
            this.pnlOverviewTree = new System.Windows.Forms.Panel();
            this.btnLoad = new System.Windows.Forms.Button();
            this.tvOverview = new System.Windows.Forms.TreeView();
            this.pnlOverviewDtl = new System.Windows.Forms.Panel();
            this.tbOverviewObjectInfo = new System.Windows.Forms.TabControl();
            this.tpCreatureObject = new System.Windows.Forms.TabPage();
            this.pnlCreatureOverview = new System.Windows.Forms.Panel();
            this.txtCreatureOrientation = new System.Windows.Forms.TextBox();
            this.lblCreatureOrientation = new System.Windows.Forms.Label();
            this.txtCreatureName = new System.Windows.Forms.TextBox();
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
            this.pnlGameObjectOverview = new System.Windows.Forms.Panel();
            this.txtGameObjectOrientation = new System.Windows.Forms.TextBox();
            this.lblGameObjectOrientation = new System.Windows.Forms.Label();
            this.txtGameObjectName = new System.Windows.Forms.TextBox();
            this.txtGameObjectEntry = new System.Windows.Forms.TextBox();
            this.txtGameObjectId = new System.Windows.Forms.TextBox();
            this.lblGameObjectIdEntry = new System.Windows.Forms.Label();
            this.txtGameObjectPositionZ = new System.Windows.Forms.TextBox();
            this.lblGameObjectPositionZ = new System.Windows.Forms.Label();
            this.txtGameObjectAreaName = new System.Windows.Forms.TextBox();
            this.txtGameObjectAreaId = new System.Windows.Forms.TextBox();
            this.lblGameObjectArea = new System.Windows.Forms.Label();
            this.txtGameObjectPositionX = new System.Windows.Forms.TextBox();
            this.lblGameObjectPositionX = new System.Windows.Forms.Label();
            this.txtGameObjectMapName = new System.Windows.Forms.TextBox();
            this.txtGameObjectMapId = new System.Windows.Forms.TextBox();
            this.lblGameObjectMap = new System.Windows.Forms.Label();
            this.txtGameObjectPositionY = new System.Windows.Forms.TextBox();
            this.lblGameObjectPositionY = new System.Windows.Forms.Label();
            this.txtGameObjectZoneName = new System.Windows.Forms.TextBox();
            this.txtGameObjectZoneId = new System.Windows.Forms.TextBox();
            this.lblGameObjectZone = new System.Windows.Forms.Label();
            this.tpGameObjectTemplate = new System.Windows.Forms.TabPage();
            this.tpPoolConversion = new System.Windows.Forms.TabPage();
            this.pnlLegacyPool = new System.Windows.Forms.Panel();
            this.scPoolConvert = new System.Windows.Forms.SplitContainer();
            this.pnlPoolTreeview = new System.Windows.Forms.Panel();
            this.btnRefreshPools = new System.Windows.Forms.Button();
            this.tvLegacyPools = new System.Windows.Forms.TreeView();
            this.tpPoolDesigner = new System.Windows.Forms.TabPage();
            this.tpWowhead = new System.Windows.Forms.TabPage();
            this.pnlWowheadGather = new System.Windows.Forms.Panel();
            this.scWowheadGather = new System.Windows.Forms.SplitContainer();
            this.pnlWowheadTreeview = new System.Windows.Forms.Panel();
            this.btnWowheadRefresh = new System.Windows.Forms.Button();
            this.tvWowheadGather = new System.Windows.Forms.TreeView();
            this.tpConfig = new System.Windows.Forms.TabPage();
            this.pnlConfigTab = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveConfig = new System.Windows.Forms.Button();
            this.grpFileLocationConfig = new System.Windows.Forms.GroupBox();
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
            this.btnBrowseWowheadFile = new System.Windows.Forms.Button();
            this.txtWowheadLuaFile = new System.Windows.Forms.TextBox();
            this.lblWowheadLuaFile = new System.Windows.Forms.Label();
            this.ssStatus.SuspendLayout();
            this.pnlMaster.SuspendLayout();
            this.tbMain.SuspendLayout();
            this.tpOverview.SuspendLayout();
            this.pnlOverview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scOverview)).BeginInit();
            this.scOverview.Panel1.SuspendLayout();
            this.scOverview.Panel2.SuspendLayout();
            this.scOverview.SuspendLayout();
            this.pnlOverviewTree.SuspendLayout();
            this.pnlOverviewDtl.SuspendLayout();
            this.tbOverviewObjectInfo.SuspendLayout();
            this.tpCreatureObject.SuspendLayout();
            this.pnlCreatureOverview.SuspendLayout();
            this.tpGameObject.SuspendLayout();
            this.pnlGameObjectOverview.SuspendLayout();
            this.tpPoolConversion.SuspendLayout();
            this.pnlLegacyPool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scPoolConvert)).BeginInit();
            this.scPoolConvert.Panel1.SuspendLayout();
            this.scPoolConvert.SuspendLayout();
            this.pnlPoolTreeview.SuspendLayout();
            this.tpWowhead.SuspendLayout();
            this.pnlWowheadGather.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scWowheadGather)).BeginInit();
            this.scWowheadGather.Panel1.SuspendLayout();
            this.scWowheadGather.SuspendLayout();
            this.pnlWowheadTreeview.SuspendLayout();
            this.tpConfig.SuspendLayout();
            this.pnlConfigTab.SuspendLayout();
            this.grpFileLocationConfig.SuspendLayout();
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
            // pnlMaster
            // 
            this.pnlMaster.Controls.Add(this.tbMain);
            this.pnlMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMaster.Location = new System.Drawing.Point(0, 0);
            this.pnlMaster.Name = "pnlMaster";
            this.pnlMaster.Size = new System.Drawing.Size(800, 428);
            this.pnlMaster.TabIndex = 4;
            // 
            // tbMain
            // 
            this.tbMain.Controls.Add(this.tpOverview);
            this.tbMain.Controls.Add(this.tpPoolConversion);
            this.tbMain.Controls.Add(this.tpPoolDesigner);
            this.tbMain.Controls.Add(this.tpWowhead);
            this.tbMain.Controls.Add(this.tpConfig);
            this.tbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMain.Location = new System.Drawing.Point(0, 0);
            this.tbMain.Name = "tbMain";
            this.tbMain.SelectedIndex = 0;
            this.tbMain.Size = new System.Drawing.Size(800, 428);
            this.tbMain.TabIndex = 5;
            // 
            // tpOverview
            // 
            this.tpOverview.Controls.Add(this.pnlOverview);
            this.tpOverview.Location = new System.Drawing.Point(4, 24);
            this.tpOverview.Name = "tpOverview";
            this.tpOverview.Padding = new System.Windows.Forms.Padding(3);
            this.tpOverview.Size = new System.Drawing.Size(792, 400);
            this.tpOverview.TabIndex = 0;
            this.tpOverview.Text = "Overview";
            this.tpOverview.UseVisualStyleBackColor = true;
            // 
            // pnlOverview
            // 
            this.pnlOverview.Controls.Add(this.scOverview);
            this.pnlOverview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOverview.Location = new System.Drawing.Point(3, 3);
            this.pnlOverview.Name = "pnlOverview";
            this.pnlOverview.Size = new System.Drawing.Size(786, 394);
            this.pnlOverview.TabIndex = 0;
            // 
            // scOverview
            // 
            this.scOverview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scOverview.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scOverview.Location = new System.Drawing.Point(0, 0);
            this.scOverview.Name = "scOverview";
            // 
            // scOverview.Panel1
            // 
            this.scOverview.Panel1.Controls.Add(this.pnlOverviewTree);
            this.scOverview.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // scOverview.Panel2
            // 
            this.scOverview.Panel2.Controls.Add(this.pnlOverviewDtl);
            this.scOverview.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.scOverview.Size = new System.Drawing.Size(786, 394);
            this.scOverview.SplitterDistance = 200;
            this.scOverview.SplitterWidth = 2;
            this.scOverview.TabIndex = 11;
            // 
            // pnlOverviewTree
            // 
            this.pnlOverviewTree.Controls.Add(this.btnLoad);
            this.pnlOverviewTree.Controls.Add(this.tvOverview);
            this.pnlOverviewTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOverviewTree.Location = new System.Drawing.Point(0, 0);
            this.pnlOverviewTree.Name = "pnlOverviewTree";
            this.pnlOverviewTree.Size = new System.Drawing.Size(200, 394);
            this.pnlOverviewTree.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.Location = new System.Drawing.Point(5, 363);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(191, 28);
            this.btnLoad.TabIndex = 13;
            this.btnLoad.Text = "Load Data";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // tvOverview
            // 
            this.tvOverview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvOverview.Location = new System.Drawing.Point(6, 3);
            this.tvOverview.Name = "tvOverview";
            this.tvOverview.Size = new System.Drawing.Size(191, 354);
            this.tvOverview.TabIndex = 12;
            this.tvOverview.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvOverview_AfterSelect);
            // 
            // pnlOverviewDtl
            // 
            this.pnlOverviewDtl.Controls.Add(this.tbOverviewObjectInfo);
            this.pnlOverviewDtl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOverviewDtl.Location = new System.Drawing.Point(0, 0);
            this.pnlOverviewDtl.Name = "pnlOverviewDtl";
            this.pnlOverviewDtl.Size = new System.Drawing.Size(584, 394);
            this.pnlOverviewDtl.TabIndex = 0;
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
            this.tbOverviewObjectInfo.Size = new System.Drawing.Size(584, 394);
            this.tbOverviewObjectInfo.TabIndex = 1;
            // 
            // tpCreatureObject
            // 
            this.tpCreatureObject.Controls.Add(this.pnlCreatureOverview);
            this.tpCreatureObject.Location = new System.Drawing.Point(4, 24);
            this.tpCreatureObject.Name = "tpCreatureObject";
            this.tpCreatureObject.Size = new System.Drawing.Size(576, 366);
            this.tpCreatureObject.TabIndex = 0;
            this.tpCreatureObject.Text = "Creature";
            this.tpCreatureObject.UseVisualStyleBackColor = true;
            // 
            // pnlCreatureOverview
            // 
            this.pnlCreatureOverview.Controls.Add(this.txtCreatureOrientation);
            this.pnlCreatureOverview.Controls.Add(this.lblCreatureOrientation);
            this.pnlCreatureOverview.Controls.Add(this.txtCreatureName);
            this.pnlCreatureOverview.Controls.Add(this.txtCreatureEntry);
            this.pnlCreatureOverview.Controls.Add(this.txtCreatureId);
            this.pnlCreatureOverview.Controls.Add(this.lblCreatureIdEntry);
            this.pnlCreatureOverview.Controls.Add(this.txtCreaturePositionZ);
            this.pnlCreatureOverview.Controls.Add(this.lblCreaturePositionZ);
            this.pnlCreatureOverview.Controls.Add(this.txtCreatureAreaName);
            this.pnlCreatureOverview.Controls.Add(this.txtCreatureAreaId);
            this.pnlCreatureOverview.Controls.Add(this.lblCreatureArea);
            this.pnlCreatureOverview.Controls.Add(this.txtCreaturePositionX);
            this.pnlCreatureOverview.Controls.Add(this.lblCreaturePositionX);
            this.pnlCreatureOverview.Controls.Add(this.txtCreatureMapName);
            this.pnlCreatureOverview.Controls.Add(this.txtCreatureMapId);
            this.pnlCreatureOverview.Controls.Add(this.lblCreatureMap);
            this.pnlCreatureOverview.Controls.Add(this.txtCreaturePositionY);
            this.pnlCreatureOverview.Controls.Add(this.lblCreaturePositionY);
            this.pnlCreatureOverview.Controls.Add(this.txtCreatureZoneName);
            this.pnlCreatureOverview.Controls.Add(this.txtCreatureZoneId);
            this.pnlCreatureOverview.Controls.Add(this.lblCreatureZone);
            this.pnlCreatureOverview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCreatureOverview.Location = new System.Drawing.Point(0, 0);
            this.pnlCreatureOverview.Name = "pnlCreatureOverview";
            this.pnlCreatureOverview.Size = new System.Drawing.Size(576, 366);
            this.pnlCreatureOverview.TabIndex = 0;
            // 
            // txtCreatureOrientation
            // 
            this.txtCreatureOrientation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCreatureOrientation.Location = new System.Drawing.Point(486, 93);
            this.txtCreatureOrientation.Name = "txtCreatureOrientation";
            this.txtCreatureOrientation.Size = new System.Drawing.Size(87, 23);
            this.txtCreatureOrientation.TabIndex = 38;
            // 
            // lblCreatureOrientation
            // 
            this.lblCreatureOrientation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCreatureOrientation.AutoSize = true;
            this.lblCreatureOrientation.Location = new System.Drawing.Point(464, 96);
            this.lblCreatureOrientation.Name = "lblCreatureOrientation";
            this.lblCreatureOrientation.Size = new System.Drawing.Size(16, 15);
            this.lblCreatureOrientation.TabIndex = 37;
            this.lblCreatureOrientation.Text = "O";
            // 
            // txtCreatureName
            // 
            this.txtCreatureName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCreatureName.Location = new System.Drawing.Point(228, 93);
            this.txtCreatureName.Name = "txtCreatureName";
            this.txtCreatureName.Size = new System.Drawing.Size(230, 23);
            this.txtCreatureName.TabIndex = 36;
            // 
            // txtCreatureEntry
            // 
            this.txtCreatureEntry.Location = new System.Drawing.Point(148, 93);
            this.txtCreatureEntry.Name = "txtCreatureEntry";
            this.txtCreatureEntry.Size = new System.Drawing.Size(74, 23);
            this.txtCreatureEntry.TabIndex = 35;
            // 
            // txtCreatureId
            // 
            this.txtCreatureId.Location = new System.Drawing.Point(68, 93);
            this.txtCreatureId.Name = "txtCreatureId";
            this.txtCreatureId.Size = new System.Drawing.Size(74, 23);
            this.txtCreatureId.TabIndex = 34;
            // 
            // lblCreatureIdEntry
            // 
            this.lblCreatureIdEntry.AutoSize = true;
            this.lblCreatureIdEntry.Location = new System.Drawing.Point(12, 96);
            this.lblCreatureIdEntry.Name = "lblCreatureIdEntry";
            this.lblCreatureIdEntry.Size = new System.Drawing.Size(50, 15);
            this.lblCreatureIdEntry.TabIndex = 33;
            this.lblCreatureIdEntry.Text = "ID/Entry";
            // 
            // txtCreaturePositionZ
            // 
            this.txtCreaturePositionZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCreaturePositionZ.Location = new System.Drawing.Point(486, 64);
            this.txtCreaturePositionZ.Name = "txtCreaturePositionZ";
            this.txtCreaturePositionZ.Size = new System.Drawing.Size(87, 23);
            this.txtCreaturePositionZ.TabIndex = 32;
            // 
            // lblCreaturePositionZ
            // 
            this.lblCreaturePositionZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCreaturePositionZ.AutoSize = true;
            this.lblCreaturePositionZ.Location = new System.Drawing.Point(464, 67);
            this.lblCreaturePositionZ.Name = "lblCreaturePositionZ";
            this.lblCreaturePositionZ.Size = new System.Drawing.Size(14, 15);
            this.lblCreaturePositionZ.TabIndex = 31;
            this.lblCreaturePositionZ.Text = "Z";
            // 
            // txtCreatureAreaName
            // 
            this.txtCreatureAreaName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCreatureAreaName.Location = new System.Drawing.Point(148, 64);
            this.txtCreatureAreaName.Name = "txtCreatureAreaName";
            this.txtCreatureAreaName.Size = new System.Drawing.Size(310, 23);
            this.txtCreatureAreaName.TabIndex = 30;
            // 
            // txtCreatureAreaId
            // 
            this.txtCreatureAreaId.Location = new System.Drawing.Point(68, 64);
            this.txtCreatureAreaId.Name = "txtCreatureAreaId";
            this.txtCreatureAreaId.Size = new System.Drawing.Size(74, 23);
            this.txtCreatureAreaId.TabIndex = 29;
            // 
            // lblCreatureArea
            // 
            this.lblCreatureArea.AutoSize = true;
            this.lblCreatureArea.Location = new System.Drawing.Point(12, 67);
            this.lblCreatureArea.Name = "lblCreatureArea";
            this.lblCreatureArea.Size = new System.Drawing.Size(31, 15);
            this.lblCreatureArea.TabIndex = 28;
            this.lblCreatureArea.Text = "Area";
            // 
            // txtCreaturePositionX
            // 
            this.txtCreaturePositionX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCreaturePositionX.Location = new System.Drawing.Point(486, 6);
            this.txtCreaturePositionX.Name = "txtCreaturePositionX";
            this.txtCreaturePositionX.Size = new System.Drawing.Size(87, 23);
            this.txtCreaturePositionX.TabIndex = 27;
            // 
            // lblCreaturePositionX
            // 
            this.lblCreaturePositionX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCreaturePositionX.AutoSize = true;
            this.lblCreaturePositionX.Location = new System.Drawing.Point(464, 9);
            this.lblCreaturePositionX.Name = "lblCreaturePositionX";
            this.lblCreaturePositionX.Size = new System.Drawing.Size(14, 15);
            this.lblCreaturePositionX.TabIndex = 26;
            this.lblCreaturePositionX.Text = "X";
            // 
            // txtCreatureMapName
            // 
            this.txtCreatureMapName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCreatureMapName.Location = new System.Drawing.Point(148, 6);
            this.txtCreatureMapName.Name = "txtCreatureMapName";
            this.txtCreatureMapName.Size = new System.Drawing.Size(310, 23);
            this.txtCreatureMapName.TabIndex = 25;
            // 
            // txtCreatureMapId
            // 
            this.txtCreatureMapId.Location = new System.Drawing.Point(68, 6);
            this.txtCreatureMapId.Name = "txtCreatureMapId";
            this.txtCreatureMapId.Size = new System.Drawing.Size(74, 23);
            this.txtCreatureMapId.TabIndex = 24;
            // 
            // lblCreatureMap
            // 
            this.lblCreatureMap.AutoSize = true;
            this.lblCreatureMap.Location = new System.Drawing.Point(12, 9);
            this.lblCreatureMap.Name = "lblCreatureMap";
            this.lblCreatureMap.Size = new System.Drawing.Size(31, 15);
            this.lblCreatureMap.TabIndex = 23;
            this.lblCreatureMap.Text = "Map";
            // 
            // txtCreaturePositionY
            // 
            this.txtCreaturePositionY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCreaturePositionY.Location = new System.Drawing.Point(486, 35);
            this.txtCreaturePositionY.Name = "txtCreaturePositionY";
            this.txtCreaturePositionY.Size = new System.Drawing.Size(87, 23);
            this.txtCreaturePositionY.TabIndex = 22;
            // 
            // lblCreaturePositionY
            // 
            this.lblCreaturePositionY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCreaturePositionY.AutoSize = true;
            this.lblCreaturePositionY.Location = new System.Drawing.Point(464, 38);
            this.lblCreaturePositionY.Name = "lblCreaturePositionY";
            this.lblCreaturePositionY.Size = new System.Drawing.Size(14, 15);
            this.lblCreaturePositionY.TabIndex = 21;
            this.lblCreaturePositionY.Text = "Y";
            // 
            // txtCreatureZoneName
            // 
            this.txtCreatureZoneName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCreatureZoneName.Location = new System.Drawing.Point(148, 35);
            this.txtCreatureZoneName.Name = "txtCreatureZoneName";
            this.txtCreatureZoneName.Size = new System.Drawing.Size(310, 23);
            this.txtCreatureZoneName.TabIndex = 20;
            // 
            // txtCreatureZoneId
            // 
            this.txtCreatureZoneId.Location = new System.Drawing.Point(68, 35);
            this.txtCreatureZoneId.Name = "txtCreatureZoneId";
            this.txtCreatureZoneId.Size = new System.Drawing.Size(74, 23);
            this.txtCreatureZoneId.TabIndex = 19;
            // 
            // lblCreatureZone
            // 
            this.lblCreatureZone.AutoSize = true;
            this.lblCreatureZone.Location = new System.Drawing.Point(12, 38);
            this.lblCreatureZone.Name = "lblCreatureZone";
            this.lblCreatureZone.Size = new System.Drawing.Size(34, 15);
            this.lblCreatureZone.TabIndex = 18;
            this.lblCreatureZone.Text = "Zone";
            // 
            // tpCreatureTemplate
            // 
            this.tpCreatureTemplate.Location = new System.Drawing.Point(4, 24);
            this.tpCreatureTemplate.Name = "tpCreatureTemplate";
            this.tpCreatureTemplate.Padding = new System.Windows.Forms.Padding(3);
            this.tpCreatureTemplate.Size = new System.Drawing.Size(576, 366);
            this.tpCreatureTemplate.TabIndex = 1;
            this.tpCreatureTemplate.Text = "Creature Template";
            this.tpCreatureTemplate.UseVisualStyleBackColor = true;
            // 
            // tpGameObject
            // 
            this.tpGameObject.Controls.Add(this.pnlGameObjectOverview);
            this.tpGameObject.Location = new System.Drawing.Point(4, 24);
            this.tpGameObject.Name = "tpGameObject";
            this.tpGameObject.Size = new System.Drawing.Size(576, 366);
            this.tpGameObject.TabIndex = 2;
            this.tpGameObject.Text = "GameObject";
            this.tpGameObject.UseVisualStyleBackColor = true;
            // 
            // pnlGameObjectOverview
            // 
            this.pnlGameObjectOverview.Controls.Add(this.txtGameObjectOrientation);
            this.pnlGameObjectOverview.Controls.Add(this.lblGameObjectOrientation);
            this.pnlGameObjectOverview.Controls.Add(this.txtGameObjectName);
            this.pnlGameObjectOverview.Controls.Add(this.txtGameObjectEntry);
            this.pnlGameObjectOverview.Controls.Add(this.txtGameObjectId);
            this.pnlGameObjectOverview.Controls.Add(this.lblGameObjectIdEntry);
            this.pnlGameObjectOverview.Controls.Add(this.txtGameObjectPositionZ);
            this.pnlGameObjectOverview.Controls.Add(this.lblGameObjectPositionZ);
            this.pnlGameObjectOverview.Controls.Add(this.txtGameObjectAreaName);
            this.pnlGameObjectOverview.Controls.Add(this.txtGameObjectAreaId);
            this.pnlGameObjectOverview.Controls.Add(this.lblGameObjectArea);
            this.pnlGameObjectOverview.Controls.Add(this.txtGameObjectPositionX);
            this.pnlGameObjectOverview.Controls.Add(this.lblGameObjectPositionX);
            this.pnlGameObjectOverview.Controls.Add(this.txtGameObjectMapName);
            this.pnlGameObjectOverview.Controls.Add(this.txtGameObjectMapId);
            this.pnlGameObjectOverview.Controls.Add(this.lblGameObjectMap);
            this.pnlGameObjectOverview.Controls.Add(this.txtGameObjectPositionY);
            this.pnlGameObjectOverview.Controls.Add(this.lblGameObjectPositionY);
            this.pnlGameObjectOverview.Controls.Add(this.txtGameObjectZoneName);
            this.pnlGameObjectOverview.Controls.Add(this.txtGameObjectZoneId);
            this.pnlGameObjectOverview.Controls.Add(this.lblGameObjectZone);
            this.pnlGameObjectOverview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGameObjectOverview.Location = new System.Drawing.Point(0, 0);
            this.pnlGameObjectOverview.Name = "pnlGameObjectOverview";
            this.pnlGameObjectOverview.Size = new System.Drawing.Size(576, 366);
            this.pnlGameObjectOverview.TabIndex = 0;
            // 
            // txtGameObjectOrientation
            // 
            this.txtGameObjectOrientation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGameObjectOrientation.Location = new System.Drawing.Point(486, 93);
            this.txtGameObjectOrientation.Name = "txtGameObjectOrientation";
            this.txtGameObjectOrientation.Size = new System.Drawing.Size(87, 23);
            this.txtGameObjectOrientation.TabIndex = 38;
            // 
            // lblGameObjectOrientation
            // 
            this.lblGameObjectOrientation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGameObjectOrientation.AutoSize = true;
            this.lblGameObjectOrientation.Location = new System.Drawing.Point(464, 96);
            this.lblGameObjectOrientation.Name = "lblGameObjectOrientation";
            this.lblGameObjectOrientation.Size = new System.Drawing.Size(16, 15);
            this.lblGameObjectOrientation.TabIndex = 37;
            this.lblGameObjectOrientation.Text = "O";
            // 
            // txtGameObjectName
            // 
            this.txtGameObjectName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGameObjectName.Location = new System.Drawing.Point(228, 93);
            this.txtGameObjectName.Name = "txtGameObjectName";
            this.txtGameObjectName.Size = new System.Drawing.Size(230, 23);
            this.txtGameObjectName.TabIndex = 36;
            // 
            // txtGameObjectEntry
            // 
            this.txtGameObjectEntry.Location = new System.Drawing.Point(148, 93);
            this.txtGameObjectEntry.Name = "txtGameObjectEntry";
            this.txtGameObjectEntry.Size = new System.Drawing.Size(74, 23);
            this.txtGameObjectEntry.TabIndex = 35;
            // 
            // txtGameObjectId
            // 
            this.txtGameObjectId.Location = new System.Drawing.Point(68, 93);
            this.txtGameObjectId.Name = "txtGameObjectId";
            this.txtGameObjectId.Size = new System.Drawing.Size(74, 23);
            this.txtGameObjectId.TabIndex = 34;
            // 
            // lblGameObjectIdEntry
            // 
            this.lblGameObjectIdEntry.AutoSize = true;
            this.lblGameObjectIdEntry.Location = new System.Drawing.Point(12, 96);
            this.lblGameObjectIdEntry.Name = "lblGameObjectIdEntry";
            this.lblGameObjectIdEntry.Size = new System.Drawing.Size(50, 15);
            this.lblGameObjectIdEntry.TabIndex = 33;
            this.lblGameObjectIdEntry.Text = "ID/Entry";
            // 
            // txtGameObjectPositionZ
            // 
            this.txtGameObjectPositionZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGameObjectPositionZ.Location = new System.Drawing.Point(486, 64);
            this.txtGameObjectPositionZ.Name = "txtGameObjectPositionZ";
            this.txtGameObjectPositionZ.Size = new System.Drawing.Size(87, 23);
            this.txtGameObjectPositionZ.TabIndex = 32;
            // 
            // lblGameObjectPositionZ
            // 
            this.lblGameObjectPositionZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGameObjectPositionZ.AutoSize = true;
            this.lblGameObjectPositionZ.Location = new System.Drawing.Point(464, 67);
            this.lblGameObjectPositionZ.Name = "lblGameObjectPositionZ";
            this.lblGameObjectPositionZ.Size = new System.Drawing.Size(14, 15);
            this.lblGameObjectPositionZ.TabIndex = 31;
            this.lblGameObjectPositionZ.Text = "Z";
            // 
            // txtGameObjectAreaName
            // 
            this.txtGameObjectAreaName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGameObjectAreaName.Location = new System.Drawing.Point(148, 64);
            this.txtGameObjectAreaName.Name = "txtGameObjectAreaName";
            this.txtGameObjectAreaName.Size = new System.Drawing.Size(310, 23);
            this.txtGameObjectAreaName.TabIndex = 30;
            // 
            // txtGameObjectAreaId
            // 
            this.txtGameObjectAreaId.Location = new System.Drawing.Point(68, 64);
            this.txtGameObjectAreaId.Name = "txtGameObjectAreaId";
            this.txtGameObjectAreaId.Size = new System.Drawing.Size(74, 23);
            this.txtGameObjectAreaId.TabIndex = 29;
            // 
            // lblGameObjectArea
            // 
            this.lblGameObjectArea.AutoSize = true;
            this.lblGameObjectArea.Location = new System.Drawing.Point(12, 67);
            this.lblGameObjectArea.Name = "lblGameObjectArea";
            this.lblGameObjectArea.Size = new System.Drawing.Size(31, 15);
            this.lblGameObjectArea.TabIndex = 28;
            this.lblGameObjectArea.Text = "Area";
            // 
            // txtGameObjectPositionX
            // 
            this.txtGameObjectPositionX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGameObjectPositionX.Location = new System.Drawing.Point(486, 6);
            this.txtGameObjectPositionX.Name = "txtGameObjectPositionX";
            this.txtGameObjectPositionX.Size = new System.Drawing.Size(87, 23);
            this.txtGameObjectPositionX.TabIndex = 27;
            // 
            // lblGameObjectPositionX
            // 
            this.lblGameObjectPositionX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGameObjectPositionX.AutoSize = true;
            this.lblGameObjectPositionX.Location = new System.Drawing.Point(464, 9);
            this.lblGameObjectPositionX.Name = "lblGameObjectPositionX";
            this.lblGameObjectPositionX.Size = new System.Drawing.Size(14, 15);
            this.lblGameObjectPositionX.TabIndex = 26;
            this.lblGameObjectPositionX.Text = "X";
            // 
            // txtGameObjectMapName
            // 
            this.txtGameObjectMapName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGameObjectMapName.Location = new System.Drawing.Point(148, 6);
            this.txtGameObjectMapName.Name = "txtGameObjectMapName";
            this.txtGameObjectMapName.Size = new System.Drawing.Size(310, 23);
            this.txtGameObjectMapName.TabIndex = 25;
            // 
            // txtGameObjectMapId
            // 
            this.txtGameObjectMapId.Location = new System.Drawing.Point(68, 6);
            this.txtGameObjectMapId.Name = "txtGameObjectMapId";
            this.txtGameObjectMapId.Size = new System.Drawing.Size(74, 23);
            this.txtGameObjectMapId.TabIndex = 24;
            // 
            // lblGameObjectMap
            // 
            this.lblGameObjectMap.AutoSize = true;
            this.lblGameObjectMap.Location = new System.Drawing.Point(12, 9);
            this.lblGameObjectMap.Name = "lblGameObjectMap";
            this.lblGameObjectMap.Size = new System.Drawing.Size(31, 15);
            this.lblGameObjectMap.TabIndex = 23;
            this.lblGameObjectMap.Text = "Map";
            // 
            // txtGameObjectPositionY
            // 
            this.txtGameObjectPositionY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGameObjectPositionY.Location = new System.Drawing.Point(486, 35);
            this.txtGameObjectPositionY.Name = "txtGameObjectPositionY";
            this.txtGameObjectPositionY.Size = new System.Drawing.Size(87, 23);
            this.txtGameObjectPositionY.TabIndex = 22;
            // 
            // lblGameObjectPositionY
            // 
            this.lblGameObjectPositionY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGameObjectPositionY.AutoSize = true;
            this.lblGameObjectPositionY.Location = new System.Drawing.Point(464, 38);
            this.lblGameObjectPositionY.Name = "lblGameObjectPositionY";
            this.lblGameObjectPositionY.Size = new System.Drawing.Size(14, 15);
            this.lblGameObjectPositionY.TabIndex = 21;
            this.lblGameObjectPositionY.Text = "Y";
            // 
            // txtGameObjectZoneName
            // 
            this.txtGameObjectZoneName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGameObjectZoneName.Location = new System.Drawing.Point(148, 35);
            this.txtGameObjectZoneName.Name = "txtGameObjectZoneName";
            this.txtGameObjectZoneName.Size = new System.Drawing.Size(310, 23);
            this.txtGameObjectZoneName.TabIndex = 20;
            // 
            // txtGameObjectZoneId
            // 
            this.txtGameObjectZoneId.Location = new System.Drawing.Point(68, 35);
            this.txtGameObjectZoneId.Name = "txtGameObjectZoneId";
            this.txtGameObjectZoneId.Size = new System.Drawing.Size(74, 23);
            this.txtGameObjectZoneId.TabIndex = 19;
            // 
            // lblGameObjectZone
            // 
            this.lblGameObjectZone.AutoSize = true;
            this.lblGameObjectZone.Location = new System.Drawing.Point(12, 38);
            this.lblGameObjectZone.Name = "lblGameObjectZone";
            this.lblGameObjectZone.Size = new System.Drawing.Size(34, 15);
            this.lblGameObjectZone.TabIndex = 18;
            this.lblGameObjectZone.Text = "Zone";
            // 
            // tpGameObjectTemplate
            // 
            this.tpGameObjectTemplate.Location = new System.Drawing.Point(4, 24);
            this.tpGameObjectTemplate.Name = "tpGameObjectTemplate";
            this.tpGameObjectTemplate.Size = new System.Drawing.Size(576, 366);
            this.tpGameObjectTemplate.TabIndex = 3;
            this.tpGameObjectTemplate.Text = "GameObject Template";
            this.tpGameObjectTemplate.UseVisualStyleBackColor = true;
            // 
            // tpPoolConversion
            // 
            this.tpPoolConversion.Controls.Add(this.pnlLegacyPool);
            this.tpPoolConversion.Location = new System.Drawing.Point(4, 24);
            this.tpPoolConversion.Name = "tpPoolConversion";
            this.tpPoolConversion.Padding = new System.Windows.Forms.Padding(3);
            this.tpPoolConversion.Size = new System.Drawing.Size(792, 400);
            this.tpPoolConversion.TabIndex = 1;
            this.tpPoolConversion.Text = "Legacy Pool Conversion";
            this.tpPoolConversion.UseVisualStyleBackColor = true;
            // 
            // pnlLegacyPool
            // 
            this.pnlLegacyPool.Controls.Add(this.scPoolConvert);
            this.pnlLegacyPool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLegacyPool.Location = new System.Drawing.Point(3, 3);
            this.pnlLegacyPool.Name = "pnlLegacyPool";
            this.pnlLegacyPool.Size = new System.Drawing.Size(786, 394);
            this.pnlLegacyPool.TabIndex = 0;
            // 
            // scPoolConvert
            // 
            this.scPoolConvert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scPoolConvert.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scPoolConvert.Location = new System.Drawing.Point(0, 0);
            this.scPoolConvert.Name = "scPoolConvert";
            // 
            // scPoolConvert.Panel1
            // 
            this.scPoolConvert.Panel1.Controls.Add(this.pnlPoolTreeview);
            this.scPoolConvert.Size = new System.Drawing.Size(786, 394);
            this.scPoolConvert.SplitterDistance = 200;
            this.scPoolConvert.TabIndex = 1;
            // 
            // pnlPoolTreeview
            // 
            this.pnlPoolTreeview.Controls.Add(this.btnRefreshPools);
            this.pnlPoolTreeview.Controls.Add(this.tvLegacyPools);
            this.pnlPoolTreeview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPoolTreeview.Location = new System.Drawing.Point(0, 0);
            this.pnlPoolTreeview.Name = "pnlPoolTreeview";
            this.pnlPoolTreeview.Size = new System.Drawing.Size(200, 394);
            this.pnlPoolTreeview.TabIndex = 0;
            // 
            // btnRefreshPools
            // 
            this.btnRefreshPools.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshPools.Location = new System.Drawing.Point(5, 363);
            this.btnRefreshPools.Name = "btnRefreshPools";
            this.btnRefreshPools.Size = new System.Drawing.Size(192, 28);
            this.btnRefreshPools.TabIndex = 15;
            this.btnRefreshPools.Text = "Refresh Pools";
            this.btnRefreshPools.UseVisualStyleBackColor = true;
            this.btnRefreshPools.Click += new System.EventHandler(this.btnRefreshPools_Click);
            // 
            // tvLegacyPools
            // 
            this.tvLegacyPools.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvLegacyPools.Location = new System.Drawing.Point(5, 3);
            this.tvLegacyPools.Name = "tvLegacyPools";
            this.tvLegacyPools.Size = new System.Drawing.Size(192, 354);
            this.tvLegacyPools.TabIndex = 14;
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
            // tpWowhead
            // 
            this.tpWowhead.Controls.Add(this.pnlWowheadGather);
            this.tpWowhead.Location = new System.Drawing.Point(4, 24);
            this.tpWowhead.Name = "tpWowhead";
            this.tpWowhead.Size = new System.Drawing.Size(792, 400);
            this.tpWowhead.TabIndex = 4;
            this.tpWowhead.Text = "Wowhead Gatherer";
            this.tpWowhead.UseVisualStyleBackColor = true;
            // 
            // pnlWowheadGather
            // 
            this.pnlWowheadGather.Controls.Add(this.scWowheadGather);
            this.pnlWowheadGather.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWowheadGather.Location = new System.Drawing.Point(0, 0);
            this.pnlWowheadGather.Name = "pnlWowheadGather";
            this.pnlWowheadGather.Size = new System.Drawing.Size(792, 400);
            this.pnlWowheadGather.TabIndex = 0;
            // 
            // scWowheadGather
            // 
            this.scWowheadGather.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scWowheadGather.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scWowheadGather.Location = new System.Drawing.Point(0, 0);
            this.scWowheadGather.Name = "scWowheadGather";
            // 
            // scWowheadGather.Panel1
            // 
            this.scWowheadGather.Panel1.Controls.Add(this.pnlWowheadTreeview);
            this.scWowheadGather.Size = new System.Drawing.Size(792, 400);
            this.scWowheadGather.SplitterDistance = 200;
            this.scWowheadGather.TabIndex = 0;
            // 
            // pnlWowheadTreeview
            // 
            this.pnlWowheadTreeview.Controls.Add(this.btnWowheadRefresh);
            this.pnlWowheadTreeview.Controls.Add(this.tvWowheadGather);
            this.pnlWowheadTreeview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWowheadTreeview.Location = new System.Drawing.Point(0, 0);
            this.pnlWowheadTreeview.Name = "pnlWowheadTreeview";
            this.pnlWowheadTreeview.Size = new System.Drawing.Size(200, 400);
            this.pnlWowheadTreeview.TabIndex = 0;
            // 
            // btnWowheadRefresh
            // 
            this.btnWowheadRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWowheadRefresh.Location = new System.Drawing.Point(4, 366);
            this.btnWowheadRefresh.Name = "btnWowheadRefresh";
            this.btnWowheadRefresh.Size = new System.Drawing.Size(191, 28);
            this.btnWowheadRefresh.TabIndex = 15;
            this.btnWowheadRefresh.Text = "Refresh";
            this.btnWowheadRefresh.UseVisualStyleBackColor = true;
            this.btnWowheadRefresh.Click += new System.EventHandler(this.btnWowheadRefresh_Click);
            // 
            // tvWowheadGather
            // 
            this.tvWowheadGather.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvWowheadGather.Location = new System.Drawing.Point(5, 6);
            this.tvWowheadGather.Name = "tvWowheadGather";
            this.tvWowheadGather.Size = new System.Drawing.Size(191, 354);
            this.tvWowheadGather.TabIndex = 14;
            // 
            // tpConfig
            // 
            this.tpConfig.Controls.Add(this.pnlConfigTab);
            this.tpConfig.Location = new System.Drawing.Point(4, 24);
            this.tpConfig.Name = "tpConfig";
            this.tpConfig.Size = new System.Drawing.Size(792, 400);
            this.tpConfig.TabIndex = 3;
            this.tpConfig.Text = "Config";
            this.tpConfig.UseVisualStyleBackColor = true;
            // 
            // pnlConfigTab
            // 
            this.pnlConfigTab.Controls.Add(this.btnCancel);
            this.pnlConfigTab.Controls.Add(this.btnSaveConfig);
            this.pnlConfigTab.Controls.Add(this.grpFileLocationConfig);
            this.pnlConfigTab.Controls.Add(this.grpSqlConfig);
            this.pnlConfigTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConfigTab.Location = new System.Drawing.Point(0, 0);
            this.pnlConfigTab.Name = "pnlConfigTab";
            this.pnlConfigTab.Size = new System.Drawing.Size(792, 400);
            this.pnlConfigTab.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(600, 374);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveConfig.Location = new System.Drawing.Point(695, 374);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(89, 23);
            this.btnSaveConfig.TabIndex = 6;
            this.btnSaveConfig.Text = "Save";
            this.btnSaveConfig.UseVisualStyleBackColor = true;
            this.btnSaveConfig.Click += new System.EventHandler(this.btnSaveConfig_Click);
            // 
            // grpFileLocationConfig
            // 
            this.grpFileLocationConfig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFileLocationConfig.Controls.Add(this.btnBrowseWowheadFile);
            this.grpFileLocationConfig.Controls.Add(this.txtWowheadLuaFile);
            this.grpFileLocationConfig.Controls.Add(this.lblWowheadLuaFile);
            this.grpFileLocationConfig.Controls.Add(this.btnDBCBrowse);
            this.grpFileLocationConfig.Controls.Add(this.txtTrinityDBCFolder);
            this.grpFileLocationConfig.Controls.Add(this.lblTrinityDBCFolder);
            this.grpFileLocationConfig.Location = new System.Drawing.Point(8, 146);
            this.grpFileLocationConfig.Name = "grpFileLocationConfig";
            this.grpFileLocationConfig.Size = new System.Drawing.Size(776, 81);
            this.grpFileLocationConfig.TabIndex = 5;
            this.grpFileLocationConfig.TabStop = false;
            this.grpFileLocationConfig.Text = "File Location";
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
            this.grpSqlConfig.TabIndex = 4;
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
            // btnBrowseWowheadFile
            // 
            this.btnBrowseWowheadFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseWowheadFile.Location = new System.Drawing.Point(652, 45);
            this.btnBrowseWowheadFile.Name = "btnBrowseWowheadFile";
            this.btnBrowseWowheadFile.Size = new System.Drawing.Size(118, 23);
            this.btnBrowseWowheadFile.TabIndex = 6;
            this.btnBrowseWowheadFile.Text = "Browse";
            this.btnBrowseWowheadFile.UseVisualStyleBackColor = true;
            this.btnBrowseWowheadFile.Click += new System.EventHandler(this.btnBrowseWowheadFile_Click);
            // 
            // txtWowheadLuaFile
            // 
            this.txtWowheadLuaFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWowheadLuaFile.Location = new System.Drawing.Point(130, 45);
            this.txtWowheadLuaFile.Name = "txtWowheadLuaFile";
            this.txtWowheadLuaFile.Size = new System.Drawing.Size(516, 23);
            this.txtWowheadLuaFile.TabIndex = 5;
            // 
            // lblWowheadLuaFile
            // 
            this.lblWowheadLuaFile.Location = new System.Drawing.Point(6, 48);
            this.lblWowheadLuaFile.Name = "lblWowheadLuaFile";
            this.lblWowheadLuaFile.Size = new System.Drawing.Size(118, 23);
            this.lblWowheadLuaFile.TabIndex = 4;
            this.lblWowheadLuaFile.Text = "Wowhead LUA File";
            // 
            // PoolManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlMaster);
            this.Controls.Add(this.ssStatus);
            this.Name = "PoolManagerForm";
            this.Text = "Trinity Pool Manager";
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            this.pnlMaster.ResumeLayout(false);
            this.tbMain.ResumeLayout(false);
            this.tpOverview.ResumeLayout(false);
            this.pnlOverview.ResumeLayout(false);
            this.scOverview.Panel1.ResumeLayout(false);
            this.scOverview.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scOverview)).EndInit();
            this.scOverview.ResumeLayout(false);
            this.pnlOverviewTree.ResumeLayout(false);
            this.pnlOverviewDtl.ResumeLayout(false);
            this.tbOverviewObjectInfo.ResumeLayout(false);
            this.tpCreatureObject.ResumeLayout(false);
            this.pnlCreatureOverview.ResumeLayout(false);
            this.pnlCreatureOverview.PerformLayout();
            this.tpGameObject.ResumeLayout(false);
            this.pnlGameObjectOverview.ResumeLayout(false);
            this.pnlGameObjectOverview.PerformLayout();
            this.tpPoolConversion.ResumeLayout(false);
            this.pnlLegacyPool.ResumeLayout(false);
            this.scPoolConvert.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scPoolConvert)).EndInit();
            this.scPoolConvert.ResumeLayout(false);
            this.pnlPoolTreeview.ResumeLayout(false);
            this.tpWowhead.ResumeLayout(false);
            this.pnlWowheadGather.ResumeLayout(false);
            this.scWowheadGather.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scWowheadGather)).EndInit();
            this.scWowheadGather.ResumeLayout(false);
            this.pnlWowheadTreeview.ResumeLayout(false);
            this.tpConfig.ResumeLayout(false);
            this.pnlConfigTab.ResumeLayout(false);
            this.grpFileLocationConfig.ResumeLayout(false);
            this.grpFileLocationConfig.PerformLayout();
            this.grpSqlConfig.ResumeLayout(false);
            this.grpSqlConfig.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.ToolStripStatusLabel tsStatusText;
        private System.Windows.Forms.ToolStripProgressBar pgStatus;
        private System.Windows.Forms.Panel pnlMaster;
        private System.Windows.Forms.TabControl tbMain;
        private System.Windows.Forms.TabPage tpOverview;
        private System.Windows.Forms.Panel pnlOverview;
        private System.Windows.Forms.SplitContainer scOverview;
        private System.Windows.Forms.Panel pnlOverviewTree;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TreeView tvOverview;
        private System.Windows.Forms.Panel pnlOverviewDtl;
        private System.Windows.Forms.TabControl tbOverviewObjectInfo;
        private System.Windows.Forms.TabPage tpCreatureObject;
        private System.Windows.Forms.Panel pnlCreatureOverview;
        private System.Windows.Forms.TextBox txtCreatureEntry;
        private System.Windows.Forms.TextBox txtCreatureId;
        private System.Windows.Forms.Label lblCreatureIdEntry;
        private System.Windows.Forms.TextBox txtCreaturePositionZ;
        private System.Windows.Forms.Label lblCreaturePositionZ;
        private System.Windows.Forms.TextBox txtCreatureAreaName;
        private System.Windows.Forms.TextBox txtCreatureAreaId;
        private System.Windows.Forms.Label lblCreatureArea;
        private System.Windows.Forms.TextBox txtCreaturePositionX;
        private System.Windows.Forms.Label lblCreaturePositionX;
        private System.Windows.Forms.TextBox txtCreatureMapName;
        private System.Windows.Forms.TextBox txtCreatureMapId;
        private System.Windows.Forms.Label lblCreatureMap;
        private System.Windows.Forms.TextBox txtCreaturePositionY;
        private System.Windows.Forms.Label lblCreaturePositionY;
        private System.Windows.Forms.TextBox txtCreatureZoneName;
        private System.Windows.Forms.TextBox txtCreatureZoneId;
        private System.Windows.Forms.Label lblCreatureZone;
        private System.Windows.Forms.TextBox txtGameObjectEntry;
        private System.Windows.Forms.TextBox txtGameObjectId;
        private System.Windows.Forms.Label lblGameObjectIdEntry;
        private System.Windows.Forms.TextBox txtGameObjectPositionZ;
        private System.Windows.Forms.Label lblGameObjectPositionZ;
        private System.Windows.Forms.TextBox txtGameObjectAreaName;
        private System.Windows.Forms.TextBox txtGameObjectAreaId;
        private System.Windows.Forms.Label lblGameObjectArea;
        private System.Windows.Forms.TextBox txtGameObjectPositionX;
        private System.Windows.Forms.Label lblGameObjectPositionX;
        private System.Windows.Forms.TextBox txtGameObjectMapName;
        private System.Windows.Forms.TextBox txtGameObjectMapId;
        private System.Windows.Forms.Label lblGameObjectMap;
        private System.Windows.Forms.TextBox txtGameObjectPositionY;
        private System.Windows.Forms.Label lblGameObjectPositionY;
        private System.Windows.Forms.TextBox txtGameObjectZoneName;
        private System.Windows.Forms.TextBox txtGameObjectZoneId;
        private System.Windows.Forms.Label lblGameObjectZone;
        private System.Windows.Forms.TextBox txtGameObjectOrientation;
        private System.Windows.Forms.Label lblGameObjectOrientation;
        private System.Windows.Forms.TextBox txtGameObjectName;
        private System.Windows.Forms.TabPage tpCreatureTemplate;
        private System.Windows.Forms.TabPage tpGameObject;
        private System.Windows.Forms.TabPage tpGameObjectTemplate;
        private System.Windows.Forms.TabPage tpPoolConversion;
        private System.Windows.Forms.TabPage tpPoolDesigner;
        private System.Windows.Forms.TabPage tpConfig;
        private System.Windows.Forms.Panel pnlLegacyPool;
        private System.Windows.Forms.SplitContainer scPoolConvert;
        private System.Windows.Forms.Panel pnlPoolTreeview;
        private System.Windows.Forms.Button btnRefreshPools;
        private System.Windows.Forms.TreeView tvLegacyPools;
        private System.Windows.Forms.TextBox txtCreatureOrientation;
        private System.Windows.Forms.Label lblCreatureOrientation;
        private System.Windows.Forms.TextBox txtCreatureName;
        private System.Windows.Forms.Panel pnlGameObjectOverview;
        private System.Windows.Forms.Panel pnlConfigTab;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveConfig;
        private System.Windows.Forms.GroupBox grpFileLocationConfig;
        private System.Windows.Forms.Button btnDBCBrowse;
        private System.Windows.Forms.TextBox txtTrinityDBCFolder;
        private System.Windows.Forms.Label lblTrinityDBCFolder;
        private System.Windows.Forms.GroupBox grpSqlConfig;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblSqlDatabase;
        private System.Windows.Forms.Label lblSqlPassword;
        private System.Windows.Forms.Label lblSqlUsername;
        private System.Windows.Forms.ComboBox cbSqlDatabase;
        private System.Windows.Forms.TextBox txtSqlPassword;
        private System.Windows.Forms.TextBox txtSqlUsername;
        private System.Windows.Forms.TextBox txtSqlServerHost;
        private System.Windows.Forms.Label lblSqlServerHost;
        private System.Windows.Forms.TabPage tpWowhead;
        private System.Windows.Forms.Panel pnlWowheadGather;
        private System.Windows.Forms.SplitContainer scWowheadGather;
        private System.Windows.Forms.Panel pnlWowheadTreeview;
        private System.Windows.Forms.Button btnWowheadRefresh;
        private System.Windows.Forms.TreeView tvWowheadGather;
        private System.Windows.Forms.Button btnBrowseWowheadFile;
        private System.Windows.Forms.TextBox txtWowheadLuaFile;
        private System.Windows.Forms.Label lblWowheadLuaFile;
    }
}

