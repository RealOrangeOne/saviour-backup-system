using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace Saviour_Backup_System
{
    class setup
    {
        static string databaseName = database.databaseName;
        internal static string[] runtimeArguements = null;
        internal static mainWindow MW;
        internal static notificationIcon icon;

        internal static void initProgram(string[] args)
        {
            runtimeArguements = args;

            icon = new notificationIcon();
            MW = new mainWindow();
            Application.Run(MW);
           
            //if (!File.Exists(databaseName)) { setupDatabase(); } // If the program has been run before, then the database will exist, so use that to test it.
        }

       

        internal static void closeProgram()
        {
            string exitMessage = "Are you sure you want to close Saviour Backup System? \n All copying backups and backup scanning will cease.";
            DialogResult result = MessageBox.Show(exitMessage, "Saviour Backup System Exiting...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if ( result == System.Windows.Forms.DialogResult.Yes) { Application.Exit(); }
        }
    }
}
