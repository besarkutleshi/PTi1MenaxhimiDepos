using PTi1MenaxhimiDepos.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PTi1MenaxhimiDepos.BO;
using PTi1MenaxhimiDepos.BO.Invoices;

namespace PTi1MenaxhimiDepos.Invoices
{
    public partial class InvoiceBody : Form
    {
        InvertoryBody obj = null;
        private readonly int _invertoryHeaderID;

        public InvoiceBody(int invertoryHeaderID)
        {
            InitializeComponent();
            _invertoryHeaderID = invertoryHeaderID;
            this.cmbItem.DropDownListElement.DropDownWidth = 300;
        }

        public InvoiceBody(InvertoryBody obj, int invertoryHeaderID)
        {
            InitializeComponent();
            this.obj = obj;
            _invertoryHeaderID = invertoryHeaderID;
            this.cmbItem.DropDownListElement.DropDownWidth = 300;
            txtDiscount.Text = obj.Discount.ToString();
            txtID.Text = obj.ID.ToString();
            txtPrice.Text = obj.Price.ToString();
            txtQuantity.Text = obj.Quantity.ToString();
            HelpClass.VisibleButton(btnSave, btndelete, btnUpdate);
        }

        private void InvoiceBody_Load(object sender, EventArgs e)
        {
            cmbItem.DataSource = ItemBLL.GetItems(); cmbItem.DisplayMember = "Name"; cmbItem.ValueMember = "ID";
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (obj != null)
            {
                if (InvoiceBLL.DeleteBody(int.Parse(txtID.Text)))
                {
                    Refresh();
                    HelpClass.NotVisibleButton(btnSave, btndelete, btnUpdate);
                }
            }
            else
            {
                MessageBox.Show("Please double click\nin a specific row in table", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (obj != null)
            {
                List<Item> items = (List<Item>)cmbItem.DataSource;
                obj.ItemID = items.Where(i => i.Name == cmbItem.Text).Select(i => i.ID).FirstOrDefault();
                obj.Price = double.Parse(txtPrice.Text);
                obj.Discount = double.Parse(txtDiscount.Text);
                obj.Quantity = double.Parse(txtQuantity.Text);
                obj.Username = HelpClass.CurrentUser.UserName;
                if (InvoiceBLL.UpdateBody(obj.ID, obj))
                {
                    Refresh();
                    HelpClass.NotVisibleButton(btnSave, btndelete, btnUpdate);
                }
            }
            else
            {
                MessageBox.Show("Please double click\nin a specific row in table", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            HelpClass.Delete(txtID, txtDiscount, txtPrice, txtQuantity);
            HelpClass.NotVisibleButton(btnSave, btndelete, btnUpdate);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbItem.SelectedIndex == -1 || txtDiscount.Text == "" || txtPrice.Text == "" || txtQuantity.Text == "")
            {
                MessageBox.Show("Please fill in empty box's", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                obj = new InvertoryBody(0, _invertoryHeaderID, (int)cmbItem.SelectedValue, double.Parse(txtQuantity.Text), double.Parse(txtPrice.Text), double.Parse(txtDiscount.Text));
                obj.Username = HelpClass.CurrentUser.UserName;
                if (InvoiceBLL.InsertBody(obj))
                {
                    Refresh();
                }
            }
        }
    }
}
