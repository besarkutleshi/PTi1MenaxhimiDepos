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
        BO.ItemCategory category = null;
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

        private void dgwCategories_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            category = new BO.ItemCategory(int.Parse(dgwCategories.Rows[e.RowIndex].Cells[0].Value.ToString()), dgwCategories.Rows[e.RowIndex].Cells[1].Value.ToString(),
                dgwCategories.Rows[e.RowIndex].Cells[2].Value.ToString());
            txtname.Text = category.Name;
            txtdescription.Text = category.Description;
            btnDelete.Visible = btnUpdate.Visible = true; btnSave.Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure","Sure",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (ItemBLL.DeleteCategory(category.ID))
                {
                    HelpClass.OnChange(btnSave, btnDelete, btnUpdate, txtname, txtdescription);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(category.Name == txtname.Text && category.Description == txtdescription.Text)
            {
                MessageBox.Show("You do not change anything", "Not Change", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
            else
            {
                category.Name = txtname.Text;
                category.Description = txtdescription.Text;
                category.Username = "besarkutleshi";
                if (MessageBox.Show("Are you sure", "Sure", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (ItemBLL.UpdateCategory(category.ID, category))
                    {
                        HelpClass.OnChange(btnSave, btnDelete, btnUpdate, txtname, txtdescription);
                    }
                }
            }
        }
    }
}
