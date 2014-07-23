using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Timers;
using System.Data.SqlClient;

namespace Saviour_Backup_System
{
    public class USBTools
    {
        public static void initDriveScan(){
            Timer scanTimer = new Timer();
            scanTimer.Elapsed += new ElapsedEventHandler(driveScanTick);
            scanTimer.Interval = 5000;
            scanTimer.Start();
        }
        private static void driveScanTick(object sender, ElapsedEventArgs e)
        {
            DriveInfo[] drives = getConnectedDrives();
            foreach (DriveInfo drive in drives)
            {
                //open database, check if record backup record exists. If so, then run backup procedure in seperate thread
            }
        }
        public static DriveInfo[] getConnectedDrives()
        {
            List<DriveInfo> drivesList = new List<DriveInfo>();
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives) {
                try {
                    string driveName = drive.VolumeLabel;
                    string driveLetter = drive.Name;
                } catch { continue; }
                drivesList.Add(drive);
            }
            return drivesList.ToArray(); 
        }
        public void safelyEjectDrive(string driveChar)
        {
            driveChar = driveChar.Remove(driveChar.Length - 1);
            RemoveDriveTools.RemoveDrive(driveChar);
        }
    }
}
