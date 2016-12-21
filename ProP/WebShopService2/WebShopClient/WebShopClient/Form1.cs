using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;

namespace WebShopClient
{
    public partial class Form1 : Form
    {
        private ServiceReference1.WebshopClient proxy;
        
        public Form1()
        {
            InitializeComponent();
            proxy = new ServiceReference1.WebshopClient();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = proxy.GetWebshopName();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            foreach (var i in proxy.GetProductList()) 
            {
                listBox1.Items.Add(i.ProductId);
                listBox2.Items.Add(i.Price);
                listBox3.Items.Add(i.Stock);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                MessageBox.Show(proxy.GetProductInfo(listBox1.SelectedItem.ToString()));
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                if (proxy.BuyProduct(listBox1.SelectedItem.ToString()))
                {
                    MessageBox.Show("You bought one " + listBox1.SelectedItem.ToString() + ".");

                }
                else
                {
                    MessageBox.Show("No " + listBox1.SelectedItem.ToString() + " left.");
                }
            }

        }


    }
}
