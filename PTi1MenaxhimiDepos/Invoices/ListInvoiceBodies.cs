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

namespace PTi1MenaxhimiDepos.Invoices
{
    public partial class ListInvoiceBodies : Form
    {
        InvertoryBody obj = null;
        public ListInvoiceBodies()
        {
            InitializeComponent();
            this.cmbItem.DropDownListElement.DropDownWidth = 380;
        }
        private readonly int _invertoryHeaderID;
        public ListInvoiceBodies(int invertoryHeaderID)
        {
            InitializeComponent();
            this._invertoryHeaderID = invertoryHeaderID;
            this.cmbItem.DropDownListElement.DropDownWidth = 380;
        }
        private void ListInvoiceBodies_Load(object sender, EventArgs e)
        {
            dgwBodies.DataSource = InvoiceBLL.GetInvertoryBodiesByHeader(_invertoryHeaderID);
            cmbItem.DataSource = ItemBLL.GetItems();cmbItem.DisplayMember = "Name";cmbItem.ValueMember = "ID";
        }

        private void dgwBodies_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            obj = (InvertoryBody)dgwBodies.Rows[e.RowIndex].DataBoundItem;
            txtID.Text = obj.ID.ToString();
            txtDiscount.Text = obj.Discount.ToString();
            txtPrice.Text = obj.Price.ToString();
            txtQuantity.Text = obj.Quantity.ToString();
            cmbItem.Text = obj.Item.Name;
            HelpClass.VisibleButton(btnSave, btndelete, btnUpdate);
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if(obj != null)
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
            if(obj != null)
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

        public override void Refresh()
        {
            dgwBodies.DataSource = null;
            dgwBodies.DataSource = InvoiceBLL.GetInvertoryBodiesByHeader(_invertoryHeaderID);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            HelpClass.Delete(txtID, txtDiscount, txtPrice, txtQuantity);
            HelpClass.NotVisibleButton(btnSave, btndelete, btnUpdate);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(cmbItem.SelectedIndex == -1 || txtDiscount.Text == "" || txtPrice.Text == "" || txtQuantity.Text == "")
            {
                MessageBox.Show("Please fill in empty box's", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                obj = new InvertoryBody(0,_invertoryHeaderID,(int)cmbItem.SelectedValue, double.Parse(txtQuantity.Text),double.Parse(txtPrice.Text),double.Parse(txtDiscount.Text));
                obj.Username = HelpClass.CurrentUser.UserName;
                if (InvoiceBLL.InsertBody(obj))
                {
                    Refresh();
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text == "")
            {
                Refresh();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text == "")
            {
                MessageBox.Show("Please fill in search box's", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                if (txtSearch.Text.All(char.IsDigit))
                {

                }
                else
                {
                    InvertoryBody obj = InvoiceBLL.GetInvertoryBodyByItem(txtSearch.Text, _invertoryHeaderID);
                    List<InvertoryBody> bodies = new List<InvertoryBody>();
                    bodies.Add(obj);
                    dgwBodies.DataSource = null;
                    dgwBodies.DataSource = bodies;
                }
            }
        }

        private void ListInvoiceBodies_FormClosing(object sender, FormClosingEventArgs e)
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
