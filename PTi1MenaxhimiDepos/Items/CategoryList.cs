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
    public partial class CategoryList : Form
    {
        private BO.ItemCategory category;

        public CategoryList()
        {
            InitializeComponent();
        }

        private void dgwCategories_Click(object sender, EventArgs e)
        {

        }

        private void CategoryList_Load(object sender, EventArgs e)
        {
            dgwCategories.DataSource = ItemBLL.GetCategories();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgwCategories.DataSource = null;
            dgwCategories.DataSource = ItemBLL.GetCategories();
        }

        private void btnInsertRole_Click(object sender, EventArgs e)
        {
            ItemCategory obj = new ItemCategory();
            obj.ShowDialog();
        }

        private void dgwCategories_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            category = (BO.ItemCategory)dgwCategories.Rows[e.RowIndex].DataBoundItem;
            ItemCategory obj = new ItemCategory(category);
            obj.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.All(char.IsDigit))
            {
                BO.ItemCategory category = ItemBLL.GetItemCategory(int.Parse(txtSearch.Text));
                DisplaySearchResult(category);
            }
            else
            {
                BO.ItemCategory category = ItemBLL.GetItemCategory(txtSearch.Text);
                DisplaySearchResult(category);
            }
        }
        private void DisplaySearchResult(BO.ItemCategory obj)
        {
            List<BO.ItemCategory> itemCategories = null;
            if (HelperClass.DoesExists(obj, ref itemCategories))
            {
                dgwCategories.DataSource = null;
                dgwCategories.DataSource = itemCategories;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                dgwCategories.DataSource = null;
                dgwCategories.DataSource = ItemBLL.GetCategories();
            }
        }
    }
}
