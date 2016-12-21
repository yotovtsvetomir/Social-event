using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        DBhelper connectionDB;
        Statistics stats; //Object with information about statistics
        //Client tempClient;

        public Form1()
        {
            InitializeComponent();
            connectionDB = new DBhelper();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void buttonGetStatistics_Click(object sender, EventArgs e)
        {
            stats = connectionDB.AskForStatistics();

            this.chartVisits.Series["visits"].Points.AddXY("In Event", stats.VisitorsInEvent);
            this.chartVisits.Series["visits"].Points.AddXY("Not InEvent ", stats.VisitorsTotal-stats.VisitorsInEvent);
            this.labelInEvent.Text = " Total Visitors " + stats.VisitorsTotal+ ", in event "+stats.VisitorsInEvent  ;

            this.ChartMoney.Series["Money In Accounts"].Points.AddXY("In Accounts", stats.TotalMoney);
            this.ChartMoney.Series["Money Spent"].Points.AddXY("Spent", stats.MoneySpend);
            this.labelMoney.Text = "Money in accounts: " + stats.TotalMoney+", already spend: "+stats.MoneySpend;
        }
    }
}
