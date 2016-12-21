using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Recharging
{
    class Connection
    {
        private MySqlConnection MySqlconnection;
        public void connect()
        {
            String connectionInfo = "server=athena01.fhict.local;"
                        + "database=dbi251195;"
                        + "User id=dbi251195;"
                        + "password=GME7PlrdGQ;"
                        + "connect timeout=30;";
            MySqlconnection = new MySqlConnection(connectionInfo);
        }

        public void RechargeBalance(int AccNum,int Amount)
        {
            string sql = "UPDATE Client SET AccountBalance = AccountBalance +" + Amount + " WHERE EventAccount = " + AccNum + ";";
            MySqlCommand command = new MySqlCommand(sql, MySqlconnection);
            try
            {
                MySqlconnection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                MySqlconnection.Close();
            }
            catch (Exception)
            {
            }
        }

        public Client searchclient(int eventAccount)
        {
            string balance = "Select * From Client WHERE EventAccount = " + eventAccount + ";";
            MySqlCommand command = new MySqlCommand(balance, MySqlconnection);
            int AccountNumber;
            string Firstname;
            int birth;
            string Lastname;
            char gender;
            string email;
            double Accountbalance;
            string status;
            Client temp;

            try
            {
                MySqlconnection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    AccountNumber = Convert.ToInt32(reader[0]);
                    Firstname = Convert.ToString(reader[1]);
                    birth = Convert.ToInt32(reader[2]);
                    Lastname = Convert.ToString(reader[3]);
                    gender = Convert.ToChar(reader[4]);
                    email = Convert.ToString(reader[5]);
                    Accountbalance = Convert.ToDouble(reader[6]);
                    status = Convert.ToString(reader[7]);
                    temp = new Client(AccountNumber, Firstname, Lastname, email, gender, Accountbalance, birth, status);
                    return temp;
                }
                return null;

            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                MySqlconnection.Close();
            }
        }
    }
}
