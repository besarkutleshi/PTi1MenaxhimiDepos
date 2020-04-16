using PTi1MenaxhimiDepos.BL;
using PTi1MenaxhimiDepos.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace PTi1MenaxhimiDepos
{
    public partial class Main : Form
    {
        CreateControl control = new CreateControl();
        public Main()
        {
            InitializeComponent();
        }

        private void btnshitja_Click(object sender, EventArgs e)
        {
            if (TabPages("Shitjet e Dites"))
            {
                return;
            }
            string[] values = new string[4];
            TabPage tabPage = new TabPage("Shitjet e Dites");
            tabControl1.TabPages.Add(tabPage);
            RadGridView obj = new RadGridView();
            obj.DataSource = SaleBLL.GetInvoicesToday();
            control.PrinButonsSales(tabPage, obj, values);
            tabControl1.SelectedTab = tabPage;
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            if(TabPages("Regjistrimet e Dites"))
            {
                return;
            }
            string[] values = new string[4];
            TabPage tabPage = new TabPage("Regjistrimet e Dites");
            tabControl1.TabPages.Add(tabPage);
            RadGridView obj = new RadGridView();
            obj.DataSource = SaleBLL.GetInvoicesToday();
            control.PrintButtonsItems(tabPage, obj, values);
            tabControl1.SelectedTab = tabPage;
        }

        private bool TabPages(string name)
        {
            foreach (TabPage item in tabControl1.TabPages)
            {
                if (item.AccessibilityObject.Name == name)
                {
                    tabControl1.SelectedTab = item;
                    return true;
                }
            }
            return false;
        }
    }
}
