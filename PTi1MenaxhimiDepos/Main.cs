﻿using PTi1MenaxhimiDepos.BL;
using PTi1MenaxhimiDepos.Collab;
using PTi1MenaxhimiDepos.Controls;
using PTi1MenaxhimiDepos.EntryExits;
using PTi1MenaxhimiDepos.EntryExits.ClientRaports;
using PTi1MenaxhimiDepos.EntryExits.ItemReports;
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (TabPages(HelpClass.SetText("Administration", "Administrata")))
            {
                tabControl1.TabPages.Remove(tabControl1.SelectedTab);
            }
            TabPage tabPage = new TabPage(HelpClass.SetText("Administration", "Administrata"));
            tabControl1.TabPages.Add(tabPage);
            control.PrintButtonsAdministration(tabPage); 
            RadGridView obj = new RadGridView();
            obj.Columns.Add(HelpClass.GridViewDataColumn("ID"));
            obj.Columns.Add(HelpClass.GridViewDataColumn("Name","Name", HelpClass.SetText("Name", "Emri")));
            obj.Columns.Add(HelpClass.GridViewDataColumn("Surname","Surname", HelpClass.SetText("Surname", "Mbiemri")));
            obj.Columns.Add(HelpClass.GridViewDataColumn("Email","Email", HelpClass.SetText("Email", "Mail")));
            obj.Columns.Add(HelpClass.GridViewDataColumn("Phone","Phone", HelpClass.SetText("Phone", "Nr.Tel")));
            obj.Columns.Add(HelpClass.GridViewDataColumn("Street","Address.Street", HelpClass.SetText("Street","Rruga")));
            obj.Columns.Add(HelpClass.GridViewDataColumn("City", "Address.City", HelpClass.SetText("City", "Qyteti")));
            obj.Columns.Add(HelpClass.GridViewDataColumn("Country", "Address.Country", HelpClass.SetText("Country", "Shteti")));
            obj.Columns.Add(HelpClass.GridViewDataColumn("PostalCode", "Address.PostalCode", HelpClass.SetText("Postal Code", "Kodi Postar")));
            obj.DataSource = CollaborationBLL.GetEmployees();
            obj.AllowSearchRow = true;
            obj.AllowEditRow = false;
            obj.AllowAddNewRow = false;
            obj.TableElement.SearchHighlightColor = Color.LightBlue;
            control.PrintGrid(tabPage, obj, new Point(7, 110), new Size(1490, 480));
            tabControl1.SelectedTab = tabPage;
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
            if (TabPages(HelpClass.SetText("Collaboration", "Partneret")))
            {
                tabControl1.TabPages.Remove(tabControl1.SelectedTab);
            }
            TabPage tabPage = new TabPage(HelpClass.SetText("Collaboration", "Partneret"));
            tabControl1.TabPages.Add(tabPage);
            control.PrintButtonsCollaboration(tabPage);
            RadGridView obj = new RadGridView();
            obj.Columns.Add(HelpClass.GridViewDataColumn("ID"));
            obj.Columns.Add(HelpClass.GridViewDataColumn("Name","Name", HelpClass.SetText("Name", "Emri")));
            obj.Columns.Add(HelpClass.GridViewDataColumn("City","City", HelpClass.SetText("City", "Qyteti")));
            obj.Columns.Add(HelpClass.GridViewDataColumn("Phone","Phone", HelpClass.SetText("Phone", "Nr.Tel")));
            obj.Columns.Add(HelpClass.GridViewDataColumn("Email","Email", HelpClass.SetText("Email", "Mail")));
            obj.Columns.Add(HelpClass.GridViewDataColumn("Description","Description", HelpClass.SetText("Description", "Pershkrimi")));
            obj.DataSource = CollaborationBLL.GetSuppliers();
            obj.AllowSearchRow = true;
            obj.AllowEditRow = false;
            obj.AllowAddNewRow = false;
            obj.TableElement.SearchHighlightColor = Color.LightBlue;
            control.PrintGrid(tabPage, obj, new Point(7, 110), new Size(1490, 480));
            tabControl1.SelectedTab = tabPage;
        }

        private void tlenglish_Click(object sender, EventArgs e)
        {
            ChangeLanguage("en-US");
            //TranslateFormMultipleResource.ChangeLanguages("sq");
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
            //CultureInfo.CurrentUICulture = new CultureInfo("en-US",false);
        }

        private void btnhyrjet_Click(object sender, EventArgs e)
        {
            ItemReport obj = new ItemReport();
            obj.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
