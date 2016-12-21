using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using WindowsFormsApplication1;


namespace WindowsFormsApplication1
{
    class DBhelper
    {
        public MySqlConnection TempConnect;
         Client tempClient;
         //CampHost tempCampHost;
         //CampSpotGuest tempCampSpotGuest;
         Statistics tempStatistics;
        public void connect()
        {
            string connectionString = "server=athena01.fhict.local;" +
                                          "database=dbi275231;" +
                                          "user id=dbi275231;" +
                                          "password=uJOaHhNP6c;" +
                                          "connect timeout=30;";

            TempConnect = new MySqlConnection(connectionString);
        }

        public Client SearchClient(string rfid)
        {
            tempClient = null;
            connect();
            //TempClient = null;
            string sql = "SELECT AccountNumber,first_name FROM client WHERE RFID = '" + rfid + "';";
            MySqlCommand command = new MySqlCommand(sql, TempConnect);
            try
            {
                TempConnect.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                { 
                    int accountNumber = Convert.ToInt32(reader["AccountNumber"]);
                    string firstName = Convert.ToString(reader["First_Name"]);
                    tempClient = new Client(accountNumber, firstName);
                }
            }

            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Bad " + ex.Message); ;
            }
            finally
            {
                TempConnect.Close();
            }
            return tempClient;
        }
        //public CampHost SearchCampHost(int acc)
        //{
        //    connect();
        //    string sql = "SELECT Camp_id,NumberOfGuests FROM campingspot WHERE Client_AccountNumber = '" + acc + "';";
        //    MySqlCommand command = new MySqlCommand(sql, TempConnect);
        //    tempCampHost = null;
        //    try
        //    {
        //        TempConnect.Open();
        //        MySqlDataReader reader = command.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            int campID = Convert.ToInt32(reader["Camp_id"]);
        //            int numberOfGuest = Convert.ToInt32(reader["NumberOfGuests"]);
        //            tempCampHost = new CampHost(acc, numberOfGuest, campID);
        //        }
        //    }

        //    catch (MySqlException ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show("Bad " + ex.Message); ;
        //    }
        //    finally
        //    {
        //        TempConnect.Close();
        //    }
        //    return tempCampHost;
        //}
        public void AssignGuest(int CampID,int acc)
        {
            connect();
            string sql = "Insert into  campingspotguest(CampingSpot_Camp_id,Client_AccountNumber) values("+CampID+","+acc+");";
            MySqlCommand command = new MySqlCommand(sql, TempConnect);
            try
            {
                TempConnect.Open();
                command.ExecuteNonQuery();

                //while (reader.Read())
                //{
                //    int campID = Convert.ToInt32(reader["Camp_id"]);
                //    int numberOfGuest = Convert.ToInt32(reader["NumberOfGuests"]);
                //    tempCampHost = new CampHost(acc, numberOfGuest, numberOfGuest);
                //}
            }

            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Bad " + ex.Message); ;
            }
            finally
            {
                TempConnect.Close();
            }

        }
        //public CampSpotGuest SearchCampGuest(int acc)
        //{
        //    connect();
        //    string sql = "SELECT CampingSpot_Camp_id FROM  campingspotguest WHERE Client_AccountNumber = '" + acc + "';";
        //    MySqlCommand command = new MySqlCommand(sql, TempConnect);
        //    tempCampSpotGuest = null;
        //    try
        //    {
        //        TempConnect.Open();
        //        MySqlDataReader reader = command.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            int campID = Convert.ToInt32(reader["CampingSpot_Camp_id"]);

        //            tempCampSpotGuest = new CampSpotGuest(campID, acc);
        //        }
        //    }

        //    catch (MySqlException ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show("Bad " + ex.Message); ;
        //    }
        //    finally
        //    {
        //        TempConnect.Close();
        //    }
        //    return tempCampSpotGuest;
        //}
        public Statistics AskForStatistics()
        {
            tempStatistics = null;
            connect();
            int totalVisitors = 0;
            int inEvent = 0;
            int moneySpend = 0;
            int totalMoney = 0;
            //TempClient = null;
            string sql1 = "SELECT count( * ) FROM client ";
            MySqlCommand command1 = new MySqlCommand(sql1, TempConnect);
            string sql2 = "SELECT count( * ) FROM client WHERE InEvent =1";
            MySqlCommand command2 = new MySqlCommand(sql2, TempConnect);
            string sql3 = "SELECT SUM(MoneyBalance) FROM client where MoneyBalance IS NOT NULL;";
            MySqlCommand command3 = new MySqlCommand(sql3, TempConnect);
            string sql4 = "SELECT SUM(TotalPrice)  FROM `order` where TotalPrice IS NOT NULL;";
            MySqlCommand command4 = new MySqlCommand(sql4, TempConnect);


            try
            {
                TempConnect.Open();
                MySqlDataReader reader1 = command1.ExecuteReader();
                
                while (reader1.Read())
                {
                    totalVisitors = Convert.ToInt32(reader1["count( * )"]);
                }
            }

            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Bad " + ex.Message); ;
            }
            finally
            {
                TempConnect.Close();
            }

            try
            {

                TempConnect.Open();
                MySqlDataReader reader2 = command2.ExecuteReader();
                while (reader2.Read())
                {
                    inEvent = Convert.ToInt32(reader2["count( * )"]);
                    ;
                }
            }

            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Bad " + ex.Message); ;
            }
            finally
            {
                TempConnect.Close();
            }

            //SELECT SUM(MoneyBalance) FROM client where MoneyBalance IS NOT NULL;

                       
            try {
                TempConnect.Open();
                MySqlDataReader reader3 = command3.ExecuteReader();
                
                while (reader3.Read())
                {
                    totalMoney = Convert.ToInt32(reader3["SUM(MoneyBalance)"]);
                }
            }

            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Bad " + ex.Message); ;
            }
            finally
            {
                TempConnect.Close();
            }

            try
            {
                TempConnect.Open();
                MySqlDataReader reader4 = command4.ExecuteReader();

                while (reader4.Read())
                {
                    moneySpend = Convert.ToInt32(reader4["SUM(TotalPrice)"]);
                }
            }

            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Bad " + ex.Message); ;
            }
            finally
            {
                TempConnect.Close();
            }
            tempStatistics = new Statistics(totalVisitors, inEvent,moneySpend,totalMoney);
            return tempStatistics;
        }
    }
}
