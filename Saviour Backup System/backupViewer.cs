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
        public backupViewer() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            DataTable table = databaseTools.getAllDriveBackups();
            for (int i = 0; i > table.Rows.Count; i++) {
                table.Rows[i].SetField(1, tools.unixDateTime( (long)table.Rows[i][1] ).ToString()); //convert time to better format
                table.Rows[i].SetField(4, ((float)table.Rows[i][1] * 1024f * 1024f).ToString() + " MB"); //format to megabytes
            }

            table.Columns[0].ColumnName = "Backup Name";
            table.Columns[1].ColumnName = "Creation Date";
            table.Columns[2].ColumnName = "Backup Location";
            table.Columns[3].ColumnName = "Drive Label";
            table.Columns[4].ColumnName = "Drive Capacity";

            dataGridView.DataSource = table; // add table to display

        }

        private void button2_Click(object sender, EventArgs e){ dataGridView.SelectAll(); }
    }
}
