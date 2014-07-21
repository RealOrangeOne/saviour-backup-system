using System;
using System.Collections;
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
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();
            ListViewItem item1 = new ListViewItem("Something");
            item1.SubItems.Add("SubItem1a");
            item1.SubItems.Add("SubItem1b");
            listViewEx1.Items.AddRange(new ListViewItem[] { item1});
        }
    }
}
