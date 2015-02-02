using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlServerCe;

namespace Saviour_Backup_System
{
    public partial class addBackupWizard : Form
    {
        public addBackupWizard()
        {
            InitializeComponent();
            populateDropdown();
            assignToolTips();
            this.Size = new Size(583, 269);
        }

        /// <summary>
        /// Add the tooltips to controls
        /// </summary>
        private void assignToolTips() {
            ToolTip tempTip = new ToolTip();
            tempTip.AutoPopDelay = 5000;
            tempTip.InitialDelay = 1000;
            tempTip.ReshowDelay = 500;
            tempTip.ShowAlways = true;

            //huge list of tooltips to use!
            tempTip.SetToolTip(this.backupNameInput, "Name the backup\nAn easy name for the backup, or even a description.");
            tempTip.SetToolTip(this.drivesDropdown, "Select the drive\nWhich drive would you like to backup?");
            tempTip.SetToolTip(this.previousBackupInput, "Previous backups\nHow many past backups would you like to store, enter -1 for all");
            tempTip.SetToolTip(this.insertionSwitch, "Automated\nWould you like to backup the drive as soon as it is inserted to the computer?");
            tempTip.SetToolTip(this.compressionSwitch, "Single File\nWould you like to store the backup in a single file?");
            tempTip.SetToolTip(this.folderPath, "Location\nWhere would you like to store the backup?");
            tempTip.SetToolTip(this.createButton, "Let's Go!\nClick to create the backup record, this can take a few seconds to run.");
            tempTip.SetToolTip(this.directoryBrowseButton, "Where?\nClick here to browse your computer to find where to store the backup.");
        }

