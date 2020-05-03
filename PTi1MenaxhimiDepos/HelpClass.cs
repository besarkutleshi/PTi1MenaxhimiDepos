using PTi1MenaxhimiDepos.BL;
using PTi1MenaxhimiDepos.BO.Account;
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
        public static User CurrentUser = null;
        public static void OnChange(RadButton btnsave, RadButton btndelete, RadButton btnupdate, params RadTextBox[] radTextBoxes)
        {
            if(btnsave.Visible == true)
            {
                btnsave.Visible = false; btndelete.Visible = btnupdate.Visible = true;
            }
            else
            {
                btnsave.Visible = true; btndelete.Visible = false; btnupdate.Visible = false;
            }
            Delete(radTextBoxes);
        }

        public static void Delete(params RadTextBox[] radTextBoxes)
        {
            if(radTextBoxes != null)
            {
                foreach (var item in radTextBoxes)
                {
                    item.Text = "";
                }
            }
        }

        public static void EnabledTextBoxs(params RadTextBox[] radTextBoxes)
        {
            if(radTextBoxes != null)
            {
                foreach (var item in radTextBoxes)
                {
                    if(item.Enabled == false)
                    {
                        item.Enabled = true;
                    }
                    else
                    {
                        item.Enabled = false;
                    }
                }
            }
        }

        public static void EnabledComboBoxs(params RadDropDownList[] radDropDownLists)
        {
            if (radDropDownLists != null)
            {
                foreach (var item in radDropDownLists)
                {
                    if (item.Enabled == false)
                    {
                        item.Enabled = true;
                    }
                    else
                    {
                        item.Enabled = false;
                    }
                }
            }
        }

        public static string GetValue(Telerik.WinControls.UI.GridViewCellEventArgs e,RadGridView grid,int index)
        {
            return grid.Rows[e.RowIndex].Cells[index].Value.ToString();
        }
    }
}
