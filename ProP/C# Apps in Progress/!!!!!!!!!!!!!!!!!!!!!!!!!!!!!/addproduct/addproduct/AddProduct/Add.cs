using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AddProduct
{
    class Add
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

        public List<Food> GetAllSnacks()
        {
            string sql = "SELECT * FROM Products WHERE SnackType = \"Snack\";";
            MySqlCommand command = new MySqlCommand(sql, MySqlconnection);
            allfoods = new List<Food>();

            try
            {
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
                    snack = new Food(name, price, stock, id);
                    allfoods.Add(snack);
                }
                return allfoods;
            }
            catch (Exception)
            {
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

                    drink = new Drinks(name, price, stock, id, alc);
                    alldrinks.Add(drink);
                }
                return alldrinks;
            }
            catch (Exception)
            {
                return alldrinks;
            }
            finally
            {
                MySqlconnection.Close();
            }
        }

        public void AddSnacks(int id, int quanlity)
        {
            string sql = "UPDATE PRODUCTS SET Stock = (Stock + " + quanlity + ") WHERE ID = " + id + ";";
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
    }
}
