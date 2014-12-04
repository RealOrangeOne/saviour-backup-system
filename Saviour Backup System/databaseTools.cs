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

        public static string[] getBackupDirectory(string id)
        {
            conn.Open();
            cmd.CommandText = "SELECT Backup_Location FROM Recordset WHERE Drive_ID = ?";
            cmd.Parameters.Add(new SqlCeParameter("Drive_ID", SqlDbType.NText));
            cmd.Parameters["Drive_ID"].Value = id;
            SqlCeDataReader reader = cmd.ExecuteReader();
        }

        public static string[] getAutomaticBackups()
        {
            conn.Open();
            List<string> IDs = new List<string>();
            cmd.CommandText = "SELECT Drive_ID FROM Recordset WHERE Automatic = 1;";
            SqlCeDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                string DriveID = reader.GetString(0);
                IDs.Add(DriveID);
            }
            reader.Close();
            conn.Close();
            return IDs.ToArray();
        }
    }
}
