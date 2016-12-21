using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


namespace MyWebshopContract
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class Cwebshop : IWebshop
    {
        List<Item> itemlist;
        string shopname;
        
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }


        public string GetWebshopName()
        {
            return shopname;
        }

        public List<Item> GetProductList()
        {
            return itemlist;
        }

        public string GetProductInfo(string ProductId)
        {
            string answer = "there is no such product";
            foreach (Item i in itemlist)
            {
                if (i.ProductId == ProductId)
                {
                    answer = i.ProductInfo.ToString();
                }
            }
            return answer;
        }

        public bool BuyProduct(string ProductId)
        {
            foreach (Item i in itemlist)
            {
                if (i.ProductId == ProductId)
                {
                    if (i.Stock > 0)
                    {
                        i.Stock--;
                        return true;
                    }
                }
               
            }
            return false;
        }

        public Cwebshop()
        {
            itemlist = new List<Item>();
            shopname = "Vytautas shop";
           
            itemlist.Add(new Item("cola", "drink", 2.89, 9, false));
            itemlist.Add(new Item("laptop", "notebook", 600, 9, false));
            itemlist.Add(new Item("nexus 4", "smartphone", 2.89, 9, false));
        }
    }
}
