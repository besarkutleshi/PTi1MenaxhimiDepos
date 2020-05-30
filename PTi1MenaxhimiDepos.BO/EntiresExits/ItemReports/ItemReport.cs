using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTi1MenaxhimiDepos.BO.EntiresExits.ItemReports
{
    public class ItemReport
    {
        public ItemReport(string barcode, string name, long quantity)
        {
            Barcode = barcode;
            Name = name;
            Quantity = quantity;
        }

        public string Barcode { get; set; }
        public string Name { get; set; }
        public long Quantity { get; set; }
    }
}
