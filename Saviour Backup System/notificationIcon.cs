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
        internal static NotifyIcon notifyIcon;
        internal static ContextMenu contextMenu;

        internal static void init()
        {
            contextMenu = new ContextMenu();
            contextMenu.MenuItems.Add("Show Interface", displayWindow);

            notifyIcon = new NotifyIcon();
            notifyIcon.Text = "Saviour Backup System";
            notifyIcon.Icon = Properties.Resources.redCDIconICO;

            notifyIcon.ContextMenu = contextMenu;
            notifyIcon.Visible = true; //finally displays the tray icon
        }

        private static void displayWindow(object sender, EventArgs e)
        {
            setup.MW.Show();
        }
    }
}
