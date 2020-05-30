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
    public partial class TypeList : Form
    {
        private BO.ItemType type;
        public TypeList()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.All(char.IsDigit))
            {
                BO.ItemType item = ItemBLL.GetItemType(int.Parse(txtSearch.Text));
                DisplaySearchResult(item);
            }
            else
            {
                BO.ItemType item = ItemBLL.GetItemType(txtSearch.Text);
                DisplaySearchResult(item);
            }
        }

        private void DisplaySearchResult(BO.ItemType obj)
        {
            List<BO.ItemType> itemTypes = null;
            if (HelperClass.DoesExists(obj, ref itemTypes))
            {
                dgwTypes.DataSource = null;
                dgwTypes.DataSource = itemTypes;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                dgwTypes.DataSource = null;
                dgwTypes.DataSource = ItemBLL.GetItemTypes();
            }
        }

        private void dgwTypes_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            type = (BO.ItemType)dgwTypes.Rows[e.RowIndex].DataBoundItem;
            ItemType obj = new ItemType(type);
            obj.ShowDialog();
        }

        private void btnInsertRole_Click(object sender, EventArgs e)
        {
            ItemType obj = new ItemType();
            obj.ShowDialog();
        }

        private void TypeList_Load(object sender, EventArgs e)
        {
            dgwTypes.DataSource = ItemBLL.GetItemTypes();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgwTypes.DataSource = null;
            dgwTypes.DataSource = ItemBLL.GetItemTypes();
        }
    }
}
