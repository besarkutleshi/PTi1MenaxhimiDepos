using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using PTi1MenaxhimiDepos.Items;
using PTi1MenaxhimiDepos.BL;
using PTi1MenaxhimiDepos.Invoices;
using PTi1MenaxhimiDepos.Collab;
using PTi1MenaxhimiDepos.Administration;
using PTi1MenaxhimiDepos.EntryExits.ItemReports;
using PTi1MenaxhimiDepos.EntryExits.ClientRaports;
using PTi1MenaxhimiDepos.EntryExits;
using PTi1MenaxhimiDepos.EntryExits.SupplierReports;

namespace PTi1MenaxhimiDepos.Controls
{
    public class CreateControl
    {
        private void PrintControls(TabPage tabPage, RadGridView obj, string[] values)
        {
            RadButton btn1 = new RadButton();
            tabPage.Controls.Add(ControlShow.GetButtonss(btn1, new Point(13, 110), new Size(38, 28)));
            RadButton btn2 = new RadButton();
            tabPage.Controls.Add(ControlShow.GetButtonss(btn2, new Point(54, 110), new Size(115, 28), HelpClass.SetText("Number", "Numro")));
            RadButton btn3 = new RadButton();
            tabPage.Controls.Add(ControlShow.GetButtonss(btn3, new Point(175, 110), new Size(115, 28), HelpClass.SetText("Description", "Pershkrimi")));
            RadButton btn4 = new RadButton();
            tabPage.Controls.Add(ControlShow.GetButtonss(btn4, new Point(296, 110), new Size(115, 28), HelpClass.SetText("Date", "Data")));
            RadButton btn5 = new RadButton();
            tabPage.Controls.Add(ControlShow.GetButtonss(btn5, new Point(417, 110), new Size(115, 28), HelpClass.SetText("Collaboration", "Partneri")));
            RadButton btn6 = new RadButton();
            tabPage.Controls.Add(ControlShow.GetButtonss(btn6, new Point(538, 110), new Size(115, 28), HelpClass.SetText("Amount", "Shuma")));
            RadButton btn7 = new RadButton();
            tabPage.Controls.Add(ControlShow.GetButtonss(btn7, new Point(659, 110), new Size(115, 28), "TVSH"));
            RadButton btn8 = new RadButton();
            tabPage.Controls.Add(ControlShow.GetButtonss(btn8, new Point(780, 110), new Size(115, 28), HelpClass.SetText("Pay", "Paguar")));
            RadButton btn9 = new RadButton();
            tabPage.Controls.Add(ControlShow.GetButtonss(btn9, new Point(901, 110), new Size(115, 28), HelpClass.SetText("Debt", "Borxhi")));
            RadButton btn10 = new RadButton();
            tabPage.Controls.Add(ControlShow.GetButtonss(btn10, new Point(1022, 110), new Size(115, 28), HelpClass.SetText("Change", "Kusuri")));
            RadButton btn11 = new RadButton();
            tabPage.Controls.Add(ControlShow.GetButtonss(btn11, new Point(1143, 110), new Size(115, 28), HelpClass.SetText("Address", "Adresa")));
            RadButton btn12 = new RadButton();
            tabPage.Controls.Add(ControlShow.GetButtonss(btn12, new Point(1264, 110), new Size(115, 28), HelpClass.SetText("POS", "Depo")));
            RadButton btn13 = new RadButton();
            tabPage.Controls.Add(ControlShow.GetButtonss(btn13, new Point(1385, 110), new Size(115, 28), HelpClass.SetText("Added", "Shtuar")));
            tabPage.Controls.Add(ControlShow.GetButtonss(obj, new Point(12, 180), new Size(1490, 410)));
            RadTextBox txt1 = new RadTextBox();
            tabPage.Controls.Add(ControlShow.GetButtonss(txt1, new Point(13, 145), new Size(38, 28), null));
            RadTextBox txt2 = new RadTextBox();
            tabPage.Controls.Add(ControlShow.GetButtonss(txt2, new Point(54, 145), new Size(115, 40), null));
            RadTextBox txt3 = new RadTextBox();
            tabPage.Controls.Add(ControlShow.GetButtonss(txt3, new Point(175, 145), new Size(115, 40), null));
            RadTextBox txt4 = new RadTextBox();
            tabPage.Controls.Add(ControlShow.GetButtonss(txt4, new Point(296, 145), new Size(115, 40), null));
            RadTextBox txt5 = new RadTextBox();
            tabPage.Controls.Add(ControlShow.GetButtonss(txt5, new Point(417, 145), new Size(115, 40), null));
            RadTextBox txt6 = new RadTextBox();
            tabPage.Controls.Add(ControlShow.GetButtonss(txt6, new Point(538, 145), new Size(115, 40), values[0], null));
            RadTextBox txt7 = new RadTextBox();
            tabPage.Controls.Add(ControlShow.GetButtonss(txt7, new Point(659, 145), new Size(115, 40), null));
            RadTextBox txt8 = new RadTextBox();
            tabPage.Controls.Add(ControlShow.GetButtonss(txt8, new Point(780, 145), new Size(115, 40), values[1], null));
            RadTextBox txt9 = new RadTextBox();
            tabPage.Controls.Add(ControlShow.GetButtonss(txt9, new Point(901, 145), new Size(115, 40), values[2], null));
            RadTextBox txt10 = new RadTextBox();
            tabPage.Controls.Add(ControlShow.GetButtonss(txt10, new Point(1022, 145), new Size(115, 40), values[3], null));
            RadTextBox txt11 = new RadTextBox();
            tabPage.Controls.Add(ControlShow.GetButtonss(txt11, new Point(1143, 145), new Size(115, 40), null));
            RadTextBox txt12 = new RadTextBox();
            tabPage.Controls.Add(ControlShow.GetButtonss(txt12, new Point(1264, 145), new Size(115, 40), null));
            RadTextBox txt13 = new RadTextBox();
            tabPage.Controls.Add(ControlShow.GetButtonss(txt13, new Point(1385, 145), new Size(115, 40), null));
        }
        private Image CreateImage(Bitmap bmp)
        {
            Image img = bmp;
            return img;
        }
        
