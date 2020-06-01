using PTi1MenaxhimiDepos.BO.EntiresExits.ClientReports;
using PTi1MenaxhimiDepos.BO.EntiresExits.SupplierReports;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTi1MenaxhimiDepos.DAL.EntriesExits
{
    public class SupplierReportRepository
    {
        public List<SupplierReport> GetSupplierReports()
        {
			try
			{
				List<SupplierReport> supplierReports = null;
				using (var con = DataConnection.Connection()) 
				{
					con.Open();
					var cmd = DataConnection.Command(con, "sp_GetSupplier_Reports", CommandType.StoredProcedure);
					SqlDataReader sdr = cmd.ExecuteReader();
					if (sdr.HasRows)
					{
						supplierReports = new List<SupplierReport>();
						while (sdr.Read())
						{
							supplierReports.Add(new SupplierReport(int.Parse(sdr["SUPPLIERID"].ToString()), sdr["NAME"].ToString(), double.Parse(sdr["Amount"].ToString())));
						}
					}
					return supplierReports;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
				return null;
			}
        }

		public List<ClientInvoices> GetSupplierInvoices(int clientid)
		{
			List<ClientInvoices> clientInvoices = null;
			try
			{
				using (var con = DataConnection.Connection())
				{
					con.Open();
					var cmd = DataConnection.Command(con, "sp_GetEnteriesReports_Clients_ById", CommandType.StoredProcedure);
					cmd.Parameters.AddWithValue("@ClientID", clientid);
					SqlDataReader sdr = cmd.ExecuteReader();
					if (sdr.HasRows)
					{
						clientInvoices = new List<ClientInvoices>();
						while (sdr.Read())
						{
							clientInvoices.Add(GetClientInvoices(sdr));
						}
					}
				}
				return clientInvoices;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
				return null;
			}
		}
		public ClientInvoices GetClientInvoices(SqlDataReader sdr)
		{
			return new ClientInvoices(int.Parse(sdr["INVERTORYID"].ToString()), sdr["DOCNO"].ToString(), sdr["DESCRIPTION"].ToString(), Convert.ToDateTime(sdr["DOCDATE"]),
				sdr["POS"].ToString(), double.Parse(sdr["AMOUNT"].ToString()));
		}
	}
}
