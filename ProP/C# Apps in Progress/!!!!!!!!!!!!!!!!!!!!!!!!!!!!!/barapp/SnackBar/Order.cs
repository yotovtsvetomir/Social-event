using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SnackBar
{
    class Order
    {
        private double totalprice = 0;
        public double Price { get { return totalprice; } }

        public double TotalPrice(BarApp bar, int i, int quanlity, Food p)
        {
            totalprice += Convert.ToDouble(bar.GetAllSnacks()[i].TotalPrice(quanlity).ToString("0.00"));
            return totalprice;
        }

        public double TotalPrice(BarApp bar, int i, int quanlity, Drinks p)
        {
            totalprice += Convert.ToDouble(bar.GetAllDrinks()[i].TotalPrice(quanlity));
            return totalprice;
        }

        public double TotalPriceAfterRemove(double price)
        {
            this.totalprice -= price;
            return totalprice;
        }
    }
}