        #region Sale
        public void PrinButonsSales(TabPage tabPage, RadGridView obj, string[] values)
        {
            RadButton btnSale = new RadButton();
            btnSale.Click += BtnSale_Click;
            Bitmap hape = Properties.Resources.iconsale;
            Image hapeimg = hape;
            tabPage.Controls.Add(ControlShow.GetButtonss(btnSale, new Point(13, 20), new Size(75, 60), null, hapeimg));
            Label sale = new Label();
            tabPage.Controls.Add(ControlShow.GetButtonss(sale, new Point(32, 85), new Size(75, 20), HelpClass.SetText("Sale", "Shitja")));
            RadButton btnRegisterInvoice = new RadButton();
            btnRegisterInvoice.Click += BtnRegisterInvoice_Click;
            Image invoice = CreateImage(new Bitmap(Properties.Resources.invoice));
            tabPage.Controls.Add(ControlShow.GetButtonss(btnRegisterInvoice, new Point(100, 20), new Size(75, 60), null, invoice));
            Label lblinvoice = new Label();
            tabPage.Controls.Add(ControlShow.GetButtonss(lblinvoice, new Point(110, 85), new Size(75, 20), HelpClass.SetText("Invoices", "Faturat")));
            values[0] = InvoiceBLL.GetTotalSalePurchaseInvertoryToday();
            PrintControls(tabPage, obj, values);
        }
        private void BtnSale_Click(object sender, EventArgs e)
        {
            Sale.Sale s = new Sale.Sale();
            s.ShowDialog();
        }
        #endregion

