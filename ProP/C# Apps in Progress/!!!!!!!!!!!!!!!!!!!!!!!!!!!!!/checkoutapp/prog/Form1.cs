using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EntranceApp
{
    public partial class Form1 : Form
    {
        private connection connect;
        public Form1()
        {
            InitializeComponent();
            connect = new connection();
            connect.connect();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (connect.Check(Convert.ToInt32(this.tbEventAcc.Text)))
                {
                    connect.connect();
                    connect.RemoveClient(Convert.ToInt32(tbEventAcc.Text));
                    this.listBox1.Items.Add(" Client: " + this.tbEventAcc.Text + " has left");
                }
                else
                {
                    MessageBox.Show("You didn't return all item");
                }

            }
            catch (Exception)
            {
                MessageBox.Show(" Account number is wrong ");
            }
            
        }
    }
}
