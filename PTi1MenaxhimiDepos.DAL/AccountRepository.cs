using PTi1MenaxhimiDepos.BO.Account;
using PTi1MenaxhimiDepos.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PTi1MenaxhimiDepos.DAL
{
    public class AccountRepository : ICrud<User>,IGetObject<User>
    {
        public User Login(string username,string password)
        {
            try
            {
                User user = null;
                using(var con = DataConnection.Connection())
                {
                    con.Open();
                    var cmd = DataConnection.Command(con, "sp_Login",CommandType.StoredProcedure);
                    DataConnection.AddParameter(cmd, "@Username", username);
                    DataConnection.AddParameter(cmd, "@Password",password);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        user = Get(sdr);
                    }
                }
                if(user != null)
                {
                    return user;
                }
                else
                {
                    MessageBox.Show("Email or password was incorrect, pleasy try again", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return null;
            }
        }
        public bool Add(User obj)
        {
            try
            {
                if (!DataConnection.DoesExist("sp_DoesExist_User", "@Username", obj.UserName))
                {
                    int value = 0;
                    using(var con = DataConnection.Connection())
                    {
                        con.Open();
                        var cmd = DataConnection.Command(con, "sp_Insert_User",CommandType.StoredProcedure);
                        value = Parameteres(obj, cmd,"InsertBy");
                    }
                    return HelperClass.GetValue(value, "Register");
                }
                else
                {
                    MessageBox.Show("User Exist", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
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
                using (var con = DataConnection.Connection())
                {
                    con.Open();
                    var cmd = DataConnection.Command(con,"sp_Delete_User",CommandType.StoredProcedure);
                    DataConnection.AddParameter(cmd, "@ID", id);
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

        public User Get(SqlDataReader sdr)
        {
            User obj = new User();
            obj.ID = int.Parse(sdr["USERID"].ToString());
            obj.Employee = new BO.Employee(sdr["EMPLOYEE"].ToString());
            obj.UserName = sdr["USERNAME"].ToString();
            obj.Password = sdr["PASSWORD"].ToString();
            obj.Role = new BO.Role( sdr["ROLE"].ToString());
            obj.Description = sdr["DESCRIPTION"].ToString();
            return obj;
        }

        public List<User> ReadAll()
        {
            try
            {
                List<User> users = null;
                using (var con = DataConnection.Connection())
                {
                    con.Open();
                    var cmd = DataConnection.Command(con, "sp_GetAll_Users", CommandType.StoredProcedure);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    if (sdr.HasRows)
                    {
                        users = new List<User>();
                        while (sdr.Read())
                        {
                            users.Add(Get(sdr));
                        }
                    }
                }
                return users;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return null;
            }
        }

        public User ReadById(int id)
        {
            try
            {
                User user = null;
                using (var con = DataConnection.Connection())
                {
                    con.Open();
                    var cmd = DataConnection.Command(con, "sp_GetAll_User_ByID", CommandType.StoredProcedure);
                    DataConnection.AddParameter(cmd, "@ID", id);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    if (sdr.HasRows)
                    {
                        user = new User();
                        while (sdr.Read())
                        {
                            user = Get(sdr);
                        }
                    }
                }
                return user;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return null;
            }
        }

        public User ReadByUsername(string username)
        {
            try
            {
                User user = null;
                using (var con = DataConnection.Connection())
                {
                    con.Open();
                    var cmd = DataConnection.Command(con, "sp_GetAll_User_ByUsername", CommandType.StoredProcedure);
                    DataConnection.AddParameter(cmd, "@Username", username);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    if (sdr.HasRows)
                    {
                        user = new User();
                        while (sdr.Read())
                        {
                            user = Get(sdr);
                        }
                    }
                }
                return user;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return null;
            }
        }

        public bool Update(int id, User obj)
        {
            try
            {
                if (!DataConnection.DoesExist("sp_DoesExist_User", "@Username", obj.UserName))
                {
                    int value = 0;
                    using (var con = DataConnection.Connection())
                    {
                        con.Open();
                        var cmd = DataConnection.Command(con, "sp_Update_User", CommandType.StoredProcedure);
                        DataConnection.AddParameter(cmd, "@ID", id);
                        value = Parameteres(obj, cmd, "UpdateBy");
                    }
                    return HelperClass.GetValue(value, "Update");
                }
                else
                {
                    MessageBox.Show("User Exist", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return false ;
            }
        }

        private int Parameteres(User obj,SqlCommand cmd,string audition)
        {
            DataConnection.AddParameter(cmd, "@EmployeeID", obj.EmployeeID);
            DataConnection.AddParameter(cmd, "@Username", obj.UserName);
            DataConnection.AddParameter(cmd, "@Password", obj.Password);
            DataConnection.AddParameter(cmd, "@Description", obj.Description);
            DataConnection.AddParameter(cmd, "@RoleID", obj.RoleID);
            DataConnection.AddParameter(cmd, audition, obj.Username);
            return DataConnection.GetValue(cmd);
        }
    }
}
