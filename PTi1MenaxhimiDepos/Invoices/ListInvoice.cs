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
        }

        private void ListInvoice_Load(object sender, EventArgs e)
        {
            dgwInvoices.DataSource = InvoiceBLL.GetPurchaseInvoicesHeader();
            cmbInoviceType.DataSource = InvoiceBLL.GetDocTypes();cmbInoviceType.DisplayMember = "Description";cmbInoviceType.ValueMember = "DocTypeID";
            cmbPos.DataSource = PosBLL.GetPointofSales();cmbPos.DisplayMember = "Name";cmbPos.ValueMember = "ID";
            cmbSupplier.DataSource = CollaborationBLL.GetSuppliers();cmbSupplier.DisplayMember = "Name";cmbSupplier.ValueMember = "ID";
        }

        private void dgwInvoices_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            obj = (InvertoryHeader)dgwInvoices.Rows[e.RowIndex].DataBoundItem;
            txtID.Text = obj.InvertoryID.ToString();
            txtDescription.Text = obj.Description;
            txtInvoiceNumber.Text = obj.DocNo.ToString();
            cmbInoviceType.Text = obj.DocType.Description;
            cmbPos.Text = obj.POS.Name;
            cmbSupplier.Text = obj.Supplier.Name;
            btnShowDetails.Visible = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            HelpClass.Delete(txtDescription, txtID, txtInvoiceNumber);
            btnShowDetails.Visible = false;
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
                    obj = new InvertoryHeader(int.Parse(txtID.Text), txtInvoiceNumber.Text, docType.DocTypeID, pos.ID, txtDescription.Text, 0, supp.ID);
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

        public override void Refresh()
        {
            dgwInvoices.DataSource = null;
            dgwInvoices.DataSource = InvoiceBLL.GetPurchaseInvoicesHeader();
            obj = null;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text == "")
            {
                MessageBox.Show("Please fill in search box", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);            
            }
            else
            {
                if (txtSearch.Text.All(char.IsDigit))
                {
                    InvertoryHeader header = InvoiceBLL.GetPurchaseInvoicesHeaderByDosNo(txtSearch.Text);
                    List<InvertoryHeader> invertoryHeaders = new List<InvertoryHeader>();
                    invertoryHeaders.Add(header);
                    dgwInvoices.DataSource = null;
                    dgwInvoices.DataSource = invertoryHeaders;
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text == "")
            {
                dgwInvoices.DataSource = null;
                dgwInvoices.DataSource = InvoiceBLL.GetPurchaseInvoicesHeader();
            }
        }
    }
}
