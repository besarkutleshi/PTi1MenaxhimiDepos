using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using PTi1MenaxhimiDepos.Items;
namespace PTi1MenaxhimiDepos.Controls
{
    public class CreateControl
    {

        private void PrintControls(TabPage tabPage, RadGridView obj, string[] values)
        {
            RadButton btn1 = new RadButton();
            tabPage.Controls.Add(ControlShow.GetButtonss(btn1, new Point(13, 110), new Size(38, 28)));
            RadButton btn2 = new RadButton();
            tabPage.Controls.Add(ControlShow.GetButtonss(btn2, new Point(54, 110), new Size(115, 28), "Numri"));
            RadButton btn3 = new RadButton();
            tabPage.Controls.Add(ControlShow.GetButtonss(btn3, new Point(175, 110), new Size(115, 28), "Pershkrimi"));
            RadButton btn4 = new RadButton();
            tabPage.Controls.Add(ControlShow.GetButtonss(btn4, new Point(296, 110), new Size(115, 28), "Data"));
            RadButton btn5 = new RadButton();
            tabPage.Controls.Add(ControlShow.GetButtonss(btn5, new Point(417, 110), new Size(115, 28), "Partneri"));
            RadButton btn6 = new RadButton();
            tabPage.Controls.Add(ControlShow.GetButtonss(btn6, new Point(538, 110), new Size(115, 28), "Total"));
            RadButton btn7 = new RadButton();
            tabPage.Controls.Add(ControlShow.GetButtonss(btn7, new Point(659, 110), new Size(115, 28), "Vl_Tvsh"));
            RadButton btn8 = new RadButton();
            tabPage.Controls.Add(ControlShow.GetButtonss(btn8, new Point(780, 110), new Size(115, 28), "Paguar"));
            RadButton btn9 = new RadButton();
            tabPage.Controls.Add(ControlShow.GetButtonss(btn9, new Point(901, 110), new Size(115, 28), "Borxhi"));
            RadButton btn10 = new RadButton();
            tabPage.Controls.Add(ControlShow.GetButtonss(btn10, new Point(1022, 110), new Size(115, 28), "Kusuri"));
            RadButton btn11 = new RadButton();
            tabPage.Controls.Add(ControlShow.GetButtonss(btn11, new Point(1143, 110), new Size(115, 28), "Adresa"));
            RadButton btn12 = new RadButton();
            tabPage.Controls.Add(ControlShow.GetButtonss(btn12, new Point(1264, 110), new Size(115, 28), "Qyteti"));
            RadButton btn13 = new RadButton();
            tabPage.Controls.Add(ControlShow.GetButtonss(btn13, new Point(1385, 110), new Size(115, 28), "Shtuar"));
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
            RadButton btnRegisterInvoice = new RadButton();
            btnRegisterInvoice.Click += BtnRegisterInvoice_Click;
            Image invoice = CreateImage(new Bitmap(Properties.Resources.invoice));
            tabPage.Controls.Add(ControlShow.GetButtonss(btnRegisterInvoice, new Point(13, 20), new Size(75, 60), null, invoice));
            Label lblinvoice = new Label();
            tabPage.Controls.Add(ControlShow.GetButtonss(lblinvoice, new Point(27, 85), new Size(75, 20),"Invoice"));
            RadButton btnRegisterItem = new RadButton();
            btnRegisterItem.Click += BtnRegisterItem_Click;
            Image hapeimg = CreateImage(new Bitmap(Properties.Resources.add_item_icon));
            tabPage.Controls.Add(ControlShow.GetButtonss(btnRegisterItem, new Point(100, 20), new Size(75, 60), null, hapeimg));
            Label lblitem = new Label();
            tabPage.Controls.Add(ControlShow.GetButtonss(lblitem, new Point(120, 85), new Size(75, 20), "Item"));
            RadButton btnRegisterType = new RadButton();
            btnRegisterType.Click += BtnRegisterType_Click;
            Image type = CreateImage(new Bitmap(Properties.Resources.type));
            tabPage.Controls.Add(ControlShow.GetButtonss(btnRegisterType, new Point(187, 20), new Size(75, 60), null, type));
            Label lbltype = new Label();
            tabPage.Controls.Add(ControlShow.GetButtonss(lbltype, new Point(205, 85), new Size(75, 20), "Type"));
            RadButton btnRegisterUnit = new RadButton();
            btnRegisterUnit.Click += BtnRegisterUnit_Click;
            Image unit = CreateImage(new Bitmap(Properties.Resources.unit));
            tabPage.Controls.Add(ControlShow.GetButtonss(btnRegisterUnit, new Point(274, 20), new Size(75, 60), null, unit));
            Label lblunit = new Label();
            tabPage.Controls.Add(ControlShow.GetButtonss(lblunit, new Point(295, 85), new Size(75, 20), "Unit"));
            RadButton btnRegisterCategory = new RadButton();
            btnRegisterCategory.Click += BtnRegisterCategory_Click;
            Image category = CreateImage(new Bitmap(Properties.Resources.category));
            tabPage.Controls.Add(ControlShow.GetButtonss(btnRegisterCategory, new Point(361, 20), new Size(75, 60), null, category));
            Label lblcategory = new Label();
            tabPage.Controls.Add(ControlShow.GetButtonss(lblcategory, new Point(368, 85), new Size(75, 20), "Category"));
            PrintControls(tabPage, obj, values);
        }
        private void BtnRegisterUnit_Click(object sender, EventArgs e)
        {
            ItemUnit obj = new ItemUnit();
            obj.ShowDialog();
        }
        private void BtnRegisterInvoice_Click(object sender, EventArgs e)
        {

        }
        private void BtnRegisterCategory_Click(object sender, EventArgs e)
        {
            ItemCategory obj = new ItemCategory();
            obj.ShowDialog();
        }
        private void BtnRegisterType_Click(object sender, EventArgs e)
        {
            ItemType obj = new ItemType();
            obj.ShowDialog();
        }
        private void BtnRegisterItem_Click(object sender, EventArgs e)
        {
            RegisterItem item = new RegisterItem();
            item.ShowDialog();
        }
        #endregion

