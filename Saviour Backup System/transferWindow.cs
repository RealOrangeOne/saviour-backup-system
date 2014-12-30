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
using System.Diagnostics;
using CopyFiles;


namespace Saviour_Backup_System
{
    public partial class transferWindow : Form, CopyFiles.ICopyFilesDiag, IDisposable
    {
        public System.ComponentModel.ISynchronizeInvoke SynchronizationObject { get; set; }
        private int arrayIndex;
        public Int64 startTime = tools.getUnixTimeStamp(); //snapshots it.
        private DriveInfo copyingDrive;
        private Stopwatch SW = new Stopwatch();
        string driveHash;
        bool finalised = false;
        public transferWindow(int backups, DriveInfo drive, string hash) {
            driveHash = hash;
            copyingDrive = drive;
            InitializeComponent();
            arrayIndex = backups;
            currentFileProgress.Maximum = 1000;
            SW.Start(); //starts the stopwatch to count how long the copy takes
        }

        private void finaliseCopy() {
            SW.Stop(); //stops the stopwatch. Is done a little too early, but it's good enough!
            databaseTools.createBackupRecord(copyingDrive, startTime, SW.Elapsed.Seconds, driveHash);
            setup.CT.progressBars[arrayIndex].ColorTable = DevComponents.DotNetBar.eProgressBarItemColor.Normal;
            setup.CT.progressBars[arrayIndex].Value = 100;
            setup.CT.progressBars[arrayIndex].Maximum = 100;
            setup.CT.progressBars[arrayIndex].Text = "Complete!";
            finalised = true;
        }

        public void update(Int32 totalFiles, Int32 copiedFiles, Int64 totalBytes, Int64 copiedBytes, string currentFilename)
        {
            totalFilesProgress.Maximum = totalFiles;
            totalFilesProgress.Value = copiedFiles;

            if (totalBytes != 0) {
                currentFileProgress.Value = Convert.ToInt32((1000f / (totalBytes / 1024f)) * (copiedBytes / 1024f));
            }
            totalFilesProgress.Text = "Copying Bytes " + copiedFiles + " of " + totalFiles + ".";
            currentFile.Text = currentFilename;
            setup.CT.progressBars[arrayIndex].Value = totalFilesProgress.Value;
            setup.CT.progressBars[arrayIndex].Maximum = totalFiles;
            setup.CT.progressBars[arrayIndex].Text = "Copying " + (copiedBytes / 1024f).ToString() + " of " + (totalBytes / 1024f).ToString();
            int percentage = ((totalFiles + 1) / (copiedFiles + 1)) * 10000;
            if (percentage >= 9999 && !finalised)
            {
                finaliseCopy();
            }
        }

        public void cancelCopy() {
            if (EN_cancelCopy != null) { EN_cancelCopy(); }
        }

        public event CopyFiles.CopyFiles.DEL_cancelCopy EN_cancelCopy;

        private void button1_Click(object sender, EventArgs e)
        {
            cancelCopy();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
