using PTi1MenaxhimiDepos.BL;
using PTi1MenaxhimiDepos.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTi1MenaxhimiDepos.POS
{
    public partial class PosList : Form
    {
        private PointofSale obj;

        public PosList()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.All(char.IsDigit))
            {
                PointofSale obj = PosBLL.GetPointofSale(int.Parse(txtSearch.Text));
                DisplaySearchResult(obj);
            }
            else
            {
                PointofSale obj = PosBLL.GetPointofSale(txtSearch.Text);
                DisplaySearchResult(obj);
            }
        }
        private void DisplaySearchResult(BO.PointofSale obj)
        {
            List<BO.PointofSale> pointofSales = null;
            if (HelperClass.DoesExists(obj, ref pointofSales))
            {
                dgwPos.DataSource = null;
                dgwPos.DataSource = pointofSales;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                dgwPos.DataSource = null;
                dgwPos.DataSource = PosBLL.GetPointofSales();
            }
        }

        private void btnInsertRole_Click(object sender, EventArgs e)
        {
            POS pOS = new POS();
            pOS.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgwPos.DataSource = null;
            dgwPos.DataSource = PosBLL.GetPointofSales();
        }

        private void PosList_Load(object sender, EventArgs e)
        {
            dgwPos.DataSource = PosBLL.GetPointofSales();
        }

        private void dgwPos_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            obj = (BO.PointofSale)dgwPos.Rows[e.RowIndex].DataBoundItem;
            POS pOS = new POS(obj);
            pOS.ShowDialog();
        }
    }
}
