﻿using System;
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
        private void clearControls()
        {
            backupNameInput.Text = "";
            drivesDropdown.Text = "";
            compressionTypeDropdown.Text = "";
            insertionSwitch.Value = false;
            unifiedFileSwitch.Value = false;
            previousBackupInput.Value = 0;
            folderPath.Text = "";
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
            DriveInfo drive = USBTools.getDriveObject(drivesDropdown.Text.Substring(0, 1));
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
            } else if (drive.VolumeLabel == ""){
                MessageBox.Show("You cannot backup a drive with no label, please rename it and try again","Can't use default name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                statusProgress.Text = "Initialising database connection...";
                createRecord();
                statusProgress.Text = "Complete!";
                statusProgress.ProgressType = DevComponents.DotNetBar.eProgressItemType.Standard;
                statusProgress.Value = statusProgress.Maximum;
                MessageBox.Show("Record created successfully!\nYou may now backup your drive.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearControls();
                this.Close();
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
            cmd.Parameters["Compression"].Value = unifiedFileSwitch.Value;
            cmd.Parameters["Previous Backups"].Value = previousBackupInput.Value;
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            statusProgress.Text = "Recordset created...";
            conn.Close();
            conn.Dispose();
            this.Close();

        }

        private void insertionSwitch_Click(object sender, EventArgs e) { insertionSwitch.Value = !insertionSwitch.Value; }

        private void unifiedFileSwitch_Click(object sender, EventArgs e) { unifiedFileSwitch.Value = !unifiedFileSwitch.Value; }
    }
}
