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
using MyWebshopContract;

namespace WebShopClient
{
    public partial class Form1 : Form
    {
        private MyWebshopContract.Service1 proxy;

        public Form1()
        {
            InitializeComponent();
            //proxy = new MyWebshopContract.Service1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(proxy.GetWebshopName());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(proxy.GetProductList());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(proxy.GetProductInfo(textBox1.Text));
        }
    }
}
