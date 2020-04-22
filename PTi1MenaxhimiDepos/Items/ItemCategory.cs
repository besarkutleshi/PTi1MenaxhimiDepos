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
    public partial class ItemCategory : Form
    {
        public ItemCategory()
        {
            InitializeComponent();
        }

        private void LoadGrid(List<BO.ItemCategory> categories)
        {
            dgwCategories.DataSource = ItemBLL.ReturnDt(categories);
        }
        private void ItemCategory_Load(object sender, EventArgs e)
        {
            LoadGrid(ItemBLL.GetCategories());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtname.Text == "" || txtdescription.Text == "")
            {
                MessageBox.Show("Please fill in empty box's", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                BO.ItemCategory category = new BO.ItemCategory(0, txtname.Text, txtdescription.Text);
                category.Username = "besarkutleshi";
                if (ItemBLL.InsertCategory(category))
                {
                    HelperClass.LoadGrid(ItemBLL.GetCategories(),dgwCategories);
                }

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.All(char.IsDigit))
            {
                BO.ItemCategory category = ItemBLL.GetItemCategory(int.Parse(txtSearch.Text));
                HelperClass.DoesExist(category, dgwCategories);
            }
            else
            {
                BO.ItemCategory category = ItemBLL.GetItemCategory(txtSearch.Text);
                HelperClass.DoesExist(category, dgwCategories);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text == "")
            {
                HelperClass.LoadGrid(ItemBLL.GetCategories(), dgwCategories);
            }
        }
    }
}
