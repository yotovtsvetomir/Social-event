using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application_for_stands
{
    class Laptop : Material
    {
        private string brand;

        //properties
        public string Brand { get { return this.brand; } }
        public Laptop(String name, int id, double rent, int damagecost , string brand)
            :base(name, id, rent,damagecost)
        {
            this.brand = brand;
        }

        public override string ToString()
        {
            return base.ToString() + " ,Brand: " + brand;
        }
    }
}
