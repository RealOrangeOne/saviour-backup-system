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
        private DriveInfo selectedDrive;

        public mainWindow()
        {
            InitializeComponent();
            refreshDriveList(); 
            connectedDrivesList.Items[0].Selected = true; //Selects the first item in the list of drives
            displayDriveDetails(connectedDrivesList.SelectedItems[0].Text.Substring(0, 3)); //displays the info for the drive

            //Starts the thread for displaying the capacity of a drive
            formatDriveCapacityTimer.Start();

            //Starts the timer for refreshing drive list
            driveRefreshTimer.Start();
        }


        internal void refreshDriveList(){
            DriveInfo[] drives = USBTools.getConnectedDrives();
            if (connectedDrivesList.Items.Count == USBTools.countDrives()) { return; }
            connectedDrivesList.Items.Clear();
            bool deviceStillConnected = false;
            foreach (DriveInfo drive in drives){
                try {
                    ListViewItem driveItem = new ListViewItem(drive.Name + " " + tools.Trim(drive.VolumeLabel, 24));
                    driveItem.SubItems.Add("X");
                    connectedDrivesList.Items.Add(driveItem);
                    if (drive.VolumeLabel == driveNameDisplay.Text)
                    {
                        deviceStillConnected = true;
                        driveItem.Selected = true;
                    }
                }
                catch { continue; }
            }
            if (!deviceStillConnected) { clearDriveDetails(); }
            connectedDrivesList.Sort();
        }


        private void connectedDrivesListRefresh_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem i in connectedDrivesList.SelectedItems){ i.Selected = false; } //Deselected all elements in the list first
            clearDriveDetails();
            refreshDriveList();
        }


        private void connectedDrivesList_Selection(object sender, ListViewItemSelectionChangedEventArgs e) {
            if (!e.IsSelected) {
                deviceTab.Visible = false;
                backupRestoreTab.Select();
                return; 
            }
            ribbonControl.RecalcLayout();
            populateDeviceTab();
            string selectedDevice = connectedDrivesList.SelectedItems[0].Text;
            displayDriveDetails(selectedDevice.Substring(0,3));
        }
        
        
        private void displayDriveDetails(string driveName)
        {
            foreach (DriveInfo drive in USBTools.getConnectedDrives()) {
                if (drive.Name == driveName) { selectedDrive = drive; break; }
            }
            driveNameDisplay.Text = tools.Trim(selectedDrive.VolumeLabel, 16);
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
            
        }


        private void formatDriveCapacity()
        {
            DriveInfo drive = selectedDrive;
            int driveCapacityPerc = USBTools.spacePercentage(drive);
            driveCapacityDisplay.Text = "Drive Capacity: " + (driveCapacityDisplay.Value / 100).ToString() + "%";
            while (driveCapacityPerc != driveCapacityDisplay.Value) {
                if (driveCapacityPerc < driveCapacityDisplay.Value) { driveCapacityDisplay.Value -= 1; }
                if (driveCapacityPerc > driveCapacityDisplay.Value) { driveCapacityDisplay.Value += 1; }
                driveCapacityDisplay.Text = "Drive Capacity: " + (driveCapacityDisplay.Value / 100).ToString() + "%";

                //adjust the colour of the progressbar depending on capacity of the drive
                if (driveCapacityDisplay.Value <= 6800) { driveCapacityDisplay.ColorTable = DevComponents.DotNetBar.eProgressBarItemColor.Normal; }
                else if (driveCapacityDisplay.Value > 6800 && driveCapacityDisplay.Value < 9000) { driveCapacityDisplay.ColorTable = DevComponents.DotNetBar.eProgressBarItemColor.Paused; }
                else if (driveCapacityDisplay.Value >= 9000) { driveCapacityDisplay.ColorTable = DevComponents.DotNetBar.eProgressBarItemColor.Error; }
            }
            
        }


        private void clearDriveDetails() {
            string blankText = "";
            selectedDrive = null;
            driveNameDisplay.Text = blankText;
            driveLetterDisplay.Text = blankText;
            driveSystemDisplay.Text = blankText;
            driveTypeDisplay.Text = blankText;
            driveCapacityDisplay.Value = 0;
            driveCapacityDisplay.Text = blankText;
        }


        private void driveRefreshTimer_Tick(object sender, EventArgs e) { refreshDriveList(); }

        private void formatDriveCapacityTimer_Tick(object sender, EventArgs e) { try { formatDriveCapacity(); } catch { } } //Because background workers cant interact with the GUI (very quickly)

        private void populateDeviceTab() {
            // put stuff in here!!
            deviceTab.Visible = true;
            deviceTab.Select();
        }
        private void mainWindow_FormClosing(object sender, FormClosingEventArgs e) { setup.closeProgram(sender, e); }
    }
}
