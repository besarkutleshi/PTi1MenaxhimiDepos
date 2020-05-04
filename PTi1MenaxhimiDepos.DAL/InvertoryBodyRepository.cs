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
    public class InvertoryBodyRepository :IGetObject<InvertoryBody>
    {
        public bool Add(InvertoryBody obj)
        {
            try
            {
                int value = 0;
                using (var con = DataConnection.Connection())
                {
                    con.Open();
                    var cmd = DataConnection.Command(con, "sp_Insert_InvertoryBody", CommandType.StoredProcedure);
                    DataConnection.AddParameter(cmd, "@HeaderID", obj.HeaderID);
                    DataConnection.AddParameter(cmd, "@ItemID", obj.ItemID);
                    DataConnection.AddParameter(cmd, "@Price", obj.Price);
                    DataConnection.AddParameter(cmd, "@Quantity", obj.Quantity);
                    DataConnection.AddParameter(cmd, "@Discount", obj.Discount);
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
                    var cmd = DataConnection.Command(con, "sp_Delete_InvertoryBody", CommandType.StoredProcedure);
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

        public InvertoryBody Get(SqlDataReader sdr)
        {
            InvertoryBody obj = new InvertoryBody(int.Parse(sdr["ID"].ToString()), int.Parse(sdr["HEADERID"].ToString()), int.Parse(sdr["QUANTITY"].ToString()),
                double.Parse(sdr["PRICE"].ToString()), Convert.ToDateTime(sdr["CDATE"].ToString()), double.Parse(sdr["DISCOUNT"].ToString()));
            obj.Item = new BO.Item(sdr["ITEM"].ToString());
            return obj;
        }

        public InvertoryBody GetInvertoryBodyByID(int id)
        {
            try
            {
                InvertoryBody obj = null;
                using (var con = DataConnection.Connection())
                {
                    con.Open();
                    var cmd = DataConnection.Command(con, "sp_GetAll_InvertoryBody_ByItem", CommandType.StoredProcedure);
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

        public InvertoryBody GetInvertoryBodyByItem(string item, int headerid)
        {
            try
            {
                InvertoryBody obj = null;
                using (var con = DataConnection.Connection())
                {
                    con.Open();
                    var cmd = DataConnection.Command(con, "sp_GetAll_InvertoryBody_ByItem", CommandType.StoredProcedure);
                    DataConnection.AddParameter(cmd, "@Item", item);
                    DataConnection.AddParameter(cmd, "@InvertoryHeader", headerid);
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

        public List<InvertoryBody> ReadAllByHeaderID(int headerid)
        {
            try
            {
                List<InvertoryBody> ib = null;
                using (var con = DataConnection.Connection())
                {
                    con.Open();
                    var cmd = DataConnection.Command(con, "sp_GetAll_InvertoryBody_ByHeaderID", CommandType.StoredProcedure);
                    DataConnection.AddParameter(cmd, "@ID", headerid);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    if (sdr.HasRows)
                    {
                        ib = new List<InvertoryBody>();
                        while (sdr.Read())
                        {
                            ib.Add(Get(sdr));
                        }
                    }
                }
                return ib;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return null;
            }
        }

        public bool Update(int id, InvertoryBody obj)
        {
            try
            {
                int value = 0;
                using(var con = DataConnection.Connection())
                {
                    con.Open();
                    var cmd = DataConnection.Command(con, "sp_Update_InvertoryBody", CommandType.StoredProcedure);
                    DataConnection.AddParameter(cmd, "@ID", id);
                    DataConnection.AddParameter(cmd, "@HeaderID", obj.HeaderID);
                    DataConnection.AddParameter(cmd, "@ItemID", obj.ItemID);
                    DataConnection.AddParameter(cmd, "@Price", obj.Price);
                    DataConnection.AddParameter(cmd, "@Quantity", obj.Quantity);
                    DataConnection.AddParameter(cmd, "@Discount", obj.Discount);
                    DataConnection.AddParameter(cmd, "@UpdateBy", obj.Username);
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
