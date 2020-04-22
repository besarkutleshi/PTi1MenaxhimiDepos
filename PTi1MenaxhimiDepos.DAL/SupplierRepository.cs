using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessLayer
{
    class SupplierRepository : ICrud<Supplier>
    {
        public bool Add(Supplier obj, string username)
        {
            try
            {
                int value = 0;
                using (SqlConnection con = new SqlConnection(HelperClass.constring))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_AddSupplier", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Name", obj.Name);
                    cmd.Parameters.AddWithValue("@Description", obj.Description);
                    cmd.Parameters.AddWithValue("@City", obj.City);
                    cmd.Parameters.AddWithValue("@Phone", obj.Phone);
                    cmd.Parameters.AddWithValue("@Mail", obj.Mail);

                    cmd.Parameters.Add(new SqlParameter("@Value", SqlDbType.Int));
                    cmd.Parameters["@Value"].Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();
                    value = int.Parse(cmd.Parameters["@Value"].Value.ToString());
                }
                if (value == 0)
                    return true;
                else return false;


            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Delete(int id)
        {
            int value = 0;
            using (SqlConnection con = new SqlConnection(HelperClass.constring))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_DeleteSupplier", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);

                cmd.Parameters.Add(new SqlParameter("@Value", SqlDbType.Int));
                cmd.Parameters["@Value"].Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                value = int.Parse(cmd.Parameters["@Value"].Value.ToString());
            }
            if (value == 1)
                return true;
            else return false;
        }

        public DataTable ReadAll()
        {

            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection con = new SqlConnection(HelperClass.constring))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select * from vw_GetAllSupplier", con);
                    cmd.ExecuteNonQuery(); //besoj qe kjo nuk nevoitet ketu. >FJ
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                }
                return dt;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable ReadById(int id)
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection con = new SqlConnection(HelperClass.constring))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_ReadByIdSupplier", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery(); //As ketu nuk duhet me qene kjo. >fj
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                }
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Update(int id, Supplier obj, string username)
        {

            int value = 0;
            using (SqlConnection con = new SqlConnection(HelperClass.constring))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("", con); // ***Duhet me bo StoreProceduren ne DB 
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Name", obj.Name);
                cmd.Parameters.AddWithValue("@Description", obj.Description);
                cmd.Parameters.AddWithValue("@Phone", obj.Phone);
                cmd.Parameters.AddWithValue("@Mail", obj.Mail);
                cmd.Parameters.AddWithValue("@City", obj.City);

                cmd.Parameters.Add(new SqlParameter("@Value", SqlDbType.Int));
                cmd.Parameters["@Value"].Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                value = int.Parse(cmd.Parameters["@Value"].Value.ToString());

            }
            if (value == 1)
                return true;
            else return false;
        }
    }
}
