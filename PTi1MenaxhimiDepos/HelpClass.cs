using PTi1MenaxhimiDepos.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls.UI;

namespace PTi1MenaxhimiDepos
{
    public static class HelpClass
    {
        public static void OnChange(RadButton btnsave, RadButton btndelete, RadButton btnupdate, params RadTextBox[] radTextBoxes)
        {
            btnsave.Visible = true; btndelete.Visible = false; btnupdate.Visible = false;
            foreach (var item in radTextBoxes)
            {
                item.Text = "";
            }
        }

        public static string GetValue(Telerik.WinControls.UI.GridViewCellEventArgs e,RadGridView grid,int index)
        {
            return grid.Rows[e.RowIndex].Cells[index].Value.ToString();
        }
    }
}
