using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Windows.Forms;


namespace Saviour_Backup_System
{
    class setup
    {
        public static string[] runtimeArguements = null;
        public static mainWindow MW;
        public static notificationIcon icon;
        public static addBackupWizard ABW;
        public static splashScreen SS;
        public static currentTransfers CT = new currentTransfers();
        public static string username = Environment.UserName; //snapshots the username

        public static void initProgram(string[] args) {
            runtimeArguements = args;

            SS = new splashScreen(); //displays the splash screen
            SS.description.Text = "From Setup...";
            //run any initialising code here!
            SS.Close();

            icon = new notificationIcon();
            MW = new mainWindow();
            Application.Run(MW);
        }

        private static void startupBackups() {
            return;
        }

        public static void closeProgram() {
            string exitMessage = "Are you sure you want to close Saviour Backup System?\nAll copying backups and backup scanning will cease.";
            DialogResult result = MessageBox.Show(exitMessage, "Saviour Backup System Exiting...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == System.Windows.Forms.DialogResult.Yes) {
                icon.notifyIcon.Dispose();
                MW.removeDisplay();
                Environment.Exit(0);
            }
        }
    }
}
