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
            refreshDriveList();
        }

        private void connectedDrivesList_Select(object sender, EventArgs e)
        {
            deviceTab.Visible = true;
            ribbonControl1.RecalcLayout();
            selectedDevice = connectedDrivesList.SelectedItems[0].Text;
            MessageBox.Show(selectedDevice);
        }
    }
}
