using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace Saviour_Backup_System
{
    public partial class mainWindow : Form
    {
        private DriveInfo selectedDrive = null;

        public mainWindow()
        {
            InitializeComponent();
            //setup.initProgram();   ##Add in later!
            refreshDriveList();
            clearDriveDetails();
            formatDriveCapacityTimer.Start();


            //Starts the timer for refreshing drive list
            driveRefreshTimer.Start();
        }


        public void refreshDriveList(){
            DriveInfo[] drives = USBTools.getConnectedDrives();
            if (connectedDrivesList.Items.Count == USBTools.countDrives()) { return; }
            connectedDrivesList.Items.Clear();
            bool deviceStillConnected = false;
            foreach (DriveInfo drive in drives){
                try {
                    ListViewItem driveItem = new ListViewItem(drive.Name + " " + drive.VolumeLabel);
                    driveItem.SubItems.Add("X");
                    connectedDrivesList.Items.Add(driveItem);
                    if (drive.VolumeLabel == driveNameDisplay.Text){
                        deviceStillConnected = true;
                        driveItem.Selected = true;
                    }
                } catch { continue; }
            }
            if (!deviceStillConnected) { clearDriveDetails(); }
            connectedDrivesList.Sort();
        }


        private void connectedDrivesListRefresh_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem i in connectedDrivesList.SelectedItems){ i.Selected = false; } //Deselected all elements in the list first
            refreshDriveList();
        }


        private void connectedDrivesList_Selection(object sender, ListViewItemSelectionChangedEventArgs e) {
            deviceTab.Visible = e.IsSelected;
            if (!e.IsSelected) {
                backupRestoreTab.Select();
                return; 
            }
            ribbonControl.RecalcLayout();
            deviceTab.Select();
            string selectedDevice = connectedDrivesList.SelectedItems[0].Text;
            displayDriveDetails(selectedDevice.Substring(0,3));
        }
        
        
        private void displayDriveDetails(string driveName)
        {
            foreach (DriveInfo drive in USBTools.getConnectedDrives()) {
                if (drive.Name == driveName) { selectedDrive = drive; break; }
            }
            driveNameDisplay.Text = tools.Trim(selectedDrive.VolumeLabel, 15);
            driveLetterDisplay.Text = selectedDrive.Name;
            driveSystemDisplay.Text = selectedDrive.DriveFormat;
            driveTypeDisplay.Text = USBTools.getDriveType(selectedDrive);
            switch (USBTools.getDriveType(selectedDrive))
            {
                case "Optical Disk Drive":
                    driveIconBox.Image = Properties.Resources.cdIcon;
                    break;
                case "Removable Drive":
                    driveIconBox.Image = Properties.Resources.usbIcon;
                    break;
                case "Fixed Disk Drive":
                    driveIconBox.Image = Properties.Resources.hddIcon;
                    break;
            }
            //formatDriveCapacity();
        }


        private void formatDriveCapacity()
        {
            DriveInfo drive = selectedDrive;
            int driveCapacityPerc = USBTools.spacePercentage(drive);
            while (driveCapacityPerc != driveCapacityDisplay.Value) {
                if (driveCapacityPerc < driveCapacityDisplay.Value) { driveCapacityDisplay.Value -= 1; }
                if (driveCapacityPerc > driveCapacityDisplay.Value) { driveCapacityDisplay.Value += 1; }

                //adjust the colour of the progressbar depending on capacity of the drive
                if (driveCapacityDisplay.Value <= 6800) { driveCapacityDisplay.ColorTable = DevComponents.DotNetBar.eProgressBarItemColor.Normal; }
                else if (driveCapacityDisplay.Value > 6800 && driveCapacityDisplay.Value < 9000) { driveCapacityDisplay.ColorTable = DevComponents.DotNetBar.eProgressBarItemColor.Paused; }
                else if (driveCapacityDisplay.Value >= 9000) { driveCapacityDisplay.ColorTable = DevComponents.DotNetBar.eProgressBarItemColor.Error; }
            }

        }


        private void clearDriveDetails() {
            string blankText = "";
            driveNameDisplay.Text = blankText;
            driveLetterDisplay.Text = blankText;
            driveSystemDisplay.Text = blankText;
            driveTypeDisplay.Text = blankText;
            driveCapacityDisplay.Value = 0;
        }


        private void driveRefreshTimer_Tick(object sender, EventArgs e) { refreshDriveList(); }

        private void formatDriveCapacityTimer_Tick(object sender, EventArgs e) { try { formatDriveCapacity(); } catch { } } //Because background workers cant interact with the GUI (very quickly)


    }
}
