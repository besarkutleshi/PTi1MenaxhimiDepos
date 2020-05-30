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
        }
        private readonly int _invertoryHeaderID;
        public ListInvoiceBodies(int invertoryHeaderID)
        {
            InitializeComponent();
            this._invertoryHeaderID = invertoryHeaderID;
        }
        private void ListInvoiceBodies_Load(object sender, EventArgs e)
        {
            dgwBodies.DataSource = InvoiceBLL.GetInvertoryBodiesByHeader(_invertoryHeaderID);
        }

        private void dgwBodies_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            obj = (InvertoryBody)dgwBodies.Rows[e.RowIndex].DataBoundItem;
            InvoiceBody body = new InvoiceBody(obj,_invertoryHeaderID);
            body.ShowDialog();
        }
        public override void Refresh()
        {
            dgwBodies.DataSource = null;
            dgwBodies.DataSource = InvoiceBLL.GetInvertoryBodiesByHeader(_invertoryHeaderID);
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnInsertRole_Click(object sender, EventArgs e)
        {
            InvoiceBody body = new InvoiceBody(_invertoryHeaderID);
            body.ShowDialog();
        }
    }
}
