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
    public class InvertoryHeaderRepository:IGetObject<InvertoryHeader>
    {
        public bool InsertInvoice(InvertoryHeader invertory)
        {
			try
			{
				int value = 0;
				using (var con = DataConnection.Connection())
				{
					con.Open();
					var cmd = DataConnection.Command(con, "sp_InvertoryBody_BulkInsert", CommandType.StoredProcedure);
					DataConnection.AddParameter(cmd, "@DocNo", invertory.DocNo);
					DataConnection.AddParameter(cmd, "@DoctypeID", invertory.DocTypeID);
					DataConnection.AddParameter(cmd, "@PosiD", invertory.PosID);
					DataConnection.AddParameter(cmd, "@Description", invertory.Description);
					DataConnection.AddParameter(cmd, "@SupplierID", invertory.SupplierID);
					DataConnection.AddParameter(cmd, "@details",ReturnDT(invertory.Bodies));
					DataConnection.AddParameter(cmd, "@InsertBy",invertory.Username);
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

        public List<InvertoryHeader> GetPurchaseInvertoryHeaders()
        {
			try
			{
				List<InvertoryHeader> headers = null;
				using(var con = DataConnection.Connection())
				{
					con.Open();
					var cmd = DataConnection.Command(con, "sp_GetPurchaseInvoices", CommandType.StoredProcedure);
					SqlDataReader sdr = cmd.ExecuteReader();
					if (sdr.HasRows)
					{
						headers = new List<InvertoryHeader>();
						while (sdr.Read())
						{
							headers.Add(Get(sdr));
						}
					}
				}
				return headers;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
				return null;
			}
		}

		public List<InvertoryHeader> GetPurchaseInvertoryHeadersToday()
		{
			try
			{
				List<InvertoryHeader> headers = null;
				using (var con = DataConnection.Connection())
				{
					con.Open();
					var cmd = DataConnection.Command(con, "sp_GetPurchase_Invoices_Today", CommandType.StoredProcedure);
					SqlDataReader sdr = cmd.ExecuteReader();
					if (sdr.HasRows)
					{
						headers = new List<InvertoryHeader>();
						while (sdr.Read())
						{
							headers.Add(Get(sdr));
						}
					}
				}
				return headers;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
				return null;
			}
		}

		public List<InvertoryHeader> GetSaleInvertoryHeadersToday()
		{
			try
			{
				List<InvertoryHeader> headers = null;
				using (var con = DataConnection.Connection())
				{
					con.Open();
					var cmd = DataConnection.Command(con, "sp_GetSale_Invoices_Today", CommandType.StoredProcedure);
					SqlDataReader sdr = cmd.ExecuteReader();
					if (sdr.HasRows)
					{
						headers = new List<InvertoryHeader>();
						while (sdr.Read())
						{
							headers.Add(Get(sdr));
						}
					}
				}
				return headers;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
				return null;
			}
		}

		public InvertoryHeader GetPurchaseInvertoryHeadersById(int id)
		{
			try
			{
				InvertoryHeader headers = null;
				using (var con = DataConnection.Connection())
				{
					con.Open();
					var cmd = DataConnection.Command(con, "sp_GetPurchaseInvoicesByID", CommandType.StoredProcedure);
					DataConnection.AddParameter(cmd,"@ID",id);
					SqlDataReader sdr = cmd.ExecuteReader();
					while (sdr.Read())
					{
						return Get(sdr);
					}
				}
				return headers;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
				return null;
			}
		}

		public InvertoryHeader GetPurchaseInvertoryHeadersByDocNo(string docno)
		{
			try
			{
				InvertoryHeader headers = null;
				using (var con = DataConnection.Connection())
				{
					con.Open();
					var cmd = DataConnection.Command(con, "sp_GetPurchaseInvertoryHeadersByDocNo", CommandType.StoredProcedure);
					DataConnection.AddParameter(cmd, "@DocNo", docno);
					SqlDataReader sdr = cmd.ExecuteReader(); 
					while (sdr.Read())
					{
						return Get(sdr);
					}
				}
				return headers;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
				return null;
			}
		}

		public bool DeletePurchaseHeader(int id)
		{
			try
			{
				int value = 0;
				using(var con = DataConnection.Connection())
				{
					con.Open();
					var cmd = DataConnection.Command(con, "sp_DeletePurchase_Header", CommandType.StoredProcedure);
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

		public bool UpdatePurchaseHeader(int id,InvertoryHeader invertory)
		{
			try
			{
				int value = 0;
				using(var con = DataConnection.Connection())
				{
					con.Open();
					var cmd = DataConnection.Command(con, "sp_UpdatePurchaseHeader", CommandType.StoredProcedure);
					DataConnection.AddParameter(cmd, "@ID", id);
					DataConnection.AddParameter(cmd, "@DocNo", invertory.DocNo);
					DataConnection.AddParameter(cmd, "@DocTypeID", invertory.DocTypeID);
					DataConnection.AddParameter(cmd, "@PosID", invertory.PosID);
					DataConnection.AddParameter(cmd, "@Description", invertory.Description);
					DataConnection.AddParameter(cmd, "@SupplierID", invertory.SupplierID);
					DataConnection.AddParameter(cmd, "@UpdateBy", invertory.Username);
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

		public DataTable ReturnDT(List<InvertoryBody> bodies)
		{
			try
			{

                DataTable dataTable = new DataTable(typeof(InvertoryBody).Name);
                System.Reflection.PropertyInfo[] Props = typeof(InvertoryBody).GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
                foreach (System.Reflection.PropertyInfo item in Props)
                {
                    if (item.Name == "Header" || item.Name == "Item" || item.Name == "Username" || item.Name == "ID" || item.Name == "Cdate")
                    {
                        continue;
                    }
                    dataTable.Columns.Add(item.Name);
                }
                foreach (var item in bodies)
                {
                    if (item == null)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        object[] values = new object[5];
                        values[0] = item.HeaderID;
                        values[1] = item.ItemID;
                        values[2] = item.Quantity;
                        values[3] = item.Price;
                        values[4] = item.Discount;
                        dataTable.Rows.Add(values);
                    }
                }
                return dataTable;
            }
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
				return null;
			}
		}

		public InvertoryHeader Get(SqlDataReader sdr)
		{
			InvertoryHeader obj = new InvertoryHeader(int.Parse(sdr["INVERTORYID"].ToString()), sdr["DOCNO"].ToString(), Convert.ToDateTime(sdr["DOCDATE"].ToString()),
				sdr["DESCRIPTION"].ToString());
			obj.POS= new BO.PointofSale(sdr["POS"].ToString());
			obj.DocType = new DocType(sdr["INVOICE"].ToString());
			obj.Supplier = new BO.Supplier(sdr["SUPPLIER"].ToString());
			return obj;
		}

		public int GetMaxID()
		{
			try
			{
				int value = 0;
				using (var con = DataConnection.Connection())
				{
					con.Open();
					var cmd = DataConnection.Command(con, "sp_GetMaxID_InvertoryHeader", CommandType.StoredProcedure);
					value = DataConnection.GetValue(cmd);
				}
				return value;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
				return 0;
			}
		}

		public int GetMaxDocNo()
		{
			try
			{
				int value = 0;
				using (var con = DataConnection.Connection())
				{
					con.Open();
					var cmd = DataConnection.Command(con, "sp_GetDocNo_InvertoryHeader", CommandType.StoredProcedure);
					value = DataConnection.GetValue(cmd);
				}
				return value;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
				return 0;
			}
		}

		public string GetTotalPurchaseInvertoryToday()
		{
			try
			{
				double value = 0;
				using (var con = DataConnection.Connection())
				{
					con.Open();
					var cmd = DataConnection.Command(con, "sp_SUM_Purchase_Invoices_Today", CommandType.StoredProcedure);
					value = DataConnection.GetSum(cmd);
				}
				return value.ToString(".00");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
				return "";
			}
		}

		public string GetTotalSaleInvertoryToday()
		{
			try
			{
				double value = 0;
				using (var con = DataConnection.Connection())
				{
					con.Open();
					var cmd = DataConnection.Command(con, "sp_SUM_Sale_Invoices_Today", CommandType.StoredProcedure);
					value = DataConnection.GetSum(cmd);
				}
				return value.ToString(".00");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
				return "";
			}
		}
	}
}
