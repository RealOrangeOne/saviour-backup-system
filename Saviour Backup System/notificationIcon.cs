using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saviour_Backup_System
{
    class notificationIcon
    {
        internal NotifyIcon notifyIcon = new NotifyIcon() ;
        internal ContextMenu contextMenu = new ContextMenu();

        internal notificationIcon()
        {
            notifyIcon.Text = "Saviour Backup System";
            notifyIcon.Icon = Properties.Resources.redCDIconICO;
            populateList();
            notifyIcon.ContextMenu = contextMenu;
            notifyIcon.Visible = true; //finally displays the tray icon
        }

        private void populateList()
        {
            contextMenu.MenuItems.Add("Show Interface", displayWindow);
            contextMenu.MenuItems.Add("Copy Progress", showProgress);
            contextMenu.MenuItems.Add("Exit", closeProgram);
        }

        private void displayWindow(object sender, EventArgs e) { setup.MW.showDisplay(); }
        private void showProgress(object sender, EventArgs e) { return; }
        private void closeProgram(object sender, EventArgs e) { setup.closeProgram(); }

        internal void displayStillRunning() {

        }
    }
}
