using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTi1MenaxhimiDepos.BO.Account
{
    public class User:AuditionAtributtes
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Description { get; set; }
        public int EmployeeID { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
