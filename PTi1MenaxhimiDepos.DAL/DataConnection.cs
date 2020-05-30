using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTi1MenaxhimiDepos.DAL
{
    public static class DataConnection
    {
        public static string Constring 
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["MenaxhimiDepos"].ConnectionString;
            }
        }

        public static SqlConnection Connection()
        {
            try
            {
                SqlConnection con = new SqlConnection(Constring);
                return con;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static SqlCommand Command(SqlConnection con ,string cmdText,CommandType commandType)
        {
            SqlCommand cmd = new SqlCommand(cmdText, con);
            cmd.CommandType = commandType;
            return cmd;
        }

        public static void AddParameter(SqlCommand cmd, string parametername,object value)
        {
            SqlParameter sqlParameter = cmd.CreateParameter();
            sqlParameter.ParameterName = parametername;
            if(value == null)
            {
                sqlParameter.Value = DBNull.Value;
                sqlParameter.Value = null;
            }
            sqlParameter.Value = value;
            cmd.Parameters.Add(sqlParameter);
        }
        public static void AddParameter(SqlCommand cmd, string parametername,ParameterDirection parameterDirection)
        {
            SqlParameter sqlParameter = cmd.CreateParameter();
            sqlParameter.ParameterName = parametername;
            sqlParameter.Direction = parameterDirection;
            sqlParameter.DbType = DbType.Double;
            cmd.Parameters.Add(sqlParameter);
        }
        public static int GetValue(SqlCommand cmd)
        {
            AddParameter(cmd, "@Value", ParameterDirection.Output);
            cmd.ExecuteNonQuery();
            if (cmd.Parameters["@Value"].Value == DBNull.Value)
            {
                return 0;
            }
            return int.Parse(cmd.Parameters["@Value"].Value.ToString());
        }

        public static double GetSum(SqlCommand cmd)
        {
            AddParameter(cmd, "@Value", ParameterDirection.Output);
            cmd.ExecuteNonQuery();
            if (cmd.Parameters["@Value"].Value == DBNull.Value)
            {
                return 0;
            }
            return double.Parse(cmd.Parameters["@Value"].Value.ToString());
        }

        public static bool DoesExist(string procedure,object parametername,object value)
        {
            try
            {
                int val = 0;
                using(var con = Connection())
                {
                    con.Open();
                    var cmd = Command(con, procedure, CommandType.StoredProcedure);
                    AddParameter(cmd, parametername.ToString(), value);
                    val = GetValue(cmd);
                }
                if (val != 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return true;
            }
        }
    }
}
