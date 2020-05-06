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
    public partial class Invoice : Form // search metodat me i bo edhe me ndreq te clear enabled 
    {
        InvertoryHeader invertoryHeader = null;
        InvertoryBody obj = null;
        int counter = 1;
        public Invoice()
        {
            InitializeComponent();
            dgwBodies.AutoGenerateColumns = false;
            this.cmbInoviceType.DropDownListElement.DropDownWidth = 380;
            this.cmbItem.DropDownListElement.DropDownWidth = 380;
            this.cmbPos.DropDownListElement.DropDownWidth = 380;
            this.cmbSupplier.DropDownListElement.DropDownWidth = 380;
        }

        private void radGridView1_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            obj = (InvertoryBody)dgwBodies.Rows[e.RowIndex].DataBoundItem;
            txtDiscount.Text = obj.Discount.ToString();
            txtPrice.Text = obj.Price.ToString();
            txtQuantity.Text = obj.Quantity.ToString();
            cmbItem.Text = obj.Item.Name;
            HelpClass.VisibleButton(btnSave, btndelete, btnUpdate);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if(txtDescription.Text == "" || txtDiscount.Text == "" || txtInvoiceNumber.Text == "" || txtPrice.Text == "" || txtQuantity.Text == "" ||
                cmbInoviceType.SelectedIndex == -1 || cmbItem.SelectedIndex == -1 || cmbPos.SelectedIndex == -1 || cmbSupplier.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in empty box's", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                if (invertoryHeader == null)
                {
                    invertoryHeader = new InvertoryHeader(InvoiceBLL.MaxID(), txtInvoiceNumber.Text, (int)cmbInoviceType.SelectedValue, (int)cmbPos.SelectedValue, txtDescription.Text
                        ,0,(int)cmbSupplier.SelectedValue);
                    invertoryHeader.Username = HelpClass.CurrentUser.UserName;
                }
                InvertoryBody obj1 = new InvertoryBody(counter++,InvoiceBLL.MaxID(), (int)cmbItem.SelectedValue, double.Parse(txtQuantity.Text), double.Parse(txtPrice.Text),
                    double.Parse(txtDiscount.Text));
                obj1.Item = new PTi1MenaxhimiDepos.BO.Item(cmbItem.Text);
                obj1.Username = HelpClass.CurrentUser.UserName;
                invertoryHeader.Bodies.Add(obj1);
                HelpClass.Delete(txtPrice, txtQuantity, txtDiscount);
                dgwBodies.DataSource = null;
                dgwBodies.DataSource = invertoryHeader.Bodies;
                HelpClass.EnabledFalseTextBoxs(txtDescription, txtInvoiceNumber);
                HelpClass.EnabledFalseComboBoxs(cmbInoviceType, cmbPos, cmbSupplier);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if(invertoryHeader != null && obj != null)
            {
                invertoryHeader.Bodies.Remove(obj);
                InvoiceBLL.RefreshGrid(invertoryHeader.Bodies, dgwBodies);
                HelpClass.Delete(txtDiscount, txtPrice, txtQuantity);
                HelpClass.NotVisibleButton(btnSave, btndelete, btnUpdate);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(invertoryHeader != null && invertoryHeader.Bodies.Count > 0)
            {
                InvoiceBLL.InsertPurchaseInvoice(invertoryHeader);
                Refresh();
            }
            else
            {
                MessageBox.Show("Empty Invoice", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            cmbItem.DataSource = ItemBLL.GetItems(); cmbItem.DisplayMember = "Name";cmbItem.ValueMember = "ID";
            cmbPos.DataSource = PosBLL.GetPointofSales(); cmbPos.DisplayMember = "Name"; cmbPos.ValueMember = "ID";
            cmbSupplier.DataSource = CollaborationBLL.GetSuppliers();cmbSupplier.DisplayMember = "Name";cmbSupplier.ValueMember = "ID";
            cmbInoviceType.DataSource = InvoiceBLL.GetDocTypes();cmbInoviceType.DisplayMember = "Description"; cmbInoviceType.ValueMember = "DocTypeID";
        }

        public override void Refresh()
        {
            HelpClass.NotVisibleButton(btnSave, btndelete, btnUpdate);
            HelpClass.Delete(txtDescription, txtDiscount, txtID, txtInvoiceNumber, txtPrice, txtQuantity, txtSearch);
            HelpClass.EnabledTrueTextBoxs(txtDescription, txtInvoiceNumber);
            HelpClass.EnabledTrueComboBoxs(cmbInoviceType, cmbPos, cmbSupplier);
            Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            obj.Discount = double.Parse(txtDiscount.Text);
            obj.Price = double.Parse(txtPrice.Text);
            obj.Quantity = double.Parse(txtQuantity.Text);
            Item item1 = (Item)cmbItem.SelectedItem.DataBoundItem;
            obj.ItemID = item1.ID;
            obj.Item = item1;
            if (invertoryHeader != null && invertoryHeader.Bodies.Count > 0)
            {
                foreach (var item in invertoryHeader.Bodies)
                {
                    if(item.ID == obj.ID)
                    {
                        item.Item = obj.Item;
                        item.ItemID = obj.ItemID;
                        item.Price = obj.Price;
                        item.Quantity = obj.Quantity;
                        item.Discount = obj.Discount;
                    }
                }
            }
            HelpClass.Delete(txtDiscount, txtPrice, txtQuantity);
            HelpClass.NotVisibleButton(btnSave, btndelete, btnUpdate);
            InvoiceBLL.RefreshGrid(invertoryHeader.Bodies, dgwBodies);
        }

        private void Clear()
        {
            dgwBodies.DataSource = null;
            invertoryHeader = null;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text == "")
            {
                if(invertoryHeader != null && invertoryHeader.Bodies.Count > 0)
                {
                    dgwBodies.DataSource = invertoryHeader.Bodies;
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text == "")
            {
                MessageBox.Show("Please fill in search box", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                if (txtSearch.Text.All(char.IsDigit) || txtSearch.Text.Any(char.IsDigit))
                {

                }
                else
                {
                    if (invertoryHeader != null && invertoryHeader.Bodies.Count > 0)
                    {
                        List<InvertoryBody> invertoryBodies = new List<InvertoryBody>();
                        invertoryBodies.Add(invertoryHeader.Bodies.FirstOrDefault(inb => inb.Item.Name == txtSearch.Text));
                        InvoiceBLL.RefreshGrid(invertoryBodies, dgwBodies);
                    }
                }
            }
            //txtSearch.Text = "";
        }
    }
}
