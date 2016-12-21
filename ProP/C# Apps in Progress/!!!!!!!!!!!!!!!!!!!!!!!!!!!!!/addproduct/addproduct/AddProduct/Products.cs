using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddProduct
{
    abstract class Products
    {
        private String name;
        private int stock;
        private double price;
        private int id;
        private int orderprice;


        //properties
        public string Name { get { return this.Name; } }
        public double Price { get { return this.price; } }
        public int Stock { get { return this.stock; } }
        public int OrderPrice { get { return this.orderprice; } }
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
            return Convert.ToString(this.id) + " | " + this.name + " - €" + price.ToString("0.00") + " --------- " + stock + " in stock .";
        }

        public virtual string AsString(int quanlity)
        {

            return Convert.ToString(this.id) + " || " + this.name +  " price : €" + Convert.ToString(this.price * quanlity) + " quanlity : " + Convert.ToString(quanlity);
        }

        public int TotalPrice(int quanlity)
        {
            this.orderprice += Convert.ToInt32(this.price * quanlity);
            return this.orderprice;
        }
    }
}
