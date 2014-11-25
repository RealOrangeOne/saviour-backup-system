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

        private void createButton_Click(object sender, EventArgs e) {
            if ((folderPath.Text == "") || (previousBackupInput.Text == "") || (compressionTypeDropdown.Text == "") || (drivesDropdown.Text == "")){
                    MessageBox.Show("You have not filled in every element, Please try again!", "Not everything is complete", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void createRecord()
        {
            SqlCeConnection conn = databaseTools.conn;
            SqlCeCommand cmd = conn.CreateCommand();
            conn.Open();

            conn.Close();
            MessageBox.Show("Record created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
