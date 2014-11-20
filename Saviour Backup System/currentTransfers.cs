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
        public currentTransfers()
        {
            InitializeComponent();
        }

        private void copyFiles(string startDirectory, string endDirectory)
        {
            CopyFiles.CopyFiles Temp = new CopyFiles.CopyFiles(startDirectory, endDirectory);

            transferWindow copyDiag = new transferWindow();
            copyDiag.
        }
    }
}
