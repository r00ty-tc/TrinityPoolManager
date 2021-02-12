using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBFileReaderLib;
using MySql.Data.MySqlClient;
using Renci.SshNet.Security;
using Trinity.PoolManagerData;

namespace Trinity.PoolManager
{
    using Trinity.PoolDB;

    public partial class PoolManagerForm : Form
    {
        private PoolDB data;
        private PoolManagerConfig config;

        public PoolManagerForm()
        {
            InitializeComponent();
            InitializeLocal();
        }

        private void InitializeLocal()
        {
            tbOverviewObjectInfo.Appearance = TabAppearance.FlatButtons;
            tbOverviewObjectInfo.ItemSize = new Size(0, 1);
            tbOverviewObjectInfo.SizeMode = TabSizeMode.Fixed;
            tbOverviewObjectInfo.Visible = false;

            // Disable other panels except config 
            foreach (var page in tbMain.TabPages.Cast<TabPage>())
                if (page != tpConfig)
                    page.Enabled = false;

            config = new PoolManagerConfig();

            var configState = config.ValidateConfig(true);
            if (configState != null)
            {
                tbMain.SelectTab(tpConfig);
                Application.DoEvents();
                MessageBox.Show($"Unable to load configuration{Environment.NewLine}{configState}{Environment.NewLine}Please correct configuration and save");
                return;
            }

            // Enable panels now config is loaded
            foreach (var page in tbMain.TabPages.Cast<TabPage>())
                if (page != tpConfig)
                    page.Enabled = true;


            // Maybe it will actually run destructor
            if (data != null)
                data = null;

            data = new PoolDB(config.Data);
            if (!data.IsLoaded)
            {
                tpPoolConversion.Enabled = false;
                tpPoolDesigner.Enabled = false;
            }

            // Set config to form
            txtSqlServerHost.Text = config.Data.SqlServerHost;
            txtSqlUsername.Text = config.Data.SqlServerUser;
            txtSqlPassword.Text = config.Data.SqlServerPass;
            cbSqlDatabase.Text = config.Data.SqlServerDB;
            txtTrinityDBCFolder.Text = config.Data.DbcFolder;

            pgStatus.Minimum = 0;
            pgStatus.Anchor = AnchorStyles.Left & AnchorStyles.Bottom & AnchorStyles.Right;
            tvOverview.Nodes.Clear();
            updateLocalStatus("Ready", 0, 1);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            btnLoad.Enabled = false;
            // Run this as a new thread, so the window is easier to keep up to date
            var task = new Thread(() => { data.LoadData(); });

            task.Start();
            while (task.IsAlive)
            {
                updateStatusDB();
                Thread.Sleep(100);
            }

            // Make sure the task is completed
            task.Join();

            if (!data.IsLoaded)
                return;

            updateStatusDB();
            //updateTreeView();
            btnLoad.Enabled = true;

            tvOverview.SuspendLayout();
            tvOverview.BeginUpdate();
            var creatureRoot = tvOverview.Nodes.Add("creatureRoot", "Creatures");
            var gameObjectRoot = tvOverview.Nodes.Add("gameObjectRoot", "Game Objects");

            var maxUpdated = data.CreatureData.Count;
            updateLocalStatus("Updating Treeview for Creatures", 0, maxUpdated);
            updateOverviewTreeviewObjects(creatureRoot, data.CreatureData, data.CreatureTemplateData);

            maxUpdated = data.GameObjectData.Count;
            updateLocalStatus("Updating Treeview for GameObjects", 0, maxUpdated);
            updateOverviewTreeviewObjects(gameObjectRoot, data.GameObjectData, data.GameObjectTemplateData);
            updateLocalStatus("Ready", 0, 1);

            tvOverview.EndUpdate();
            tvOverview.ResumeLayout();

            tpPoolConversion.Enabled = true;
            tpPoolDesigner.Enabled = true;
        }

