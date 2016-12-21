using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application_for_stands
{
    class Material
    {
        private String name;
        private int id;
        private double rent;
        private int damageCost;
        //private DateTime rentStartTime;

        public string Name { get { return this.Name; } }
        public int Id { get { return this.id; } }
        public double Rent { get { return this.rent; } }
        public int DamageCost { get { return this.damageCost; } }
        //public DateTime RentStarTime {get {return this.rentStartTime;}}

        public Material(String name, int id, double rent , int damageCost)
        {
            this.name = name;
            this.id = id;
            this.rent = rent;
            this.damageCost = damageCost;
        }
        //public double TotalCost()
        //{
        //    double totalAmount = (DateTime.Now.CompareTo(this.rentStartTime));
        //    return totalAmount;
        //}
        public override string ToString()
        {
            return Convert.ToString(id) + " || " + this.name + " , Rent: €" + rent.ToString();
        }
    }
}
