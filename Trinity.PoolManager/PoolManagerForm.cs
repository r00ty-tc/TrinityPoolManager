﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trinity.PoolManagerData;

namespace Trinity.PoolManager
{
    using Trinity.PoolDB;
    public partial class PoolManagerForm : Form
    {
        private PoolDB data;
        public PoolManagerForm()
        {
            InitializeComponent();
            data = new PoolDB("localhost", "trinity", "trinity", "world_335_pooling-s3");
            pgStatus.Minimum = 0;
            pgStatus.Anchor = AnchorStyles.Left & AnchorStyles.Bottom & AnchorStyles.Right;
            tvOverview.Nodes.Clear();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            btnLoad.Enabled = false;
            // Run this as a new thread, so the window is easier to keep up to date
            var task = new Thread(() =>
            {
                data.LoadData();
            });

            task.Start();
            while (task.IsAlive)
            {
                updateStatusDB();
                Thread.Sleep(100);
            }

            // Make sure the task is completed
            task.Join();
            updateStatusDB();
            //updateTreeView();
            btnLoad.Enabled = true;

            tvOverview.SuspendLayout();
            tvOverview.BeginUpdate();
            var creatureRoot = tvOverview.Nodes.Add("creatureRoot","Creatures");
            var gameObjectRoot = tvOverview.Nodes.Add("gameObjectRoot", "Game Objects");

            var updated = 0;
            var maxUpdated = data.CreatureData.Count;

            updateLocalStatus("Updating Treeview for Creatures", 0, maxUpdated);

            // Add unique maps first
            var mapNodes =
            (
                from row in data.CreatureData.Values.Select(row => row.dbcMap).Distinct().OrderBy(row => row.Id)
            select new
                    TreeNode(row.ToString())
            ).ToArray();
            creatureRoot.Nodes.AddRange(mapNodes);

            // Probably a better way to go about this
            foreach (var mapNode in creatureRoot.Nodes.Cast<TreeNode>())
            {
                var mapId = Convert.ToUInt32(mapNode.Text.Split(':')[0]);
                // Add distinct zones per map
                var zoneNodes =
                (
                    from row in data.CreatureData.Values.Where(row => row.map.Equals(mapId) && row.dbcZone != null).Select(row => row.dbcZone).Distinct().OrderBy(row => row.ID)
                    select new
                        TreeNode(row.ToString())
                ).ToArray();
                mapNode.Nodes.AddRange(zoneNodes);

                foreach (var zoneNode in zoneNodes)
                {
                    // Distinct creature templates
                    var zoneId = Convert.ToUInt32(zoneNode.Text.Split(':')[0]);
                    var creatureTemplateNodes =
                    (
                        from row in data.CreatureData.Values.Where(row => row.zoneId.Equals(zoneId)).Select(row => row.creatureTemplate).Distinct().OrderBy(row => row.entry)
                        select new
                            TreeNode(row.ToString())
                    ).ToArray();
                    zoneNode.Nodes.AddRange(creatureTemplateNodes);

                    foreach (var templateNode in creatureTemplateNodes)
                    {
                        // Add creatures for each template
                        var entryId = Convert.ToUInt32(templateNode.Text.Split(':')[0]);
                        var template = data.CreatureTemplateData[entryId];
                        var creatureNodes = (
                            from row in template.objects.Where(row => row.zoneId.Equals(zoneId))
                            select new TreeNode(row.ToString())
                        ).ToArray();
                        templateNode.Nodes.AddRange(creatureNodes);
                    }
                }
            }

            tvOverview.EndUpdate();
            tvOverview.ResumeLayout();
            
        }

        private void updateStatusDB()
        {
            var result = data.GetStatus();
            tsStatusText.Text = result.currentStatus ?? string.Empty;
            pgStatus.Maximum = (int)result.maxItems;
            pgStatus.Value = (int)result.currentItem;
            Application.DoEvents();
        }

        private void updateLocalStatus(string statusText, int? value, int? maxValue)
        {
            var maxValueInt = maxValue.HasValue ? maxValue.Value : pgStatus.Maximum;
            if (value.HasValue && value % (maxValueInt / 100) == 0)
            {
                if (statusText != null)
                    tsStatusText.Text = statusText;

                if (maxValue.HasValue)
                    pgStatus.Maximum = maxValue.Value;

                if (value.HasValue)
                    pgStatus.Value = value.Value;

                Application.DoEvents();
            }
        }

        private void statusStrip1_Resize(object sender, EventArgs e)
        {
            // It's 2021 and status bar has no auto resize.
            pgStatus.Width = ssStatus.Width - tsStatusText.Width - 20;
        }

    }
}
