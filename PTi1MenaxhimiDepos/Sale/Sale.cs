using PTi1MenaxhimiDepos.BL;
using PTi1MenaxhimiDepos.BO;
using PTi1MenaxhimiDepos.BO.Invoices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            this.cmbClients.DropDownListElement.DropDownWidth = 380;
            this.cmbPOS.DropDownListElement.DropDownWidth = 380;
        }

        private void Sale_Load(object sender, EventArgs e)
        {
            cmbClients.DataSource = CollaborationBLL.GetClients();cmbClients.DisplayMember = "Name";cmbClients.ValueMember = "ID";
            cmbPOS.DataSource = PosBLL.GetPointofSales(); cmbPOS.DisplayMember = "Name"; cmbPOS.ValueMember = "ID";
            dgwItems.DataSource = ItemBLL.GetItems();
            txtsearch.Focus();
        }

        private void dgwItems_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            Item obj = (Item)dgwItems.Rows[e.RowIndex].DataBoundItem;
            txtsearch.Text = obj.Name;
            txtquantity.Focus();
        }

        private void dgwItems_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            Item obj = (Item)dgwItems.Rows[e.RowIndex].DataBoundItem;
            if(header == null)
            {
                header = new InvertoryHeader(0, InvoiceBLL.MaxDocNo().ToString(), 2, (int)cmbPOS.SelectedValue, txtDescription.Text, (int)cmbClients.SelectedValue,
                    0);
            }
            InvertoryBody body = new InvertoryBody(0, InvoiceBLL.MaxID(), obj.ID,1, 0.6,0);
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
            bool inn = false;
            if(body.Quantity > 1)
            {
                body.Quantity -= 1;
                header.Bodies.Add(body);
            }
            if (header.Bodies.Any())
            {
                foreach (var item in header.Bodies)
                {
                    if (item.Item == obj)
                    {
                        item.Quantity += 1;
                        inn = true;
                        break;
                    }
                }
                if (inn == false)
                {
                    header.Bodies.Add(body);
                }
            }
            else
            {
                header.Bodies.Add(body);
            }
            dgwitemtolist.DataSource = null;
            dgwitemtolist.DataSource = header.Bodies;
            txttotali.Text = GetSum();
            HelpClass.Delete(txtDescription, txtprice, txtquantity, txtsearch);
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
            if (txtsearch.Text == "" || txtdiscount.Text == "" || txtprice.Text == "" || txtquantity.Text == "")
            {
                MessageBox.Show("Please fill in empty box's!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }
            Item obj = ItemBLL.GetItemByName(txtsearch.Text);
            if (headerbody != null)
            {
                if(obj != null)
                {
                    header.Bodies.Remove(headerbody);
                    headerbody = new InvertoryBody(0, InvoiceBLL.MaxID(), obj.ID, double.Parse(txtquantity.Text), double.Parse(txtprice.Text), double.Parse(txtdiscount.Text));
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
                    header = new InvertoryHeader(0, InvoiceBLL.MaxDocNo().ToString(), 2, (int)cmbPOS.SelectedValue, txtDescription.Text, (int)cmbClients.SelectedValue,
                        0);
                }
                InvertoryBody body = new InvertoryBody(0, InvoiceBLL.MaxID(), obj.ID, double.Parse(txtquantity.Text), double.Parse(txtprice.Text), double.Parse(txtdiscount.Text));
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(header != null && headerbody != null)
            {
                header.Bodies.Remove(headerbody);
                dgwitemtolist.DataSource = null;
                dgwitemtolist.DataSource = header.Bodies;
                txttotali.Text = GetSum();
                HelpClass.Delete(txtDescription, txtprice, txtquantity, txtsearch);
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            dgwItems.DataSource = ItemBLL.GetItems();
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
    }
}
