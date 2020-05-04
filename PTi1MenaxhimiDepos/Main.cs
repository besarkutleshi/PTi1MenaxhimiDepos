using PTi1MenaxhimiDepos.BL;
using PTi1MenaxhimiDepos.Controls;
using System;
using System.Drawing;
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
                tabControl1.TabPages.Remove(tabControl1.SelectedTab);
            }
            string[] values = new string[4];
            TabPage tabPage = new TabPage("Shitjet e Dites");
            tabControl1.TabPages.Add(tabPage);
            RadGridView obj = new RadGridView();
            obj.AllowAddNewRow = false;
            obj.DataSource = SaleBLL.GetInvoicesToday();
            control.PrinButonsSales(tabPage, obj, values);
            tabControl1.SelectedTab = tabPage;
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            if(TabPages("Regjistrimet e Dites"))
            {
                tabControl1.TabPages.Remove(tabControl1.SelectedTab);
            }
            string[] values = new string[4];
            TabPage tabPage = new TabPage("Regjistrimet e Dites");
            tabControl1.TabPages.Add(tabPage);
            RadGridView obj = new RadGridView();
            obj.AllowAddNewRow = false;
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (TabPages("Administrata"))
            {
                tabControl1.TabPages.Remove(tabControl1.SelectedTab);
            }
            TabPage tabPage = new TabPage("Administrata");
            tabControl1.TabPages.Add(tabPage);
            control.PrintButtonsAdministration(tabPage); 
            RadGridView obj = new RadGridView();
            obj.DataSource = CollaborationBLL.ReturnTableEmployees(CollaborationBLL.GetEmployees());
            obj.AllowSearchRow = true;
            obj.AllowEditRow = false;
            obj.AllowAddNewRow = false;
            obj.TableElement.SearchHighlightColor = Color.LightBlue;
            control.PrintGrid(tabPage, obj, new Point(7, 110), new Size(1490, 480));
            tabControl1.SelectedTab = tabPage;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            POS.POS obj = new POS.POS();
            obj.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.ShowDialog();
        }

        private void btnartikujt_Click(object sender, EventArgs e)
        {
            if (TabPages("Artikujt"))
            {
                tabControl1.TabPages.Remove(tabControl1.SelectedTab);
            }
            RadGridView obj = new RadGridView();
            obj.Columns.Add(HelpClass.GridViewDataColumn("ID", "ID", "ID"));
            obj.Columns.Add(HelpClass.GridViewDataColumn("Barcode", "Barcode", "Barcode"));
            obj.Columns.Add(HelpClass.GridViewDataColumn("Name", "Name", "Name"));
            obj.Columns.Add(HelpClass.GridViewDataColumn("Unit", "Unit.Name", "Name"));
            obj.Columns.Add(HelpClass.GridViewDataColumn("Category", "Category.Name", "Category"));
            obj.Columns.Add(HelpClass.GridViewDataColumn("Type", "Type.Name", "Type"));
            obj.Columns.Add(HelpClass.GridViewDataColumn("Supplier", "Supplier.Name", "Supplier"));
            obj.Columns.Add(HelpClass.GridViewDataColumn("Active", "Active", "Active"));
            obj.Columns.Add(HelpClass.GridViewDataColumn("Stock", "StockQuantity", "Stock"));
            obj.Columns.Add(HelpClass.GridViewDataColumn("Description", "Description", "Description"));
            obj.AllowSearchRow = true;
            obj.AllowEditRow = false;
            obj.AllowAddNewRow = false;
            obj.TableElement.SearchHighlightColor = Color.LightBlue;
            obj.DataSource = ItemBLL.GetItems();
            TabPage tabPage = new TabPage("Artikujt");
            tabControl1.TabPages.Add(tabPage);
            control.PrintGrid(tabPage, obj, new Point(7, 5), new Size(1490, 590));
            tabControl1.SelectedTab = tabPage;
        }
    }
}