        private void updateOverviewTreeviewObjects(TreeNode rootNode, SortedDictionary<uint, TrinityObject> objectData,
            SortedDictionary<uint, TrinityObjectTemplate> templateData)
        {
            int updated = 0;

            // Add unique maps first
            var mapNodes =
            (
                from row in objectData.Values.Select(row => row.dbcMap).Distinct().OrderBy(row => row.Id)
                select new
                    TrinityOverviewTreeNode(row.ToString())
                    {
                        TrinityMap = row
                    }
            ).ToArray();
            rootNode.Nodes.AddRange(mapNodes);

            // Probably a better way to go about this
            foreach (var mapNode in rootNode.Nodes.Cast<TrinityOverviewTreeNode>())
            {
                var mapId = (uint)mapNode.TrinityMap.Id;
                // Add distinct zones per map
                var zoneNodes =
                (
                    from row in objectData.Values.Where(row => row.map.Equals(mapId) && row.dbcZone != null)
                        .Select(row => row.dbcZone).Distinct().OrderBy(row => row.ID)
                    select new
                        TrinityOverviewTreeNode(row.ToString())
                        {
                            TrinityZone = row
                        }
                ).ToArray();
                mapNode.Nodes.AddRange(zoneNodes);

                foreach (var zoneNode in zoneNodes)
                {
                    // Distinct object templates
                    var zoneId = (uint)zoneNode.TrinityZone.ID;
                    var objectTemplateNodes =
                    (
                        from row in objectData.Values.Where(row => row.zoneId.Equals(zoneId))
                            .Select(row => row.trinityTemplateObject).Distinct().OrderBy(row => row.entry)
                        select new
                            TrinityOverviewTreeNode(row.ToString())
                            {
                                TrinityTemplate = row
                            }
                    ).ToArray();
                    zoneNode.Nodes.AddRange(objectTemplateNodes);

                    foreach (var templateNode in objectTemplateNodes)
                    {
                        // Add objects for each template
                        var entryId = templateNode.TrinityTemplate.entry;
                        var template = templateData[entryId];
                        var objectNodes = (
                            from row in template.objects.Where(row => row.zoneId.Equals(zoneId))
                            select new TrinityOverviewTreeNode(row.ToString())
                            {
                                TrinityObject = row
                            }
                        ).ToArray();
                        templateNode.Nodes.AddRange(objectNodes);
                        updated += objectNodes.Length;
                        updateLocalStatus(null, updated, null, true);
                    }
                }
            }

        }

        private void updateStatusDB()
        {
            var result = data.GetStatus();
            tsStatusText.Text = result.currentStatus ?? string.Empty;
            pgStatus.Maximum = (int) result.maxItems;
            pgStatus.Value = (int) result.currentItem;
            Application.DoEvents();
        }

        private void updateLocalStatus(string statusText, int? value, int? maxValue, bool noDelay = false)
        {
            var maxValueInt = maxValue.HasValue ? maxValue.Value : pgStatus.Maximum;
            if (noDelay || (value.HasValue && value % ((maxValueInt / 100) + 1) == 0))
            {
                if (statusText != null)
                    tsStatusText.Text = statusText;

                if (maxValue.HasValue)
                    pgStatus.Maximum = maxValue.Value;

                if (value.HasValue)
                    pgStatus.Value = Math.Min(value.Value, pgStatus.Maximum);

                Application.DoEvents();
            }
        }

