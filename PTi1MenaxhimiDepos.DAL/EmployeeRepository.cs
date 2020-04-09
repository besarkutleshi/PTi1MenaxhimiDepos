using PTi1MenaxhimiDepos.BO;
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
    public class EmployeeRepostiory : ICrud<Employee>
    {
        public bool Add(Employee obj)
        {
            try
            {
                if (!obj.Equals(obj))
                {
                    int val = 0;
                    using (SqlConnection con = new SqlConnection(DataConnection.Constring))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("sp_Insert_Personel", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Name", obj.Name);
                        cmd.Parameters.AddWithValue("@Surname", obj.Surname);
                        cmd.Parameters.AddWithValue("@Email", obj.Email);
                        cmd.Parameters.AddWithValue("@Phone", obj.Phone);
                        cmd.Parameters.AddWithValue("@Street", obj.Address.Street);
                        cmd.Parameters.AddWithValue("@City", obj.Address.City);
                        cmd.Parameters.AddWithValue("@Country", obj.Address.Country);
                        cmd.Parameters.AddWithValue("@PostalCode", obj.Address.PostalCode);
                        cmd.Parameters.AddWithValue("RoleID", obj.Role.ID);
                        cmd.Parameters.AddWithValue("InsertBy", obj.Username);
                        val = DataConnection.GetValue(cmd);
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
                else
                {
                    MessageBox.Show("Role Exist \nRegister Failed", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
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
                using (SqlConnection con = new SqlConnection(DataConnection.Constring))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_Delete_Personel", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", id);
                    if (DataConnection.GetValue(cmd) == 1)
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return false;
            }
        }

        public List<Employee> ReadAll()
        {
            try
            {
                List<Employee> employees = null;
                using (var con = DataConnection.Connection())
                {
                    con.Open();
                    var cmd = DataConnection.Command(con, "sp_GetAll_Personel", CommandType.StoredProcedure);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    if (sdr.HasRows)
                    {
                        employees = new List<Employee>();
                        Employee obj = null;
                        while (sdr.Read())
                        {
                            obj = GetEmployee(sdr);
                            employees.Add(obj);
                        }
                    }
                }
                return employees;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return null;
            }
        }

        public Employee ReadById(int id)
        {
            try
            {
                Employee employee = null;
                using (var con = DataConnection.Connection())
                {
                    con.Open();
                    var cmd = DataConnection.Command(con, "sp_Get_Personel_By_ID", CommandType.StoredProcedure);
                    DataConnection.AddParameter(cmd, "@ID", id);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    if (sdr.HasRows)
                    {
                        while (sdr.Read())
                        {
                            employee = GetEmployee(sdr);
                        }
                    }
                }
                return employee;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return null;
            }
        }

        public Employee GetEmployee(SqlDataReader sdr)
        {
            Employee employee = new Employee(sdr["NAME"].ToString(), sdr["SURNAME"].ToString(), sdr["EMAIL"].ToString(), sdr["PHONE"].ToString(),
                                new Address(sdr["STREET"].ToString(), sdr["CITY"].ToString(), sdr["COUNTRY"].ToString(), long.Parse(sdr["POSTALCODE"].ToString())));
            employee.Role.Name = sdr["ROLE"].ToString();
            employee.Username = sdr["INSERTBY"].ToString();
            return employee;
        }

        public bool Update(int id, Employee obj)
        {
            try
            {
                int val = 0;
                using (SqlConnection con = new SqlConnection(DataConnection.Constring))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_Update_Personel", con);
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
                    cmd.Parameters.AddWithValue("RoleID", obj.Role.ID);
                    cmd.Parameters.AddWithValue("UpdateBy", obj.Username);
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