        #region Items
        public void PrintButtonsItems(TabPage tabPage, RadGridView obj, string[] values)
        {
            RadButton btnListInvoice = new RadButton();
            btnListInvoice.Click += BtnListInvoice_Click;
            Image invoice = CreateImage(new Bitmap(Properties.Resources.invoice));
            tabPage.Controls.Add(ControlShow.GetButtonss(btnListInvoice, new Point(13, 20), new Size(75, 60), null, invoice));
            Label lblListinvoice = new Label();
            tabPage.Controls.Add(ControlShow.GetButtonss(lblListinvoice, new Point(22, 85), new Size(75,23), HelpClass.SetText("Invoices", "Faturat")));
            RadButton btnRegisterInvoice = new RadButton();
            btnRegisterInvoice.Click += BtnRegisterInvoice_Click;
            tabPage.Controls.Add(ControlShow.GetButtonss(btnRegisterInvoice, new Point(100, 20), new Size(75, 60), null, invoice));
            Label lblinvoice = new Label();
            tabPage.Controls.Add(ControlShow.GetButtonss(lblinvoice, new Point(110, 85), new Size(75, 20), HelpClass.SetText("Invoice", "Fatura")));
            RadButton btnRegisterItem = new RadButton();
            btnRegisterItem.Click += BtnRegisterItem_Click;
            Image hapeimg = CreateImage(new Bitmap(Properties.Resources.add_item_icon));
            tabPage.Controls.Add(ControlShow.GetButtonss(btnRegisterItem, new Point(187, 20), new Size(75, 60), null, hapeimg));
            if(HelpClass.SetText("Item", "Artikull") == "Artikull")
            {
                Label lblitem = new Label();
                tabPage.Controls.Add(ControlShow.GetButtonss(lblitem, new Point(200, 85), new Size(75, 20),"Artikull"));
            }
            else
            {
                Label lblitem = new Label();
                tabPage.Controls.Add(ControlShow.GetButtonss(lblitem, new Point(208, 85), new Size(75, 20), "Item"));
            }
            RadButton btnRegisterType = new RadButton();
            btnRegisterType.Click += BtnRegisterType_Click;
            Image type = CreateImage(new Bitmap(Properties.Resources.type));
            tabPage.Controls.Add(ControlShow.GetButtonss(btnRegisterType, new Point(274, 20), new Size(75, 60), null, type));
            Label lbltype = new Label();
            tabPage.Controls.Add(ControlShow.GetButtonss(lbltype, new Point(292, 85), new Size(75, 20), HelpClass.SetText("Type", "Lloji")));
            RadButton btnRegisterUnit = new RadButton();
            btnRegisterUnit.Click += BtnRegisterUnit_Click;
            Image unit = CreateImage(new Bitmap(Properties.Resources.unit));
            tabPage.Controls.Add(ControlShow.GetButtonss(btnRegisterUnit, new Point(361, 20), new Size(75, 60), null, unit));
            Label lblunit = new Label();
            tabPage.Controls.Add(ControlShow.GetButtonss(lblunit, new Point(380, 85), new Size(75, 20), HelpClass.SetText("Unit", "Njesi")));
            RadButton btnRegisterCategory = new RadButton();
            btnRegisterCategory.Click += BtnRegisterCategory_Click;
            Image category = CreateImage(new Bitmap(Properties.Resources.category));
            tabPage.Controls.Add(ControlShow.GetButtonss(btnRegisterCategory, new Point(448, 20), new Size(75, 60), null, category));
            Label lblcategory = new Label();
            tabPage.Controls.Add(ControlShow.GetButtonss(lblcategory, new Point(453, 85), new Size(75, 20), HelpClass.SetText("Category", "Kategori")));
            values[0] = InvoiceBLL.GetTotalPurchaseInvertoryToday();
            PrintControls(tabPage, obj, values);
        }
        private void BtnListInvoice_Click(object sender, EventArgs e)
        {
            InvoiceList obj = new InvoiceList();
            obj.ShowDialog();
        }
        public void PrintGrid(TabPage tab, RadGridView obj,Point point,Size size)
        {
            tab.Controls.Add(ControlShow.GetButtonss(obj,point, size));
        }
        private void BtnRegisterUnit_Click(object sender, EventArgs e)
        {
            UnitList obj = new UnitList();
            obj.ShowDialog();
        }
        private void BtnRegisterInvoice_Click(object sender, EventArgs e)
        {
            Invoices.Invoice obj = new Invoices.Invoice();
            obj.ShowDialog();
        }
        private void BtnRegisterCategory_Click(object sender, EventArgs e)
        {
            CategoryList obj = new CategoryList();
            obj.ShowDialog();
        }
        private void BtnRegisterType_Click(object sender, EventArgs e)
        {
            TypeList obj = new TypeList();
            obj.ShowDialog();
        }
        private void BtnRegisterItem_Click(object sender, EventArgs e)
        {
            ItemList item = new ItemList();
            item.ShowDialog();
        }
        #endregion

