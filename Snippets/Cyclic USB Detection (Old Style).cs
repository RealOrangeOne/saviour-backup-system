using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace USB_Detection_and_XML_Reading
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] foundDrives= cycleDrivesForFile();
            Console.WriteLine("Cycle Ended!");
            foreach (char drive in foundDrives)
            {
                Console.WriteLine("File found on drive " + drive + ":\\");
            }
            Console.ReadKey();
        }


        static bool fileExists(string driveLetter)
        {
            string path = driveLetter + "config.sbf";
            return File.Exists(path);
        }


        static string[] cycleDrivesForFile()
        {
            /*
            char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            char[] systemDrives = "C".ToCharArray(); //Scan will not look in these drives
            int count = 0;
            
            foreach (char driveLetter in letters)
            {
                if (systemDrives.Contains(driveLetter))
                {
                    continue;
                }
                if (fileExists(driveLetter))
                {
                    foundDrives.Add(driveLetter);
                }
            }
            return foundDrives.ToArray();
             */
            List<string> foundDrives = new List<string>();
            DriveInfo[] driveArray = DriveInfo.GetDrives();
            for (int i = 0; i < driveArray.Count(); i++)
            {
                if (fileExists(driveArray[i].Name))
                {
                    foundDrives.Add(driveArray[i].Name);
                }
                Console.WriteLine("Drive " + i + ": " + driveArray[i].Name);
            }
            return foundDrives.ToArray();
        }
    }
}