        private void statusStrip1_Resize(object sender, EventArgs e)
        {
            // It's 2021 and status bar has no auto resize.
            pgStatus.Width = ssStatus.Width - tsStatusText.Width - 20;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                var dbList = PoolDB.GetDatabases(txtSqlServerHost.Text, txtSqlUsername.Text, txtSqlPassword.Text);
                cbSqlDatabase.Items.AddRange(dbList);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Unable to open MySQL DB. Error {ex.Number}: {ex.Message}", "MySQL Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDBCBrowse_Click(object sender, EventArgs e)
        {
            using (var dbcDialog = new FolderBrowserDialog())
            {
                if (Directory.Exists(txtTrinityDBCFolder.Text))
                    dbcDialog.SelectedPath = txtTrinityDBCFolder.Text;

                if (dbcDialog.ShowDialog(this) == DialogResult.OK && !string.IsNullOrWhiteSpace(dbcDialog.SelectedPath))
                {
                    if (!isTrinityFolderValid(dbcDialog.SelectedPath))
                        MessageBox.Show($"DBC files not found in location {txtTrinityDBCFolder.Text}",
                            "DBC folder selection error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    else
                        txtTrinityDBCFolder.Text = dbcDialog.SelectedPath;
                }
            }
        }

        private bool isTrinityFolderValid(string folder)
        {
            if (!folder.Last().Equals('\\'))
                folder += "\\";
            if (!File.Exists(folder + "AreaTable.dbc"))
                return false;
            if (!File.Exists(folder + "Map.dbc"))
                return false;

            return true;
        }

        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            var configData = config.Data;
            configData.SqlServerHost = txtSqlServerHost.Text;
            configData.SqlServerUser = txtSqlUsername.Text;
            configData.SqlServerPass = txtSqlPassword.Text;
            configData.SqlServerDB = cbSqlDatabase.Text;
            configData.DbcFolder = txtTrinityDBCFolder.Text;
            var result = config.SaveConfig(true);
            if (result != null)
                MessageBox.Show(result, "Error writing configuration", MessageBoxButtons.OK, MessageBoxIcon.Error);
            updateConfigFields();
            InitializeLocal();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var result =
                MessageBox.Show(
                    "This will overwrite any changes you have made and reload from configuration file" +
                    Environment.NewLine + Environment.NewLine + "Are you sure?", "Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (!config.LoadConfig())
                    MessageBox.Show("Error reading configuration", "Config load", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                updateConfigFields();
            }
        }

        private void updateConfigFields()
        {
            var configData = config.Data;
            txtSqlServerHost.Text = configData.SqlServerHost;
            txtSqlUsername.Text = configData.SqlServerUser;
            txtSqlPassword.Text = configData.SqlServerPass;
            cbSqlDatabase.Text = configData.SqlServerDB;
            txtTrinityDBCFolder.Text = configData.DbcFolder;
        }

        private void tvOverview_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                var trinityNode = (TrinityOverviewTreeNode) e.Node;
                if (trinityNode.IsTrinityObject)
                {
                    tbOverviewObjectInfo.Visible = true;
                    if (trinityNode.TrinityObject.type == ObjectType.OBJECT_CREATURE)
                        setVisibleTab(tbOverviewObjectInfo, tpCreatureObject);
                    else
                        setVisibleTab(tbOverviewObjectInfo, tpGameObject);
                }
                else if (trinityNode.IsTrinityTemplate)
                {
                    tbOverviewObjectInfo.Visible = true;
                    if (trinityNode.TrinityTemplate.objectType == ObjectType.OBJECT_CREATURE)
                        setVisibleTab(tbOverviewObjectInfo, tpCreatureTemplate);
                    else
                        setVisibleTab(tbOverviewObjectInfo, tpGameObjectTemplate);
                }
                else
                {
                    tbOverviewObjectInfo.Visible = false;
                }
                updateObjectInfo(trinityNode);
            }
            catch { }

        }

        private void setVisibleTab(TabControl tabControl, TabPage selectedPage)
        {
            foreach (var page in tabControl.TabPages)
            {
                if (page.Equals(selectedPage))
                    tabControl.SelectTab(selectedPage);
            }
        }

