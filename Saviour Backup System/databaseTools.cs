using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.Data;
using System.IO;
using Saviour_Backup_System.Properties;

namespace Saviour_Backup_System
{
    class databaseTools
    {
        public static string databaseName = "saviour.sdf";
        public static SqlCeConnection conn = new SqlCeConnection("Data Source = " + databaseName + "; password=12a712d7e6f71ed07822c219318da2c0"); //password is a hash
        private static SqlCeCommand cmd = conn.CreateCommand();

        private static void copyDatabase()
        {
            File.WriteAllBytes(@"" + databaseName, Resources.saviour); //copy file from resources to project file
        }


        public static void init() {
            if (!File.Exists(databaseName)) { //if the database doesnt exists (program hasnt been run before)
                copyDatabase();
            }
        }
        public static backup[] getBackups()
        {
            List<backup> backups = null;
            conn.Open();
            cmd.CommandText = "";
            SqlCeDataReader reader = cmd.ExecuteReader();
            int index = 0;
            while (reader.Read())
            {
                backup temp = new backup();
                backups.Add(temp);
                temp = null;
                index++;
            }
            if (backups == null)
            {
                return new backup[0];
            }
            return backups.ToArray();
        }

    }


    class backup
    {
        public string driveID;
        public string name;
        public Int64 startDate;
        public string hash;
        public Int32 duration;

        public void store()
        {
            SqlCeCommand cmd = databaseTools.conn.CreateCommand();
            cmd.CommandText = "";
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }

        public void update()
        {
            databaseTools.conn.Open();
            SqlCeCommand cmd = databaseTools.conn.CreateCommand();
            cmd.CommandText = "";
            //execute reader or whatever it is
            databaseTools.conn.Close();
            cmd.Dispose();
        }

        public void create(string Drive_ID, string Backup_Name, Int64 Start_Date, string Hash, Int32 Duration ) {
            driveID = Drive_ID;
            name = Backup_Name;
            startDate = Start_Date;
            hash = Hash;
            duration = Duration;
        }
    }


}
