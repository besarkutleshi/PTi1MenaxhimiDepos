using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTi1MenaxhimiDepos.BO.EntiresExits.SupplierReports
{
    public class SupplierReport
    {
        public SupplierReport(int supplierID, string name, double amount)
        {
            SupplierID = supplierID;
            Name = name;
            Amount = amount;
        }

        public int SupplierID { get; set; }
        public string Name { get; set; }
        public double Amount { get; set; }

    }
}
