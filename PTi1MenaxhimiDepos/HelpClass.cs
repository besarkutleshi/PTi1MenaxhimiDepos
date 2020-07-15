using PTi1MenaxhimiDepos.BO.Account;
using System.Globalization;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace PTi1MenaxhimiDepos
{
    public static class HelpClass
    {
        public static User CurrentUser = null;
        public static void VisibleButton(RadButton btnsave, RadButton btndelete, RadButton btnupdate, params RadTextBox[] radTextBoxes)
        {
            btnsave.Visible = false; btndelete.Visible = btnupdate.Visible = true;
            Delete(radTextBoxes);
        }

        public static void NotVisibleButton(RadButton btnsave, RadButton btndelete, RadButton btnupdate)
        {
            btnsave.Visible = true; btndelete.Visible = btnupdate.Visible = false;
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

        public static void EnabledTrueTextBoxs(params RadTextBox[] radTextBoxes)
        {
            if(radTextBoxes != null)
            {
                foreach (var item in radTextBoxes)
                {
                    item.Enabled = true;
                }
            }
        }

        public static void EnabledFalseTextBoxs(params RadTextBox[] radTextBoxes)
        {
            if (radTextBoxes != null)
            {
                foreach (var item in radTextBoxes)
                {
                    item.Enabled = false;
                }
            }
        }

        public static void EnabledTrueComboBoxs(params RadDropDownList[] radDropDownLists)
        {
            if (radDropDownLists != null)
            {
                foreach (var item in radDropDownLists)
                {
                    item.Enabled = true;
                }
            }
        }

        public static void EnabledFalseComboBoxs(params RadDropDownList[] radDropDownLists)
        {
            if (radDropDownLists != null)
            {
                foreach (var item in radDropDownLists)
                {
                    item.Enabled = false;
                }
            }
        }

        public static void DeleteComboBoxs(params RadDropDownList[] radDropDownLists)
        {
            if(radDropDownLists != null)
            {
                foreach (var item in radDropDownLists)
                {
                    item.SelectedIndex = -1;
                }
            }
        }

        public static string GetValue(Telerik.WinControls.UI.GridViewCellEventArgs e,RadGridView grid,int index)
        {
            return grid.Rows[e.RowIndex].Cells[index].Value.ToString();
        }

        public static GridViewDataColumn GridViewDataColumn(string uniquename,string fieldname,string headertext)
        {
            GridViewDataColumn column = new GridViewTextBoxColumn(uniquename, fieldname);
            column.HeaderText = headertext;
            return column;
        }

        public static GridViewDataColumn GridViewDataColumn(string uniquename)
        {
            GridViewDataColumn column = new GridViewTextBoxColumn(uniquename, uniquename);
            column.HeaderText = uniquename;
            return column;
        }

        public static string SetText(string enText,string sqText)
        {
            if (CultureInfo.CurrentCulture.Name == "en-US")
                return enText;
            else
                return sqText;
        }

        public static void ShowHelp(Form parent, string htmlPage)
        {
            //Help.ShowHelp(null, @"C:\Users\Admin\Desktop\PTi1MenaxhimiDepos\UserMaunal.hmxz", HelpNavigator.Topic,htmlPage);
            System.Windows.Forms.Help.ShowHelp(parent, @"C:\Users\Admin\Desktop\PTi1MenaxhimiDepos\UserMaunal.hmxz",
            System.Windows.Forms.HelpNavigator.TopicId, htmlPage);
        }
    }
}
