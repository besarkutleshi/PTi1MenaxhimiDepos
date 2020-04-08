using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTi1MenaxhimiDepos.BO
{
    public class ItemUnit:AuditionAtributtes
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ItemUnit(int iD, string name, string description)
        {
            ID = iD;
            Name = name;
            Description = description;
        }
    }
}
