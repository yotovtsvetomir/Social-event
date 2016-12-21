using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace InsepectStatus
{
    class connect
    {
        MySqlConnection MySqlconnection;

        public void connecting()
        {
            String connectionInfo = "server=athena01.fhict.local;"
                        + "database=dbi251195;"
                        + "User id=dbi251195;"
                        + "password=GME7PlrdGQ;"
                        + "connect timeout=30;";
            MySqlconnection = new MySqlConnection(connectionInfo);
        }

        public int VisitorsInside()
        {
            int temp;

            string sql = "SELECT count(*) FROM Client WHERE status = \"in\";";
            MySqlCommand command = new MySqlCommand(sql, MySqlconnection);

            try
            {
                MySqlconnection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    temp = Convert.ToInt32(reader[0]);
                    MySqlconnection.Close();
                    return temp;
                }

            }
            catch (Exception)
            { }
            finally
            {
                MySqlconnection.Close();
            }

            return 0;
        }

        public int TotalVisitors()
        {
            int temp;

            string sql = "SELECT count(*) FROM Client WHERE status = \"in\" OR status = \"out\";";
            MySqlCommand command = new MySqlCommand(sql, MySqlconnection);

            try
            {
                MySqlconnection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    temp = Convert.ToInt32(reader[0]);
                    MySqlconnection.Close();
                    return temp;
                }

            }
            catch (Exception)
            { }
            finally
            {
                MySqlconnection.Close();
            }

            return 0;
        }

        public int AverageAge()
        {
            int temp;

            string sql = "SELECT round( AVG(Age)) FROM Client WHERE status = \"in\";";
            MySqlCommand command = new MySqlCommand(sql, MySqlconnection);

            try
            {
                MySqlconnection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    temp = Convert.ToInt32(reader[0]);
                    MySqlconnection.Close();
                    return temp;
                }

            }
            catch (Exception)
            { }
            finally
            {
                MySqlconnection.Close();
            }

            return 0;
        }

        public Double GenderRatio()
        {
            double temp;
            double temp2;
            Double ratio;

            string sql = "SELECT count(*) FROM Client WHERE gender = \"m\" AND status = \"in\";";
            string sql1 = "SELECT count(*) FROM Client WHERE gender = \"f\" AND status = \"in\";";
            MySqlCommand command = new MySqlCommand(sql, MySqlconnection);
            MySqlCommand command1 = new MySqlCommand(sql1, MySqlconnection);

            try
            {
                temp = 1;
                temp2 = 8;
                MySqlconnection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    temp = Convert.ToDouble(reader[0]);
                }
                MySqlconnection.Close();
                MySqlconnection.Open();
                MySqlDataReader reader1 = command1.ExecuteReader();
                while (reader1.Read())
                {
                    temp2 = Convert.ToDouble(reader1[0]);
                }
                MySqlconnection.Close();

                ratio = Convert.ToDouble((temp / temp2).ToString("0.00"));
                return ratio;

            }
            catch (Exception)
            { }
            finally
            {
                MySqlconnection.Close();
            }

            return 0;
        }

        public double AverageBalance()
        {
            double temp;

            string sql = "SELECT round( AVG(AccountBalance)) FROM Client WHERE status = \"in\";";
            MySqlCommand command = new MySqlCommand(sql, MySqlconnection);

            try
            {
                MySqlconnection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    temp = Convert.ToDouble(reader[0]);
                    MySqlconnection.Close();
                    return temp;
                }

            }
            catch (Exception)
            { }
            finally
            {
                MySqlconnection.Close();
            }

            return 0;
        }
    }
}
