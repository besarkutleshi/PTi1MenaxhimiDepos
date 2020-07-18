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

namespace PTi1MenaxhimiDepos.Items
{
    public partial class UnitList : Form
    {
        private BO.ItemUnit unit;

        public UnitList()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.All(char.IsDigit))
            {
                BO.ItemUnit unit = ItemBLL.GetUnit(int.Parse(txtSearch.Text));
                DisplaySearchResult(unit);
            }
            else
            {
                BO.ItemUnit unit = ItemBLL.GetUnit(txtSearch.Text);
                DisplaySearchResult(unit);
            }
        }
        private void DisplaySearchResult(BO.ItemUnit obj)
        {
            List<BO.ItemUnit> itemUnits = null;
            if (HelperClass.DoesExists(obj, ref itemUnits))
            {
                dgwUnits.DataSource = null;
                dgwUnits.DataSource = itemUnits;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                dgwUnits.DataSource = null;
                dgwUnits.DataSource = ItemBLL.GetItemUnits();
            }
        }

        private void UnitList_Load(object sender, EventArgs e)
        {
            dgwUnits.DataSource = ItemBLL.GetItemUnits();
        }

        private void dgwUnits_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            unit = (BO.ItemUnit)dgwUnits.Rows[e.RowIndex].DataBoundItem;
            ItemUnit obj = new ItemUnit(unit);
            obj.ShowDialog();
        }

        private void btnInsertRole_Click(object sender, EventArgs e)
        {
            ItemUnit obj = new ItemUnit();
            obj.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgwUnits.DataSource = null;
            dgwUnits.DataSource = ItemBLL.GetItemUnits();
        }
    }
}
