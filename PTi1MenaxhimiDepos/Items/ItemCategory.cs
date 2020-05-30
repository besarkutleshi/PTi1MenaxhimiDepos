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
        public ItemCategory(BO.ItemCategory category)
        {
            this.category = category;
            InitializeComponent();
            txtdescription.Text = category.Description;
            txtID.Text = category.ID.ToString();
            txtname.Text = category.Name;
            HelpClass.VisibleButton(btnSave, btnDelete, btnUpdate);
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            HelpClass.NotVisibleButton(btnSave, btnDelete, btnUpdate);
            HelpClass.Delete(txtname, txtdescription, txtID);
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
