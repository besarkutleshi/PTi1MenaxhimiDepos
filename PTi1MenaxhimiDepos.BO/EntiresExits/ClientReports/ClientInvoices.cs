using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTi1MenaxhimiDepos.BO.EntiresExits.ClientReports
{
    public class ClientInvoices
    {
        public ClientInvoices(int invertoryID, string docNo, string invoiceType, DateTime docDate, string posName, double amount)
        {
            InvertoryID = invertoryID;
            DocNo = docNo;
            InvoiceType = invoiceType;
            DocDate = docDate;
            PosName = posName;
            Amount = amount;
        }

        public int InvertoryID { get; set; }
        public string DocNo { get; set; }
        public string InvoiceType { get; set; }
        public DateTime DocDate { get; set; }
        public string PosName { get; set; }
        public double Amount { get; set; }

    }
}
