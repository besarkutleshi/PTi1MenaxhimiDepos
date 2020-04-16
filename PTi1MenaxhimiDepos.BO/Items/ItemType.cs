using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace PTi1MenaxhimiDepos.BO
{
    public class ItemType:AuditionAtributtes
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ItemType(string name)
        {
            Name = name;
        }
        public ItemType(int iD, string name, string description)
        {
            ID = iD;
            Name = name;
            Description = description;
        }

    }
}
