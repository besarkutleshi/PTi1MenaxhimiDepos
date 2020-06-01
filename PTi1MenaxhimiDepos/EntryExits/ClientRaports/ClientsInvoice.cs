using PTi1MenaxhimiDepos.BL;
using PTi1MenaxhimiDepos.BO.EntiresExits.ClientReports;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PTi1MenaxhimiDepos.EntryExits.ClientRaports
{
    public partial class ClientsInvoice : Form
    {
        BO.EntiresExits.ClientReport obj = null;
        int invertoryid = 0;
        public ClientsInvoice()
        {
            InitializeComponent();
        }

        public ClientsInvoice(BO.EntiresExits.ClientReport obj)
        {
            InitializeComponent();
            this.obj = obj;
        }

        public ClientsInvoice(int invertoryid)
        {
            InitializeComponent();
            this.invertoryid = invertoryid;
        }

        private void ClientsInvoice_Load(object sender, EventArgs e)
        {
            if(this.obj != null)
            {
                dgwClientInvoices.DataSource = EntriesExitsBL.GetClientInvoices(this.obj.ID).Where(ci => ci.InvoiceType == "FATURE SHITJE");
            }
            else if (invertoryid != 0)
            {
                dgwClientInvoices.DataSource = EntriesExitsBL.GetClientInvoices(invertoryid).Where(ci => ci.InvoiceType == "FATURE BLERJE");
            }
        }

        private void dgwClientInvoices_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            ClientInvoices clientInvoices = (ClientInvoices)dgwClientInvoices.Rows[e.RowIndex].DataBoundItem;
            ListBodies obj = new ListBodies(clientInvoices.InvertoryID);
            obj.ShowDialog();
        }
    }
}
