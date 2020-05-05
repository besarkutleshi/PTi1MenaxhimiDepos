using PTi1MenaxhimiDepos.BO.Invoices;
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
    public class DocTypeRepository : ICrud<DocType>,IGetObject<DocType>
    {
        public bool Add(DocType obj)
        {
            try
            {
                int value = 0;
                if (!DataConnection.DoesExist("sp_DoesExist_DocType", "@Name", obj.Description))
                {
                    using (var con = DataConnection.Connection())
                    {
                        con.Open();
                        var cmd = DataConnection.Command(con, "sp_Insert_DocType", CommandType.StoredProcedure);
                        AddParams(obj, cmd, "InsertBy");
                        value = DataConnection.GetValue(cmd);
                    }
                    return HelperClass.GetValue(value, "Register");
                }
                else
                {
                    MessageBox.Show("This Type Exist", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
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
                    var cmd = DataConnection.Command(con, "sp_Delete_DocType", CommandType.StoredProcedure);
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

        public DocType Get(SqlDataReader sdr)
        {
            return new DocType(int.Parse(sdr["DOCTYPEID"].ToString()), sdr["CODE"].ToString(), sdr["DESCRIPTION"].ToString());
        }

        public List<DocType> ReadAll()
        {
            try
            {
                List<DocType> docTypes = null;
                using (var con = DataConnection.Connection())
                {
                    con.Open();
                    var cmd = DataConnection.Command(con, "sp_GetAll_DocType", CommandType.StoredProcedure);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    if (sdr.HasRows)
                    {
                        docTypes = new List<DocType>();
                        while (sdr.Read())
                        {
                            docTypes.Add(Get(sdr));
                        }
                    }
                    return docTypes;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return null;
            }
        }

        public DocType ReadById(int id)
        {
            try
            {
                DocType docTypes = null;
                using (var con = DataConnection.Connection())
                {
                    con.Open();
                    var cmd = DataConnection.Command(con, "sp_GetAll_DocType_ByID", CommandType.StoredProcedure);
                    DataConnection.AddParameter(cmd, "@ID", id);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        docTypes = Get(sdr);
                    }
                    return docTypes;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return null;
            }
        }

        public DocType ReadByName(string name)
        {
            try
            {
                DocType docTypes = null;
                using (var con = DataConnection.Connection())
                {
                    con.Open();
                    var cmd = DataConnection.Command(con, "sp_GetAll_DocType_ByName", CommandType.StoredProcedure);
                    DataConnection.AddParameter(cmd, "@Name", name);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        docTypes = Get(sdr);
                    }
                    return docTypes;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return null;
            }
        }

        public bool Update(int id, DocType obj)
        {
            try
            {
                int value = 0;
                if (!DataConnection.DoesExist("sp_DoesExist_DocType", "@Name", obj.Description))
                {
                    using (var con = DataConnection.Connection())
                    {
                        con.Open();
                        var cmd = DataConnection.Command(con, "sp_Update_DocType", CommandType.StoredProcedure);
                        DataConnection.AddParameter(cmd, "@ID", id);
                        AddParams(obj, cmd, "UpdateBy");
                        value = DataConnection.GetValue(cmd);
                    }
                    return HelperClass.GetValue(value, "Register");
                }
                else
                {
                    MessageBox.Show("Invoice Type Exist!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return false;
            }
        }

        private void AddParams(DocType obj,SqlCommand cmd,string audition)
        {
            DataConnection.AddParameter(cmd, "@Code", obj.Code);
            DataConnection.AddParameter(cmd, "@Description", obj.Description);
            DataConnection.AddParameter(cmd, audition, obj.Username);
        }
    }
}
