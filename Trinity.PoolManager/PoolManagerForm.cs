using System;
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

            // We don't get to see progress, or add key IDs. But it's 1,000,000 times faster
            var treeNodes = 
            (
                from row in data.CreatureData.Values
                select new 
                    TreeNode($"{row.guid}/{row.creatureTemplate.entry}: {row.creatureTemplate.name}")
            ).ToArray();

            creatureRoot.Nodes.AddRange(treeNodes);
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
