using PTi1MenaxhimiDepos.BO.Employees;
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
    public class EmployeePosRepository : ICrud<EmployeePOS>, IGetObject<EmployeePOS>
    {
        public bool Add(EmployeePOS obj)
        {
            try
            {
                int value = 0;
                using(var con = DataConnection.Connection())
                {
                    con.Open();
                    var cmd = DataConnection.Command(con, "sp_Insert_EmpPOS", CommandType.StoredProcedure);
                    DataConnection.AddParameter(cmd, "@EmployeeID", obj.EmployeeID);
                    DataConnection.AddParameter(cmd, "@PosID", obj.PosID);
                    DataConnection.AddParameter(cmd, "@Description", obj.Description);
                    DataConnection.AddParameter(cmd, "@InsertBy", obj.Username);
                    value = DataConnection.GetValue(cmd);
                }
                return HelperClass.GetValue(value, "Register");
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
                using(var con = DataConnection.Connection())
                {
                    con.Open();
                    var cmd = DataConnection.Command(con, "sp_Delete_EmpPos", CommandType.StoredProcedure);
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

        public EmployeePOS Get(SqlDataReader sdr)
        {
            EmployeePOS obj = new EmployeePOS();
            obj.ID = int.Parse(sdr["ID"].ToString());
            obj.Description = sdr["DESCRIPTION"].ToString();
            obj.POS = new BO.PointofSale(sdr["POS"].ToString());
            obj.Employee = new BO.Employee(sdr["FULLNAME"].ToString());
            return obj;
        }

        public List<EmployeePOS> ReadAll()
        {
            try
            {
                List<EmployeePOS> employeePOs = null;
                using(var con = DataConnection.Connection())
                {
                    con.Open();
                    var cmd = DataConnection.Command(con, "sp_GetAll_EmpPos", CommandType.StoredProcedure);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    if (sdr.HasRows)
                    {
                        employeePOs = new List<EmployeePOS>();
                        while (sdr.Read())
                        {
                            employeePOs.Add(Get(sdr));
                        }
                    }
                    return employeePOs;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return null;
            }
        }

        public EmployeePOS ReadById(int id)
        {
            try
            {
                EmployeePOS employeePOs = null;
                using (var con = DataConnection.Connection())
                {
                    con.Open();
                    var cmd = DataConnection.Command(con, "sp_GetAll_EmpPos_ByEmployeeID", CommandType.StoredProcedure);
                    DataConnection.AddParameter(cmd, "@EmployeeID", id);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    if (sdr.HasRows)
                    {
                        employeePOs = new EmployeePOS();
                        while (sdr.Read())
                        {
                            employeePOs = Get(sdr);
                        }
                    }
                    return employeePOs;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return null;
            }
        }

        public EmployeePOS ReadByName(string fullname)
        {
            try
            {
                EmployeePOS employeePOs = null;
                using (var con = DataConnection.Connection())
                {
                    con.Open();
                    var cmd = DataConnection.Command(con, "sp_GetAll_EmpPos_ByEmployeeFullName", CommandType.StoredProcedure);
                    DataConnection.AddParameter(cmd, "@EmployeeFullName", fullname);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    if (sdr.HasRows)
                    {
                        employeePOs = new EmployeePOS();
                        while (sdr.Read())
                        {
                            employeePOs = Get(sdr);
                        }
                    }
                    return employeePOs;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return null;
            }
        }

        public bool Update(int id, EmployeePOS obj)
        {
            try
            {
                int value = 0;
                using (var con = DataConnection.Connection())
                {
                    con.Open();
                    var cmd = DataConnection.Command(con, "sp_Update_EmpPOS", CommandType.StoredProcedure);
                    DataConnection.AddParameter(cmd, "@ID", obj.ID);
                    DataConnection.AddParameter(cmd, "@EmployeeID", obj.EmployeeID);
                    DataConnection.AddParameter(cmd, "@PosID", obj.PosID);
                    DataConnection.AddParameter(cmd, "@Description", obj.Description);
                    DataConnection.AddParameter(cmd, "@UpdateBy", obj.Username);
                    value = DataConnection.GetValue(cmd);
                }
                return HelperClass.GetValue(value, "Register");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
