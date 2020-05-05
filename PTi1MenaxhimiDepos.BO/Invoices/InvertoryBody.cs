using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTi1MenaxhimiDepos.BO.Invoices
{
    public class InvertoryBody:AuditionAtributtes
    {
        public InvertoryBody(int id,int headerID, int itemID,double quantity, double price,double discount)
        {
            ID = id;
            HeaderID = headerID;
            ItemID = itemID;
            Quantity = quantity;
            Price = price;
            Discount = discount;
        }

        public InvertoryBody(int id,int headerid,double quantity,double price,DateTime dt,double discount)
        {
            ID = id;
            HeaderID = headerid;
            Quantity = quantity;
            Price = price;
            Cdate = dt;
            Discount = discount;
        }

        public int ID { get; set; }
        public int HeaderID { get; set; }
        public virtual InvertoryHeader Header { get; set; }
        public int ItemID { get; set; }
        public virtual Item Item { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }
        public DateTime Cdate { get; set; }
        public double Discount { get; set; }

    }
}
