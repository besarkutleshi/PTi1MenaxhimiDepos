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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtname.Text == "" || txtdescription.Text == "")
            {
                MessageBox.Show("Please fill in empty box's", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                BO.ItemCategory category = new BO.ItemCategory(0, txtname.Text, txtdescription.Text);
                category.Username = HelpClass.CurrentUser.UserName;
                if (ItemBLL.InsertCategory(category))
                {
                    Refresh();
                }
            }
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
            if(HelperClass.DoesExists(obj,ref itemCategories))
            {
                dgwCategories.DataSource = null;
                dgwCategories.DataSource = itemCategories;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text == "")
            {
                dgwCategories.DataSource = null;
                dgwCategories.DataSource = ItemBLL.GetCategories();
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure","Sure",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (ItemBLL.DeleteCategory(category.ID))
                {
                    Refresh();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(category.Name == txtname.Text && category.Description == txtdescription.Text)
            {
                MessageBox.Show("You do not change anything", "Not Change", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                category = new BO.ItemCategory(int.Parse(txtID.Text), txtname.Text, txtdescription.Text);
                category.Username = HelpClass.CurrentUser.UserName;
                if (MessageBox.Show("Are you sure", "Sure", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (ItemBLL.UpdateCategory(category.ID, category))
                    {
                        Refresh();
                    }
                }
            }
        }

        private void ItemCategory_Load(object sender, EventArgs e)
        {
            dgwCategories.DataSource = ItemBLL.GetCategories();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            HelpClass.NotVisibleButton(btnSave, btnDelete, btnUpdate);
            HelpClass.Delete(txtname, txtdescription, txtID);
        }

        public override void Refresh()
        {
            dgwCategories.DataSource = null;
            dgwCategories.DataSource = ItemBLL.GetCategories();
            HelpClass.NotVisibleButton(btnSave, btnDelete, btnUpdate);
            HelpClass.Delete(txtname, txtdescription, txtID);
        }

        private void dgwCategories_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            category = (BO.ItemCategory)dgwCategories.Rows[e.RowIndex].DataBoundItem;
            txtID.Text = category.ID.ToString();
            txtname.Text = category.Name;
            txtdescription.Text = category.Description;
            HelpClass.VisibleButton(btnSave, btnDelete, btnUpdate);
        }

        private void ItemCategory_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure ?", "Sure", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