        #region Administrate
        public void PrintButtonsAdministration(TabPage tabPage)
        {
            RadButton Employee = new RadButton();
            Employee.Click += Employee_Click;
            Image invoice = CreateImage(new Bitmap(Properties.Resources.employee));
            tabPage.Controls.Add(ControlShow.GetButtonss(Employee, new Point(13, 20), new Size(75, 60), null, invoice));
            Label lblinvoice = new Label();
            tabPage.Controls.Add(ControlShow.GetButtonss(lblinvoice, new Point(19, 85), new Size(75, 20), HelpClass.SetText("Employee","Puntori")));
            RadButton User = new RadButton();
            User.Click += User_Click;
            Image hapeimg = CreateImage(new Bitmap(Properties.Resources.Admin_icon));
            tabPage.Controls.Add(ControlShow.GetButtonss(User, new Point(100, 20), new Size(75, 60), null, hapeimg));
            if(HelpClass.SetText("User", "Perdorues") == "Perdorues")
            {
                Label lblitem = new Label();
                tabPage.Controls.Add(ControlShow.GetButtonss(lblitem, new Point(103, 85), new Size(75, 20), "Perdorues"));
            }
            else
            {
                Label lblitem = new Label();
                tabPage.Controls.Add(ControlShow.GetButtonss(lblitem, new Point(115, 85), new Size(75, 20), "User"));
            }
            RadButton Role = new RadButton();
            Role.Click += Role_Click;
            Image type = CreateImage(new Bitmap(Properties.Resources.TinkerTool_icon));
            tabPage.Controls.Add(ControlShow.GetButtonss(Role, new Point(187, 20), new Size(75, 60), null, type));
            Label lbltype = new Label();
            tabPage.Controls.Add(ControlShow.GetButtonss(lbltype, new Point(203, 85), new Size(75, 20), HelpClass.SetText("Role", "Roli")));
            RadButton EmpPos = new RadButton();
            EmpPos.Click += EmpPos_Click;
            Image Emp = CreateImage(new Bitmap(Properties.Resources.TinkerTool_icon));
            tabPage.Controls.Add(ControlShow.GetButtonss(EmpPos, new Point(275, 20), new Size(75, 60), null, invoice));
            Label lblemp = new Label();
            tabPage.Controls.Add(ControlShow.GetButtonss(lblemp, new Point(274, 85), new Size(75, 20), HelpClass.SetText("EMPPOS", "PunDepo")));
        }

        private void EmpPos_Click(object sender, EventArgs e)
        {
            EmployeePOSList employeePOS = new EmployeePOSList();
            employeePOS.ShowDialog();
        }

        private void Role_Click(object sender, EventArgs e)
        {
            RoleList role = new RoleList();
            role.ShowDialog();
        }
        private void User_Click(object sender, EventArgs e)
        {
            Administration.UserList user = new Administration.UserList();
            user.ShowDialog();
        }
        private void Employee_Click(object sender, EventArgs e)
        {
            EmployeeList employee = new EmployeeList();
            employee.ShowDialog();
        }
        #endregion

        #region Collaboration
        public void PrintButtonsCollaboration(TabPage tabPage)
        {
            RadButton Suppliers = new RadButton();
            Suppliers.Click += Suppliers_Click;
            Image invoice = CreateImage(new Bitmap(Properties.Resources.Company_icon));
            tabPage.Controls.Add(ControlShow.GetButtonss(Suppliers, new Point(13, 20), new Size(75, 60), null, invoice));
            Label lblinvoice = new Label();
            tabPage.Controls.Add(ControlShow.GetButtonss(lblinvoice, new Point(19, 85), new Size(75, 20), HelpClass.SetText("Supplier", "Funitor")));
        }

        private void Client_Click(object sender, EventArgs e)
        {
            Client obj = new Client();
            obj.ShowDialog();
        }

        private void Suppliers_Click(object sender, EventArgs e)
        {
            SupplierList supplier = new SupplierList();
            supplier.ShowDialog();
        }

        #endregion

        #region Entries
        public void PrintEntriesButtons(TabPage tabPage)
        {
            RadButton btnItems = new RadButton();
            btnItems.Click += BtnItems_Click;
            Image invoice = CreateImage(new Bitmap(Properties.Resources.add_item_icon));
            tabPage.Controls.Add(ControlShow.GetButtonss(btnItems, new Point(13, 20), new Size(75, 60), null, invoice));
            Label lblinvoice = new Label();
            tabPage.Controls.Add(ControlShow.GetButtonss(lblinvoice, new Point(30, 85), new Size(75, 20), HelpClass.SetText("Items", "Artikujt")));
            RadButton btnClients = new RadButton();
            btnClients.Click += BtnClients_Click;
            Image hapeimg = CreateImage(new Bitmap(Properties.Resources.Clients_icon));
            tabPage.Controls.Add(ControlShow.GetButtonss(btnClients, new Point(100, 20), new Size(75, 60), null, hapeimg));
            Label lblitem = new Label();
            tabPage.Controls.Add(ControlShow.GetButtonss(lblitem, new Point(112, 85), new Size(75, 20), HelpClass.SetText("Clients", "Klientat")));
            RadButton btnMonths = new RadButton();
            btnMonths.Click += BtnMonths_Click;
            Image type = CreateImage(new Bitmap(Properties.Resources.month));
            tabPage.Controls.Add(ControlShow.GetButtonss(btnMonths, new Point(187, 20), new Size(75, 60), null, type));
            Label lbltype = new Label();
            tabPage.Controls.Add(ControlShow.GetButtonss(lbltype, new Point(198, 85), new Size(75, 20), HelpClass.SetText("Months", "Muajt")));
            RadButton btnWeek = new RadButton();
            btnWeek.Click += BtnWeek_Click;
            Image Emp = CreateImage(new Bitmap(Properties.Resources.week));
            tabPage.Controls.Add(ControlShow.GetButtonss(btnWeek, new Point(275, 20), new Size(75, 60), null, Emp));
            Label lblemp = new Label();
            tabPage.Controls.Add(ControlShow.GetButtonss(lblemp, new Point(290, 85), new Size(75, 20), HelpClass.SetText("Week", "Java")));
        }