        private void updateObjectInfo(TrinityOverviewTreeNode node)
        {
            var trinObject = node.TrinityObject;
            if (node.IsTrinityObject && node.TrinityObject.type == ObjectType.OBJECT_CREATURE)
            {
                txtCreatureMapId.Text = trinObject.dbcMap.Id.ToString();
                txtCreatureMapName.Text = trinObject.dbcMap.MapName_Lang;
                txtCreatureZoneId.Text = trinObject.dbcZone.ID.ToString();
                txtCreatureZoneName.Text = trinObject.dbcZone.AreaName_Lang;
                txtCreatureAreaId.Text = trinObject.dbcArea.ID.ToString();
                txtCreatureAreaName.Text = trinObject.dbcArea.AreaName_Lang;
                txtCreaturePositionX.Text = trinObject.positionX.ToString("0.00000000");
                txtCreaturePositionY.Text = trinObject.positionY.ToString("0.00000000");
                txtCreaturePositionZ.Text = trinObject.positionZ.ToString("0.00000000");
                txtCreatureOrientation.Text = trinObject.orientation.ToString("0.00000000");
                txtCreatureId.Text = trinObject.guid.ToString();
                txtCreatureEntry.Text = trinObject.id.ToString();
                txtCreatureName.Text = trinObject.trinityTemplateObject.name;
            }
            else if (node.IsTrinityObject && node.TrinityObject.type == ObjectType.OBJECT_GAMEOBJECT)
            {
                txtGameObjectMapId.Text = trinObject.dbcMap.Id.ToString();
                txtGameObjectMapName.Text = trinObject.dbcMap.MapName_Lang;
                txtGameObjectZoneId.Text = trinObject.dbcZone.ID.ToString();
                txtGameObjectZoneName.Text = trinObject.dbcZone.AreaName_Lang;
                txtGameObjectAreaId.Text = trinObject.dbcArea.ID.ToString();
                txtGameObjectAreaName.Text = trinObject.dbcArea.AreaName_Lang;
                txtGameObjectPositionX.Text = trinObject.positionX.ToString("0.00000000");
                txtGameObjectPositionY.Text = trinObject.positionY.ToString("0.00000000");
                txtGameObjectPositionZ.Text = trinObject.positionZ.ToString("0.00000000");
                txtGameObjectOrientation.Text = trinObject.orientation.ToString("0.00000000");
                txtGameObjectId.Text = trinObject.guid.ToString();
                txtGameObjectEntry.Text = trinObject.id.ToString();
                txtGameObjectName.Text = trinObject.trinityTemplateObject.name;       // Technically doesn't belong on this tab, but whatever.
                //txtGameObjectPhaseMask.Text = trinObject.phaseMask.ToString();
                //txtGameObjectSpawnMask.Text = trinObject.spawnMask.ToString();
                //txtGameObjectRespawnTime.Text = trinObject.spawntimeSecs.ToString();
            }
        }

        private void btnRefreshPools_Click(object sender, EventArgs e)
        {
            tvLegacyPools.SuspendLayout();
            tvLegacyPools.BeginUpdate();
            tvLegacyPools.Nodes.Clear();
            var rootNode = tvLegacyPools.Nodes.Add("Pools");
            updateLocalStatus("Loading Legacy Pool Treeview", 0,  data.LegacyPoolData.Count);
            updateLegacyPoolTreeViewObjects(rootNode, data.LegacyPoolData);
            tvLegacyPools.EndUpdate();
            tvLegacyPools.ResumeLayout();
        }

        private void updateLegacyPoolTreeViewObjects(TreeNode rootNode, SortedDictionary<uint, LegacyPoolEntry> poolData)
        {
            int updated = 0;

            // Add unique maps first
            var tempMaps = new List<MapEntry>();
            foreach (var thisMap in poolData.Values.Select(row => row.poolMaps))
                tempMaps.AddRange(thisMap);

            var mapNodes =
            (
                from row in tempMaps.Distinct().OrderBy(row => row.Id)
                select new
                    TrinityLegacyPoolTreeNode(row.ToString())
                    {
                        TrinityMap = row
                    }
            ).ToArray();
            rootNode.Nodes.AddRange(mapNodes);

            // Now Unique Zones
            foreach (var mapNode in rootNode.Nodes.Cast< TrinityLegacyPoolTreeNode>())
            {
                var allowedPoolNodes = poolData.Values.Where(row =>
                    row.poolMaps.Select(row => row.Id).Contains(mapNode.TrinityMap.Id)).Select(row => row.poolZones).Distinct();

                var tempZones = new List<AreaTableEntry>();
                foreach (var thisZone in allowedPoolNodes)
                    tempZones.AddRange(thisZone);

                var zoneNodes =
                (
                    from row in tempZones.Distinct().OrderBy(row => row.ID)
                    select new TrinityLegacyPoolTreeNode(row.ToString())
                    {
                        TrinityZone = row
                    }
                ).ToArray();
                mapNode.Nodes.AddRange(zoneNodes);

                // Now pools for the zone
                foreach (var zoneNode in mapNode.Nodes.Cast<TrinityLegacyPoolTreeNode>())
                {
                    var poolNodes =
                    (
                        from row in poolData.Values.Where(row =>
                                row.poolMaps.Select(mapRow => mapRow.Id).Contains(mapNode.TrinityMap.Id) &&
                                row.poolZones.Select(zoneRow => zoneRow.ID).Contains(zoneNode.TrinityZone.ID))
                            .Distinct()
                            .OrderBy(row => row.poolId)
                        select new TrinityLegacyPoolTreeNode(row.ToString())
                        {
                            LegacyPool = row
                        }
                    ).ToArray();
                    zoneNode.Nodes.AddRange(poolNodes);

                    // We recurse into pool structure, even though I don't believe any more than 1 level is ever used.
                    foreach (var poolNode in poolNodes)
                        AddLegacySubNodes(poolNode);
                }
            }
        }

