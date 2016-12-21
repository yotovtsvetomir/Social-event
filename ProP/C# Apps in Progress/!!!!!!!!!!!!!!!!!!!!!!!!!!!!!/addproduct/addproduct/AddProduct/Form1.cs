using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddProduct
{
    public partial class Form1 : Form
    {
        Add adding;
        public Form1()
        {
            InitializeComponent();
            adding = new Add();
            adding.connect();

            for (int i = 0; i < adding.GetAllSnacks().Count; i++)
            {
                this.listBoxSnacks.Items.Add(adding.GetAllSnacks()[i].ToString());
            }

            for (int i = 0; i < adding.GetAllDrinks().Count; i++)
            {
                this.listBoxDrinks.Items.Add(adding.GetAllDrinks()[i].ToString());
            }

            this.timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                string ID = null;
                int selectindex1 = listBoxSnacks.SelectedIndex;
                string str1 = Convert.ToString(this.listBoxSnacks.Items[selectindex1]);

                for (int i = 0; i < str1.Length - 30; i++)
                        {
                            if (char.IsDigit(str1, i))
                            {
                                ID += str1[i];
                            }
                        }
                adding.AddSnacks(Convert.ToInt32(ID), Convert.ToInt32(this.textBox1.Text));
            }
            else if (radioButton2.Checked)
            {
                string ID = null;
                int selectindex2 = listBoxDrinks.SelectedIndex;
                string str2 = Convert.ToString(this.listBoxDrinks.Items[selectindex2]);

                for (int i = 0; i < str2.Length - 55; i++)
                        {
                            if (char.IsDigit(str2, i))
                            {
                                ID += str2[i];
                            }
                        }
                adding.AddSnacks(Convert.ToInt32(ID), Convert.ToInt32(this.textBox1.Text));
            }

            this.listBoxSnacks.Items.Clear();
            this.listBoxDrinks.Items.Clear();

            for (int i = 0; i < adding.GetAllSnacks().Count; i++)
            {
                this.listBoxSnacks.Items.Add(adding.GetAllSnacks()[i].ToString());
            }

            for (int i = 0; i < adding.GetAllDrinks().Count; i++)
            {
                this.listBoxDrinks.Items.Add(adding.GetAllDrinks()[i].ToString());
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.listBoxDrinks.Items.Clear();
            this.listBoxSnacks.Items.Clear();
            for (int i = 0; i < adding.GetAllSnacks().Count; i++)
            {
                this.listBoxSnacks.Items.Add(adding.GetAllSnacks()[i].ToString());
            }

            for (int i = 0; i < adding.GetAllDrinks().Count; i++)
            {
                this.listBoxDrinks.Items.Add(adding.GetAllDrinks()[i].ToString());
            }
        }

    }
}
