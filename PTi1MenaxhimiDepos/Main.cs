using PTi1MenaxhimiDepos.BL;
using PTi1MenaxhimiDepos.BO;
using PTi1MenaxhimiDepos.Collab;
using PTi1MenaxhimiDepos.Controls;
using PTi1MenaxhimiDepos.Languages;
using System;
using System.Drawing;
using System.Globalization;
using System.Threading;
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
            if (TabPages(HelpClass.SetText("Today Sales", "Shitjet e Dites")))
            {
                tabControl1.TabPages.Remove(tabControl1.SelectedTab);
            }
            string[] values = new string[4];
            TabPage tabPage = new TabPage(HelpClass.SetText("Today Sales", "Shitjet e Dites"));
            tabControl1.TabPages.Add(tabPage);
            RadGridView obj = new RadGridView();
            obj.AllowAddNewRow = false;
            obj.Columns.Add(HelpClass.GridViewDataColumn("INVERTORYID", "InvertoryID", HelpClass.SetText("InvertoryID", "FaturaID")));
            obj.Columns.Add(HelpClass.GridViewDataColumn("DocNo", "DocNo", HelpClass.SetText("Invoice Number", "Numri Fatures")));
            obj.Columns.Add(HelpClass.GridViewDataColumn("DocDate", "DocDate", HelpClass.SetText("Invoice Date", "Data e Fatures")));
            obj.Columns.Add(HelpClass.GridViewDataColumn("Invoice", "DocType.Description", HelpClass.SetText("Invoice", "Fatura")));
            obj.Columns.Add(HelpClass.GridViewDataColumn("Pos", "POS.Name", HelpClass.SetText("Pos", "Depo")));
            obj.Columns.Add(HelpClass.GridViewDataColumn("Description", "Description", HelpClass.SetText("Description", "Pershkrimi")));
            obj.Columns.Add(HelpClass.GridViewDataColumn("Supplier", "Supplier.Name", HelpClass.SetText("Supplier", "Funitori")));
            obj.DataSource = InvoiceBLL.GetSaleInvertoryToday();
            control.PrinButonsSales(tabPage, obj, values);
            tabControl1.SelectedTab = tabPage;
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            if(TabPages(HelpClass.SetText("Today Purchases", "Blerjet e Dites")))
            {
                tabControl1.TabPages.Remove(tabControl1.SelectedTab);
            }
            string[] values = new string[4];
            TabPage tabPage = new TabPage(HelpClass.SetText("Today Purchases", "Blerjet e Dites"));
            tabControl1.TabPages.Add(tabPage);
            RadGridView obj = new RadGridView();
            obj.AllowAddNewRow = false;
            obj.Columns.Add(HelpClass.GridViewDataColumn("INVERTORYID", "InvertoryID", HelpClass.SetText("InvertoryID", "FaturaID")));
            obj.Columns.Add(HelpClass.GridViewDataColumn("DocNo","DocNo", HelpClass.SetText("Invoice Number", "Numri Fatures")));
            obj.Columns.Add(HelpClass.GridViewDataColumn("DocDate", "DocDate", HelpClass.SetText("Invoice Date", "Data e Fatures")));
            obj.Columns.Add(HelpClass.GridViewDataColumn("Invoice", "DocType.Description", HelpClass.SetText("Invoice", "Fatura")));
            obj.Columns.Add(HelpClass.GridViewDataColumn("Pos", "POS.Name", HelpClass.SetText("Pos", "Depo")));
            obj.Columns.Add(HelpClass.GridViewDataColumn("Description", "Description", HelpClass.SetText("Description", "Pershkrimi")));
            obj.Columns.Add(HelpClass.GridViewDataColumn("Supplier","Supplier.Name", HelpClass.SetText("Supplier", "Funitori")));
            obj.DataSource = InvoiceBLL.GetInvertoryHeadersToday();
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
        RadGridView dgwEmployees;
        private void button2_Click(object sender, EventArgs e)
        {
            if (TabPages(HelpClass.SetText("Administration", "Administrata")))
            {
                tabControl1.TabPages.Remove(tabControl1.SelectedTab);
            }
            TabPage tabPage = new TabPage(HelpClass.SetText("Administration", "Administrata"));
            tabControl1.TabPages.Add(tabPage);
            control.PrintButtonsAdministration(tabPage); 
            dgwEmployees = new RadGridView();
            dgwEmployees.CellDoubleClick += DgwEmployees_CellDoubleClick;
            dgwEmployees.Columns.Add(HelpClass.GridViewDataColumn("ID"));
            dgwEmployees.Columns.Add(HelpClass.GridViewDataColumn("Name","Name", HelpClass.SetText("Name", "Emri")));
            dgwEmployees.Columns.Add(HelpClass.GridViewDataColumn("Surname","Surname", HelpClass.SetText("Surname", "Mbiemri")));
            dgwEmployees.Columns.Add(HelpClass.GridViewDataColumn("Email","Email", HelpClass.SetText("Email", "Mail")));
            dgwEmployees.Columns.Add(HelpClass.GridViewDataColumn("Phone","Phone", HelpClass.SetText("Phone", "Nr.Tel")));
            dgwEmployees.Columns.Add(HelpClass.GridViewDataColumn("Street","Address.Street", HelpClass.SetText("Street","Rruga")));
            dgwEmployees.Columns.Add(HelpClass.GridViewDataColumn("City", "Address.City", HelpClass.SetText("City", "Qyteti")));
            dgwEmployees.Columns.Add(HelpClass.GridViewDataColumn("Country", "Address.Country", HelpClass.SetText("Country", "Shteti")));
            dgwEmployees.Columns.Add(HelpClass.GridViewDataColumn("PostalCode", "Address.PostalCode", HelpClass.SetText("Postal Code", "Kodi Postar")));
            dgwEmployees.DataSource = CollaborationBLL.GetEmployees();
            dgwEmployees.AllowSearchRow = true;
            dgwEmployees.AllowEditRow = false;
            dgwEmployees.AllowAddNewRow = false;
            dgwEmployees.TableElement.SearchHighlightColor = Color.LightBlue;
            control.PrintGrid(tabPage, dgwEmployees, new Point(7, 110), new Size(1490, 480));
            tabControl1.SelectedTab = tabPage;
        }

        private void DgwEmployees_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            BO.Employee obj = (BO.Employee)dgwEmployees.Rows[e.RowIndex].DataBoundItem;
            Collab.Employee employee = new Collab.Employee(obj);
            employee.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            POS.PosList obj = new POS.PosList();
            obj.ShowDialog();
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.ShowDialog();
        }

        private void btnartikujt_Click(object sender, EventArgs e)
        {
            if (TabPages(HelpClass.SetText("Items","Artikujt")))
            {
                tabControl1.TabPages.Remove(tabControl1.SelectedTab);
            }
            RadGridView obj = new RadGridView();
            obj.Columns.Add(HelpClass.GridViewDataColumn("ID"));
            obj.Columns.Add(HelpClass.GridViewDataColumn("Barcode","Barcode", HelpClass.SetText("Barcode", "Barkodi")));
            obj.Columns.Add(HelpClass.GridViewDataColumn("Name","Name", HelpClass.SetText("Name", "Emri")));
            obj.Columns.Add(HelpClass.GridViewDataColumn("Unit", "Unit.Name", HelpClass.SetText("Unit", "Njesia")));
            obj.Columns.Add(HelpClass.GridViewDataColumn("Category", "Category.Name", HelpClass.SetText("Category", "Kategoria")));
            obj.Columns.Add(HelpClass.GridViewDataColumn("Type", "Type.Name", HelpClass.SetText("Type", "Lloji")));
            obj.Columns.Add(HelpClass.GridViewDataColumn("Supplier", "Supplier.Name", HelpClass.SetText("Supplier", "Funitori")));
            obj.Columns.Add(HelpClass.GridViewDataColumn("Active","Active", HelpClass.SetText("Active", "Aktiv")));
            obj.Columns.Add(HelpClass.GridViewDataColumn("Stock", "StockQuantity", HelpClass.SetText("Stock", "Quantity")));
            obj.Columns.Add(HelpClass.GridViewDataColumn("Description","Description", HelpClass.SetText("Description", "Pershkrimi")));
            obj.AllowSearchRow = true;
            obj.AllowEditRow = false;
            obj.AllowAddNewRow = false;
            obj.TableElement.SearchHighlightColor = Color.LightBlue;
            obj.DataSource = ItemBLL.GetItems();
            TabPage tabPage = new TabPage(HelpClass.SetText("Items", "Artikujt"));
            tabControl1.TabPages.Add(tabPage);
            control.PrintGrid(tabPage, obj, new Point(7, 5), new Size(1490, 590));
            tabControl1.SelectedTab = tabPage;
        }

        private void btnbashkpunimet_Click(object sender, EventArgs e)
        {
            //if (TabPages(HelpClass.SetText("Collaboration", "Partneret")))
            //{
            //    tabControl1.TabPages.Remove(tabControl1.SelectedTab);
            //}
            //TabPage tabPage = new TabPage(HelpClass.SetText("Collaboration", "Partneret"));
            //tabControl1.TabPages.Add(tabPage);
            //control.PrintButtonsCollaboration(tabPage);
            //RadGridView obj = new RadGridView();
            //obj.Columns.Add(HelpClass.GridViewDataColumn("ID"));
            //obj.Columns.Add(HelpClass.GridViewDataColumn("Name","Name", HelpClass.SetText("Name", "Emri")));
            //obj.Columns.Add(HelpClass.GridViewDataColumn("City","City", HelpClass.SetText("City", "Qyteti")));
            //obj.Columns.Add(HelpClass.GridViewDataColumn("Phone","Phone", HelpClass.SetText("Phone", "Nr.Tel")));
            //obj.Columns.Add(HelpClass.GridViewDataColumn("Email","Email", HelpClass.SetText("Email", "Mail")));
            //obj.Columns.Add(HelpClass.GridViewDataColumn("Description","Description", HelpClass.SetText("Description", "Pershkrimi")));
            //obj.DataSource = CollaborationBLL.GetSuppliers();
            //obj.AllowSearchRow = true;
            //obj.AllowEditRow = false;
            //obj.AllowAddNewRow = false;
            //obj.TableElement.SearchHighlightColor = Color.LightBlue;
            //control.PrintGrid(tabPage, obj, new Point(7, 110), new Size(1490, 480));
            //tabControl1.SelectedTab = tabPage;

            SupplierList supplier = new SupplierList();
            supplier.ShowDialog();
        }

        private void tlenglish_Click(object sender, EventArgs e)
        {
            ChangeLanguage("en-US");
            //TranslateFormMultipleResource.ChangeLanguages("en-US");
        }

        private void ChangeLanguage(string lang)
        {
            CultureInfo ci = new CultureInfo(lang);
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;
            this.Controls.Clear();
            this.InitializeComponent();
        }

        private void tlalbania_Click(object sender, EventArgs e)
        {
            ChangeLanguage("sq");
            //TranslateFormMultipleResource.ChangeLanguages("sq");
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if(HelpClass.language != "en-US")
            {
                HelpClass.language = "en-US";
            }
            else
            {
                CultureInfo ci = new CultureInfo(HelpClass.language);
                Thread.CurrentThread.CurrentCulture = ci;
                Thread.CurrentThread.CurrentUICulture = ci;
            }
        }

        private void btnhyrjet_Click(object sender, EventArgs e)
        {
            if (TabPages(HelpClass.SetText("Entries", "Hyrjet")))
            {
                tabControl1.TabPages.Remove(tabControl1.SelectedTab);
            }
            TabPage tabPage = new TabPage(HelpClass.SetText("Entries", "Hyrjet"));
            tabControl1.TabPages.Add(tabPage);
            control.PrintEntriesButtons(tabPage);
            tabControl1.SelectedTab = tabPage;
            //ItemReport obj = new ItemReport();
            //obj.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btndaljet_Click(object sender, EventArgs e)
        {
            if (TabPages(HelpClass.SetText("Exits", "Daljet")))
            {
                tabControl1.TabPages.Remove(tabControl1.SelectedTab);
            }
            TabPage tabPage = new TabPage(HelpClass.SetText("Exits", "Daljet"));
            tabControl1.TabPages.Add(tabPage);
            control.PrintExitsButtons(tabPage);
            tabControl1.SelectedTab = tabPage;
        }

        private void language_Click(object sender, EventArgs e)
        {

        }
    }
}
