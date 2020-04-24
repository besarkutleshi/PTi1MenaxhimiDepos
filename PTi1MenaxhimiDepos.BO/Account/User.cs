using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTi1MenaxhimiDepos.BO.Account
{
    public class User:AuditionAtributtes
    {
        public User()
        {

        }
        public User(int iD, string userName, string password, string description, int employeeID, int roleID)
        {
            ID = iD;
            UserName = userName;
            Password = password;
            Description = description;
            EmployeeID = employeeID;
            RoleID = roleID;
        }

        public User(int iD, string userName, string password, string description)
        {
            ID = iD;
            UserName = userName;
            Password = password;
            Description = description;
        }

        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Description { get; set; }
        public int EmployeeID { get; set; }
        public int RoleID { get; set; }
        public virtual Role Role { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
