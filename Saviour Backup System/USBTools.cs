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
        public DriveInfo[] getConnectedDrives()
        {
            List<DriveInfo> drivesList = new List<DriveInfo>();
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives) {
                try {
                    string driveName = drive.VolumeLabel;
                    string driveLetter = drive.Name;
                } catch { // If there is a problem getting the drive data, then the program would crash!
                    continue;
                }
                drivesList.Add(drive);
            }
            return drivesList.ToArray(); 
        }
    }
}
