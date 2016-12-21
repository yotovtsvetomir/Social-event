using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Application_for_stands
{
    public partial class Form1 : Form
    {
        private MaterialsApp matirial;
        string I1;
        string I2;
        string I3;
        string I4;
        string I5;

        public Form1()
        {
            InitializeComponent();
            matirial = new MaterialsApp();
            I1 = null;
            I2 = null;
            I3 = null;
            I4 = null;
            I5 = null;
            matirial.connect();
            for (int i = 0; i < matirial.GetAllCables1().Count; i++)
            {
                this.listBox1.Items.Add(matirial.GetAllCables1()[i].ToString());
            }
            for (int i = 0; i < matirial.GetAllLaptops1().Count; i++)
            {
                this.listBox2.Items.Add(matirial.GetAllLaptops1()[i].ToString());
            }
            for (int i = 0; i < matirial.GetAllStorageDevices1().Count; i++)
            {
                this.listBox3.Items.Add(matirial.GetAllStorageDevices1()[i].ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {


                int a = this.listBox3.SelectedIndex;
                string str = Convert.ToString(this.listBox3.Items[a]);
                string ID = null;
                string rent = null;
                for (int i = 0; i < 3; i++)
                {
                    if (char.IsDigit(str, i))
                    {
                        ID += str[i];
                    }
                }

                for (int i = 15; i < 26; i++)
                {
                    if (char.IsDigit(str, i))
                    {
                        rent += str[i];
                    }
                }

                if (matirial.PayOrder(Convert.ToInt32(this.textBox2.Text), Convert.ToInt32(rent)))
                {
                    try
                    {
                        if (matirial.rent1(Convert.ToInt32(this.textBox2.Text)))
                        {
                            this.listBox4.Items.Add(matirial.GetAllStorageDevices1()[a].ToString());
                            matirial.rentOut1(Convert.ToInt32(this.textBox2.Text), Convert.ToInt32(ID));
                        }
                        else if (matirial.rent2(Convert.ToInt32(this.textBox2.Text)))
                        {
                            this.listBox4.Items.Add(matirial.GetAllStorageDevices1()[a].ToString());
                            matirial.rentOut2(Convert.ToInt32(this.textBox2.Text), Convert.ToInt32(ID));
                        }
                        else if (matirial.rent3(Convert.ToInt32(this.textBox2.Text)))
                        {
                            this.listBox4.Items.Add(matirial.GetAllStorageDevices1()[a].ToString());
                            matirial.rentOut3(Convert.ToInt32(this.textBox2.Text), Convert.ToInt32(ID));
                        }
                        else if (matirial.rent4(Convert.ToInt32(this.textBox2.Text)))
                        {
                            this.listBox4.Items.Add(matirial.GetAllStorageDevices1()[a].ToString());
                            matirial.rentOut4(Convert.ToInt32(this.textBox2.Text), Convert.ToInt32(ID));
                        }
                        else if (matirial.rent5(Convert.ToInt32(this.textBox2.Text)))
                        {
                            this.listBox4.Items.Add(matirial.GetAllStorageDevices1()[a].ToString());
                            matirial.rentOut5(Convert.ToInt32(this.textBox2.Text), Convert.ToInt32(ID));
                        }
                        else
                        {
                            MessageBox.Show("You already rented 5 items !");
                        }
                        this.listBox3.Items.Clear();
                        for (int i = 0; i < matirial.GetAllStorageDevices1().Count; i++)
                        {
                            this.listBox3.Items.Add(matirial.GetAllStorageDevices1()[i].ToString());
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Nothing selected");
                    }
                }
                else
                {
                    MessageBox.Show(" Sorry you don't have enougn money ");
                }
                this.listBox6.Items.Add(matirial.searchclient(Convert.ToInt32(this.textBox2.Text)));
            }
            catch (Exception)
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = this.listBox1.SelectedIndex;
                string str = Convert.ToString(this.listBox1.Items[a]);
                string ID = null;
                string rent = null;
                for (int i = 0; i < 3; i++)
                {
                    if (char.IsDigit(str, i))
                    {
                        ID += str[i];
                    }
                }

                for (int i = 15; i < 26; i++)
                {
                    if (char.IsDigit(str, i))
                    {
                        rent += str[i];
                    }
                }

                if (matirial.PayOrder(Convert.ToInt32(this.textBox2.Text), Convert.ToInt32(rent)))
                {
                    try
                    {

                            if (matirial.rent1(Convert.ToInt32(this.textBox2.Text)))
                            {
                                this.listBox4.Items.Add(matirial.GetAllCables1()[a].ToString());
                                matirial.rentOut1(Convert.ToInt32(this.textBox2.Text), Convert.ToInt32(ID));
                                this.matirial.searchclient(Convert.ToInt32(this.textBox2.Text)).item1 = Convert.ToInt32(ID);
                            }
                            else if (matirial.rent2(Convert.ToInt32(this.textBox2.Text)))
                            {
                                this.listBox4.Items.Add(matirial.GetAllCables1()[a].ToString());
                                matirial.rentOut2(Convert.ToInt32(this.textBox2.Text), Convert.ToInt32(ID));
                                this.matirial.searchclient(Convert.ToInt32(this.textBox2.Text)).item2 = Convert.ToInt32(ID);
                            }
                            else if (matirial.rent3(Convert.ToInt32(this.textBox2.Text)))
                            {
                                this.listBox4.Items.Add(matirial.GetAllCables1()[a].ToString());
                                matirial.rentOut3(Convert.ToInt32(this.textBox2.Text), Convert.ToInt32(ID));
                                this.matirial.searchclient(Convert.ToInt32(this.textBox2.Text)).item3 = Convert.ToInt32(ID);
                            }
                            else if (matirial.rent4(Convert.ToInt32(this.textBox2.Text)))
                            {
                                this.listBox4.Items.Add(matirial.GetAllCables1()[a].ToString());
                                matirial.rentOut4(Convert.ToInt32(this.textBox2.Text), Convert.ToInt32(ID));
                                this.matirial.searchclient(Convert.ToInt32(this.textBox2.Text)).item4 = Convert.ToInt32(ID);
                            }
                            else if (matirial.rent5(Convert.ToInt32(this.textBox2.Text)))
                            {
                                this.listBox4.Items.Add(matirial.GetAllCables1()[a].ToString());
                                matirial.rentOut5(Convert.ToInt32(this.textBox2.Text), Convert.ToInt32(ID));
                                this.matirial.searchclient(Convert.ToInt32(this.textBox2.Text)).item5 = Convert.ToInt32(ID);
                            }
                            else
                            {
                                MessageBox.Show("You already rented 5 items !");
                            }
                            this.listBox1.Items.Clear();
                            for (int i = 0; i < matirial.GetAllCables1().Count; i++)
                            {
                                this.listBox1.Items.Add(matirial.GetAllCables1()[i].ToString());
                            }
                        }
                        catch (Exception)
                        {
                          MessageBox.Show("Nothing selected");
                        }
                    }
                    else
                    {
                        MessageBox.Show(" Sorry you don't have enougn money ");
                    }
                    this.listBox6.Items.Add(matirial.searchclient(Convert.ToInt32(this.textBox2.Text)));
            }
            catch (Exception)
            {
                MessageBox.Show("Nothing selected");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int a = this.listBox2.SelectedIndex;
                string str = Convert.ToString(this.listBox2.Items[a]);
                string ID = null;
                string rent = null;
                for (int i = 0; i < 3; i++)
                {
                    if (char.IsDigit(str, i))
                    {
                        ID += str[i];
                    }
                }

                for (int i = 15; i < 26; i++)
                {
                    if (char.IsDigit(str, i))
                    {
                        rent += str[i];
                    }
                }

                if (matirial.PayOrder(Convert.ToInt32(this.textBox2.Text), Convert.ToInt32(rent)))
                {
                    try
                    {
                        if (matirial.rent1(Convert.ToInt32(this.textBox2.Text)))
                        {
                            this.listBox4.Items.Add(matirial.GetAllLaptops1()[a].ToString());
                            matirial.rentOut1(Convert.ToInt32(this.textBox2.Text), Convert.ToInt32(ID));
                        }
                        else if (matirial.rent2(Convert.ToInt32(this.textBox2.Text)))
                        {
                            this.listBox4.Items.Add(matirial.GetAllLaptops1()[a].ToString());
                            matirial.rentOut2(Convert.ToInt32(this.textBox2.Text), Convert.ToInt32(ID));
                        }
                        else if (matirial.rent3(Convert.ToInt32(this.textBox2.Text)))
                        {
                            this.listBox4.Items.Add(matirial.GetAllLaptops1()[a].ToString());
                            matirial.rentOut3(Convert.ToInt32(this.textBox2.Text), Convert.ToInt32(ID));
                        }
                        else if (matirial.rent4(Convert.ToInt32(this.textBox2.Text)))
                        {
                            this.listBox4.Items.Add(matirial.GetAllLaptops1()[a].ToString());
                            matirial.rentOut4(Convert.ToInt32(this.textBox2.Text), Convert.ToInt32(ID));
                        }
                        else if (matirial.rent5(Convert.ToInt32(this.textBox2.Text)))
                        {
                            this.listBox4.Items.Add(matirial.GetAllLaptops1()[a].ToString());
                            matirial.rentOut5(Convert.ToInt32(this.textBox2.Text), Convert.ToInt32(ID));
                        }
                        else
                        {
                            MessageBox.Show("You already rented 5 items !");
                        }
                        this.listBox2.Items.Clear();
                        for (int i = 0; i < matirial.GetAllLaptops1().Count; i++)
                        {
                            this.listBox2.Items.Add(matirial.GetAllLaptops1()[i].ToString());
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Nothing selected");
                    }
                }
                else
                {
                    MessageBox.Show("Sorry you don't have enough money");
                }
                this.listBox6.Items.Add(matirial.searchclient(Convert.ToInt32(this.textBox2.Text)));

            }
            catch (Exception)
            {
                MessageBox.Show("Nothing selected");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.listBox4.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int a = this.listBox4.SelectedIndex;
                string str = Convert.ToString(this.listBox4.Items[a]);
                string ID = null;
                for (int i = 0; i < 3; i++)
                {
                    if (char.IsDigit(str, i))
                    {
                        ID += str[i];
                    }
                }
                this.matirial.ReturnItem(Convert.ToInt32(ID));

                try
                {
                    if (matirial.returnBack1(Convert.ToInt32(this.textBox2.Text),Convert.ToInt32(ID)))
                    {
                        this.listBox1.Items.Clear();
                        for (int i = 0; i < matirial.GetAllCables1().Count; i++)
                        {
                            this.listBox1.Items.Add(matirial.GetAllCables1()[i].ToString());
                        }
                        this.listBox2.Items.Clear();
                        for (int i = 0; i < matirial.GetAllLaptops1().Count; i++)
                        {
                            this.listBox2.Items.Add(matirial.GetAllLaptops1()[i].ToString());
                        }
                        this.listBox3.Items.Clear();
                        for (int i = 0; i < matirial.GetAllStorageDevices1().Count; i++)
                        {
                            this.listBox3.Items.Add(matirial.GetAllStorageDevices1()[i].ToString());
                        }
                        this.listBox4.Items.RemoveAt(a);
                    }
                    else if (matirial.returnBack2(Convert.ToInt32(this.textBox2.Text),Convert.ToInt32(ID)))
                    {
                        this.listBox1.Items.Clear();
                        for (int i = 0; i < matirial.GetAllCables1().Count; i++)
                        {
                            this.listBox1.Items.Add(matirial.GetAllCables1()[i].ToString());
                        }
                        this.listBox2.Items.Clear();
                        for (int i = 0; i < matirial.GetAllLaptops1().Count; i++)
                        {
                            this.listBox2.Items.Add(matirial.GetAllLaptops1()[i].ToString());
                        }
                        this.listBox3.Items.Clear();
                        for (int i = 0; i < matirial.GetAllStorageDevices1().Count; i++)
                        {
                            this.listBox3.Items.Add(matirial.GetAllStorageDevices1()[i].ToString());
                        }
                        this.listBox4.Items.RemoveAt(a);
                    }
                    else if (matirial.returnBack3(Convert.ToInt32(this.textBox2.Text), Convert.ToInt32(ID)))
                    {
                        this.listBox1.Items.Clear();
                        for (int i = 0; i < matirial.GetAllCables1().Count; i++)
                        {
                            this.listBox1.Items.Add(matirial.GetAllCables1()[i].ToString());
                        }
                        this.listBox2.Items.Clear();
                        for (int i = 0; i < matirial.GetAllLaptops1().Count; i++)
                        {
                            this.listBox2.Items.Add(matirial.GetAllLaptops1()[i].ToString());
                        }
                        this.listBox3.Items.Clear();
                        for (int i = 0; i < matirial.GetAllStorageDevices1().Count; i++)
                        {
                            this.listBox3.Items.Add(matirial.GetAllStorageDevices1()[i].ToString());
                        }
                        this.listBox4.Items.RemoveAt(a);
                    }
                    else if (matirial.returnBack4(Convert.ToInt32(this.textBox2.Text), Convert.ToInt32(ID)))
                    {
                        this.listBox1.Items.Clear();
                        for (int i = 0; i < matirial.GetAllCables1().Count; i++)
                        {
                            this.listBox1.Items.Add(matirial.GetAllCables1()[i].ToString());
                        }
                        this.listBox2.Items.Clear();
                        for (int i = 0; i < matirial.GetAllLaptops1().Count; i++)
                        {
                            this.listBox2.Items.Add(matirial.GetAllLaptops1()[i].ToString());
                        }
                        this.listBox3.Items.Clear();
                        for (int i = 0; i < matirial.GetAllStorageDevices1().Count; i++)
                        {
                            this.listBox3.Items.Add(matirial.GetAllStorageDevices1()[i].ToString());
                        }
                        this.listBox4.Items.RemoveAt(a);
                    }
                    else if (matirial.returnBack5(Convert.ToInt32(this.textBox2.Text), Convert.ToInt32(ID)))
                    {
                        this.listBox1.Items.Clear();
                        for (int i = 0; i < matirial.GetAllCables1().Count; i++)
                        {
                            this.listBox1.Items.Add(matirial.GetAllCables1()[i].ToString());
                        }
                        this.listBox2.Items.Clear();
                        for (int i = 0; i < matirial.GetAllLaptops1().Count; i++)
                        {
                            this.listBox2.Items.Add(matirial.GetAllLaptops1()[i].ToString());
                        }
                        this.listBox3.Items.Clear();
                        for (int i = 0; i < matirial.GetAllStorageDevices1().Count; i++)
                        {
                            this.listBox3.Items.Add(matirial.GetAllStorageDevices1()[i].ToString());
                        }
                        this.listBox4.Items.RemoveAt(a);
                    }
                    else
                    {
                        MessageBox.Show("You didn't rent anything");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("nothing selected");
                }
                this.listBox6.Items.Add(matirial.searchclient(Convert.ToInt32(this.textBox2.Text)));
            }
            catch (Exception)
            {
                MessageBox.Show("Nothing selected");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            List<Material> templist;
            try
            {
                I1 = null;
                I2 = null;
                I3 = null;
                I4 = null;
                I5 = null;
                this.listBox6.Items.Add(matirial.searchclient(Convert.ToInt32(this.textBox2.Text)));
                this.listBox6.SelectedIndex = listBox6.Items.Count - 1;
                int a = this.listBox6.SelectedIndex;
                string str = Convert.ToString(this.listBox6.Items[a]);

                for (int i = str.Length - 44; i < str.Length - 37; i++)
                {
                    if (char.IsDigit(str, i))
                    {
                        I1 += str[i];
                    }
                }
                for (int i = str.Length - 36; i < str.Length - 30; i++)
                {
                    if (char.IsDigit(str, i))
                    {
                        I2 += str[i];
                    }
                }
                for (int i = str.Length - 27; i < str.Length - 20; i++)
                {
                    if (char.IsDigit(str, i))
                    {
                        I3 += str[i];
                    }
                }
                for (int i = str.Length - 19; i < str.Length - 12; i++)
                {
                    if (char.IsDigit(str, i))
                    {
                        I4 += str[i];
                    }
                }
                for (int i = str.Length - 11; i < str.Length; i++)
                {
                    if (char.IsDigit(str, i))
                    {
                        I5 += str[i];
                    }
                }


                templist = new List<Material>();
                if (Convert.ToInt32(I1) != 0 )
                {
                    templist.Add(matirial.GetMatiral(Convert.ToInt32(I1)));
                }
                if (Convert.ToInt32(I2) != 0 )
                {
                    templist.Add(matirial.GetMatiral(Convert.ToInt32(I2)));
                }
                if (Convert.ToInt32(I3) != 0 )
                {
                    templist.Add(matirial.GetMatiral(Convert.ToInt32(I3)));
                }
                if (Convert.ToInt32(I4) != 0 )
                {
                    templist.Add(matirial.GetMatiral(Convert.ToInt32(I4)));
                }
                if (Convert.ToInt32(I5) != 0 )
                {
                    templist.Add(matirial.GetMatiral(Convert.ToInt32(I5)));
                }

                this.listBox4.Items.Clear();
                for (int i = 0; i < templist.Count; i++)
                {
                    listBox4.Items.Add(templist[i].ToString());
                }
            }
            catch (Exception)
            {
            }

        }
    }
}
