using System;
using System.Collections.Generic;
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
    public partial class addBackupWizard : Form
    {
        private string folderPath = "";
        public addBackupWizard()
        {
            InitializeComponent();
            populateDropdown();            
        }

        private void directoryBrowseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                folderPath = folderBrowserDialog.SelectedPath;
            }
            folderBrowserDialog.Dispose(); //memory management
        }

        private void populateDropdown()
        {
            DriveInfo[] drives = USBTools.getConnectedDrives();
            foreach (DriveInfo drive in drives)
            {
                drivesDropdown.Items.Add(drive.VolumeLabel);
            }
        }
    }
}
