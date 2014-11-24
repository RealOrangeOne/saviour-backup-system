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

        private void createButton_Click(object sender, EventArgs e)
        {
            statusProgress.Text = "Initialising...";
            int initHeight = 299;
            while (this.Size.Height != 330) {
                initHeight++;
                this.Size = new Size(583, initHeight);
                Thread.Sleep(10);
            }
            try { //check validity of input from user

                if ((folderPath.Text == "") || (previousBackupInput.Text == "") || (compressionTypeDropdown.Text == "") || (drivesDropdown.Text == "")){
                    MessageBox.Show("You have not filled in every element, Please try again!", "Not everything is complete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (!Directory.Exists(folderPath.Text) {
                    DialogResult result = MessageBox.Show("The folder path you have entered doesnt exist, would you like to create it?", "Create Folder", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes){
                        try{
                            Directory.CreateDirectory(folderPath.Text);
                        } catch{
                            MessageBox.Show("Error Creating Folder!");
                            return;
                        }
                    } else {
                        return;
                    }
                }
            } finally {
                while (this.Size.Height != 299) {
                    initHeight--;
                    this.Size = new Size(583, initHeight);
                    Thread.Sleep(10);
                }
                statusProgress.ResetText();
                statusProgress.Value = 0;
            }
        }
    }
}
