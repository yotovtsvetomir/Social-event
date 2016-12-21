using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application_for_stands
{
    class StorageDevices : Material
    {
        private int size;

        public int Size { get { return this.size; } }

        public StorageDevices(String name, int id, double rent, int size ,int damageCost)
            :base(name, id, rent,damageCost)
        {
            this.size = size;
        }

        public override string ToString()
        {
            return base.ToString() + " , Capacity: " + size.ToString() + " MB";
        }
    }
}
