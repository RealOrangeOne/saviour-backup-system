using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.IO;
using System.Windows.Forms;

namespace Saviour_Backup_System
{
    class databaseTools
    {
        private static string databaseName = "db.sdf";
        public static void initDatabase()
        {
            try{
                if (!File.Exists(databaseName))
                {
                    SqlCeEngine SQLEngine = new SqlCeEngine("Data Source = " + databaseName);
                    SQLEngine.CreateDatabase(); //Creates the database if it doesnt exist already

                    SqlCeConnection conn = new SqlCeConnection("Data Source = " + databaseName);
                    conn.Open();
                    SqlCeCommand cmd = conn.CreateCommand();

                    cmd.CommandText = "CREATE TABLE Rules (%%)"; //Fill these in! (Before running)
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception err) { MessageBox.Show("An Error has occured: \n" + err.ToString()); }
        }
        public static string queryDatabase(string sqlCode)
        {
            return "";
        }

        public static void modifyDatabase(string sqlCode)
        {

        }

        public static void clearTable(string tableName)
        {
            modifyDatabase("DELETE FROM " + tableName + ";");
        }
    }
}
