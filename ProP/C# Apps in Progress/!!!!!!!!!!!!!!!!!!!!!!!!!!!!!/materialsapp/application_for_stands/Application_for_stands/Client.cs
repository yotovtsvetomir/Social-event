using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application_for_stands
{
    class Client
    {
        private int accountNum;
        private string firstName;
        private string lastName;
        private string email;
        private char gender;
        private int age;
        private double accountBalance;
        //-------------only getter------------
        public int AccountNum { get { return this.accountNum; } }
        public string FirstName { get { return this.firstName; } }
        public string LastName { get { return this.lastName; } }
        public string Email { get { return this.email; } }
        public char Gender { get { return this.gender; } }
        public int Age { get { return this.age; } }
        public double AccountBalance { get { return this.accountBalance; } }
        //-------------both getter and setter--
        public string Status { get; set; }
        public int item1 { get; set; }
        public int item2 { get; set; }
        public int item3 { get; set; }
        public int item4 { get; set; }
        public int item5 { get; set; }

        public Client(int accountNum, string firstName, string lastName, string email, char gender, double accountBalance, int age, string status)
        {
            this.accountNum = accountNum;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.gender = gender;
            this.accountBalance = accountBalance;
            this.age = age;
            this.Status = status;
        }

        public Client(int accountNum, string firstName, string lastName)
        {
            this.accountNum = accountNum;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Boolean Pay(double amount)
        {
            if (amount <= this.accountBalance)
            {
                this.accountBalance -= amount;
                return true;
            }

            return false;
        }
        public Boolean ChargeBalance(double amount)
        {
            if (amount > 0)
            {
                this.accountBalance += amount;
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            return "AccNum: " + Convert.ToString(accountNum).PadLeft(6, '0') + " ; " + firstName + " " + lastName + " , Balance: €" + accountBalance + "-------" + item1 + "-------" + item2 + "-------" + item3 + "-------" + item4 + "-------" + item5 + "-------";
        }
    }
}
