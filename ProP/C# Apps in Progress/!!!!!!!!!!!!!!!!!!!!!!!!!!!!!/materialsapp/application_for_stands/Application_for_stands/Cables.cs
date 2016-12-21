using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application_for_stands
{
    class Cables : Material
    {
        private int length;

        //properties
        public int Length { get { return this.length; } }
        public Cables(String name, int id, double rent, int damagecost , int length)
            :base(name, id, rent ,damagecost)
        {
            this.length = length;
        }

        public override string ToString()
        {
            return base.ToString() + " , length: " + length.ToString();
        }
    }
}
