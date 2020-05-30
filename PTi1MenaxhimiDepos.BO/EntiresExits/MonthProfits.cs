using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTi1MenaxhimiDepos.BO.EntiresExits
{
    public class MonthProfits
    {
        public MonthProfits(string month, double profit)
        {
            Month = month;
            Profit = profit;
        }

        public string Month { get; set; }
        public double Profit { get; set; }
    }
}
