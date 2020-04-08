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
        public Client(string name,string surname ,string phone, string email, int fiscalNo, int vatNo,Address address)
        {
            Name = name;
            Surname = surname;
            Phone = phone;
            Email = email;
            Address = address;
            FiscalNo = fiscalNo;
            VatNo = vatNo;
        }

        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int FiscalNo { get; set; }
        public int VatNo { get; set; }
        public string Surname { get; set; }
        public Address Address { get; set; }

    }
}
