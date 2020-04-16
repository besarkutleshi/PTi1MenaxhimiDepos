using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace PTi1MenaxhimiDepos.Controls
{
    public class CreateControl
    {
        private void PrintControls(TabPage tabPage, RadGridView obj, string[] values)
        {
            Button btn1 = new Button();
            tabPage.Controls.Add(ControlShow.GetButtonss(btn1, new Point(13, 110), new Size(38, 28)));
            Button btn2 = new Button();
            tabPage.Controls.Add(ControlShow.GetButtonss(btn2, new Point(54, 110), new Size(115, 28), "Numri"));
            Button btn3 = new Button();
            tabPage.Controls.Add(ControlShow.GetButtonss(btn3, new Point(175, 110), new Size(115, 28), "Pershkrimi"));
            Button btn4 = new Button();
            tabPage.Controls.Add(ControlShow.GetButtonss(btn4, new Point(296, 110), new Size(115, 28), "Data"));
            Button btn5 = new Button();
            tabPage.Controls.Add(ControlShow.GetButtonss(btn5, new Point(417, 110), new Size(115, 28), "Partneri"));
            Button btn6 = new Button();
            tabPage.Controls.Add(ControlShow.GetButtonss(btn6, new Point(538, 110), new Size(115, 28), "Total"));
            Button btn7 = new Button();
            tabPage.Controls.Add(ControlShow.GetButtonss(btn7, new Point(659, 110), new Size(115, 28), "Vl_Tvsh"));
            Button btn8 = new Button();
            tabPage.Controls.Add(ControlShow.GetButtonss(btn8, new Point(780, 110), new Size(115, 28), "Paguar"));
            Button btn9 = new Button();
            tabPage.Controls.Add(ControlShow.GetButtonss(btn9, new Point(901, 110), new Size(115, 28), "Borxhi"));
            Button btn10 = new Button();
            tabPage.Controls.Add(ControlShow.GetButtonss(btn10, new Point(1022, 110), new Size(115, 28), "Kusuri"));
            Button btn11 = new Button();
            tabPage.Controls.Add(ControlShow.GetButtonss(btn11, new Point(1143, 110), new Size(115, 28), "Adresa"));
            Button btn12 = new Button();
            tabPage.Controls.Add(ControlShow.GetButtonss(btn12, new Point(1264, 110), new Size(115, 28), "Qyteti"));
            Button btn13 = new Button();
            tabPage.Controls.Add(ControlShow.GetButtonss(btn13, new Point(1385, 110), new Size(115, 28), "Shtuar"));
            tabPage.Controls.Add(ControlShow.GetButtonss(obj, new Point(12, 180), new Size(1490, 410)));
            TextBox txt1 = new TextBox();
            tabPage.Controls.Add(ControlShow.GetButtonss(txt1, new Point(13, 145), new Size(38, 28), null));
            TextBox txt2 = new TextBox();
            tabPage.Controls.Add(ControlShow.GetButtonss(txt2, new Point(54, 145), new Size(115, 40), null));
            TextBox txt3 = new TextBox();
            tabPage.Controls.Add(ControlShow.GetButtonss(txt3, new Point(175, 145), new Size(115, 40), null));
            TextBox txt4 = new TextBox();
            tabPage.Controls.Add(ControlShow.GetButtonss(txt4, new Point(296, 145), new Size(115, 40), null));
            TextBox txt5 = new TextBox();
            tabPage.Controls.Add(ControlShow.GetButtonss(txt5, new Point(417, 145), new Size(115, 40), null));
            TextBox txt6 = new TextBox();
            tabPage.Controls.Add(ControlShow.GetButtonss(txt6, new Point(538, 145), new Size(115, 40), values[0], null));
            TextBox txt7 = new TextBox();
            tabPage.Controls.Add(ControlShow.GetButtonss(txt7, new Point(659, 145), new Size(115, 40), null));
            TextBox txt8 = new TextBox();
            tabPage.Controls.Add(ControlShow.GetButtonss(txt8, new Point(780, 145), new Size(115, 40), values[1], null));
            TextBox txt9 = new TextBox();
            tabPage.Controls.Add(ControlShow.GetButtonss(txt9, new Point(901, 145), new Size(115, 40), values[2], null));
            TextBox txt10 = new TextBox();
            tabPage.Controls.Add(ControlShow.GetButtonss(txt10, new Point(1022, 145), new Size(115, 40), values[3], null));
            TextBox txt11 = new TextBox();
            tabPage.Controls.Add(ControlShow.GetButtonss(txt11, new Point(1143, 145), new Size(115, 40), null));
            TextBox txt12 = new TextBox();
            tabPage.Controls.Add(ControlShow.GetButtonss(txt12, new Point(1264, 145), new Size(115, 40), null));
            TextBox txt13 = new TextBox();
            tabPage.Controls.Add(ControlShow.GetButtonss(txt12, new Point(1385, 110), new Size(115, 40), null));
        }
        private Image CreateImage(Bitmap bmp)
        {
            Image img = bmp;
            return img;
        }
        #region Sale
        public void PrinButonsSales(TabPage tabPage, RadGridView obj, string[] values)
        {
            Button btnSale = new Button();
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
            Button btnRegisterInvoice = new Button();
            btnRegisterInvoice.Click += BtnRegisterInvoice_Click; ;
            Image invoice = CreateImage(new Bitmap(Properties.Resources.invoice));
            tabPage.Controls.Add(ControlShow.GetButtonss(btnRegisterInvoice, new Point(13, 20), new Size(75, 60), null, invoice));
            Label lblinvoice = new Label();
            tabPage.Controls.Add(ControlShow.GetButtonss(lblinvoice, new Point(27, 85), new Size(75, 20),"Invoice"));
            Button btnRegisterItem = new Button();
            btnRegisterItem.Click += BtnRegisterItem_Click;
            Image hapeimg = CreateImage(new Bitmap(Properties.Resources.add_item_icon));
            tabPage.Controls.Add(ControlShow.GetButtonss(btnRegisterItem, new Point(100, 20), new Size(75, 60), null, hapeimg));
            Label lblitem = new Label();
            tabPage.Controls.Add(ControlShow.GetButtonss(lblitem, new Point(120, 85), new Size(75, 20), "Item"));
            Button btnRegisterType = new Button();
            btnRegisterType.Click += BtnRegisterType_Click;
            Image type = CreateImage(new Bitmap(Properties.Resources.type));
            tabPage.Controls.Add(ControlShow.GetButtonss(btnRegisterType, new Point(187, 20), new Size(75, 60), null, type));
            Label lbltype = new Label();
            tabPage.Controls.Add(ControlShow.GetButtonss(lbltype, new Point(205, 85), new Size(75, 20), "Type"));
            Button btnRegisterUnit = new Button();
            btnRegisterType.Click += BtnRegisterType_Click;
            Image unit = CreateImage(new Bitmap(Properties.Resources.unit));
            tabPage.Controls.Add(ControlShow.GetButtonss(btnRegisterUnit, new Point(274, 20), new Size(75, 60), null, unit));
            Label lblunit = new Label();
            tabPage.Controls.Add(ControlShow.GetButtonss(lblunit, new Point(295, 85), new Size(75, 20), "Unit"));
            Button btnRegisterCategory = new Button();
            btnRegisterCategory.Click += BtnRegisterCategory_Click;
            Image category = CreateImage(new Bitmap(Properties.Resources.category));
            tabPage.Controls.Add(ControlShow.GetButtonss(btnRegisterCategory, new Point(361, 20), new Size(75, 60), null, category));
            Label lblcategory = new Label();
            tabPage.Controls.Add(ControlShow.GetButtonss(lblcategory, new Point(368, 85), new Size(75, 20), "Category"));
            PrintControls(tabPage, obj, values);
        }

        private void BtnRegisterInvoice_Click(object sender, EventArgs e)
        {
        }
        private void BtnRegisterCategory_Click(object sender, EventArgs e)
        {
        }
        private void BtnRegisterType_Click(object sender, EventArgs e)
        {
        }
        private void BtnRegisterItem_Click(object sender, EventArgs e)
        {
            RegisterItem item = new RegisterItem();
            item.ShowDialog();
        }
        #endregion
    }
}
