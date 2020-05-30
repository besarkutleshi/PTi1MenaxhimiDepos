using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTi1MenaxhimiDepos.BO.Invoices
{
    public class InvertoryHeader : AuditionAtributtes
    {
        public InvertoryHeader(int invertoryID, string docNo,int docTypeID,int posID,string description,int supplierid =0)
        {
            InvertoryID = invertoryID;
            DocNo = docNo;
            DocTypeID = docTypeID;
            PosID = posID;
            Description = description;
            SupplierID = supplierid;
            Bodies = new List<InvertoryBody>();
        }

        public InvertoryHeader(int invertoryID, string docNo,DateTime dt,string description)
        {
            InvertoryID = invertoryID;
            DocNo = docNo;
            DocDate = dt;
            Description = description;
        }

        public int InvertoryID { get; set; }
        public string DocNo { get; set; }
        public DateTime DocDate { get; set; }
        public int DocTypeID { get; set; }
        public virtual DocType DocType { get; set; }
        public int PosID { get; set; }
        public virtual PointofSale POS { get; set; }
        public string Description { get; set; }
        public int SupplierID { get; set; }
        public virtual Supplier Supplier { get; set; }
        public List<InvertoryBody> Bodies { get; set; }
    }
}
