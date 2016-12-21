using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace SnackBar
{
    class Drinks : Products
    {
        private bool alcoholic;
        public bool Alcoholic { get { return this.alcoholic; } }


        public Drinks(String name, double price,int stock,int id, bool alc)
            : base(name, price,stock,id){this.alcoholic = alc;}

        public override string ToString()
        {
            string alcohol = "";
            if (alcoholic == true){ alcohol = "alcoholic"; }
            else if(alcoholic == false){ alcohol = "non-alcoholic"; }
            return base.ToString() + " Alcoholic : " + alcohol;
        }

    }
}
