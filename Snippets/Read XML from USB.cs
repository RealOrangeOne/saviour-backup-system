using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace Read_USB_XML
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            for (int i = 0; i < drives.Count(); i++)
            {
                string driveName;
                string driveLetter;
                try //if the volume label is invalid (CD Drive in laptop), then the program crashes
                {
                    driveName = drives[i].VolumeLabel;
                    driveLetter = drives[i].Name;
                } catch {
                    continue;
                }
                if (driveName == "")
                {
                    driveName = "Unnamed Volume";
                }
                Console.WriteLine("Drive " + i + ": " + driveLetter + ". Drive Label: " + driveName);
            }
            Console.ReadKey();
        }
    }
}
