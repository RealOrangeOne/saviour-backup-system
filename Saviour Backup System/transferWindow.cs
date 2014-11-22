using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CopyFiles;


namespace Saviour_Backup_System
{
    public partial class transferWindow : Form, CopyFiles.ICopyFilesDiag
    {
        public System.ComponentModel.ISynchronizeInvoke SynchronizationObject { get; set; }
        int arrayIndex;
        public transferWindow(int backups)
        {
            InitializeComponent();
            arrayIndex = backups;
            currentFileProgress.Maximum = 1000;
        }
        public void update(Int32 totalFiles, Int32 copiedFiles, Int64 totalBytes, Int64 copiedBytes, string currentFilename)
        {
            totalFilesProgress.Maximum = totalFiles;
            totalFilesProgress.Value = copiedFiles;

            if (totalBytes != 0) {
                currentFileProgress.Value = Convert.ToInt32((1000f / (totalBytes / 1024f)) * (copiedBytes / 1024f));
            }
            totalFilesProgress.Text = "Copying File " + copiedFiles + " of " + totalFiles + ".";
            currentFile.Text = currentFilename;
            setup.CT.progressBars[arrayIndex].Value = totalFilesProgress.Value;
            setup.CT.progressBars[arrayIndex].Maximum = totalFiles;
            setup.CT.progressBars[arrayIndex].Text = "Copying " + (copiedBytes / 1024f).ToString() + " of " + (totalBytes / 1024f).ToString();

            if (setup.MW.selectedDrive.Name.Substring(0, 1) == currentFilename.Substring(0, 1)) { 
                setup.MW.backupProgress.Value = totalFilesProgress.Value;
                setup.MW.backupProgress.Maximum = totalFiles;
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
