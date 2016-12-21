using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SnackBar
{
    public partial class SnackBarForm : Form
    {
        private BarApp bar;
        private Order order;

        public SnackBarForm()
        {
            InitializeComponent();
            bar = new BarApp();
            this.order = new Order();
            bar.connect();
            for (int i = 0; i < bar.GetAllSnacks().Count; i++)
            {
                this.listBoxSnacks.Items.Add(bar.GetAllSnacks()[i].ToString());
            }
            for (int i = 0; i < bar.GetAllDrinks().Count; i++)
            {
                this.listBoxDrinks.Items.Add(bar.GetAllDrinks()[i].ToString());
            }
            this.timer1.Start();
        }

        private void btAddSnack_Click(object sender, EventArgs e)
        {
            try
            {
                int a = this.listBoxSnacks.SelectedIndex;
                if (bar.GetAllSnacks()[a].Stock >= Convert.ToInt32(this.textBox1.Text) && Convert.ToInt32(this.textBox1.Text) > 0)
                {  
                    this.lbOrders.Items.Add(bar.GetAllSnacks()[a].AsString(Convert.ToInt32(this.textBox1.Text)));
                    this.lbTotalPrice.Text = "€" + Convert.ToString(order.TotalPrice(bar, a, Convert.ToInt32(this.textBox1.Text), bar.GetAllSnacks()[a]));
                }
                else
	            {
                    MessageBox.Show("Not enough in stock");
	            }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Please type in right quality");
            }

        }

        private void btAddDrink_Click(object sender, EventArgs e)
        {
            try
            {
                int a = this.listBoxDrinks.SelectedIndex;
                if (bar.GetAllDrinks()[a].Stock >= Convert.ToInt32(this.textBox1.Text) && Convert.ToInt32(this.textBox1.Text) > 0)
                {
                    this.lbOrders.Items.Add(bar.GetAllDrinks()[a].AsString(Convert.ToInt32(this.textBox1.Text)));

                    this.lbTotalPrice.Text = "€" + Convert.ToString(order.TotalPrice(bar, a, Convert.ToInt32(this.textBox1.Text),bar.GetAllDrinks()[a]));
                }
                else
                {
                    MessageBox.Show("Not enough in stock");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please type in right quality");
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            try
            {
                int a = this.lbOrders.SelectedIndex;
                string str = Convert.ToString(this.lbOrders.Items[a]);
                string number = null;
                this.lbOrders.Items.RemoveAt(a);

                for (int i = str.Length - 18; i < str.Length - 12; i++)
                {
                    if (char.IsDigit(str, i) || char.IsPunctuation(str,i))
                    {
                        number += str[i];
                    }
                }

                this.lbTotalPrice.Text = "€" + Convert.ToString(order.TotalPriceAfterRemove(Convert.ToDouble(number)));
            }
            catch (Exception)
            {
                MessageBox.Show("Nothing selected");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                order = new Order();
                this.lbOrders.Items.Clear();
                this.lbTotalPrice.Text = "€" + Convert.ToString(this.order.Price);
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }

        }

        private void btPay_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.bar.PayOrder(Convert.ToInt32(this.textBox2.Text), this.order.Price))
                {
                    order = new Order();
                    this.lbTotalPrice.Text = "€" + Convert.ToString(this.order.Price);

                    //==============================================================
                    try
                    {
                        for (int index = 0; index < lbOrders.Items.Count; index++)
                        {
                            string str = Convert.ToString(this.lbOrders.Items[index]);
                            string ID = null;
                            string Quanlity = null;
                            for (int i = 0; i < str.Length - 25; i++)
                            {
                                if (char.IsDigit(str, i))
                                {
                                    ID += str[i];
                                }
                            }

                            for (int i = 33; i < str.Length; i++)
                            {
                                if (char.IsNumber(str, i))
                                {
                                    Quanlity += str[i];
                                }
                            }
                            this.bar.buySnack(Convert.ToInt32(ID), Convert.ToInt32(Quanlity));
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("error");
                    }
                    this.lbOrders.Items.Clear();
                }
                else
                {
                    MessageBox.Show("Not enough money or wrong Account-Number");
                }
                this.listBoxDrinks.Items.Clear();
                this.listBoxSnacks.Items.Clear();

                for (int i = 0; i < bar.GetAllSnacks().Count; i++)
                {
                    this.listBoxSnacks.Items.Add(bar.GetAllSnacks()[i].ToString());
                }

                for (int i = 0; i < bar.GetAllDrinks().Count; i++)
                {
                    this.listBoxDrinks.Items.Add(bar.GetAllDrinks()[i].ToString());
                }

                this.listBox1.Items.Add(bar.searchclient(Convert.ToInt32(this.textBox2.Text)));
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong Account Number");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.listBox1.Items.Add(bar.searchclient(Convert.ToInt32(this.textBox2.Text)));
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong Account Number");
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bar.connect();
            this.listBoxDrinks.Items.Clear();
            this.listBoxSnacks.Items.Clear();
            for (int i = 0; i < bar.GetAllSnacks().Count; i++)
            {
                this.listBoxSnacks.Items.Add(bar.GetAllSnacks()[i].ToString());
            }
            for (int i = 0; i < bar.GetAllDrinks().Count; i++)
            {
                this.listBoxDrinks.Items.Add(bar.GetAllDrinks()[i].ToString());
            }
        }
    }
}
