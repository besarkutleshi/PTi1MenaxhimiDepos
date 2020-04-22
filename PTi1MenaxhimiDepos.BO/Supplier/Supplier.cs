using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Supplier
    {
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

        public override bool Equals(object obj)
        {
            int value = 0;
            if (obj is Supplier)
            {
                Supplier cobj = (Supplier)obj;
                using (SqlConnection con = new SqlConnection(HelperClass.constring)) //SqlConnection con = new SqlConnection(Program.connstring)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_DoesExistSupplier", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@name", cobj.Name);
                    cmd.Parameters.Add(new SqlParameter("@Value", SqlDbType.Int));
                    cmd.Parameters["@Value"].Direction = ParameterDirection.Output;
                    value = int.Parse(cmd.Parameters["@Value"].Value.ToString());
                }
            }
            if (value == 0)
                return false;
            else return true;
        }
    }
}
