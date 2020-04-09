using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PTi1MenaxhimiDepos.BO
{
    public class Client:AuditionAtributtes,IBase
    {
        public Client(string name,string surname ,string phone, string email,Address address)
        {
            Name = name;
            Surname = surname;
            Phone = phone;
            Email = email;
            Address = address;
        }

        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Surname { get; set; }
        public Address Address { get; set; }

    }
}
