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
        public transferWindow()
        {
            InitializeComponent();
        }
        public void update(Int32 totalFiles, Int32 copiedFiles, Int64 totalBytes, Int64 copiedBytes, string currentFilename)
        {
            totalFilesProgress.Maximum = totalFiles;
            totalFilesProgress.Value = copiedFiles;
            currentFileProgress.Maximum = 100; //so its a percentage, might make it more accurate.

            if (totalBytes != 0) {
                currentFileProgress.Value = Convert.ToInt32((100f / (totalBytes / 1024f)) * (copiedBytes / 1024f));
            }
            totalFilesProgress.Text = "Copying File " + copiedFiles + " of " + totalFiles + ".";
            currentFile.Text = currentFilename;
        }

        public void cancelCopy() {
            if (EN_cancelCopy != null) { EN_cancelCopy(); }
        }

        public event CopyFiles.CopyFiles.DEL_cancelCopy EN_cancelCopy;

        private void button1_Click(object sender, EventArgs e)
        {
            cancelCopy();
        }
    }
}
