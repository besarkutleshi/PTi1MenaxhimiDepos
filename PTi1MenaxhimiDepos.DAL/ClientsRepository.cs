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
    public class ClientsRepository : ICrud<Client>
    {
        public bool Add(Client obj)
        {
            try
            {
                int value = 0;
                using (var con = DataConnection.Connection())
                {
                    con.Open();
                    var cmd = DataConnection.Command(con, "sp_AddCleint", CommandType.StoredProcedure);
                    DataConnection.AddParameter(cmd, "Name", obj.Name);
                    DataConnection.AddParameter(cmd, "Phone", obj.Phone);
                    DataConnection.AddParameter(cmd, "Email", obj.Email);
                    DataConnection.AddParameter(cmd, "FiscalNo", obj.FiscalNo);
                    DataConnection.AddParameter(cmd, "VatNo", obj.VatNo);
                    DataConnection.AddParameter(cmd, "Street", obj.Address.Street);
                    DataConnection.AddParameter(cmd, "City", obj.Address.City);
                    DataConnection.AddParameter(cmd, "Country", obj.Address.Country);
                    DataConnection.AddParameter(cmd, "PostalCode", obj.Address.PostalCode);
                    DataConnection.AddParameter(cmd, "InsertBy", obj.Username);
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
                    SqlCommand cmd = new SqlCommand("sp_DeleteClients", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", id);
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

        public DataTable ReadAll()
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection con = new SqlConnection(DataConnection.Constring))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select * from vw_ReadAllClients", con);
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
                    SqlCommand cmd = new SqlCommand("sp_ReadByIdClients", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", id);
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

        public bool Update(int id, Client obj)
        {
            try
            {
                int value = 0;
                using (SqlConnection con = new SqlConnection(DataConnection.Constring))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_UpdateClients", con); // ***Duhet me bo StoreProceduren ne DB 
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Name", obj.Name);
                    cmd.Parameters.AddWithValue("@Phone", obj.Phone);
                    cmd.Parameters.AddWithValue("@Email", obj.Email);
                    cmd.Parameters.AddWithValue("@FiscalNo", obj.FiscalNo);
                    cmd.Parameters.AddWithValue("@VatNo", obj.VatNo);
                    cmd.Parameters.AddWithValue("@Street", obj.Address.Street);
                    cmd.Parameters.AddWithValue("@City", obj.Address.City);
                    cmd.Parameters.AddWithValue("@Country", obj.Address.Country);
                    cmd.Parameters.AddWithValue("@PostalCode", obj.Address.PostalCode);
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
