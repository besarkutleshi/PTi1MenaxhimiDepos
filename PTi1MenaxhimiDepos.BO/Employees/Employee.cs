using PTi1MenaxhimiDepos.BO.Interfaces;
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
    public class Employee :AuditionAtributtes,IBase
    {
        public int RoleID { get; set; }
        public virtual Role Role { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Address Address { get; set; }

        public Employee(string name, string surname, string email, string phone, Address address)
        {
            this.Name = name;
            this.Surname = surname;
            this.Email = email;
            this.Phone = phone;
            this.Address = address;
        }

        public Employee(string name, string surname, string email, string phone, Address address, int roleid)
        {
            this.Name = name;
            this.Surname = surname;
            this.Email = email;
            this.Phone = phone;
            this.Address = address;
            this.RoleID = roleid;
        }
    }
}
