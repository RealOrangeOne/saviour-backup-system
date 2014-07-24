using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.IO;

namespace Local_Database_Connection
{ 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlCeConnection conn = null;
            try
            {
                if (File.Exists("Test.sdf")) { File.Delete("Test.sdf"); }

                SqlCeEngine engine = new SqlCeEngine("Data Source = Test.sdf");
                engine.CreateDatabase();

                conn = new SqlCeConnection("Data Source = Test.sdf");
                conn.Open();

                SqlCeCommand cmd = conn.CreateCommand();

                cmd.CommandText = "CREATE TABLE TestTbl (col1 INT PRIMARY KEY, col2 NTEXT, col3 MONEY)";

                cmd.ExecuteNonQuery();

                cmd.CommandText = "INSERT INTO TestTbl (col1, col2, col3) VALUES (0, 'abc', 15.66)";

                cmd.ExecuteNonQuery();

                cmd.CommandText = "INSERT INTO TestTbl (col1, col2, col3) VALUES (?, ?, ?)";

                cmd.Parameters.Add(new SqlCeParameter("p1", SqlDbType.Int));
                cmd.Parameters.Add(new SqlCeParameter("p2", SqlDbType.NText));
                cmd.Parameters.Add(new SqlCeParameter("p3", SqlDbType.Money));

                cmd.Parameters["p2"].Size = 50;

                cmd.Prepare();

                cmd.Parameters["p1"].Value = 1;
                cmd.Parameters["p2"].Value = "abc";
                cmd.Parameters["p3"].Value = 15.66;
                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();

                cmd.CommandText = "SELECT * From TestTbl";
                SqlCeDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    MessageBox.Show(" col1 = " + rdr.GetInt32(0) +
                     " col2 = " + rdr.GetString(1) +
                     " col3 = " + rdr.GetSqlMoney(2));
                }
            }
            catch (Exception err) { MessageBox.Show("ERROR! : " + err.ToString()); }
            finally { conn.Close(); }
        }
    }
}
