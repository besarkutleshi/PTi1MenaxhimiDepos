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

        public PointofSale(string name, string city, int phone, string description)
        {
            Name = name;
            City = city;
            Phone = phone;
            Description = description;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public int Phone { get; set; }
        public string Description { get; set; }
    }
}
