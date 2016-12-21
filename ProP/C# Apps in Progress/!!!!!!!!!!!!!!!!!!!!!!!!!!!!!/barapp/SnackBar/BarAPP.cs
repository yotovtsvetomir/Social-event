using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace SnackBar
{
    class BarApp
    {
        MySqlConnection MySqlconnection;
        List<Food> allfoods;
        List<Drinks> alldrinks;

        public void connect()
        {
            String connectionInfo = "server=athena01.fhict.local;"
                        + "database=dbi251195;"
                        + "User id=dbi251195;"
                        + "password=GME7PlrdGQ;"
                        + "connect timeout=30;";
            MySqlconnection = new MySqlConnection(connectionInfo);
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
                MySqlconnection.Close();
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

        public bool PayOrder(int eventAccount, double orderSum)
        {
            string balance ="Select AccountBalance From Client WHERE EventAccount =" + eventAccount +";";
            MySqlCommand command = new MySqlCommand(balance, MySqlconnection);
            double money = -1;
            MySqlconnection.Close();
            try
            {
                MySqlconnection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    money = Convert.ToDouble(reader[0]);
                }
            }
            catch (Exception)
            {
            
            }
            finally
            {
                MySqlconnection.Close();
            }

            if (money >= orderSum)
            {
                string sql = "UPDATE Client SET AccountBalance =(AccountBalance -" + orderSum + ") WHERE EventAccount =" + eventAccount + ";";
                MySqlCommand command1 = new MySqlCommand(sql, MySqlconnection);
                try
                {
                    MySqlconnection.Open();
                    MySqlDataReader cmd = command1.ExecuteReader();
                }
                catch (Exception)
                {
                    return false;
                }
                finally
                {
                    MySqlconnection.Close();
                }
                return true;
            }
            return false;
        }

        public void buySnack(int id,int quanlity)
        {
            string sql = "UPDATE PRODUCTS SET Stock = (Stock - " + quanlity + ") WHERE ID = " + id + ";";
            MySqlCommand command = new MySqlCommand(sql, MySqlconnection);
            try
            {
                MySqlconnection.Open();
                MySqlDataReader reader = command.ExecuteReader();
            }
            catch (Exception)
            {
            }
            finally
            {
                MySqlconnection.Close();
            }
        }

        public List<Food> GetAllSnacks()
        {
            string sql = "SELECT * FROM Products WHERE SnackType = \"Snack\";";
            MySqlCommand command = new MySqlCommand(sql, MySqlconnection);
            allfoods = new List<Food>();

            try
            {
                MySqlconnection.Close();
                MySqlconnection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                Food snack;

                String name;
                int id;
                double price;
                int stock;

                while (reader.Read())
                {
                    name = Convert.ToString(reader[0]);
                    id = Convert.ToInt32(reader[3]);
                    price = Convert.ToDouble(reader[2]);
                    stock = Convert.ToInt32(reader[1]);
                    snack = new Food(name, price, stock,id);
                    allfoods.Add(snack);
                }
                MySqlconnection.Close();
                return allfoods;
            }
            catch (Exception)
            {
                MySqlconnection.Close();
                return allfoods;
            }
            finally
            {
                MySqlconnection.Close();
            }
        }

        public List<Drinks> GetAllDrinks()
        {
            string sql = "SELECT * FROM Products WHERE SnackType = \"Drink\";";
            MySqlCommand command = new MySqlCommand(sql, MySqlconnection);
            alldrinks = new List<Drinks>();

            try
            {
                MySqlconnection.Close();
                MySqlconnection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                Drinks drink;

                String name;
                double price;
                int stock;
                bool alc = true;
                int id;

                while (reader.Read())
                {
                    name = Convert.ToString(reader[0]);
                    price = Convert.ToDouble(reader[2]);
                    stock = Convert.ToInt32(reader[1]);
                    id = Convert.ToInt32(reader[3]);
                    if (Convert.ToString(reader[4]) == "Y")
                    {
                        alc = true;
                    }
                    else if (Convert.ToString(reader[4]) == "N")
                    {
                        alc = false;
                    }

                    drink = new Drinks(name, price, stock,id, alc);
                    alldrinks.Add(drink);
                }
                MySqlconnection.Close();
                return alldrinks;
            }
            catch (Exception)
            {
                MySqlconnection.Close();
                return alldrinks;
            }
            finally
            {
                MySqlconnection.Close();
            }
        }

    }
}
