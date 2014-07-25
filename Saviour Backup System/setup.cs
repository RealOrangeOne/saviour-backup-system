using System;
using System.Collections.Generic;
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
            string databaseName = databaseTools.databaseName;
            if (File.Exists(databaseName)) { return; } // If the program has been run before, then the database will exist, so use that to test it.
            SqlCeEngine SQLEngine = new SqlCeEngine("Data Source = " + databaseName);
            SQLEngine.CreateDatabase(); //Creates the database if it doesnt exist already

            SqlCeConnection conn = new SqlCeConnection("Data Source = " + databaseName);
            conn.Open();
            SqlCeCommand cmd = conn.CreateCommand();

            cmd.CommandText = "CREATE TABLE Rules (%%);"; //Fill these in! (Before running)
            cmd.ExecuteNonQuery();

            cmd.CommandText = "CREATE TABLE Properties (%%);"; //Fill this one in too
            cmd.ExecuteNonQuery();

            cmd.CommandText = "CREATE TABLE ";
        }
    }
}
