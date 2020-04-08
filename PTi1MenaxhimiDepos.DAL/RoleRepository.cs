using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PTi1MenaxhimiDepos.BO;
namespace PTi1MenaxhimiDepos.DAL
{
    public class RoleRepository : ICrud<Role>
    {
        public bool Add(Role obj)
        {
            try
            {
                if (obj.Equals(obj))
                {
                    MessageBox.Show("Role Exist \nRegister Failed", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    int val = 0;
                    using (SqlConnection con = new SqlConnection(DataConnection.Constring))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("sp_Insert_Role", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Name", obj.Name);
                        cmd.Parameters.AddWithValue("@Code", obj.Code);
                        cmd.Parameters.AddWithValue("@Description", obj.Description);
                        cmd.Parameters.AddWithValue("@InsertBy", obj.Username);
                        val = DataConnection.GetValue(cmd);
                    }
                    if (val == 1)
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
                int val = 0;
                using (SqlConnection con = new SqlConnection(DataConnection.Constring))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_Delete_Role", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", id);
                    val = DataConnection.GetValue(cmd);
                }
                if (val == 1)
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

        public DataTable ReadAll()
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection con = new SqlConnection(DataConnection.Constring))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select * from vw_ReadAll_Role", con);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                }
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return null;
            }
        }

        public DataTable ReadById(int id)
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection con = new SqlConnection(DataConnection.Constring))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_ReadByID_Role", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return null;
            }
        }

        public bool Update(int id, Role obj)
        {
            try
            {
                int val = 0;
                using (SqlConnection con = new SqlConnection(DataConnection.Constring))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_Update_Role", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@Name", obj.Name);
                    cmd.Parameters.AddWithValue("@Code", obj.Code);
                    cmd.Parameters.AddWithValue("@Description", obj.Description);
                    cmd.Parameters.AddWithValue("@UpdateBy", obj.Username);
                    val = DataConnection.GetValue(cmd);
                }
                if (val == 1)
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
    }
}
