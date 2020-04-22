using PTi1MenaxhimiDepos.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace PTi1MenaxhimiDepos.BL
{
    public static class HelperClass
    {
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
            grid.DataSource = ItemBLL.ReturnDt(ts);
        }

        public static void DoesExist(Item obj,RadGridView grid)
        {
            if(obj == null)
            {
                MessageBox.Show("Nothing to show", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                List<Item> objs = new List<Item>();
                objs.Add(obj);
                LoadGridItem(objs, grid);
            }
        }

        public static void LoadGridItem(List<Item> items,RadGridView grid)
        {
            grid.DataSource = ItemBLL.ConvertToDataTableItems(items);
        }
    }
}
