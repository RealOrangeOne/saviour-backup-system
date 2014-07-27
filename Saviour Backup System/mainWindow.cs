using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Saviour_Backup_System
{
    public partial class mainWindow : Form
    {
        public string selectedDevice;
        public mainWindow()
        {
            InitializeComponent();
            refreshDriveList();
            setup.initProgram();
        }
        public void refreshDriveList()
        {
            DriveInfo[] drives = USBTools.getConnectedDrives();
            connectedDrivesList.Items.Clear();
            foreach (DriveInfo drive in drives){
                ListViewItem driveItem = new ListViewItem(drive.Name + " " + drive.VolumeLabel);
                driveItem.SubItems.Add("X");
                connectedDrivesList.Items.Add(driveItem);
            }
            connectedDrivesList.Sort();
        }

        private void connectedDrivesListRefresh_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem i in connectedDrivesList.SelectedItems){ i.Selected = false; } //Deselected all elements in the list first
            refreshDriveList();
        }

        private void connectedDrivesList_Selection(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            deviceTab.Visible = e.IsSelected;
            ribbonControl1.RecalcLayout();
            if (!e.IsSelected) { backupRestoreTab.Select(); return; }
            deviceTab.Select();
            selectedDevice = connectedDrivesList.SelectedItems[0].Text;
            USBTools.displayDriveDetails(selectedDevice.Substring(4));
        }
    }
}