        #region Administrate

        public void PrintButtonsAdministration(TabPage tabPage)
        {
            RadButton Employee = new RadButton();
            Employee.Click += Employee_Click;
            Image invoice = CreateImage(new Bitmap(Properties.Resources.invoice));
            tabPage.Controls.Add(ControlShow.GetButtonss(Employee, new Point(13, 20), new Size(75, 60), null, invoice));
            Label lblinvoice = new Label();
            tabPage.Controls.Add(ControlShow.GetButtonss(lblinvoice, new Point(19, 85), new Size(75, 20), "Employee"));
            RadButton User = new RadButton();
            User.Click += User_Click;
            Image hapeimg = CreateImage(new Bitmap(Properties.Resources.add_item_icon));
            tabPage.Controls.Add(ControlShow.GetButtonss(User, new Point(100, 20), new Size(75, 60), null, hapeimg));
            Label lblitem = new Label();
            tabPage.Controls.Add(ControlShow.GetButtonss(lblitem, new Point(115, 85), new Size(75, 20), "User"));
            RadButton Role = new RadButton();
            Role.Click += Role_Click;
            Image type = CreateImage(new Bitmap(Properties.Resources.type));
            tabPage.Controls.Add(ControlShow.GetButtonss(Role, new Point(187, 20), new Size(75, 60), null, type));
            Label lbltype = new Label();
            tabPage.Controls.Add(ControlShow.GetButtonss(lbltype, new Point(203, 85), new Size(75, 20), "Role"));
            RadButton ChangePasswrod = new RadButton();
            ChangePasswrod.Click += ChangePasswrod_Click;
            Image unit = CreateImage(new Bitmap(Properties.Resources.unit));
            tabPage.Controls.Add(ControlShow.GetButtonss(ChangePasswrod, new Point(274, 20), new Size(75, 60), null, unit));
            Label lblunit = new Label();
            tabPage.Controls.Add(ControlShow.GetButtonss(lblunit, new Point(280, 85), new Size(75, 20), "Passwrod"));
        }

        private void ChangePasswrod_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Role_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void User_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Employee_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion


    }
}
