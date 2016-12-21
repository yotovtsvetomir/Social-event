using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SnackBar
{
    class ListOfClients
    {
        List<Client> clientList;

        public ListOfClients()
        {
            clientList = new List<Client>();
        }

        public List<Client> GetAllClients()
        {
            //We need to get whole table from the database which will be created .

            return clientList;
        }

        public List<Client> GetAllClientsWithStatus(String status)
        {
            List<Client> templist = new List<Client>();
            //Use foreach to check the status for every client and "put" him in the list if he is inside of the event.
            foreach (Client client in this.GetAllClients())
            {
                if (client.Status == status)
                    templist.Add(client);

            }
            return templist;
        }
        public void RemoveClient(int accountNumber)
        {
            //if (client.AccountNum == accountNumber)
            //remove the client from the database



        }
        public Client SearchClient(int accountNumber)
        {
            Client client = new Client(111, "example", "example");
            return client;
        }

        public void AddClient(int accountNum, int reservationNum, string firstName, string lastName, string email, char gender, double accountBalance, int age)
        {
            //accountNumber & ReservationNumber should be autonumber
            Client client = new Client(accountNum, firstName, lastName, email, gender, accountBalance, age, "inside");
            //add client object to the database - we don't need to add him to a list, cause the list is getting actual data from the DB
            clientList.Add(client);
        }



    }
}
