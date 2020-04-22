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
    public class ItemUnitRepository : ICrud<ItemUnit>,IGetObject<ItemUnit>
    {
        public bool Add(ItemUnit obj)
        {
            try
            {
                int value = 0;
                using (SqlConnection con = new SqlConnection(DataConnection.Constring))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_Insert_Unit", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Name", obj.Name);
                    cmd.Parameters.AddWithValue("@Description", obj.Description);
                    cmd.Parameters.AddWithValue("@InsertBy", obj.Username);
                    value = DataConnection.GetValue(cmd);
                }
                if (value == 1)
                {
                    MessageBox.Show("Register Successful", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Register Failed", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
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
                    SqlCommand cmd = new SqlCommand("sp_Delete_Unit", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", id);
                    value = DataConnection.GetValue(cmd);
                }
                if (value == 1)
                {
                    MessageBox.Show("Delete Successful", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Delete Failed", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return false;
            }
        }

        public ItemUnit Get(SqlDataReader sdr)
        {
            return new ItemUnit(int.Parse(sdr["UNITID"].ToString()), sdr["NAME"].ToString(), sdr["DESCRIPTION"].ToString());
        }

        public List<ItemUnit> ReadAll()
        {
            try
            {
                List<ItemUnit> dt = new List<ItemUnit>();
                using (SqlConnection con = new SqlConnection(DataConnection.Constring))
                {
                    con.Open();
                    var cmd = DataConnection.Command(con, "sp_GetAll_Unit", CommandType.StoredProcedure);
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
        public ItemUnit ReadById(int id)
        {
            try
            {
                ItemUnit obj = null;
                using (SqlConnection con = new SqlConnection(DataConnection.Constring))
                {
                    con.Open();
                    var cmd = DataConnection.Command(con, "sp_ReadById_Unit", CommandType.StoredProcedure);
                    DataConnection.AddParameter(cmd, "@ID", id);
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

        public ItemUnit ReadByName(string name)
        {
            try
            {
                ItemUnit obj = null;
                using (SqlConnection con = new SqlConnection(DataConnection.Constring))
                {
                    con.Open();
                    var cmd = DataConnection.Command(con, "sp_ReadByName_Unit", CommandType.StoredProcedure);
                    DataConnection.AddParameter(cmd, "@Name", name);
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
        public bool Update(int id, ItemUnit obj)
        {
            try
            {
                int value = 0;
                using (SqlConnection con = new SqlConnection(DataConnection.Constring))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_Update_unit", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@Name", obj.Name);
                    cmd.Parameters.AddWithValue("@Description", obj.Description);
                    cmd.Parameters.AddWithValue("@UpdateBy", obj.Username);
                    value = DataConnection.GetValue(cmd);
                }
                if (value == 1)
                {
                    MessageBox.Show("Update Successful", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Update Failed", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
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
