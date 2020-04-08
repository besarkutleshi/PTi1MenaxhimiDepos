using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTi1MenaxhimiDepos.BO
{
    public class Item : AuditionAtributtes
    {
        public Item(string barcode, string name, ItemUnit unit, ItemCategory category, ItemType type, bool active, int stockquantity,string description)
        {
            Barcode = barcode;
            Name = name;
            Unit = unit;
            Category = category;
            Type = type;
            Active = active;
            Description = description;
            StockQuantity = stockquantity;
        }

        public string Barcode { get; set; }
        public string Name { get; set; }
        public ItemUnit Unit { get; set; }
        public ItemCategory Category { get; set; }
        public ItemType Type { get; set; }
        public Supplier Supplier { get; set; }
        public bool Active { get; set; }
        public int StockQuantity { get; set; }
        public string Description { get; set; }
    }
}
