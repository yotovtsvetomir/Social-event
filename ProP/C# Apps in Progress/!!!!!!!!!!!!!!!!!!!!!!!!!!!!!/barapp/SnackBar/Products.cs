using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SnackBar
{
    abstract class Products
    {
        private String name;
        private int stock;
        private double price;
        private int id;
        private double orderprice;


        //properties
        public string Name { get { return this.Name; } }
        public double Price { get { return this.price; } }
        public int Stock { get { return this.stock; } }
        public double OrderPrice { get { return this.orderprice; } }
        public int ID { get { return this.id; } }

        //constructor
        public Products(String name, double price, int stock,int id)
        {
            this.name = name;
            this.price = price;
            this.stock = stock;
            this.id = id;
        }

        public override string ToString()
        {
            return this.name + " - €" + price.ToString("0.00") + " , " + stock + " in stock .";
        }

        public virtual string AsString(int quanlity)
        {

            return Convert.ToString(this.id) + " || " + this.name +  " price : €  " + (this.price * quanlity).ToString("0.00") + " quanlity : " + Convert.ToString(quanlity);
        }

        public Double TotalPrice(int quanlity)
        {
            this.orderprice += Convert.ToDouble(this.price * quanlity);
            return this.orderprice;
        }
    }
}
