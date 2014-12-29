﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Saviour_Backup_System
{
    public partial class currentTransfers : Form
    {
        public List<CopyFiles.CopyFiles> copyFilesList = new List<CopyFiles.CopyFiles>();
        public List<transferWindow> transfersList = new List<transferWindow>();
        public List<DevComponents.DotNetBar.Controls.ProgressBarX> progressBars = new List<DevComponents.DotNetBar.Controls.ProgressBarX>();
        public int backups = -1; //used for index in arrays

        public currentTransfers() {
            InitializeComponent();
        }

        public void startCopy(DriveInfo drive, string endDirectory, bool visible) { //used for validation to make sure the copy wont fail.
            if (!Directory.Exists(drive.Name)) { MessageBox.Show("The drive directory does not exist."); }

            else if (!Directory.Exists(endDirectory)) { MessageBox.Show("The end directory does not exist."); }

            else { //error checking is done (just in case something slips through.
                string hash = tools.hashDirectory(drive.Name);
                string DBHash = databaseTools.getHashofRecentBackup(USBTools.calculateDriveID(drive)); //get the hash from the database
                if (DBHash == "NONE") {
                    if (DBHash == hash) { //if the hash in the database matches the drive, don't backup because nothing will have changed.
                        MessageBox.Show("No changes have been made to files on drive " + drive.VolumeLabel + ", Will not backup.", "No Changes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    } else { //The actual backup case
                        databaseTools.createBackupRecord(drive, tools.getUnixTimeStamp(), 0L, hash);
                        copyFiles(drive.Name.Substring(0, 1), endDirectory, visible, drive);
                    }
                } else {
                    MessageBox.Show("An error occured when checking the drive. Please try again.", "Hash Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void copyFiles(string driveLetter, string endDirectory, bool display, DriveInfo drive) //actually starts the backups (and loads the dialogs)
        {
            backups++; //appends to the number of backups running
            progressBars.Add(new copyProgressBar());
            layoutPanel.Controls.Add(new copyProgressLabel());
            layoutPanel.Controls.Add(progressBars[backups]);


            copyFilesList.Add(new CopyFiles.CopyFiles(driveLetter + ":\\", endDirectory));

            transfersList.Add(new transferWindow(backups, drive));
            transfersList[backups].SynchronizationObject = this;
            copyFilesList[backups].CopyAsync(transfersList[backups]);

            if (!display) { transfersList[backups].Hide(); } //if it is a startup backup process, dont display the dialog.
        }

        private class copyProgressLabel : Label {
            public copyProgressLabel()
            {
                base.InitLayout();
                this.Font = new Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.Text = "Content";
                this.Margin = new Padding(20, 3, 0, 0);
            }
        }

        private class copyProgressBar : DevComponents.DotNetBar.Controls.ProgressBarX
        {
            public copyProgressBar()
            {
                base.InitLayout();
                this.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
                this.Text = "Backup in Progress";
                this.TextVisible = true;
                this.Size = new Size(567, 27);
                this.Margin = new Padding(12, 0, 0, 17);
                this.ColorTable = DevComponents.DotNetBar.eProgressBarItemColor.Paused;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Starting...");
            startCopy(USBTools.getDriveObject("F"), "E:\\Temp\\CopyTemp", true);
            MessageBox.Show("Process Complete!");
        }

        private void currentTransfers_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
