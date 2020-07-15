using PTi1MenaxhimiDepos.BL;
using PTi1MenaxhimiDepos.BO;
using PTi1MenaxhimiDepos.BO.Invoices;
using PTi1MenaxhimiDepos.Languages;
using System;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace PTi1MenaxhimiDepos.Sale
{
    public partial class Sale : Form
    {
        InvertoryHeader header = null;
        InvertoryBody headerbody = null;
        double Totali = 0;
        public Sale()
        {
            InitializeComponent();
            this.cmbClients.DropDownListElement.DropDownWidth = 300;
            this.cmbPOS.DropDownListElement.DropDownWidth = 300;
            BtnSave.Enabled = false;
        }

        private void Sale_Load(object sender, EventArgs e)
        {
            cmbClients.DataSource = CollaborationBLL.GetSuppliers();cmbClients.DisplayMember = "Name";cmbClients.ValueMember = "ID";
            cmbClients.SelectedIndex = 2;
            cmbPOS.DataSource = PosBLL.GetPointofSales(); cmbPOS.DisplayMember = "Name"; cmbPOS.ValueMember = "ID";
            dgwItems.DataSource = ItemBLL.GetItems();
            txtsearch.Focus();
        }

        private void dgwItems_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                Item obj = (Item)dgwItems.Rows[e.RowIndex].DataBoundItem;
                txtsearch.Text = obj.Name;
                txtprice.Text = obj.SalePrice.ToString();
                txtquantity.Focus();
            }
        }

        private void dgwItems_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            Item obj = (Item)dgwItems.Rows[e.RowIndex].DataBoundItem;
            if(header == null)
            {
                header = new InvertoryHeader(0, InvoiceBLL.MaxDocNo().ToString(), 2, (int)cmbPOS.SelectedValue, txtDescription.Text, (int)cmbClients.SelectedValue);
            }
            InvertoryBody body = new InvertoryBody(0, InvoiceBLL.MaxID(), obj.ID, 1,double.Parse(txtprice.Text), 0);
            AddItems(obj, body);
            Console.Beep();
        }

        private string GetSum()
        {
            Totali = 0;
            foreach (var item in header.Bodies)
            {
                if(item.Quantity > 1)
                {
                    Totali += item.Quantity * item.Price;
                }
                else
                {
                    Totali += item.Price;
                }
            }
            return Totali.ToString("0.00");
        }

        private void AddItems(Item obj,InvertoryBody body)
        {
            body.Item = obj;
            if (header.Bodies.Count == 0)
            {
                header.Bodies.Add(body);
            }
            else
            {
                InvertoryBody invertory = header.Bodies.FirstOrDefault(b => b.Item.Barcode == obj.Barcode);
                if(invertory != null)
                {
                    foreach (var item in header.Bodies)
                    {
                        if (item == invertory)
                        {
                            item.Quantity += body.Quantity;
                            break;
                        }
                    }
                }
                else
                {
                    header.Bodies.Add(body);
                }
            }
            BtnSave.Enabled = true;

            //bool inn = false;
            //if(body.Quantity > 1)
            //{
            //    body.Quantity -= 1;
            //    header.Bodies.Add(body);
            //}
            //if (header.Bodies.Any())
            //{
            //    foreach (var item in header.Bodies)
            //    {
            //        if (item.Item == obj)
            //        {
            //            item.Quantity += 1;
            //            inn = true;
            //            break;
            //        }
            //    }
            //    if (inn == false)
            //    {
            //        header.Bodies.Add(body);
            //    }
            //}
            //else
            //{
            //    header.Bodies.Add(body);
            //}
            dgwitemtolist.DataSource = null;
            dgwitemtolist.DataSource = header.Bodies;
            txttotali.Text = GetSum();
            HelpClass.Delete(txtDescription, txtprice, txtquantity, txtsearch,txtdiscount);
        }

       

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment(txttotali.Text,header);
            payment.ShowDialog();
            txtkusuri.Text = Payment.Back;
            txtvlera.Text = txttotali.Text;
            txtPayment.Text = Payment.Pay;
            if (!Payment.Closed)
            {
                header = null;
                dgwitemtolist.DataSource = null;
                txttotali.Text = "0.00";
                txtsearch.Text = "";
                dgwItems.DataSource = ItemBLL.GetItems();
            }
        }

        private void dgwitemtolist_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            headerbody = (InvertoryBody)dgwitemtolist.Rows[e.RowIndex].DataBoundItem;
            txtsearch.Text = headerbody.Item.Name;
            txtquantity.Text = headerbody.Quantity.ToString();
            txtprice.Text = headerbody.Price.ToString();
            txtdiscount.Text = headerbody.Discount.ToString();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            double discount = 0;
            double price = 0;
            double quantity = 0;
            if (txtsearch.Text == "" || txtprice.Text == "" || txtquantity.Text == "")
            {
                MessageBox.Show("Please fill in empty box's!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }
            if (!IsDigit(txtdiscount.Text, "Discount must be positive number", ref discount))
                return;
            if (!IsDigit(txtprice.Text, "Price must be positive number", ref price))
                return;
            if (!IsDigit(txtquantity.Text, "Quantity must be positive number", ref quantity))
                return;
            Discount(ref price, discount);
            Item obj = ItemBLL.GetItemByName(txtsearch.Text);
            if (obj.StockQuantity < int.Parse(txtquantity.Text))
            {
                MessageBox.Show("Item does not have quantity!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }
            if (headerbody != null)
            {
                if(obj != null)
                {
                    header.Bodies.Remove(headerbody);
                    headerbody = new InvertoryBody(0, InvoiceBLL.MaxID(), obj.ID, quantity, price, discount);
                    headerbody.Username = HelpClass.CurrentUser.UserName;
                    AddItems(obj, headerbody);
                    txtsearch.Focus();
                    Console.Beep();
                    return;
                }
            }
            if (obj != null)
            {
                if (header == null)
                {
                    header = new InvertoryHeader(0, InvoiceBLL.MaxDocNo().ToString(), 2, (int)cmbPOS.SelectedValue, txtDescription.Text, (int)cmbClients.SelectedValue);
                }
                InvertoryBody body = new InvertoryBody(0, InvoiceBLL.MaxID(), obj.ID, quantity, price, discount);
                body.Username = HelpClass.CurrentUser.UserName;
                AddItems(obj, body);
                txtsearch.Focus();
                Console.Beep();
            }
            else
            {
                MessageBox.Show("Item does not exist!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void Discount(ref double price , double discount)
        {
            if(discount > 0)
            {
                double persent = (price / 100) * discount;
                price = price - persent;
            }
        }

        private bool IsDigit(string text,string message,ref double money)
        {
            double.TryParse(text, out money);
            if (text.Any(char.IsLetter))
            {
                MessageBox.Show(message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return false;
            }
            else if(money == 0)
            {
                if (message.Contains("Discount") && money >= 0)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show(message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    return false;
                }
            }
            else if (money > 0)
            {
                return true;
            }
            MessageBox.Show(message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            return false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(header != null && headerbody != null)
            {
                header.Bodies.Remove(headerbody);
                if(header.Bodies == null || header.Bodies.Count == 0)
                {
                    BtnSave.Enabled = false;
                }
                headerbody = null;
                dgwitemtolist.DataSource = null;
                dgwitemtolist.DataSource = header.Bodies;
                txttotali.Text = GetSum();
                HelpClass.Delete(txtDescription, txtprice, txtquantity, txtsearch);
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            if (txtsearch.Text == "")
            {
                dgwItems.DataSource = ItemBLL.GetItems();
            }
            else
            {
                if (txtsearch.Text.All(char.IsDigit))
                {
                    dgwItems.DataSource = null;
                    dgwItems.DataSource = ItemBLL.GetItemsByBarcode(txtsearch.Text);
                }
                else
                {
                    dgwItems.DataSource = null;
                    dgwItems.DataSource = ItemBLL.GetItems(txtsearch.Text);
                }
            }
        }

        private void Sale_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure ?", "Sure", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure to delete all items","Sure",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                header.Bodies = null;
                dgwitemtolist.DataSource = null;
                dgwitemtolist.DataSource = header.Bodies;
                txttotali.Text = "0.00";
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpClass.ShowHelp(this, "Overview.html");
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ChangeLanguage("en-US");
            TranslateFormMultipleResource.ChangeLanguages("en-US");
        }

        private void albaniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ChangeLanguage("sq");
            TranslateFormMultipleResource.ChangeLanguages("sq");
        }
        private void ChangeLanguage(string lang)
        {
            CultureInfo ci = new CultureInfo(lang);
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;
            this.Controls.Clear();
            this.InitializeComponent();
            this.cmbClients.DropDownListElement.DropDownWidth = 300;
            this.cmbPOS.DropDownListElement.DropDownWidth = 300;
            BtnSave.Enabled = false;

            cmbClients.DataSource = CollaborationBLL.GetSuppliers(); cmbClients.DisplayMember = "Name"; cmbClients.ValueMember = "ID";
            cmbClients.SelectedIndex = 2;
            cmbPOS.DataSource = PosBLL.GetPointofSales(); cmbPOS.DisplayMember = "Name"; cmbPOS.ValueMember = "ID";
            dgwItems.DataSource = ItemBLL.GetItems();
            txtsearch.Focus();
        }
    }
}
