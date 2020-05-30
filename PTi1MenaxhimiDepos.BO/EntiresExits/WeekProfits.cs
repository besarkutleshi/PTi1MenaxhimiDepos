using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTi1MenaxhimiDepos.BO.EntiresExits
{
    public class WeekProfits
    {
        public WeekProfits(string day, double profit)
        {
            Day = day;
            Profit = profit;
        }

        public string Day { get; set; }
        public double Profit { get; set; }
    }
}