        private void AddLegacySubNodes(TrinityLegacyPoolTreeNode currentLevel)
        {
            if (currentLevel.LegacyPool.IsLeaf)
            {
                // Add any Creature templates
                var creatureTemplateNodes = currentLevel.LegacyPool.poolItems
                    .Where(row => row.type == LegacyPoolType.POOLTYPE_CREATURE).Select(objRow => objRow.trinityObject.trinityTemplateObject).Distinct();
                if (creatureTemplateNodes.Any())
                {
                    var creatureNode = new TrinityLegacyPoolTreeNode("Creatures");
                    currentLevel.Nodes.Add(creatureNode);
                    var creatureTemplateTreeNodes =
                    (
                        from row in creatureTemplateNodes
                        select new TrinityLegacyPoolTreeNode(row.ToString())
                        {
                            TrinityTemplate = row
                        }
                    ).ToArray();
                    creatureNode.Nodes.AddRange(creatureTemplateTreeNodes);

                    // Add creature nodes to templates
                    foreach (var creatureTemplateNode in creatureTemplateTreeNodes)
                    {
                        var creatureNodes = currentLevel.LegacyPool.poolItems
                            .Where(row => row.type == LegacyPoolType.POOLTYPE_CREATURE && row.trinityObject.id == creatureTemplateNode.TrinityTemplate.entry)
                            .Select(objRow => objRow.trinityObject).Distinct();
                        var creatureTreeNodes =
                        (
                            from row in creatureNodes
                            select new TrinityLegacyPoolTreeNode(row.LegacyPoolString(currentLevel.LegacyPool.poolId))
                            {
                                TrinityObject = row
                            }
                        ).ToArray();
                        creatureTemplateNode.Nodes.AddRange(creatureTreeNodes);
                    }
                }

                // Add any GameObject templates
                var gameObjectTemplateNodes = currentLevel.LegacyPool.poolItems
                    .Where(row => row.type == LegacyPoolType.POOLTYPE_GAMEOBJECT).Select(objRow => objRow.trinityObject.trinityTemplateObject).Distinct();
                if (gameObjectTemplateNodes.Any())
                {
                    var gameObjectNode = new TrinityLegacyPoolTreeNode("GameObjects");
                    currentLevel.Nodes.Add(gameObjectNode);
                    var gameObjectTemplateTreeNodes =
                    (
                        from row in gameObjectTemplateNodes
                        select new TrinityLegacyPoolTreeNode(row.ToString())
                        {
                            TrinityTemplate = row
                        }
                    ).ToArray();
                    gameObjectNode.Nodes.AddRange(gameObjectTemplateTreeNodes);

                    // Add gameobject nodes to templates
                    foreach (var gameObjectTemplateNode in gameObjectTemplateTreeNodes)
                    {
                        var gameObjectNodes = currentLevel.LegacyPool.poolItems
                            .Where(row => row.type == LegacyPoolType.POOLTYPE_GAMEOBJECT && row.trinityObject.id == gameObjectTemplateNode.TrinityTemplate.entry)
                            .Select(objRow => objRow.trinityObject).Distinct();
                        var gameObjectTreeNodes =
                        (
                            from row in gameObjectNodes
                            select new TrinityLegacyPoolTreeNode(row.LegacyPoolString(currentLevel.LegacyPool.poolId))
                            {
                                TrinityObject = row
                            }
                        ).ToArray();
                        gameObjectTemplateNode.Nodes.AddRange(gameObjectTreeNodes);
                    }
                }

                return;
            }

            var childNodes =
            (
                from row in currentLevel.LegacyPool.childPools
                select new TrinityLegacyPoolTreeNode(row.ToString())
                {
                    LegacyPool = row
                }
            ).ToArray();
            currentLevel.Nodes.AddRange(childNodes);

            foreach (var childNode in childNodes)
                AddLegacySubNodes(childNode);
        }
    }
}
