using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTi1MenaxhimiDepos.BO.EntiresExits
{
    public class ClientReport
    {
        public ClientReport(int iD, string name, double amount)
        {
            ID = iD;
            Name = name;
            Amount = amount;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public double Amount { get; set; }
    }
}
