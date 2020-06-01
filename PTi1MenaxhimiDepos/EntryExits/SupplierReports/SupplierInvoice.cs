using PTi1MenaxhimiDepos.BO.EntiresExits.ClientReports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTi1MenaxhimiDepos.EntryExits.SupplierReports
{
    public partial class SupplierInvoice : Form
    {
        public SupplierInvoice()
        {
            InitializeComponent();
        }

        private void dgwClientInvoices_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            ClientInvoices clientInvoices = (ClientInvoices)dgwClientInvoices.Rows[e.RowIndex].DataBoundItem;
            ListBodies obj = new ListBodies(clientInvoices.InvertoryID);
            obj.ShowDialog();
        }
    }
}
