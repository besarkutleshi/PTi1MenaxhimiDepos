using PTi1MenaxhimiDepos.BO;
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
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Address Address { get; set; }
        public string Fullname { get; set; }
        public Employee(int id,string name, string surname, string email, string phone, Address address)
        {
            this.ID = id;
            this.Name = name;
            this.Surname = surname;
            this.Email = email;
            this.Phone = phone;
            this.Address = address;
        }

        public Employee(string name)
        {
            this.Name = name;
        }

    }
}
