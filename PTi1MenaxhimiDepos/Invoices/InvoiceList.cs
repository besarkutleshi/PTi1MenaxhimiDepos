using PTi1MenaxhimiDepos.BL;
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
    public partial class InvoiceList : Form
    {
        private InvertoryHeader objhead;

        public InvoiceList()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
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
            if (txtSearch.Text == "")
            {
                dgwInvoices.DataSource = null;
                dgwInvoices.DataSource = InvoiceBLL.GetPurchaseInvoicesHeader();
            }
        }

        private void btnInsertRole_Click(object sender, EventArgs e)
        {
            Invoice obj = new Invoice();
            obj.ShowDialog();
        }

        private void InvoiceList_Load(object sender, EventArgs e)
        {
            dgwInvoices.DataSource = InvoiceBLL.GetPurchaseInvoicesHeader();
        }

        private void dgwInvoices_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            objhead = (InvertoryHeader)dgwInvoices.Rows[e.RowIndex].DataBoundItem;
            ListInvoice obj = new ListInvoice(objhead);
            obj.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgwInvoices.DataSource = null;
            dgwInvoices.DataSource = InvoiceBLL.GetPurchaseInvoicesHeader();
        }
    }
}
