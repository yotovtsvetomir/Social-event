using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Statistics
    {
                
        public int VisitorsTotal;
        public int VisitorsInEvent;
        public int MoneySpend;
        public int TotalMoney;

        public Statistics(int VisitorsTotal, int VisitorsInEvent, int MoneySpend, int TotalMoney)
        {
            this.VisitorsTotal = VisitorsTotal;
            this.VisitorsInEvent = VisitorsInEvent;
            this.MoneySpend = MoneySpend;
            this.TotalMoney = TotalMoney;
        }
    }
}
