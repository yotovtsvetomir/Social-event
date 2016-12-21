using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace EntranceApp
{
    class connection
    {
        MySqlConnection MySqlconnection;
        public void connect()
        {
            String connectionInfo = "server=athena01.fhict.local;"
                                    +"database=dbi251195;"
                                    +"User id=dbi251195;"
                                    +"password=GME7PlrdGQ;"
                                    + "connect timeout=30;";
            MySqlconnection = new MySqlConnection(connectionInfo);
        }

        public Client GetClient(int EventAccount)
        {
            string sql = "SELECT * FROM client where EventAccount =" + EventAccount + ";";
            MySqlCommand command = new MySqlCommand(sql, MySqlconnection);
            Client temp;
            try
            {
                MySqlconnection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                int accountNum ;
                int reservationNum;
                string firstName ;
                string lastName ;
                string email ;
                char gender;
                double accountBalance; 
                int age;
                string status;

                   
                while (reader.Read())
                {
                    accountNum = Convert.ToInt32(reader[0]);
                    firstName = Convert.ToString(reader[1]);
                    lastName = Convert.ToString(reader[4]);
                    email = Convert.ToString(reader[6]);
                    reservationNum = Convert.ToInt32(reader[3]);
                    status = Convert.ToString(reader[8]);
                    accountBalance = Convert.ToInt32(reader[7]);
                    gender = Convert.ToChar(reader[5]);
                    age = Convert.ToInt32(reader[2]);


                    temp = new Client(accountNum, reservationNum, firstName, lastName, email, gender, accountBalance, age, status);
                    return temp;
                }
                
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                MySqlconnection.Close();
            }
            return null;
        }

        public void RemoveClient(int EventAccount)
        {

            string sql = "UPDATE Client SET Status = 'out' where EventAccount =" + EventAccount + ";";
            string sql1 = "UPDATE Client SET AccountBalance = 0 where EventAccount =" + EventAccount + ";";
            MySqlCommand command = new MySqlCommand(sql, MySqlconnection);
            MySqlCommand command1 = new MySqlCommand(sql1, MySqlconnection);
            //========================================
            try
            {
                MySqlconnection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                MySqlconnection.Close();
                MySqlconnection.Open();
                MySqlDataReader reader2 = command1.ExecuteReader();
            }
            catch (Exception)
            {
            }
            finally
            {
                MySqlconnection.Close();
            }
            
        }

        public bool Check( int eventAccount)
        {
            string sql = "SELECT * FROM client where EventAccount = " + eventAccount + ";";
            MySqlCommand command = new MySqlCommand(sql, MySqlconnection);
            MySqlconnection.Open();
            MySqlDataReader reader = command.ExecuteReader();
            int item1;
            int item2;
            int item3;
            int item4;
            int item5;
            while (reader.Read())
            {
                item1 = Convert.ToInt32(reader[8]);
                item2 = Convert.ToInt32(reader[9]);
                item3 = Convert.ToInt32(reader[10]);
                item4 = Convert.ToInt32(reader[11]);
                item5 = Convert.ToInt32(reader[12]);
                if (item1 != 0)
                {
                    MySqlconnection.Close();
                    return false;
                }
                if (item2 != 0)
                {
                    MySqlconnection.Close();
                    return false;
                }
                if (item3 != 0)
                {
                    MySqlconnection.Close();
                    return false;
                }
                if (item4 != 0)
                {
                    MySqlconnection.Close();
                    return false;
                }
                if (item5 != 0)
                {
                    MySqlconnection.Close();
                    return false;
                }
            }
            MySqlconnection.Close();
            return true;
        }
    }
}