        private void BtnWeek_Click(object sender, EventArgs e)
        {
            WeekProfits obj = new WeekProfits();
            obj.ShowDialog();
        }

        private void BtnMonths_Click(object sender, EventArgs e)
        {
            MonthProfits obj = new MonthProfits();
            obj.ShowDialog();
        }

        private void BtnClients_Click(object sender, EventArgs e)
        {
            ClientRaport obj = new ClientRaport();
            obj.ShowDialog();
        }

        private void BtnItems_Click(object sender, EventArgs e)
        {
            ItemReport obj = new ItemReport();
            obj.ShowDialog();
        }

        #endregion

        #region Exits
        public void PrintExitsButtons(TabPage tabPage)
        {
            RadButton btnExitsItems = new RadButton();
            btnExitsItems.Click += BtnExitsItems_Click;
            Image invoice = CreateImage(new Bitmap(Properties.Resources.add_item_icon));
            tabPage.Controls.Add(ControlShow.GetButtonss(btnExitsItems, new Point(13, 20), new Size(75, 60), null, invoice));
            Label lblinvoice = new Label();
            tabPage.Controls.Add(ControlShow.GetButtonss(lblinvoice, new Point(30, 85), new Size(75, 20), HelpClass.SetText("Items", "Artikujt")));
            RadButton btnExitsClients = new RadButton();
            btnExitsClients.Click += BtnExitsClients_Click;
            Image hapeimg = CreateImage(new Bitmap(Properties.Resources.Clients_icon));
            tabPage.Controls.Add(ControlShow.GetButtonss(btnExitsClients, new Point(100, 20), new Size(75, 60), null, hapeimg));
            Label lblitem = new Label();
            tabPage.Controls.Add(ControlShow.GetButtonss(lblitem, new Point(105, 85), new Size(75, 20), HelpClass.SetText("Suppliers", "Funitoret")));
            RadButton btnExitsMonths = new RadButton();
            btnExitsMonths.Click += BtnExitsMonths_Click;
            Image type = CreateImage(new Bitmap(Properties.Resources.month));
            tabPage.Controls.Add(ControlShow.GetButtonss(btnExitsMonths, new Point(187, 20), new Size(75, 60), null, type));
            Label lbltype = new Label();
            tabPage.Controls.Add(ControlShow.GetButtonss(lbltype, new Point(198, 85), new Size(75, 20), HelpClass.SetText("Months", "Muajt")));
            RadButton btnExitsWeek = new RadButton();
            btnExitsWeek.Click += BtnExitsWeek_Click;
            Image Emp = CreateImage(new Bitmap(Properties.Resources.week));
            tabPage.Controls.Add(ControlShow.GetButtonss(btnExitsWeek, new Point(275, 20), new Size(75, 60), null, Emp));
            Label lblemp = new Label();
            tabPage.Controls.Add(ControlShow.GetButtonss(lblemp, new Point(290, 85), new Size(75, 20), HelpClass.SetText("Week", "Java")));
        }

        private void BtnExitsWeek_Click(object sender, EventArgs e)
        {
            WeekExits obj = new WeekExits();
            obj.ShowDialog();
        }

        private void BtnExitsMonths_Click(object sender, EventArgs e)
        {
            MonthExits obj = new MonthExits();
            obj.ShowDialog();
        }

        private void BtnExitsClients_Click(object sender, EventArgs e)
        {
            SupplierReport obj = new SupplierReport();
            obj.ShowDialog();
        }

        private void BtnExitsItems_Click(object sender, EventArgs e)
        {
            ItemExitReports obj = new ItemExitReports();
            obj.ShowDialog();
        }



        #endregion
    }
}
