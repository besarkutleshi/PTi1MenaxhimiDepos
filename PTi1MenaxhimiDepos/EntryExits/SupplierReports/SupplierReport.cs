using PTi1MenaxhimiDepos.BL;
using PTi1MenaxhimiDepos.BO.EntiresExits.ClientReports;
using PTi1MenaxhimiDepos.BO.EntiresExits.SupplierReports;
using PTi1MenaxhimiDepos.EntryExits.ClientRaports;
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
    public partial class SupplierReport : Form
    {
        public SupplierReport()
        {
            InitializeComponent();
        }

        private void SupplierReport_Load(object sender, EventArgs e)
        {
            dgwSupplierReports.DataSource = EntriesExitsBL.GetSupplierReports();
        }

        private void dgwSupplierReports_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            BO.EntiresExits.SupplierReports.SupplierReport clientInvoices = (BO.EntiresExits.SupplierReports.SupplierReport)dgwSupplierReports.Rows[e.RowIndex].DataBoundItem;
            ClientsInvoice obj = new ClientsInvoice(clientInvoices.SupplierID);
            obj.ShowDialog();
        }
    }
}
