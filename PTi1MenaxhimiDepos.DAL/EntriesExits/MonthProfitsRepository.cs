using PTi1MenaxhimiDepos.BO.EntiresExits;
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
    public class MonthProfitsRepository
    {
        public IEnumerable<MonthProfits> GetMonthProfits()
        {
            List<MonthProfits> monthProfits = new List<MonthProfits>();
            try
            {
                for (int i = 0; i < Arrays.months.Length; i++)
                {
                    using (var con = DataConnection.Connection())
                    {
                        con.Open();
                        var cmd = DataConnection.Command(con, "sp_Get_Enteries_Month", CommandType.StoredProcedure);
                        cmd.Parameters.AddWithValue("Month", Arrays.monthsnums[i]);
                        SqlDataReader sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                        {
                            MonthProfits obj = new MonthProfits(Arrays.months[i], double.Parse(sdr["SUM"].ToString()));
                            monthProfits.Add(obj);
                        }
                    }
                }
                return monthProfits;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return null;
            }
        }

        public IEnumerable<WeekProfits> GetWeekProfits()
        {
            int day = DateTime.Now.Day;
            List<WeekProfits> monthProfits = new List<WeekProfits>();
            try
            {
                for (int i = 0; i < Arrays.days.Length; i++)
                {
                    using (var con = DataConnection.Connection())
                    {
                        con.Open();
                        var cmd = DataConnection.Command(con, "sp_Get_Enteries_Week", CommandType.StoredProcedure);
                        cmd.Parameters.AddWithValue("@Day", Arrays.days[i]);
                        SqlDataReader sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                        {
                            WeekProfits obj = new WeekProfits(Arrays.days[i], double.Parse(sdr["SUM"].ToString()));
                            monthProfits.Add(obj);
                        }
                    }
                }
                return monthProfits;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
