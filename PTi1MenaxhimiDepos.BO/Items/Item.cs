using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTi1MenaxhimiDepos.BO
{
    public class Item : AuditionAtributtes
    {
        public Item(int id,string barcode, string name, int unit, int category, int type,int supplier, bool active, int stockquantity,string description)
        {
            ID = id;
            Barcode = barcode;
            Name = name;
            UnitID = unit;
            CategoryId = category;
            TypeID = type;
            SupplierID = supplier;
            Active = active;
            Description = description;
            StockQuantity = stockquantity;
        }

        public Item(int id,string barcode, string name, bool active, int stockquantity, string description)
        {
            ID = id;
            Barcode = barcode;
            Name = name;
            Active = active;
            Description = description;
            StockQuantity = stockquantity;
        }

        public int ID { get; set; }
        public string Barcode { get; set; }
        public string Name { get; set; }
        public virtual ItemUnit Unit { get; set; }
        public int UnitID { get; set; }
        public virtual ItemCategory Category { get; set; }
        public int CategoryId { get; set; }
        public virtual ItemType Type { get; set; }
        public int TypeID { get; set; }
        public virtual Supplier Supplier { get; set; }
        public int SupplierID { get; set; }
        public bool Active { get; set; }
        public int StockQuantity { get; set; }
        public string Description { get; set; }
    }
}
