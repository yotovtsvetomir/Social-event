using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsepectStatus
{
    public partial class Form1 : Form
    {
        connect connector;
        public Form1()
        {
            InitializeComponent();
            connector = new connect();
            connector.connecting();
            this.lbinside.Text = connector.VisitorsInside().ToString();
            this.lbTotal.Text = connector.TotalVisitors().ToString();
            this.lbAge.Text = connector.AverageAge().ToString();
            this.lbRatio.Text = connector.GenderRatio().ToString() + " : 1";
            this.lbBalance.Text = "€ " + connector.AverageBalance().ToString();
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lbinside.Text = connector.VisitorsInside().ToString();
            this.lbTotal.Text = connector.TotalVisitors().ToString();
            this.lbAge.Text = connector.AverageAge().ToString();
            this.lbRatio.Text = connector.GenderRatio().ToString() + " : 1";
            this.lbBalance.Text = "€ " + connector.AverageBalance().ToString();
        }
    }
}
