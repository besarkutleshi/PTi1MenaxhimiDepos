using PTi1MenaxhimiDepos.BO.EntiresExits.ItemReports;
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
    public class ItemReportRepository
    {
        public List<ItemReport> GetItemReports()
        {
			try
			{
				List<ItemReport> itemReports = null;
				using (var con = DataConnection.Connection())
				{
					con.Open();
					var cmd = DataConnection.Command(con, "sp_GetEnteriesReports_Item", CommandType.StoredProcedure);
					SqlDataReader sdr = cmd.ExecuteReader();
					if (sdr.HasRows)
					{
						itemReports = new List<ItemReport>();
						while (sdr.Read())
						{
							itemReports.Add(new ItemReport(sdr["BARCODE"].ToString(), sdr["NAME"].ToString(), long.Parse(sdr["Quantity"].ToString())));
						}
					}
				}
				return itemReports;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
				return null;
			}
        }

		public List<ItemReport> GetExitItemReports()
		{
			try
			{
				List<ItemReport> itemReports = null;
				using (var con = DataConnection.Connection())
				{
					con.Open();
					var cmd = DataConnection.Command(con, "sp_GetExitItems_Report", CommandType.StoredProcedure);
					SqlDataReader sdr = cmd.ExecuteReader();
					if (sdr.HasRows)
					{
						itemReports = new List<ItemReport>();
						while (sdr.Read())
						{
							itemReports.Add(new ItemReport(sdr["BARCODE"].ToString(), sdr["NAME"].ToString(), long.Parse(sdr["Quantity"].ToString())));
						}
					}
				}
				return itemReports;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
				return null;
			}
		}
	}
}
