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

        /// <summary>
        /// Checks if the database exists, and then pings the connection
        /// </summary>
        public static void init() {
            if (!File.Exists(databaseName)) { //if the database doesnt exists (program hasnt been run before)
                copyDatabase();
            }
            conn.Open();
            conn.Close();
        }

        /// <summary>
        /// Returns the drive name from an ID
        /// </summary>
        /// <param name="id">ID of the drive to search for</param>
        /// <returns></returns>
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

        /// <summary>
        /// Returns the backup directory for a drive
        /// </summary>
        /// <param name="id">ID of the drive to search for</param>
        /// <returns></returns>
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

        /// <summary>
        /// Returns the creation date for a backup directory
        /// </summary>
        /// <param name="id">ID of the drive to search for</param>
        /// <returns></returns>
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

        /// <summary>
        /// Returns what drives are set to back up automatically
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Returns the name of the backup
        /// </summary>
        /// <param name="drive">Drive object to search for</param>
        /// <returns></returns>
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

        /// <summary>
        /// Create a backup record in the database
        /// </summary>
        /// <param name="drive">Drive info object for backup drive</param>
        /// <param name="startDate">Date the backup started (as UNIX timestamp)</param>
        /// <param name="duration">How long the backup took to run (in seconds)</param>
        /// <param name="hash">New hash of the drive</param>
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

        /// <summary>
        /// Returns the most recent hash of a drive
        /// </summary>
        /// <param name="id">ID of drive to search for</param>
        /// <returns></returns>
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


        /// <summary>
        /// Returns if the drive is compressed
        /// </summary>
        /// <param name="id">ID of the drive to search for</param>
        /// <returns></returns>
        public static bool isCompression(string id)
        {
            conn.Open();
            bool compression = false;
            cmd.CommandText = "SELECT Compression FROM Recordset WHERE Drive_ID Like ?;";
            cmd.Parameters.Add(new SqlCeParameter("Drive ID", SqlDbType.NText));
            cmd.Parameters["Drive ID"].Value = id;
            SqlCeDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) {
                compression = reader.GetBoolean(0);
            }
            cmd.Parameters.Clear();
            reader.Close();
            conn.Close();
            return compression;
        }

        /// <summary>
        /// Returns all the drives that have backup records
        /// </summary>
        /// <returns></returns>
        public static DataTable getAllDriveBackups()
        {
            DataTable table = new DataTable();
            conn.Open();
            cmd.CommandText =
                "SELECT Recordset.Name, Recordset.Creation_Date, Recordset.Backup_Location, Drive.Name, Drive.Capacity FROM Recordset, Drive";
            using (SqlCeDataAdapter adapter = new SqlCeDataAdapter(cmd.CommandText, conn)) {
                adapter.Fill(table);
                conn.Close();
                return table;
            }
        }

        /// <summary>
        /// Deletes a drive record from the database
        /// </summary>
        /// <param name="creationDate">Date of drive creation as UNIX timestamp</param>
        public static void deleteDriveRecord(Int64 creationDate) {
            conn.Open();
            cmd.CommandText = "DELETE FROM RecordSet, Drive WHERE Creation_Date=? AND Recordset.Drive_ID = Drive.ID;";
            cmd.Parameters.Add(new SqlCeParameter("Creation Date", SqlDbType.BigInt));
            cmd.Parameters["Creation Date"].Value = creationDate;
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            conn.Close();
        }

        /// <summary>
        /// Update a drive record in the database
        /// </summary>
        /// <param name="backupName">Name of the backup record</param>
        /// <param name="backupLocation">Location to store backup</param>
        /// <param name="automatic">is the backup automatic on insert?</param>
        /// <param name="compression">Will the backup be compressed</param>
        /// <param name="previousBackups">How many previous backups will be stored</param>
        /// <param name="creationDate">Creation date of record</param>
        public static void updateDriveRecord(string backupName, string backupLocation, bool automatic, bool compression, int previousBackups, Int64 creationDate)
        {
            conn.Open();
            cmd.CommandText = "UPDATE Recordset SET Name=?, Backup_Location=?, Automatic=?, Compression=?, Previous_Backups=? WHERE Creation_Date=?;";
            cmd.Parameters.Add(new SqlCeParameter("Backup Name", SqlDbType.NText));
            cmd.Parameters.Add(new SqlCeParameter("Backup Location", SqlDbType.NText));
            cmd.Parameters.Add(new SqlCeParameter("Automatic", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlCeParameter("Compression", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlCeParameter("Previous Backups", SqlDbType.Int));
            cmd.Parameters.Add(new SqlCeParameter("Creation Date", SqlDbType.BigInt));

            cmd.Parameters["Backup Name"].Value = backupName;
            cmd.Parameters["Backup Location"].Value = backupLocation;
            cmd.Parameters["Automatic"].Value = automatic;
            cmd.Parameters["Compression"].Value = compression;
            cmd.Parameters["Previous Backups"].Value = previousBackups;
            cmd.Parameters["Creation Date"].Value = creationDate;

            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            conn.Close();
        }
    }
}
