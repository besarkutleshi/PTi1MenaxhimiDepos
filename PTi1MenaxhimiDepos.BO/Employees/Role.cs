using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTi1MenaxhimiDepos.BO
{
    public class Role:AuditionAtributtes
    {
        public int ID { get; set; }
        public Role(string name, string code, string description)
        {
            Name = name;
            Code = code;
            Description = description;
        }

        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

    }
}
