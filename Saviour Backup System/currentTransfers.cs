using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saviour_Backup_System
{
    public partial class currentTransfers : Form
    {
        public List<CopyFiles.CopyFiles> copyFilesList = new List<CopyFiles.CopyFiles>();
        public List<transferWindow> transfersList = new List<transferWindow>();
        public List<DevComponents.DotNetBar.Controls.ProgressBarX> progressBars = new List<DevComponents.DotNetBar.Controls.ProgressBarX>();
        public int backups = -1; //used for index in arrays

        public currentTransfers()
        {
            InitializeComponent();
        }

        private void copyFiles(string driveLetter, string endDirectory, bool display) //actually starts the backups (and loads the dialogs)
        {
            backups++; //appends to the number of backups running
            copyFilesList.Add(new CopyFiles.CopyFiles(driveLetter + ":\\", endDirectory));

            transfersList.Add(new transferWindow());
            transfersList[backups].SynchronizationObject = this;
            copyFilesList[backups].CopyAsync(transfersList[backups]);
            if (!display) { transfersList[backups].Hide(); }
        }

        private void currentTransfers_Load(object sender, EventArgs e)
        {
            foreach (DevComponents.DotNetBar.Controls.ProgressBarX PB in progressBars) { PB.Dispose(); }
            for (int i = 0; i < backups; i++)
            {
                progressBars.Add(new DevComponents.DotNetBar.Controls.ProgressBarX());
                progressBars[i] = progressTemplate;
                progressBars[i].Location = new Point(12, (30 * i) + 59);
            }
        }

    }
}
