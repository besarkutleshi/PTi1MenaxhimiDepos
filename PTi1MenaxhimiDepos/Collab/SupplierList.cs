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

namespace PTi1MenaxhimiDepos.Collab
{
    public partial class SupplierList : Form
    {
        private BO.Supplier supplier = null;

        public SupplierList()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.All(char.IsDigit))
            {
                BO.Supplier obj = CollaborationBLL.GetSupplier(int.Parse(txtSearch.Text));
                DisplaySearchResult(obj);
            }
            else
            {
                BO.Supplier obj = CollaborationBLL.GetSupplier(txtSearch.Text);
                DisplaySearchResult(obj);
            }
        }
        private void DisplaySearchResult(BO.Supplier obj)
        {
            List<BO.Supplier> suppliers = null;
            if (HelperClass.DoesExists(obj, ref suppliers))
            {
                dgwSuppliers.DataSource = null;
                dgwSuppliers.DataSource = suppliers;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                dgwSuppliers.DataSource = null;
                dgwSuppliers.DataSource = CollaborationBLL.GetSuppliers();
            }
        }

        private void dgwSuppliers_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            supplier = (BO.Supplier)dgwSuppliers.Rows[e.RowIndex].DataBoundItem;
            Supplier s = new Supplier(supplier);
            s.ShowDialog();
        }

        private void btnInsertRole_Click(object sender, EventArgs e)
        {
            Supplier s = new Supplier();
            s.ShowDialog();
        }

        private void SupplierList_Load(object sender, EventArgs e)
        {
            dgwSuppliers.DataSource = CollaborationBLL.GetSuppliers();
        }
    }
}
