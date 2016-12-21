using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Recharging
{
    public partial class Form1 : Form
    {
        private Connection connect;
        public Form1()
        {
            InitializeComponent();
            connect = new Connection();
            connect.connect();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream file = null;
            StreamWriter stream = null;
            try
            {
                if (Convert.ToInt32(textBox2.Text) >= 0)
                {
                    connect.RechargeBalance(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
                    this.listBox1.Items.Add(connect.searchclient(Convert.ToInt32(textBox1.Text)));


                        file = new FileStream("InfoBalance.txt", FileMode.Append, FileAccess.Write);
                        stream = new StreamWriter(file);

                        stream.WriteLine(connect.searchclient(Convert.ToInt32(textBox1.Text)).AsString(Convert.ToInt32(textBox2.Text)) + "\n");
                }
                else
                {
                    MessageBox.Show("Please type a positive amount");
                }

            }
            catch (Exception)
            {
                MessageBox.Show(" please type right account number and right amount ");
            }
            finally
            {
                if (file != null)
                { stream.Close(); }
                if (stream != null)
                {
                    file.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.listBox1.Items.Add(connect.searchclient(Convert.ToInt32(textBox1.Text)));
            }
            catch (Exception)
            {
                MessageBox.Show("No such client");
            }

        }
    }
}
