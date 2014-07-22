using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Saviour_Backup_System
{
    public class USBTools
    {
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
