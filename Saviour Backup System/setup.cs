using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlServerCe;


namespace Saviour_Backup_System
{
    class setup
    {
        public static void initProgram()
        {
            return; // Stops the code running while testing.

            string databaseName = databaseTools.databaseName;
            if (File.Exists(databaseName)) { return; } // If the program has been run before, then the database will exist, so use that to test it.

            SqlCeEngine SQLEngine = new SqlCeEngine("Data Source = " + databaseName);
            SQLEngine.CreateDatabase(); //Creates the database if it doesnt exist already

            SqlCeConnection conn = new SqlCeConnection("Data Source = " + databaseName);
            conn.Open();
            SqlCeCommand cmd = conn.CreateCommand();

            cmd.CommandText = "CREATE TABLE Rules (%%);"; //Fill these in! (Before running)
            cmd.ExecuteNonQuery();

            cmd.CommandText = "CREATE TABLE Properties (Property NTEXT PRIMARY KEY, value NTEXT);"; //Fill this one in too
            cmd.ExecuteNonQuery();

            fillDatabase(cmd, conn);
        }
        private static void fillDatabase(SqlCeCommand cmd, SqlCeConnection conn)
        {
            cmd.CommandText = "INSERT INTO Properties VALUES (?,?);";
            cmd.Parameters.Add(new SqlCeParameter("PROPERTY", SqlDbType.Int));
            cmd.Parameters.Add(new SqlCeParameter("VALUE", SqlDbType.NText));

            cmd.Parameters["PROPERTY"].Value = "Startup";
            cmd.Parameters["VALUE"].Value = "FALSE";
            cmd.ExecuteNonQuery();

            cmd.Parameters["PROPERTY"].Value = "";
            cmd.Parameters["VALUE"].Value = "";
            cmd.ExecuteNonQuery();

        }
    }
}
