using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTi1MenaxhimiDepos.BO.Employees
{
    public class EmployeePOS : AuditionAtributtes
    {
        public EmployeePOS()
        {

        }
        public EmployeePOS(int id,int employeeID,int posID,string description)
        {
            ID = id;
            EmployeeID = employeeID;
            PosID = posID;
            Description = description;
        }
        public int ID { get; set; }
        public int EmployeeID { get; set; }
        public virtual Employee Employee { get; set; }
        public int PosID { get; set; }
        public virtual PointofSale POS { get; set; }
        public string Description { get; set; }
    }
}
