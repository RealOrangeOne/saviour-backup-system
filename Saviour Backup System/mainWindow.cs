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
        public DriveInfo selectedDrive;

        public mainWindow() {
            InitializeComponent();
            try
            {
                if (setup.runtimeArguements[0] == "STARTUP") { this.removeDisplay(); }
                else { this.showDisplay(); }
            }
            catch { this.showDisplay(); }
        }

        public void removeDisplay() {
            formatDriveCapacityTimer.Stop();
            driveRefreshTimer.Stop();
            connectedDrivesList.Update();
            clearDriveDetails();
            this.Hide();
            setup.icon.notifyIcon.Visible = true;
        }

        public void showDisplay() {
            refreshDriveList();
            connectedDrivesList.Update();
            connectedDrivesList.Items[0].Selected = true;
            displayDriveDetails(USBTools.getDriveObject(connectedDrivesList.SelectedItems[0].Text.Substring(0,1)));
            formatDriveCapacityTimer.Start();
            driveRefreshTimer.Start();
            setup.icon.notifyIcon.Visible = false;
            this.Show();
        }

        public void refreshDriveList() {
            DriveInfo[] drives = USBTools.getConnectedDrives();
            if (connectedDrivesList.Items.Count == USBTools.countDrives()) { return; } //if there is no change in the numer
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
            toolStripProgress.Visible = true;
            foreach (ListViewItem i in connectedDrivesList.SelectedItems){ i.Selected = false; } //Deselected all elements in the list first
            clearDriveDetails();
            refreshDriveList();
            toolStripProgress.Visible = false;
        }


        private void connectedDrivesList_Selection(object sender, ListViewItemSelectionChangedEventArgs e) {
            toolStripProgress.Visible = true;
            if (!e.IsSelected) {
                deviceTab.Visible = false;
                backupRestoreTab.Select();
                return; 
            }
            formatDriveCapacityTimer.Start();
            ribbonControl.RecalcLayout();
            populateDeviceTab();
            string selectedDevice = connectedDrivesList.SelectedItems[0].Text;
            displayDriveDetails(USBTools.getDriveObject(selectedDevice.Substring(0,1)));
            toolStripProgress.Visible = false;
        }
        
        private void displayDriveDetails(DriveInfo drive) {
            toolStripProgress.Visible = true;
            selectedDrive = drive;
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
            long timeStamp = databaseTools.getBackupCreationDate(USBTools.calculateDriveID(selectedDrive));
            backupDirectoryDisplay.Text = databaseTools.getBackupDirectory(USBTools.calculateDriveID(selectedDrive));
            if (timeStamp == 0L) { creationDateDisplay.Text = "NONE"; }
            else { creationDateDisplay.Text = tools.unixDateTime(timeStamp).ToString(); }
            toolStripProgress.Visible = false;
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
            formatDriveCapacityTimer.Stop();
            
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

        private void formatDriveCapacityTimer_Tick(object sender, EventArgs e) { try { formatDriveCapacity(); } catch { } } //Because background workers cant interact with the GUI (very quickly), so a timer has to 

        private void populateDeviceTab() {
            // put stuff in here for changing labels of buttons etc.
            deviceTab.Visible = true;
            deviceTab.Select();
        }
        private void mainWindow_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = true;
            switch (e.CloseReason) {
                case(CloseReason.ApplicationExitCall):
                case(CloseReason.WindowsShutDown):
                    formatDriveCapacityTimer.Stop();
                    driveRefreshTimer.Stop();
                    this.Close();
                    this.Dispose();
                    break;
                case(CloseReason.UserClosing):
                    this.removeDisplay();
                    setup.icon.displayStillRunning();
                    break;
                default:
                    this.Close();
                    break;
            }
        }

        private void addBackupRuleButton_Click(object sender, EventArgs e)
        {
            setup.ABW = new addBackupWizard();
            setup.ABW.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e) { setup.closeProgram(); }

        private void currentTransfersButton_Click(object sender, EventArgs e)
        {
            setup.CT.Show();
        }

        private void viewAllRulesButton_Click(object sender, EventArgs e)
        {
            setup.BV = new backupViewer();
            setup.BV.Show();
        }

        private void backupDeviceButton_Click(object sender, EventArgs e)
        {
            if (backupDirectoryDisplay.Text != "NONE") {
                toolStripProgress.Visible = true;
                setup.CT.startCopy(selectedDrive, databaseTools.getBackupDirectory(USBTools.calculateDriveID(selectedDrive)), true);
                MessageBox.Show("Backup initiated for drive '" + selectedDrive.VolumeLabel + "'", "Backup started", MessageBoxButtons.OK, MessageBoxIcon.Information);
                toolStripProgress.Visible = false;
            }
            else { MessageBox.Show("You cannot backup a drive without a record. Please create one before continueing!", "No Backup Exists", MessageBoxButtons.OK, MessageBoxIcon.Stop); }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(databaseTools.conn.State.ToString());
        }

        private void buttonItem5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Unavailable.");
        }
    }
}
