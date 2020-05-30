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

namespace PTi1MenaxhimiDepos.EntryExits.ClientRaports
{
    public partial class ClientRaport : Form
    {
        public ClientRaport()
        {
            InitializeComponent();
        }

        private void ClientRaport_Load(object sender, EventArgs e)
        {
            dgwClientReports.DataSource = EntriesExitsBL.GetClientReports();
        }

        private void dgwClientReports_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            BO.EntiresExits.ClientReport obj = (BO.EntiresExits.ClientReport)dgwClientReports.Rows[e.RowIndex].DataBoundItem;
            ClientsInvoice clientsInvoice = new ClientsInvoice(obj);
            clientsInvoice.ShowDialog();
        }
    }
}