        /// <summary>
        /// Browse through window directory to select backup directory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void directoryBrowseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                folderPath.Text = folderBrowserDialog.SelectedPath;
            }
            folderBrowserDialog.Dispose(); //memory management
        }

        /// <summary>
        /// Fill dropdown with available drives
        /// </summary>
        private void populateDropdown()
        {
            DriveInfo[] drives = USBTools.getConnectedDrives();
            foreach (DriveInfo drive in drives)
            {
                drivesDropdown.Items.Add(drive.Name + " " + drive.VolumeLabel);
            }
        }

        /// <summary>
        /// Remove all content from inputs
        /// </summary>
        private void clearControls()
        {
            backupNameInput.Text = "";
            drivesDropdown.Text = "";
            insertionSwitch.Value = false;
            compressionSwitch.Value = false;
            previousBackupInput.Value = 0;
            folderPath.Text = "";
        }

        /// <summary>
        /// Mark all controls as read only, or unmark
        /// </summary>
        /// <param name="state"></param>
        private void lockControls(bool state)
        {
            backupNameInput.ReadOnly = state;
            drivesDropdown.Enabled = !state;
            insertionSwitch.IsReadOnly = state;
            compressionSwitch.IsReadOnly = state;
            previousBackupInput.Enabled = !state;
            folderPath.ReadOnly = state;
        }

        /// <summary>
        /// Create the backup record from given information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createButton_Click(object sender, EventArgs e) {
            DriveInfo drive = USBTools.getDriveObject(drivesDropdown.Text.Substring(0, 1));
            lockControls(true);
            if ((folderPath.Text == "") || (previousBackupInput.Text == "") ||(drivesDropdown.Text == "") || (backupNameInput.Text == "")) {
                    MessageBox.Show("You have not filled in every element, Please try again!", "Not everything is complete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lockControls(false);
                    return;
            }

            statusProgress.Text = "Initialising...";
            int initHeight = 269;
            while (this.Size.Height != 302) {
                initHeight++;
                this.Size = new Size(583, initHeight);
                Thread.Sleep(10);
            }

            statusProgress.Text = "Checking form...";     
            if (!Directory.Exists(folderPath.Text)) {
                DialogResult result = MessageBox.Show("The folder path you have entered doesnt exist, would you like to create it?", "Create Folder", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) {
                    try { Directory.CreateDirectory(folderPath.Text);
                    } catch {
                        MessageBox.Show("Error Creating Folder! Please check the path and try agian.", "Error creating folder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            } else if (drive.VolumeLabel == ""){
                MessageBox.Show("You cannot backup a drive with no label, please rename it and try again","Can't use default name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                statusProgress.Text = "Initialising database connection...";
                if (createButton.Text == "Update") { setup.BV.passBack(backupNameInput.Text, folderPath.Text, insertionSwitch.Value, compressionSwitch.Value, previousBackupInput.Value); return; }
                createRecord();
                statusProgress.Text = "Complete!";
                statusProgress.ProgressType = DevComponents.DotNetBar.eProgressItemType.Standard;
                statusProgress.Value = statusProgress.Maximum;
                MessageBox.Show("Record created successfully!\nYou may now backup your drive.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearControls();
                this.Close();
            }
            while (this.Size.Height != 269) {
                initHeight--;
                this.Size = new Size(583, initHeight);
                Thread.Sleep(10);
            }
        }


        /// <summary>
        /// Create record for drive
        /// </summary>
        private void createRecord() {
            SqlCeConnection conn = databaseTools.conn;
            SqlCeCommand cmd = conn.CreateCommand();
            DriveInfo drive = USBTools.getDriveObject(drivesDropdown.Text.Substring(0, 1));
            conn.Open();
            statusProgress.Text = "Connection established...";

            cmd.CommandText = "INSERT INTO Drive (ID, Name, Capacity, File_System, Type) VALUES (?,?,?,?,?)";
            cmd.Parameters.Add(new SqlCeParameter("Drive ID", SqlDbType.NText));
            cmd.Parameters.Add(new SqlCeParameter("Drive Name", SqlDbType.NText));
            cmd.Parameters.Add(new SqlCeParameter("Capacity", SqlDbType.BigInt));
            cmd.Parameters.Add(new SqlCeParameter("File System", SqlDbType.NText));
            cmd.Parameters.Add(new SqlCeParameter("Type", SqlDbType.NText));
            cmd.Prepare();
            cmd.Parameters["Drive ID"].Value = USBTools.calculateDriveID(drive);
            cmd.Parameters["Drive Name"].Value = drive.VolumeLabel;
            cmd.Parameters["Capacity"].Value = Convert.ToInt64(drive.TotalSize);
            cmd.Parameters["File System"].Value = drive.DriveFormat;
            cmd.Parameters["Type"].Value = USBTools.getDriveType(drive);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            statusProgress.Text = "Drive Record Created...";

            cmd.CommandText = "INSERT INTO Recordset VALUES (?, ?, ?, ?, ?, ?, ?)";
            cmd.Parameters.Add(new SqlCeParameter("Name", SqlDbType.NText));
            cmd.Parameters.Add(new SqlCeParameter("Drive ID", SqlDbType.NText));
            cmd.Parameters.Add(new SqlCeParameter("Creation Date", SqlDbType.BigInt));
            cmd.Parameters.Add(new SqlCeParameter("Backup Location", SqlDbType.NText));
            cmd.Parameters.Add(new SqlCeParameter("Automatic", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlCeParameter("Compression", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlCeParameter("Previous Backups", SqlDbType.Int));
            cmd.Prepare();
            cmd.Parameters["Name"].Value = backupNameInput.Text;
            cmd.Parameters["Drive ID"].Value = USBTools.calculateDriveID(drive);
            cmd.Parameters["Creation Date"].Value = tools.getUnixTimeStamp();
            cmd.Parameters["Backup Location"].Value = folderPath.Text;
            cmd.Parameters["Automatic"].Value = insertionSwitch.Value;
            cmd.Parameters["Compression"].Value = compressionSwitch.Value;
            cmd.Parameters["Previous Backups"].Value = previousBackupInput.Value;
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            statusProgress.Text = "Recordset created...";
            conn.Close();

        }

        private void insertionSwitch_Click(object sender, EventArgs e) { insertionSwitch.Value = !insertionSwitch.Value; }

        /// <summary>
        /// Display warning for compression time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void unifiedFileSwitch_Click(object sender, EventArgs e) { 
            compressionSwitch.Value = !compressionSwitch.Value;
            if(compressionSwitch.Value) {
                DialogResult result = MessageBox.Show("Compression can take a long time to complete, and your computer will need to be on all this time.\nAre you sure you want to do this?", "Compression Time Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                compressionSwitch.Value = (result == System.Windows.Forms.DialogResult.Yes);
            }
        }
    }
}
