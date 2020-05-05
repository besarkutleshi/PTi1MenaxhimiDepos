using PTi1MenaxhimiDepos.BO;
using PTi1MenaxhimiDepos.DAL;
using PTi1MenaxhimiDepos.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTi1MenaxhimiDepos.DAL
{
    public class SupplierRepository :ICrud<Supplier>,IGetObject<Supplier>
    {
        public bool Add(Supplier obj)
        {
            try
            {
                if (!DataConnection.DoesExist("sp_DoesExist_Supplier", "Name", obj.Name))
                {
                    int value = 0;
                    using (SqlConnection con = new SqlConnection(DataConnection.Constring))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("sp_AddSupplier", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Name", obj.Name);
                        cmd.Parameters.AddWithValue("@Description", obj.Description);
                        cmd.Parameters.AddWithValue("@City", obj.City);
                        cmd.Parameters.AddWithValue("@Phone", obj.Phone);
                        cmd.Parameters.AddWithValue("@Mail", obj.Mail);
                        cmd.Parameters.AddWithValue("@InsertBy", obj.Username);
                        value = DataConnection.GetValue(cmd);
                    }
                    return HelperClass.GetValue(value, "Register");
                }
                else
                {
                    MessageBox.Show("Supplier Exist!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                int value = 0;
                using (SqlConnection con = new SqlConnection(DataConnection.Constring))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_DeleteSupplier", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", id);
                    value = DataConnection.GetValue(cmd);
                }
                return HelperClass.GetValue(value, "Delete");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return false;
            }
        }

        public Supplier Get(SqlDataReader sdr)
        {
            Supplier obj = new Supplier(int.Parse(sdr["SUPPLIERID"].ToString()), sdr["NAME"].ToString(), sdr["DESCRIPTION"].ToString(), sdr["CITY"].ToString(),
                sdr["Phone"].ToString(), sdr["MAIL"].ToString());
            return obj;
        }

        public List<Supplier> ReadAll()
        {
            try
            {
                List<Supplier> dt = new List<Supplier>();
                using (SqlConnection con = new SqlConnection(DataConnection.Constring))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_GetAll_Suppliers", con);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        dt.Add(Get(sdr));
                    }
                }
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return null;
            }
        }

        public Supplier ReadById(int id)
        {
            try
            {
                Supplier obj = null;
                using (SqlConnection con = new SqlConnection(DataConnection.Constring))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_GetById_Suppliers", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", id);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        obj = Get(sdr);
                    }
                }
                return obj;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return null;
            }
        }

        public Supplier ReadByName(string name)
        {
            try
            {
                Supplier obj = null;
                using (SqlConnection con = new SqlConnection(DataConnection.Constring))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_GetByName_Suppliers", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Name", name);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        obj = Get(sdr);
                    }
                }
                return obj;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return null;
            }
        }

        public bool Update(int id, Supplier obj)
        {
            try
            {
                if (!DataConnection.DoesExist("sp_DoesExist_Supplier", "Name", obj.Name))
                {
                    int value = 0;
                    using (SqlConnection con = new SqlConnection(DataConnection.Constring))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("sp_UpdateSupplier", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.Parameters.AddWithValue("@Name", obj.Name);
                        cmd.Parameters.AddWithValue("@Description", obj.Description);
                        cmd.Parameters.AddWithValue("@Phone", obj.Phone);
                        cmd.Parameters.AddWithValue("@Mail", obj.Mail);
                        cmd.Parameters.AddWithValue("@City", obj.City);
                        cmd.Parameters.AddWithValue("@UpdateBy", obj.Username);
                        value = DataConnection.GetValue(cmd);

                    }
                    return HelperClass.GetValue(value, "Update");
                }
                else
                {
                    MessageBox.Show("Supplier Exist!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
