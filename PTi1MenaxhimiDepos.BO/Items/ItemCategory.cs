using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTi1MenaxhimiDepos.BO
{
    public class ItemCategory : AuditionAtributtes
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ItemCategory(string name)
        {
            Name = name;
        }
        public ItemCategory(int iD, string name, string description)
        {
            ID = iD;
            Name = name;
            Description = description;
        }
    }
}
