using PTi1MenaxhimiDepos.BO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace PTi1MenaxhimiDepos.BL
{
    public static class HelperClass
    {
        public static bool DoesExists<T>(T obj , ref List<T> ts)
        {
            if(obj != null)
            {
                ts = new List<T>();
                ts.Add(obj);
                return true;
            }
            MessageBox.Show("Nothing to show", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            return false;
        }
        public static void DoesExist<T>(T obj,RadGridView grid)
        {
            if(obj == null)
            {
                MessageBox.Show("Nothing to show", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                List<T> objs = new List<T>();
                objs.Add(obj);
                LoadGrid(objs, grid);
            }
        }

        public static void LoadGrid<T>(List<T> ts, RadGridView grid)
        {
            object obj = null;
            foreach (var item in ts)
            {
                obj = item;
                break;
            }
            if (obj is PTi1MenaxhimiDepos.BO.Account.User)
            {
                grid.DataSource = AdministrationBLL.ReturnUsers(AdministrationBLL.GetUsers());
                return;
            }
            if(obj is PTi1MenaxhimiDepos.BO.Item)
            {
                grid.DataSource = ItemBLL.ConvertToDataTableItems(ItemBLL.GetItems());
                return;
            }
            grid.DataSource = ReturnDt(ts);
        }

        public static DataTable ReturnDt<T>(List<T> singers)
        {
            try
            {
                DataTable dataTable = new DataTable(typeof(T).Name);
                System.Reflection.PropertyInfo[] Props = typeof(T).GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
                foreach (System.Reflection.PropertyInfo item in Props)
                {
                    if (item.Name == "Username")
                    {
                        continue;
                    }
                    dataTable.Columns.Add(item.Name);
                }
                foreach (T item in singers)
                {
                    var values = new object[Props.Length - 1];
                    for (int i = 0; i < Props.Length - 1; i++)
                    {
                        values[i] = Props[i].GetValue(item, null);
                    }
                    dataTable.Rows.Add(values);
                }
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
