using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTi1MenaxhimiDepos.BO.Invoices
{
    public class InvertoryHeader : AuditionAtributtes
    {
        public InvertoryHeader(int invertoryID, int docNo,int docTypeID,int posID,string description, int clientID)
        {
            InvertoryID = invertoryID;
            DocNo = docNo;
            DocTypeID = docTypeID;
            PosID = posID;
            Description = description;
            ClientID = clientID;
        }

        public InvertoryHeader(int invertoryID, int docNo,DateTime dt,string description)
        {
            InvertoryID = invertoryID;
            DocNo = docNo;
            DocDate = dt;
            Description = description;
        }

        public int InvertoryID { get; set; }
        public int DocNo { get; set; }
        public DateTime DocDate { get; set; }
        public int DocTypeID { get; set; }
        public virtual DocType DocType { get; set; }
        public int PosID { get; set; }
        public virtual PointofSale POS { get; set; }
        public string Description { get; set; }
        public int ClientID { get; set; }
        public virtual Client Client { get; set; }
        public List<InvertoryBody> Bodies { get; set; }
    }
}
