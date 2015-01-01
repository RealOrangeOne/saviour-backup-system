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
    public partial class backupViewer : Form
    {
        public backupViewer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            dataGridView.DataSource = databaseTools.getAllDriveBackups();
            /*this will need editing to make it more people readable, and format dates etc.*/
        }
    }
}
