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

        private static void copyDatabase() { File.WriteAllBytes(@"" + databaseName, Resources.saviour); } //copy the file from resources


        public static void init() {
            if (!File.Exists(databaseName)) { //if the database doesnt exists (program hasnt been run before)
                copyDatabase();
            }
            conn.Open();
            conn.Close();
        }

        public static string getDriveName(string id) {
            string name = "NONE";
            conn.Open();
            cmd.CommandText = "SELECT Name FROM Drive WHERE ID LIKE ?;";
            cmd.Parameters.Add(new SqlCeParameter("Drive_ID", SqlDbType.NText));
            cmd.Parameters["Drive_ID"].Value = id;
            SqlCeDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) { name = reader.GetString(0); }
            conn.Close();
            reader.Close();
            cmd.Parameters.Clear();
            return name;
        }

        public static string getBackupDirectory(string id) {
            string directory = "NONE";
            conn.Open();
            cmd.CommandText = "SELECT Backup_Location FROM Recordset WHERE Drive_ID LIKE ?";
            cmd.Parameters.Add(new SqlCeParameter("Drive_ID", SqlDbType.NText));
            cmd.Parameters["Drive_ID"].Value = id;
            try {
                SqlCeDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) { directory = reader.GetString(0); }
                reader.Close(); 
            } catch { }
            conn.Close();
            cmd.Parameters.Clear();
            return directory;
        }

        public static Int64 getBackupCreationDate(string id)
        {
            Int64 date = 0;
            conn.Open();
            cmd.CommandText = "SELECT Creation_Date FROM Recordset WHERE Drive_ID LIKE ?";
            cmd.Parameters.Add(new SqlCeParameter("Drive ID", SqlDbType.NText));
            cmd.Parameters["Drive ID"].Value = id;
            try
            {
                SqlCeDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) { date = reader.GetInt64(0); }
                reader.Close();
            }
            catch { }
            conn.Close();
            cmd.Parameters.Clear();
            return date;
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

        public static string getBackupName(DriveInfo drive)
        {
            string name = "";
            conn.Open();
            cmd.CommandText = "SELECT Name FROM Recordset WHERE Drive_ID LIKE ?;";
            cmd.Parameters.Add(new SqlCeParameter("Drive ID", SqlDbType.NText));
            cmd.Parameters["Drive ID"].Value = USBTools.calculateDriveID(drive);
            SqlCeDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                name = reader.GetString(0);
            }
            cmd.Parameters.Clear();
            reader.Close();
            conn.Close();
            return name;
        }

        public static void createBackupRecord(DriveInfo drive, Int64 startDate, Int64 duration, string hash)
        {
            string id = USBTools.calculateDriveID(drive);
            string backupName = getBackupName(drive);
            conn.Open();
            cmd.CommandText = "INSERT INTO Backups VALUES (?,?,?,?,?);";
            cmd.Parameters.Add(new SqlCeParameter("Drive ID", SqlDbType.NText));
            cmd.Parameters.Add(new SqlCeParameter("Start Date", SqlDbType.BigInt));
            cmd.Parameters.Add(new SqlCeParameter("Backup Name", SqlDbType.NText));
            cmd.Parameters.Add(new SqlCeParameter("Hash", SqlDbType.NText));
            cmd.Parameters.Add(new SqlCeParameter("Duration", SqlDbType.Int));

            cmd.Parameters["Drive ID"].Value = id;
            cmd.Parameters["Start Date"].Value = startDate;
            cmd.Parameters["Backup Name"].Value = backupName;
            cmd.Parameters["Hash"].Value = hash;
            cmd.Parameters["Duration"].Value = (int)duration;
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            conn.Close();
        }


        public static string getHashofRecentBackup(string id)
        {
            conn.Open();
            string hash = "NONE";
            cmd.CommandText = "SELECT Hash FROM Backups WHERE Drive_ID Like ?;";
            cmd.Parameters.Add(new SqlCeParameter("Drive ID", SqlDbType.NText));
            cmd.Parameters["Drive ID"].Value = id;
            SqlCeDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) {
                hash = reader.GetString(0);
            }
            cmd.Parameters.Clear();
            reader.Close();
            conn.Close();
            return hash;
        }
    }
}
