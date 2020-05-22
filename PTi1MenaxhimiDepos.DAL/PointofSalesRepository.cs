using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PTi1MenaxhimiDepos.BO;
using PTi1MenaxhimiDepos.DAL.Interface;

namespace PTi1MenaxhimiDepos.DAL
{
    public class PointofSalesRepository : ICrud<PointofSale>,IGetObject<PointofSale>
    {
        public bool Add(PointofSale obj)
        {
            try
            {
                if (!DataConnection.DoesExist("sp_DoesExist_POS","Name",obj.Name))
                {
                    int value = 0;
                    using (SqlConnection con = new SqlConnection(DataConnection.Constring))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("sp_Insert_POS", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Name", obj.Name);
                        cmd.Parameters.AddWithValue("@City", obj.City);
                        cmd.Parameters.AddWithValue("@Phone", obj.Phone);
                        cmd.Parameters.AddWithValue("@Description", obj.Description);
                        cmd.Parameters.AddWithValue("@InsertBy", obj.Username);
                        value = DataConnection.GetValue(cmd);
                    }
                    return HelperClass.GetValue(value, "Register");
                }
                else
                {
                    MessageBox.Show("POS Exist!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
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
                    SqlCommand cmd = new SqlCommand("sp_Delete_POS", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", id);
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

        public PointofSale Get(SqlDataReader sdr)
        {
            return new PointofSale(int.Parse(sdr["POSID"].ToString()),sdr["NAME"].ToString(), sdr["CITY"].ToString(), sdr["PHONE"].ToString(), sdr["DESCRITPTION"].ToString());
        }

        public List<PointofSale> ReadAll()
        {
            try
            {
                List<PointofSale> poss = new List<PointofSale>();
                using (SqlConnection con = new SqlConnection(DataConnection.Constring))
                {
                    con.Open();
                    var cmd = DataConnection.Command(con, "sp_GetAll_Pos", CommandType.StoredProcedure);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        poss.Add(Get(sdr));
                    }
                }
                return poss;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return null;
            }
        }

        public PointofSale ReadById(int id)
        {
            try
            {
                PointofSale pos = null;
                using (SqlConnection con = new SqlConnection(DataConnection.Constring))
                {
                    con.Open();
                    var cmd = DataConnection.Command(con, "sp_ReadById_POS", CommandType.StoredProcedure);
                    DataConnection.AddParameter(cmd, "@ID", id);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        pos = Get(sdr);
                    }
                }
                return pos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return null;
            }
        }

        public PointofSale ReadByName(string name)
        {
            try
            {
                PointofSale pos = null;
                using (SqlConnection con = new SqlConnection(DataConnection.Constring))
                {
                    con.Open();
                    var cmd = DataConnection.Command(con, "sp_ReadByName_POS", CommandType.StoredProcedure);
                    DataConnection.AddParameter(cmd, "@Name", name);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        pos = Get(sdr);
                    }
                }
                return pos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return null;
            }
        }

        public bool Update(int id, PointofSale obj)
        {
            try
            {
                int value = 0;
                using (SqlConnection con = new SqlConnection(DataConnection.Constring))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_Update_POS", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@Name", obj.Name);
                    cmd.Parameters.AddWithValue("@City", obj.City);
                    cmd.Parameters.AddWithValue("@Phone", obj.Phone);
                    cmd.Parameters.AddWithValue("@Description", obj.Description);
                    cmd.Parameters.AddWithValue("@UpdateBy", obj.Username);
                    value = DataConnection.GetValue(cmd);
                }
                return HelperClass.GetValue(value, "Update");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
