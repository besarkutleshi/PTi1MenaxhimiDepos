using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTi1MenaxhimiDepos.BO
{
    public class Address
    {
        public Address(string street, string city, string country, long postalCode)
        {
            Street = street;
            City = city;
            Country = country;
            PostalCode = postalCode;
        }

        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public long PostalCode { get; set; }
    }
}
