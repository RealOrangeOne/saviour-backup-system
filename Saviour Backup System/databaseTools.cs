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
        private static SqlCeConnection conn = new SqlCeConnection("Data Source = " + databaseName);
        public static string databaseName = "db.sdf";


        private static void executeSQL(string sqlCode)
        {
            conn.Open();
            SqlCeCommand cmd = conn.CreateCommand();
            cmd.CommandText = sqlCode;
            cmd.ExecuteNonQuery();
        }


        public static void clearBackups(string tableName)
        {
           executeSQL("DELETE FROM Rules;");
        }
    }
}
