using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppForRegistration
{
    class Client
    {
        public static int entranceFee = 45; 
        private int accountNum;
        private string firstName;
        private string lastName;
        private string email;
        private string gender;
        private int age;
        private double accountBalance;
        private string status;
        //-------------only getter------------
        public int AccountNum { get { return this.accountNum; } }
        public string FirstName { get { return this.firstName; } }
        public string LastName { get { return this.lastName; } }
        public string Email { get { return this.email; } }
        public string Gender { get { return this.gender; } }
        public int Age { get { return this.age; } }
        public double AccountBalance { get { return this.accountBalance; } }
        //-------------both getter and setter--
        public string Status { get {return this.status ;}  }
        

        public Client(int accountNum, string firstName, string lastName, string email, string gender, double accountBalance, int age, string status)
        {
           
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.gender = gender;
            this.accountBalance = accountBalance;
            this.age = age;
            this.status = status;
            this.accountNum = accountNum;

        }

        public Client(string firstName, string lastName, string email, string gender, double accountBalance, int age, string status)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.gender = gender;
            this.accountBalance = accountBalance;
            this.age = age;
            this.status = status;
        }


      
        public void ChargeBalance(double amount)
        {
            if (amount > 0)
            {
                this.accountBalance += amount;
            }
        }

      

        public override string ToString()
        {
            return accountNum + ": " + firstName + " " + lastName +" €"+ accountBalance +" "+ status+ " "+ gender;
        }
    }
}
