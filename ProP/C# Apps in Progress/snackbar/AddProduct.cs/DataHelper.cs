using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace BarApp.cs
{
    class DataHelper
    {
        MySqlConnection MySqlconnection;
        string sqlString = "server=athena01.fhict.local;" +
                                          "database=dbi255571;" +
                                          "user id=dbi255571;" +
                                          "password=2zysHCniY2;" +
                                          "connect timeout=30;";

        public string SqlString { get { return sqlString; } set { sqlString = value; } }
        public void connect()
        {
            string connectionString = "server=athena01.fhict.local;" +
                                          "database=dbi255571;" +
                                          "user id=dbi255571;" +
                                          "password=2zysHCniY2;" +
                                          "connect timeout=30;";

            MySqlconnection = new MySqlConnection(connectionString);
            try
            {
                MySqlconnection = new MySqlConnection(connectionString);
                MySqlconnection.Open();
                MessageBox.Show("connected");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (MySqlconnection != null)
                    MySqlconnection.Close();
            }
        }

    }
}
