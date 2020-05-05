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
    public class ItemTypeRepository : ICrud<ItemType>,IGetObject<ItemType>
    {
        public bool Add(ItemType obj)
        {
            try
            {
                if (!DataConnection.DoesExist("sp_DoesExist_ItemType", "Name", obj.Name))
                {
                    int value = 0;
                    using (SqlConnection con = new SqlConnection(DataConnection.Constring))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("sp_Insert_Type", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Name", obj.Name);
                        cmd.Parameters.AddWithValue("@Description", obj.Description);
                        cmd.Parameters.AddWithValue("@InsertBy", obj.Username);
                        value = DataConnection.GetValue(cmd);
                    }
                    return HelperClass.GetValue(value, "Register");
                }
                else
                {
                    MessageBox.Show("Type Exist!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
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
                    SqlCommand d = new SqlCommand("sp_Delete_Type", con);
                    d.CommandType = CommandType.StoredProcedure;
                    d.Parameters.AddWithValue("@ID", id);
                    value = DataConnection.GetValue(d);
                }
                return HelperClass.GetValue(value, "Delete");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return false;
            }
        }

        public ItemType Get(SqlDataReader sdr)
        {
            return new ItemType(int.Parse(sdr["TYPEID"].ToString()), sdr["NAME"].ToString(), sdr["DESCRIPTION"].ToString());
        }

        public List<ItemType> ReadAll()
        {
            try
            {
                List<ItemType> dt = new List<ItemType>();
                using (SqlConnection con = new SqlConnection(DataConnection.Constring))
                {
                    con.Open();
                    var cmd = DataConnection.Command(con, "sp_GetAll_Types", CommandType.StoredProcedure);
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
        public ItemType ReadById(int id)
        {
            try
            {
                ItemType obj = null;
                using (SqlConnection con = new SqlConnection(DataConnection.Constring))
                {
                    con.Open();
                    var cmd = DataConnection.Command(con, "sp_ReadById_Type", CommandType.StoredProcedure);
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

        public ItemType ReadByName(string name)
        {
            try
            {
                ItemType obj = null;
                using (SqlConnection con = new SqlConnection(DataConnection.Constring))
                {
                    con.Open();
                    var cmd = DataConnection.Command(con, "sp_ReadByName_Type", CommandType.StoredProcedure);
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
        public bool Update(int id, ItemType obj)
        {
            try
            {
                if (!DataConnection.DoesExist("sp_DoesExist_ItemType", "Name", obj.Name))
                {
                    int value = 0;
                    using (SqlConnection con = new SqlConnection(DataConnection.Constring))
                    {
                        con.Open();
                        SqlCommand cc = new SqlCommand("sp_Update_Type", con);
                        cc.CommandType = CommandType.StoredProcedure;
                        cc.Parameters.AddWithValue("@ID", id);
                        cc.Parameters.AddWithValue("@Name", obj.Name);
                        cc.Parameters.AddWithValue("@Description", obj.Description);
                        cc.Parameters.AddWithValue("@UpdateBy", obj.Username);
                        value = DataConnection.GetValue(cc);
                    }
                    return HelperClass.GetValue(value, "Update");
                }
                else
                {
                    MessageBox.Show("Type Exist!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
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
