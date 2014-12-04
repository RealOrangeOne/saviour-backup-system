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
        private string defaultText;
        public addBackupWizard()
        {
            InitializeComponent();
            populateDropdown();
            defaultText = introTextBox.Text; //stores it so we can append to the end at runtime
            this.Size = new Size(583, 299);
        }

        private void directoryBrowseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                folderPath.Text = folderBrowserDialog.SelectedPath;
            }
            folderBrowserDialog.Dispose(); //memory management
        }

        private void populateDropdown()
        {
            DriveInfo[] drives = USBTools.getConnectedDrives();
            foreach (DriveInfo drive in drives)
            {
                drivesDropdown.Items.Add(drive.Name + " " + drive.VolumeLabel);
            }
        }
        private void lockControls(bool state)
        {
            backupNameInput.ReadOnly = state;
            drivesDropdown.Enabled = !state;
            compressionTypeDropdown.Enabled = !state;
            insertionSwitch.IsReadOnly = state;
            unifiedFileSwitch.IsReadOnly = state;
            previousBackupInput.Enabled = !state;
            folderPath.ReadOnly = state;
        }
        private void createButton_Click(object sender, EventArgs e) {
            lockControls(true);
            if ((folderPath.Text == "") || (previousBackupInput.Text == "") || (compressionTypeDropdown.Text == "") || (drivesDropdown.Text == "") || (backupNameInput.Text == "")) {
                    MessageBox.Show("You have not filled in every element, Please try again!", "Not everything is complete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lockControls(false);
                    return;
            }

            statusProgress.Text = "Initialising...";
            int initHeight = 299;
            while (this.Size.Height != 330) {
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
            }

            else if (compressionTypeDropdown.Text == "None" && unifiedFileSwitch.Value == true) {
                MessageBox.Show("You cannot have a unified file without some form of compression, please select again.", "Compression Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                createRecord();
            }
            while (this.Size.Height != 299) {
                initHeight--;
                this.Size = new Size(583, initHeight);
                Thread.Sleep(10);
            }
        }

        private void createRecord() {
            SqlCeConnection conn = databaseTools.conn;
            SqlCeCommand cmd = conn.CreateCommand();
            DriveInfo drive = USBTools.getDriveObject(drivesDropdown.Text.Substring(0, 1));
            conn.Open();

            cmd.CommandText = "INSERT INTO Drive (ID, Name, Capacity, File_System, Type) VALUES (?,?,?,?,?)";
            cmd.Parameters.Add(new SqlCeParameter("Drive ID", SqlDbType.NText));
            cmd.Parameters.Add(new SqlCeParameter("Drive Name", SqlDbType.NText));
            cmd.Parameters.Add(new SqlCeParameter("Capacity", SqlDbType.Int));
            cmd.Parameters.Add(new SqlCeParameter("File System", SqlDbType.NText));
            cmd.Parameters.Add(new SqlCeParameter("Type", SqlDbType.NText));
            cmd.Prepare();
            cmd.Parameters["Drive ID"].Value = USBTools.calculateDriveID(drive);
            cmd.Parameters["Drive Name"].Value = drive.VolumeLabel;
            cmd.Parameters["Capacity"].Value = drive.TotalSize;
            cmd.Parameters["File System"].Value = drive.DriveFormat;
            cmd.Parameters["Type"].Value = USBTools.getDriveType(drive);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();

            cmd.CommandText = "INSERT INTO Recordset (Name, Drive_ID, Creation_Date, Backup_Location, Automatic, Compression, Previous_Backups) VALUES (?, ?, ?, ?, ?, ?, ?)";
            cmd.Parameters.Add(new SqlCeParameter("Name", SqlDbType.Int));
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
            cmd.Parameters["Automatic"].Value = (insertionSwitch.Value) ? 1 : 0; //hopefully this is converted to a bit properly by SQLCE!
            cmd.Parameters["Compression"].Value = (unifiedFileSwitch.Value) ? 1 : 0;
            cmd.Parameters["Previous Backups"].Value = previousBackupInput.Value;
            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();
            MessageBox.Show("Record created successfully!\nYou may now backup your drive.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();
            conn.Dispose();
            this.Close();

        }
    }
}
