using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using PTi1MenaxhimiDepos.BO;

namespace PTi1MenaxhimiDepos.BO
{
    public class Client:AuditionAtributtes,IBase
    {
        public Client(int id,string name,string surname ,string phone, string email,Address address)
        {
            ID = id;
            Name = name;
            Surname = surname;
            Phone = phone;
            Email = email;
            Address = address;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Surname { get; set; }
        public Address Address { get; set; }
        public string Fullname { get; set; }

    }
}
