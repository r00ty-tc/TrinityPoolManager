using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Data.Common;
using Trinity.PoolDB;

namespace TrinityPoolManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private PoolDB data;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Grid_Initialized(object sender, EventArgs e)
        {
            // Clear treeview
            tvOverview.Items.Clear();

            // Add root items
            AddTvItem(tvOverview.Items, "creatureRoot", "Creatures");
            AddTvItem(tvOverview.Items, "gameObjectRoot", "GameObjects");

            data = new PoolDB("localhost", "trinity", "trinity", "world_335_pooling-s3");
            prgStatus.Minimum = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            btnLoad.IsEnabled = false;
            // Man is this the crappiest way to do it? Should have just used winforms
            var task = new Thread(() =>
            {
                data.LoadData();
            });

            task.Start();
            while (task.IsAlive)
            {
                updateStatus();
                Thread.Sleep(100);
            }

            // Make sure the task is completed
            task.Join();
            updateStatus();
            updateTreeView();
            btnLoad.IsEnabled = true;
        }

        private void updateStatus()
        {
            var result = data.GetStatus();
            lblStatus.Content = result.currentStatus ?? string.Empty;
            prgStatus.Value = Convert.ToDouble(result.currentItem);
            prgStatus.Maximum = Convert.ToDouble(result.maxItems);
            Application.Current.Dispatcher.Invoke(DispatcherPriority.Background, new Action(delegate { }));
        }

        private void updateTreeView()
        {
            var creatureItem = FindTvItem(tvOverview.Items,"creatureRoot");
            foreach (var creature in data.CreatureData.Values)
            {
                var item = AddTvItem(creatureItem.Items, $"c{creature.guid}",
                    $"{creature.guid}: {creature.creatureTemplate.name}");
            }
        }

        private TreeViewItem AddTvItem(ItemCollection items, string name, string title)
        {
            var newItem = new TreeViewItem()
            {
                Name = name,
                Header = title,
            };
            items.Add(newItem);
            return newItem;
        }

        private TreeViewItem FindTvItem(ItemCollection items, string name) => items.Cast<TreeViewItem>().FirstOrDefault(row => row.Name.Equals(name));

        private void Grid_Unloaded(object sender, RoutedEventArgs e)
        {
            data = null;
        }
    }
}
