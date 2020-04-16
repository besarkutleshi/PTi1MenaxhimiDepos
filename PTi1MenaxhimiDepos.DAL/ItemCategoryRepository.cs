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
    public class ItemCategoriesRepository : ICrud<ItemCategory>,IGetObject<ItemCategory>
    {
        public bool Add(ItemCategory obj)
        {
            try
            {
                if (!obj.Equals(obj))
                {
                    int value = 0;
                    using (SqlConnection con = new SqlConnection(DataConnection.Constring))
                    {
                        con.Open();
                        SqlCommand o = new SqlCommand("sp_Insert_Category", con);
                        o.CommandType = CommandType.StoredProcedure;
                        o.Parameters.AddWithValue("@Name", obj.Name);
                        o.Parameters.AddWithValue("@Description", obj.Description);
                        o.Parameters.AddWithValue("@InsertBy", obj.Username);
                        value = DataConnection.GetValue(o);
                    }
                    if (value == 1)
                    {
                        MessageBox.Show("Register Successful", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Register Failed", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Category Exist \nRegister Failed", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
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
                    SqlCommand cmd = new SqlCommand("sp_Delete_Category", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", id);
                    value = DataConnection.GetValue(cmd);
                }
                if (value == 1)
                {
                    MessageBox.Show("Delete Successful", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        public bool Update(int id, ItemCategory obj)
        {
            try
            {
                int value = 0;
                using (SqlConnection con = new SqlConnection(DataConnection.Constring))
                {
                    con.Open();
                    SqlCommand cc = new SqlCommand("sp_Update_Category", con);
                    cc.CommandType = CommandType.StoredProcedure;
                    cc.Parameters.AddWithValue("@ID", id);
                    cc.Parameters.AddWithValue("@Name", obj.Name);
                    cc.Parameters.AddWithValue("@Description", obj.Description);
                    cc.Parameters.AddWithValue("@UpdateBy", obj.Username);
                    value = DataConnection.GetValue(cc);
                }
                if (value == 1)
                {
                    MessageBox.Show("Update Successful", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        public List<ItemCategory> ReadAll()
        {
            try
            {
                List<ItemCategory> dt = new List<ItemCategory>();
                using (SqlConnection con = new SqlConnection(DataConnection.Constring))
                {
                    con.Open();
                    var cmd = DataConnection.Command(con, "sp_GetAll_ItemCategory", CommandType.StoredProcedure);
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
        public ItemCategory ReadById(int id)
        {
            try
            {
                ItemCategory obj = null;
                using (SqlConnection con = new SqlConnection(DataConnection.Constring))
                {
                    con.Open();
                    var cmd = DataConnection.Command(con, "sp_ReadById_Category", CommandType.StoredProcedure);
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

        public ItemCategory Get(SqlDataReader sdr)
        {
            return new ItemCategory(int.Parse(sdr["CATEGORYID"].ToString()), sdr["NAME"].ToString(), sdr["DESCRIPTION"].ToString());
        }
    }
}
