using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace SnackBar
{
    class Food : Products
    {
        public Food(String name, double price, int stock, int id)
            : base(name, price,stock,id){}

        public override string ToString()
        {
            return base.ToString();
        }

        public override string AsString(int quanlity)
        {
            return base.AsString(quanlity);
        }
    }
}
