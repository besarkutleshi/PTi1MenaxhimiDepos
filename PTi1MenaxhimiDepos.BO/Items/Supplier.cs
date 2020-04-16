using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTi1MenaxhimiDepos.BO
{
    public class Supplier:AuditionAtributtes
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Supplier(string name)
        {
            Name = name;
        }
    }
}
