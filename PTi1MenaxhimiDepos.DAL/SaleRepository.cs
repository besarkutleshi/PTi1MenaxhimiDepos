using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PTi1MenaxhimiDepos.BO;
namespace PTi1MenaxhimiDepos.DAL
{
    public class SaleRepository
    {
        public DataTable GetInvoicesToday()
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection con = new SqlConnection(DataConnection.Constring))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select * from vw_Get_Invoices_Today", con);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    return dt;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Sale()
        {

        }
    }
}