using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saviour_Backup_System
{
    class notificationIcon : IDisposable
    {
        public NotifyIcon notifyIcon = new NotifyIcon() ;
        public ContextMenu contextMenu = new ContextMenu();

        public notificationIcon()
        {
            notifyIcon.Text = "Saviour Backup System";
            notifyIcon.Icon = Properties.Resources.redCDIconICO;
            populateList();
            notifyIcon.ContextMenu = contextMenu;
            notifyIcon.Visible = true; //finally displays the tray icon
        }

        private void populateList() {
            contextMenu.MenuItems.Add("Show Interface", displayWindow);
            contextMenu.MenuItems.Add("Copy Progress", showProgress);
            contextMenu.MenuItems.Add("Exit", closeProgram);
        }

        private void displayWindow(object sender, EventArgs e) { setup.MW.showDisplay(); }
        private void showProgress(object sender, EventArgs e) { return; } //nothing yet!
        private void closeProgram(object sender, EventArgs e) { setup.closeProgram(); }

        public void displayStillRunning() {
            string title = "I'm Still Here!";
            string message = "Saviour Backup System is still running in the background";
            notifyIcon.ShowBalloonTip(2000, title, message, ToolTipIcon.Info);
        }

        public void Dispose()//deconstructor - for memory management
        {
            notifyIcon.Dispose();
            contextMenu.Dispose();
        }
    }
}
