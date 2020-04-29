using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTi1MenaxhimiDepos.BO
{
    public class Supplier : AuditionAtributtes
    {
        public Supplier(string name)
        {
            Name = name;
        }
        public Supplier(int iD, string name, string description, string city, string phone, string mail)
        {
            ID = iD;
            Name = name;
            Description = description;
            City = city;
            Phone = phone;
            Mail = mail;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
    }
}