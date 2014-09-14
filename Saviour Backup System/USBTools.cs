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
    class USBTools
    {
        internal static void initDriveScan(){
            Timer scanTimer = new Timer();
            scanTimer.Elapsed += new ElapsedEventHandler(driveScanTick);
            scanTimer.Interval = 1000 * 7; //seconds to check for new drives
            scanTimer.Start();
        }
        private static List<string> connectedDrives = null;
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
        internal static DriveInfo[] getConnectedDrives()
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


        internal static void safelyEjectDrive(string driveChar)
        {
            driveChar = driveChar.Remove(driveChar.Length - 1);
            RemoveDriveTools.RemoveDrive(driveChar);
        }


        internal static string getDriveType(DriveInfo selectedDrive)
        {
            string driveTypeDecoded = "Error decoding drive details!";
            switch (selectedDrive.DriveType)
            {
                case DriveType.CDRom:
                    driveTypeDecoded = "Optical Disk Drive";
                    break;
                case DriveType.Fixed:
                    driveTypeDecoded = "Fixed Disk Drive";
                    break;
                case DriveType.Network:
                    driveTypeDecoded = "Network Drive";
                    break;
                case DriveType.NoRootDirectory:
                    driveTypeDecoded = "Drive Without Root Directory";
                    break;
                case DriveType.Ram:
                    driveTypeDecoded = "RAM Drive";
                    break;
                case DriveType.Removable:
                    driveTypeDecoded = "Removable Drive";
                    break;
                case DriveType.Unknown:
                    driveTypeDecoded = "Unknown";
                    break;
            }
            return driveTypeDecoded;
        }


        internal static int countDrives()
        {
            int numberofDrives = 0;
            foreach (DriveInfo drive in getConnectedDrives()) { numberofDrives++; }
            return numberofDrives;
        }


        internal static int spacePercentage(DriveInfo drive)
        {
            double capacity = (double)(drive.TotalSize / (1024 * 1024));
            double free = (double)(drive.AvailableFreeSpace / (1024 * 1024));
            double answer = (10000 - ((free / capacity) * 10000));
            return (int)answer;
        }
    }
}
