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
    public class ClientsRepository : ICrud<Client>,IGetObject<Client>
    {
        public bool Add(Client obj)
        {
            try
            {
                if (!DataConnection.DoesExist("sp_DoesExist_Client", "Name", obj.Name + " " + obj.Surname))
                {
                    int value = 0;
                    using (var con = DataConnection.Connection())
                    {
                        con.Open();
                        var cmd = DataConnection.Command(con, "sp_Insert_Client", CommandType.StoredProcedure);
                        DataConnection.AddParameter(cmd, "Name", obj.Name);
                        DataConnection.AddParameter(cmd, "Surname", obj.Surname);
                        DataConnection.AddParameter(cmd, "Email", obj.Email);
                        DataConnection.AddParameter(cmd, "Phone", obj.Phone);
                        DataConnection.AddParameter(cmd, "Street", obj.Address.Street);
                        DataConnection.AddParameter(cmd, "City", obj.Address.City);
                        DataConnection.AddParameter(cmd, "Country", obj.Address.Country);
                        DataConnection.AddParameter(cmd, "PostalCode", obj.Address.PostalCode);
                        DataConnection.AddParameter(cmd, "InsertBy", obj.Username);
                        value = DataConnection.GetValue(cmd);
                    }
                    return HelperClass.GetValue(value, "Register");
                }
                else
                {
                    MessageBox.Show("Client Exist!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return false;
            }
        }

        public string aa()
        {
            return "";
        }

        public bool Delete(int id)
        {
            try
            {
                int value = 0;
                using (SqlConnection con = new SqlConnection(DataConnection.Constring))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_DeleteClient", con);
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

        public List<Client> ReadAll()
        {
            try
            {
                List<Client> clients = new List<Client>();
                using (var con = DataConnection.Connection())
                {
                    con.Open();
                    var cmd = DataConnection.Command(con,"sp_GetAll_Clients", CommandType.StoredProcedure);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        clients.Add(Get(sdr));
                    }
                }
                return clients;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return null;
            }
        }

        public Client Get(SqlDataReader sdr)
        {
            Client obj = new Client(int.Parse(sdr["CLIENTID"].ToString()),sdr["NAME"].ToString(), sdr["SURNAME"].ToString(), sdr["PHONE"].ToString(), sdr["EMAIL"].ToString(),
                            new Address(sdr["STREET"].ToString(), sdr["CITY"].ToString(), sdr["COUNTRY"].ToString(), sdr["POSTALCODE"].ToString()));
            return obj;
        }

        public Client ReadById(int id)
        {
            try
            {
                Client client = null;
                using (var con = DataConnection.Connection())
                {
                    con.Open();
                    var cmd = DataConnection.Command(con, "sp_Get_Clients_By_ID", CommandType.StoredProcedure);
                    DataConnection.AddParameter(cmd, "@ID", id);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        client = Get(sdr);
                    }
                }
                return client;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return null;
            }
        }

        public Client ReadByName(string name)
        {
            try
            {
                Client client = null;
                using (var con = DataConnection.Connection())
                {
                    con.Open();
                    var cmd = DataConnection.Command(con, "sp_Get_Clients_By_Name", CommandType.StoredProcedure);
                    DataConnection.AddParameter(cmd, "@Name", name);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        client = Get(sdr);
                    }
                }
                return client;
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
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@Name", obj.Name);
                    cmd.Parameters.AddWithValue("@Surname", obj.Surname);
                    cmd.Parameters.AddWithValue("@Email", obj.Email);
                    cmd.Parameters.AddWithValue("@Phone", obj.Phone);
                    cmd.Parameters.AddWithValue("@Street", obj.Address.Street);
                    cmd.Parameters.AddWithValue("@City", obj.Address.City);
                    cmd.Parameters.AddWithValue("@Country", obj.Address.Country);
                    cmd.Parameters.AddWithValue("@PostalCode", obj.Address.PostalCode);
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
