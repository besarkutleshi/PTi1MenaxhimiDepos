using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTi1MenaxhimiDepos.BO
{
    public class PointofSale:AuditionAtributtes
    {
        public PointofSale(string name)
        {
            Name = name;
        }

        public PointofSale(int id,string name, string city, string phone, string description)
        {
            ID = id;
            Name = name;
            City = city;
            Phone = phone;
            Description = description;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Description { get; set; }
    }
}
