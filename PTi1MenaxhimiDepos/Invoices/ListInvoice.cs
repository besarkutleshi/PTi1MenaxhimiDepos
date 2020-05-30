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
    public partial class ListInvoice : Form
    {
        private InvertoryHeader obj;
        public ListInvoice()
        {
            InitializeComponent();
            this.cmbSupplier.DropDownListElement.DropDownWidth = 300;
            this.cmbPos.DropDownListElement.DropDownWidth = 300;
            this.cmbInoviceType.DropDownListElement.DropDownWidth = 300;
        }

        public ListInvoice(InvertoryHeader obj)
        {
            this.obj = obj;
            InitializeComponent();
            this.cmbSupplier.DropDownListElement.DropDownWidth = 300;
            this.cmbPos.DropDownListElement.DropDownWidth = 300;
            this.cmbInoviceType.DropDownListElement.DropDownWidth = 300;
        }

        private void ListInvoice_Load(object sender, EventArgs e)
        {
            cmbInoviceType.DataSource = InvoiceBLL.GetDocTypes();cmbInoviceType.DisplayMember = "Description";cmbInoviceType.ValueMember = "DocTypeID";
            cmbPos.DataSource = PosBLL.GetPointofSales();cmbPos.DisplayMember = "Name";cmbPos.ValueMember = "ID";
            cmbSupplier.DataSource = CollaborationBLL.GetSuppliers();cmbSupplier.DisplayMember = "Name";cmbSupplier.ValueMember = "ID";
            if(obj != null)
            {
                txtDescription.Text = obj.Description;
                txtID.Text = obj.InvertoryID.ToString();
                txtInvoiceNumber.Text = obj.DocNo;
                cmbInoviceType.Text = obj.DocType.Description;
                cmbPos.Text = obj.POS.Name;
                cmbSupplier.Text = obj.Supplier.Name;
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            HelpClass.Delete(txtDescription, txtID, txtInvoiceNumber);
            obj = null;
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            ListInvoiceBodies bodies = new ListInvoiceBodies(obj.InvertoryID);
            bodies.ShowDialog();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if(obj != null)
            {
                if (MessageBox.Show("Are you sure ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (InvoiceBLL.DeletePurchaseInvoiceHeader(obj.InvertoryID))
                    {
                        Refresh();
                        obj = null;
                    }
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
                if (MessageBox.Show("Are you sure ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    PointofSale pos = (PointofSale)cmbPos.SelectedItem.DataBoundItem;
                    Supplier supp = (Supplier)cmbSupplier.SelectedItem.DataBoundItem;
                    DocType docType = (DocType)cmbInoviceType.SelectedItem.DataBoundItem;
                    obj = new InvertoryHeader(int.Parse(txtID.Text), txtInvoiceNumber.Text, docType.DocTypeID, pos.ID, txtDescription.Text,supp.ID);
                    obj.Username = HelpClass.CurrentUser.UserName;
                    if (InvoiceBLL.UpdatePurchaseInoviceHeader(obj.InvertoryID, obj))
                    {
                        Refresh();
                        obj = null;
                    }
                }
                HelpClass.Delete(txtDescription, txtID, txtInvoiceNumber);
            }
            else
            {
                MessageBox.Show("Please double click\nin a specific row in table", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void ListInvoice_FormClosing(object sender, FormClosingEventArgs e)
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
