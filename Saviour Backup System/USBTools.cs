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
            scanTimer.Interval = 1000 * 7; //seconds to check for new drives
            scanTimer.Start();
        }
        private static List<string> connectedDrives;
        private static void driveScanTick(object sender, ElapsedEventArgs e)
        {
            List<string> drivesSnapshot = connectedDrives;
            DriveInfo[] drives = getConnectedDrives();
            foreach (DriveInfo drive in drives)
            {
                connectedDrives.Add(drive.VolumeLabel);
            }
            if (connectedDrives.All(item => drivesSnapshot.Contains(item)) &&
                drivesSnapshot.All(item => connectedDrives.Contains(item))) {
                    return;
            } else {
                //check if record exists in database
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
