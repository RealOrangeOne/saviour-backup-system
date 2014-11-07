using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.Data;
using System.IO;

namespace Saviour_Backup_System
{
    class database
    {
        internal static string databaseName = "db.sdf";
        private static SqlCeConnection conn = new SqlCeConnection("Data Source = " + databaseName);
        private static SqlCeCommand cmd = conn.CreateCommand();

        internal static void setup(){
            SqlCeEngine SQLEngine = new SqlCeEngine("Data Source = " + databaseName);
            SQLEngine.CreateDatabase(); //Creates the database if it doesnt exist already
            SQLEngine.Dispose();

            createTables();
            fillProperties();
        }
        private static void fillProperties() {   
            conn.Open();
            
            cmd.CommandText = "INSERT INTO Properties VALUES (?,?);";
            cmd.Parameters.Add(new SqlCeParameter("PROPERTY", SqlDbType.Int));
            cmd.Parameters.Add(new SqlCeParameter("VALUE", SqlDbType.NText));

            cmd.Parameters["PROPERTY"].Value = "Startup";
            cmd.Parameters["VALUE"].Value = "FALSE";
            cmd.ExecuteNonQuery();

            cmd.Parameters["PROPERTY"].Value = "Save_Location";
            string saveLocation;
            string username = Environment.UserName;
            switch (OSInfo.Name)
            {
                case("Windows XP"):
                    saveLocation = @"C:\Documents and Settings\" + username + @"\Saviour Backup System\My Backups\";
                    break;
                case("Windows Vista"):
                    saveLocation = @"C:\Users\" + username + @"\Saviour Backup System\My Backups\";
                    break;
                default:
                    saveLocation = @"C:\";
                    break;
            }
            cmd.Parameters["VALUE"].Value = "";
            cmd.ExecuteNonQuery();

            cmd.Parameters["PROPERTY"].Value = "Window_Style";
            cmd.Parameters["VALUE"].Value = "Office2010Black";
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        private static void createTables()
        {
            conn.Open();

            cmd.CommandText = "CREATE TABLE RecordSet (ID NTEXT PRIMARY KEY, Drive_Name NTEXT, Capacity INTEGER, File_System NTEXT, Type NTEXT);";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "CREATE TABLE Properties (Property NTEXT PRIMARY KEY, value NTEXT);";
            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}
