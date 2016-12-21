using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace AppForRegistration
{
    class DataHelper
    {
     
       private MySqlConnection connection;
        List<Client> clientlist;

        public DataHelper()
        {
            clientlist = new List<Client>();
            String connectionInfo = "server=athena01.fhict.local;"
                        + "database=dbi251195;"
                        + "User id=dbi251195;"
                        + "password=GME7PlrdGQ;"
                        + "connect timeout=30;";

            connection = new MySqlConnection(connectionInfo);
        }


        public List<Client> GetAllClients()
        {
            String sql = "SELECT * FROM Client";
            MySqlCommand command = new MySqlCommand(sql, connection);
            clientlist = new List<Client>();
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
     
                while (reader.Read())
                {
                    int accountNum =  Convert.ToInt32(reader[0]);
                    string firstName = reader[1].ToString();
                    int age = Convert.ToInt32(reader[2]);
                    
                    string lastName =  reader[3].ToString();
                    string gender = reader[4].ToString();
                    string email =  reader[5].ToString();
                    double accountBalance =  Convert.ToDouble(reader[6]);
                    string status = reader[7].ToString();

                    Client temp = new Client(accountNum, firstName, lastName, email, gender, accountBalance - Client.entranceFee, age, status);
                    if (temp.Status == "in")
                    {
                        temp.ChargeBalance(Client.entranceFee);
                        clientlist.Add(temp);
                    }
                    else if (temp.Status == "reserved")
                    {
                        clientlist.Add(temp);
                    }
                    else if (temp.Status == "out")
                    {
                        temp.ChargeBalance(Client.entranceFee);
                        clientlist.Add(temp);
                    }
                    
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return clientlist;
        }

        public List<Client> GetAllClientsWithStatus(String status)
        {
            String sql = "Select * From Client  Where Status =" + "'"+status+"'";
            MySqlCommand command = new MySqlCommand(sql, connection);
            clientlist = new List<Client>();
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int accountNum = Convert.ToInt32(reader[0]);
                    string firstName = reader[1].ToString();
                    int age = Convert.ToInt32(reader[2]);
                    string lastName = reader[3].ToString();
                    string gender = Convert.ToString(reader[4]);
                    string email = reader[5].ToString();
                    double accountBalance = Convert.ToDouble(reader[6]);
                    string sts = reader[7].ToString();

                    Client temp = new Client(accountNum, firstName, lastName, email, gender, accountBalance, age, status);
                   
                        clientlist.Add(temp);
                    

                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return clientlist;
        }

        public int UpdateClientStatus(string status,int accNum)
        {
            String sql = "UPDATE client SET Status="+ "'"+status+"'" + 
            "WHERE EventAccount ="+ accNum ; 
            MySqlCommand command = new MySqlCommand(sql, connection);


            try
            {

                connection.Open();
                int number = Convert.ToInt32(command.ExecuteScalar());
                return number;
            }
            catch (FormatException)
            {
                return -1;
            }
            finally
            {
                connection.Close();
            }

        }


        public Client AddClient(string firstName, string lastName, string email, string gender, double accountBalance, int age, string status)
        {
            String sql = "INSERT INTO client(FirstName,Age, LastName,gender,Email,AccountBalance,Status) VALUES ('" + firstName + "'," + age + "," + "'" + lastName + "','" + gender + "','" + email + "'," + accountBalance + ",'" + status + "')";
            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {

                connection.Open();
                command.ExecuteReader();
                Client client = new Client(firstName, lastName, email, gender, accountBalance, age, status);
                return client;
            }
            catch(FormatException)
            {
                throw;
                
            }
            finally
            {
                connection.Close();
            }
        }

        public Client SearchVisitor(int acc)
        {
            string balance = "Select * From Client WHERE EventAccount = " + acc + ";";
            MySqlCommand command = new MySqlCommand(balance, connection);
            int AccountNumber;
            string Firstname;
            int birth;
            string Lastname;
            string gender;
            string email;
            double Accountbalance;
            string status;
            Client temp;

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    AccountNumber = Convert.ToInt32(reader[0]);
                    Firstname = Convert.ToString(reader[1]);
                    birth = Convert.ToInt32(reader[2]);
                    Lastname = Convert.ToString(reader[3]);
                    gender = reader[4].ToString();
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
                connection.Close();
            }
        }
     

    
        
        
    }
}
    

