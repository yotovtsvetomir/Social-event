using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace Application_for_stands
{
    class MaterialsApp
    {
        MySqlConnection MySqlconnection;
        List<StorageDevices> storagedevicesList;
        List<Cables> cableList;
        List<Laptop> laptopList;

        public void connect()
        {
            String connectionInfo = "server=athena01.fhict.local;"
                        + "database=dbi251195;"
                        + "User id=dbi251195;"
                        + "password=GME7PlrdGQ;"
                        + "connect timeout=30;";
            MySqlconnection = new MySqlConnection(connectionInfo);
        }

        public List<StorageDevices> GetAllStorageDevices()
        {
            string sql = "SELECT * FROM matirals WHERE MatiralsType = \"StorageDevice\";";
            MySqlCommand command = new MySqlCommand(sql, MySqlconnection);
            this.storagedevicesList = new List<StorageDevices>();

            try
            {
                MySqlconnection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                StorageDevices SD;

                String name;
                int id;
                double rent;
                int damagecost;
                int size;

                while (reader.Read())
                {
                    name = Convert.ToString(reader[0]);
                    id = Convert.ToInt32(reader[4]);
                    rent = Convert.ToDouble(reader[1]);
                    damagecost = Convert.ToInt32(reader[2]);
                    size = Convert.ToInt32(reader[6]);
                    SD = new StorageDevices(name, id, rent, size, damagecost);
                    storagedevicesList.Add(SD);
                }
                return storagedevicesList;
            }
            catch (Exception)
            {
                return storagedevicesList;
            }

            finally
            {
                MySqlconnection.Close();
            }
        }

        public List<StorageDevices> GetAllStorageDevices1()
        {
            string sql = "SELECT * FROM matirals WHERE MatiralsType = \"StorageDevice\" AND Avaliable = \"Y\";";
            MySqlCommand command = new MySqlCommand(sql, MySqlconnection);
            this.storagedevicesList = new List<StorageDevices>();

            try
            {
                MySqlconnection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                StorageDevices SD;

                String name;
                int id;
                double rent;
                int damagecost;
                int size;

                while (reader.Read())
                {
                    name = Convert.ToString(reader[0]);
                    id = Convert.ToInt32(reader[4]);
                    rent = Convert.ToDouble(reader[1]);
                    damagecost = Convert.ToInt32(reader[2]);
                    size = Convert.ToInt32(reader[6]);
                    SD = new StorageDevices(name, id, rent, size, damagecost);
                    storagedevicesList.Add(SD);
                }
                return storagedevicesList;
            }
            catch (Exception)
            {
                return storagedevicesList;
            }

            finally
            {
                MySqlconnection.Close();
            }
        }

        public List<Cables> GetAllCables()
        {
            cableList = new List<Cables>();
            string sql = "SELECT * FROM matirals WHERE MatiralsType = \"Cable\";";
            MySqlCommand command = new MySqlCommand(sql, MySqlconnection);

            try
            {
                MySqlconnection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                Cables CB;

                String name;
                int id;
                double rent;
                int damagecost;
                int lenth;

                while (reader.Read())
                {
                    name = Convert.ToString(reader[0]);
                    id = Convert.ToInt32(reader[4]);
                    rent = Convert.ToDouble(reader[1]);
                    damagecost = Convert.ToInt32(reader[2]);
                    lenth = Convert.ToInt32(reader[7]);
                    CB = new Cables(name,id,rent,damagecost,lenth);
                    this.cableList.Add(CB);
                }
                return cableList;
            }
            catch (Exception)
            {
                return cableList;
            }

            finally
            {
                MySqlconnection.Close();
            }
        }

        public List<Cables> GetAllCables1()
        {
            cableList = new List<Cables>();
            string sql = "SELECT * FROM matirals WHERE MatiralsType = \"Cable\" AND Avaliable = \"Y\";";
            MySqlCommand command = new MySqlCommand(sql, MySqlconnection);

            try
            {
                MySqlconnection.Close();
                MySqlconnection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                Cables CB;

                String name;
                int id;
                double rent;
                int damagecost;
                int lenth;

                while (reader.Read())
                {
                    name = Convert.ToString(reader[0]);
                    id = Convert.ToInt32(reader[4]);
                    rent = Convert.ToDouble(reader[1]);
                    damagecost = Convert.ToInt32(reader[2]);
                    lenth = Convert.ToInt32(reader[7]);
                    CB = new Cables(name, id, rent, damagecost, lenth);
                    this.cableList.Add(CB);
                }
                return cableList;
            }
            catch (Exception)
            {
                return cableList;
            }

            finally
            {
                MySqlconnection.Close();
            }
        }

        public List<Laptop> GetAllLaptops()
        {
            laptopList = new List<Laptop>();
            string sql = "SELECT * FROM matirals WHERE MatiralsType = \"Laptop\";";
            MySqlCommand command = new MySqlCommand(sql, MySqlconnection);

            try
            {
                MySqlconnection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                Laptop LP;

                String name;
                int id;
                double rent;
                int damagecost;
                string brand;

                while (reader.Read())
                {
                    name = Convert.ToString(reader[0]);
                    id = Convert.ToInt32(reader[4]);
                    rent = Convert.ToDouble(reader[1]);
                    damagecost = Convert.ToInt32(reader[2]);
                    brand = Convert.ToString(reader[8]);
                    LP = new Laptop(name, id, rent, damagecost, brand);
                    this.laptopList.Add(LP);
                }
                return laptopList;
            }
            catch (Exception)
            {
                return laptopList;
            }

            finally
            {
                MySqlconnection.Close();
            }
        }

        public List<Laptop> GetAllLaptops1()
        {
            laptopList = new List<Laptop>();
            string sql = "SELECT * FROM matirals WHERE MatiralsType = \"Laptop\" AND Avaliable = \"Y\";";
            MySqlCommand command = new MySqlCommand(sql, MySqlconnection);

            try
            {
                MySqlconnection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                Laptop LP;

                String name;
                int id;
                double rent;
                int damagecost;
                string brand;

                while (reader.Read())
                {
                    name = Convert.ToString(reader[0]);
                    id = Convert.ToInt32(reader[4]);
                    rent = Convert.ToDouble(reader[1]);
                    damagecost = Convert.ToInt32(reader[2]);
                    brand = Convert.ToString(reader[8]);
                    LP = new Laptop(name, id, rent, damagecost, brand);
                    this.laptopList.Add(LP);
                }
                return laptopList;
            }
            catch (Exception)
            {
                return laptopList;
            }

            finally
            {
                MySqlconnection.Close();
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
            int item1;
            int item2;
            int item3;
            int item4;
            int item5;
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
                    item1 = Convert.ToInt32(reader[8]);
                    item2 = Convert.ToInt32(reader[9]);
                    item3 = Convert.ToInt32(reader[10]);
                    item4 = Convert.ToInt32(reader[11]);
                    item5 = Convert.ToInt32(reader[12]);
                    temp = new Client(AccountNumber,Firstname, Lastname, email, gender, Accountbalance, birth, status);
                    temp.item1 = item1;
                    temp.item2 = item2;
                    temp.item3 = item3;
                    temp.item4 = item4;
                    temp.item5 = item5;
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

        public bool rent1(int EventAccount)
        {
            string rent1 = "select RENT1 from client where EventAccount = " + EventAccount;
            MySqlCommand command = new MySqlCommand(rent1, MySqlconnection);
            int rentThing1;
            MySqlconnection.Close();
            try
            {
                MySqlconnection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    rentThing1 = Convert.ToInt32(reader[0]);
                    if (rentThing1 == 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                MySqlconnection.Close();
            }
        }

        public bool rent2(int EventAccount)
        {
            string rent1 = "select rent2 from client where EventAccount = " + EventAccount;
            MySqlCommand command = new MySqlCommand(rent1, MySqlconnection);
            String rentThing1;

            try
            {
                MySqlconnection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    rentThing1 = Convert.ToString(reader[0]);
                    if (rentThing1 == "0")
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                MySqlconnection.Close();
            }
        }

        public bool rent3(int EventAccount)
        {
            string rent1 = "select rent3 from client where EventAccount = " + EventAccount;
            MySqlCommand command = new MySqlCommand(rent1, MySqlconnection);
            String rentThing1;

            try
            {
                MySqlconnection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    rentThing1 = Convert.ToString(reader[0]);
                    if (rentThing1 == "0")
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                MySqlconnection.Close();
            }
        }

        public bool rent4(int EventAccount)
        {
            string rent1 = "select rent4 from client where EventAccount = " + EventAccount;
            MySqlCommand command = new MySqlCommand(rent1, MySqlconnection);
            String rentThing1;

            try
            {
                MySqlconnection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    rentThing1 = Convert.ToString(reader[0]);
                    if (rentThing1 == "0")
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                MySqlconnection.Close();
            }
        }

        public bool rent5(int EventAccount)
        {
            string rent1 = "select rent5 from client where EventAccount = " + EventAccount;
            MySqlCommand command = new MySqlCommand(rent1, MySqlconnection);
            int rentThing1;

            try
            {
                MySqlconnection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    rentThing1 = Convert.ToInt32(reader[0]);
                    if (rentThing1 == 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                MySqlconnection.Close();
            }
        }

        public void rentOut1(int EventAccount, int id)
        {
            string rentout = "Update Client set Rent1 =" + id + " where EventAccount = " + EventAccount + ";";
            string rentout1 = "Update Matirals set Avaliable = 'N' where ID = " + id + ";";
            MySqlCommand command1 = new MySqlCommand(rentout1, MySqlconnection);
            MySqlCommand command = new MySqlCommand(rentout, MySqlconnection);
            MySqlconnection.Close();
            MySqlconnection.Open();
            MySqlDataReader reader = command.ExecuteReader();
            MySqlconnection.Close();
            MySqlconnection.Open();
            MySqlDataReader reader1 = command1.ExecuteReader();
            MySqlconnection.Close();
        }

        public void rentOut2(int EventAccount, int id)
        {
            string rentout = "Update Client set Rent2 =" + id + " where EventAccount = " + EventAccount + ";";
            string rentout1 = "Update Matirals set Avaliable = 'N' where ID = " + id + ";";
            MySqlCommand command1 = new MySqlCommand(rentout1, MySqlconnection);
            MySqlCommand command = new MySqlCommand(rentout, MySqlconnection);
            MySqlconnection.Close();
            MySqlconnection.Open();
            MySqlDataReader reader = command.ExecuteReader();
            MySqlconnection.Close();
            MySqlconnection.Open();
            MySqlDataReader reader1 = command1.ExecuteReader();
            MySqlconnection.Close();
        }

        public void rentOut3(int EventAccount, int id)
        {
            string rentout = "Update Client set Rent3 =" + id + " where EventAccount = " + EventAccount + ";";
            string rentout1 = "Update Matirals set Avaliable = 'N' where ID = " + id + ";";
            MySqlCommand command1 = new MySqlCommand(rentout1, MySqlconnection);
            MySqlCommand command = new MySqlCommand(rentout, MySqlconnection);
            MySqlconnection.Close();
            MySqlconnection.Open();
            MySqlDataReader reader = command.ExecuteReader();
            MySqlconnection.Close();
            MySqlconnection.Open();
            MySqlDataReader reader1 = command1.ExecuteReader();
            MySqlconnection.Close();
        }

        public void rentOut4(int EventAccount, int id)
        {
            string rentout = "Update Client set Rent4 =" + id + " where EventAccount = " + EventAccount + ";";
            string rentout1 = "Update Matirals set Avaliable = 'N' where ID = " + id + ";";
            MySqlCommand command = new MySqlCommand(rentout, MySqlconnection);
            MySqlCommand command1 = new MySqlCommand(rentout1, MySqlconnection);
            MySqlconnection.Close();
            MySqlconnection.Open();
            MySqlDataReader reader = command.ExecuteReader();
            MySqlconnection.Close();
            MySqlconnection.Open();
            MySqlDataReader reader1 = command1.ExecuteReader();
            MySqlconnection.Close();
        }

        public void rentOut5(int EventAccount, int id)
        {
            string rentout = "Update Client set Rent5 =" + id + " where EventAccount = " + EventAccount + ";";
            string rentout1 = "Update Matirals set Avaliable = 'N' where ID = " + id + ";";
            MySqlCommand command1 = new MySqlCommand(rentout1, MySqlconnection);
            MySqlCommand command = new MySqlCommand(rentout, MySqlconnection);
            MySqlconnection.Close();
            MySqlconnection.Open();
            MySqlDataReader reader = command.ExecuteReader();
            MySqlconnection.Close();
            MySqlconnection.Open();
            MySqlDataReader reader1 = command1.ExecuteReader();
            MySqlconnection.Close();
        }

        public bool PayOrder(int eventAccount, int rent)
        {
            string balance = "Select AccountBalance From Client WHERE EventAccount =" + eventAccount + ";";
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
            { }
            finally
            {
                MySqlconnection.Close();
            }
            if (money >= rent)
            {
                string sql = "UPDATE Client SET AccountBalance =(AccountBalance -" + rent + ") WHERE EventAccount =" + eventAccount + ";";
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

        public void ReturnItem(int id)
        {
            string rentout1 = "Update Matirals set Avaliable = 'Y' where ID = " + id + ";";
            MySqlCommand command1 = new MySqlCommand(rentout1, MySqlconnection);
            MySqlconnection.Open();
            MySqlDataReader reader1 = command1.ExecuteReader();
            MySqlconnection.Close();
        }

        public bool returnBack1(int EventAccount, int id)
        {
            string rentout = "select Rent1 from client where EventAccount =" + EventAccount + ";";
            string renturn = "update client set rent1 = 0 where EventAccount =" + EventAccount + ";";
            MySqlCommand command = new MySqlCommand(rentout, MySqlconnection);
            MySqlCommand command2 = new MySqlCommand(renturn, MySqlconnection);
            string ItemID = null;
            MySqlconnection.Open();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ItemID = Convert.ToString(reader[0]);
            }
            MySqlconnection.Close();
            MySqlconnection.Open();
            if (ItemID == Convert.ToString(id))
            {
                MySqlDataReader reader2 = command2.ExecuteReader();
                MySqlconnection.Close();
                return true;
            }
            else
            {
                MySqlconnection.Close();
                return false;
            }
        }

        public bool returnBack2(int EventAccount, int id)
        {
            string rentout = "select Rent2 from client where EventAccount =" + EventAccount + ";";
            string renturn = "update client set rent2 = 0 where EventAccount =" + EventAccount + ";";
            MySqlCommand command = new MySqlCommand(rentout, MySqlconnection);
            MySqlCommand command2 = new MySqlCommand(renturn, MySqlconnection);
            string ItemID = null;
            MySqlconnection.Open();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ItemID = Convert.ToString(reader[0]);
            }
            MySqlconnection.Close();
            MySqlconnection.Open();
            if (ItemID == Convert.ToString(id))
            {
                MySqlDataReader reader2 = command2.ExecuteReader();
                MySqlconnection.Close();
                return true;
            }
            else
            {
                MySqlconnection.Close();
                return false;
            }
        }

        public bool returnBack3(int EventAccount, int id)
        {
            string rentout = "select Rent3 from client where EventAccount =" + EventAccount + ";";
            string renturn = "update client set rent3 = 0 where EventAccount =" + EventAccount + ";";
            MySqlCommand command = new MySqlCommand(rentout, MySqlconnection);
            MySqlCommand command2 = new MySqlCommand(renturn, MySqlconnection);
            string ItemID = null;
            MySqlconnection.Open();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ItemID = Convert.ToString(reader[0]);
            }
            MySqlconnection.Close();
            MySqlconnection.Open();
            if (ItemID == Convert.ToString(id))
            {
                MySqlDataReader reader2 = command2.ExecuteReader();
                MySqlconnection.Close();
                return true;
            }
            else
            {
                MySqlconnection.Close();
                return false;
            }
        }

        public bool returnBack4(int EventAccount, int id)
        {
            string rentout = "select Rent4 from client where EventAccount =" + EventAccount + ";";
            string renturn = "update client set rent4 = 0 where EventAccount =" + EventAccount + ";";
            MySqlCommand command = new MySqlCommand(rentout, MySqlconnection);
            MySqlCommand command2 = new MySqlCommand(renturn, MySqlconnection);
            string ItemID = null;
            MySqlconnection.Open();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ItemID = Convert.ToString(reader[0]);
            }
            MySqlconnection.Close();
            MySqlconnection.Open();
            if (ItemID == Convert.ToString(id))
            {
                MySqlDataReader reader2 = command2.ExecuteReader();
                MySqlconnection.Close();
                return true;
            }
            else
            {
                MySqlconnection.Close();
                return false;
            }
        }

        public bool returnBack5(int EventAccount, int id)
        {
            string rentout = "select Rent5 from client where EventAccount =" + EventAccount + ";";
            string renturn = "update client set rent5 = 0 where EventAccount =" + EventAccount + ";";
            MySqlCommand command = new MySqlCommand(rentout, MySqlconnection);
            MySqlCommand command2 = new MySqlCommand(renturn, MySqlconnection);
            string ItemID = null;
            MySqlconnection.Open();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ItemID = Convert.ToString(reader[0]);
            }
            MySqlconnection.Close();
            MySqlconnection.Open();
            if (ItemID == Convert.ToString(id))
            {
                MySqlDataReader reader2 = command2.ExecuteReader();
                MySqlconnection.Close();
                return true;
            }
            else
            {
                MySqlconnection.Close();
                return false;
            }
        }

        public Material GetMatiral(int id)
        {
            if (id != 0)
            {
                string rentout = "select * from matirals where ID = " + id + ";";
                MySqlCommand command = new MySqlCommand(rentout, MySqlconnection);
                String name;
                int id1;
                double rent;
                int damageCost;
                Material temp;
                MySqlconnection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    id1 = Convert.ToInt32(reader[4]);
                    name = Convert.ToString(reader[0]);
                    rent = Convert.ToDouble(reader[1]);
                    damageCost = Convert.ToInt32(reader[2]);
                    temp = new Material(name, id1, rent, damageCost);
                    MySqlconnection.Close();
                    return temp;
                }
            }
            MySqlconnection.Close();
            return null;
        }

    }
}
