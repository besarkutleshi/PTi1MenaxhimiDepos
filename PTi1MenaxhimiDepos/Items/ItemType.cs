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
using Telerik.WinControls.UI;

namespace PTi1MenaxhimiDepos.Items
{
    public partial class ItemType : Form
    {
        BO.ItemType type = null;
        public ItemType()
        {
            InitializeComponent();
        }

        private void ItemType_Load(object sender, EventArgs e)
        {
            HelperClass.LoadGrid(ItemBLL.GetItemTypes(), dgwTypes);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            PTi1MenaxhimiDepos.BO.ItemType itemtype = new BO.ItemType(0, txtname.Text, txtdescription.Text);
            itemtype.Username = HelpClass.CurrentUser.UserName;
            if (ItemBLL.InsertItemType(itemtype))
            {
                HelperClass.LoadGrid(ItemBLL.GetItemTypes(), dgwTypes);
                HelpClass.VisibleButton(btnSave, btndelete, btnUpdate, txtname, txtdescription, txtid);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.All(char.IsDigit))
            {
                BO.ItemType item = ItemBLL.GetItemType(int.Parse(txtSearch.Text));
                HelperClass.DoesExist(item, dgwTypes);
            }
            else
            {
                BO.ItemType item = ItemBLL.GetItemType(txtSearch.Text);
                HelperClass.DoesExist(item, dgwTypes);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text == "")
            {
                HelperClass.LoadGrid(ItemBLL.GetItemTypes(),dgwTypes);
            }
        }

        private void dgwTypes_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            type = new BO.ItemType(int.Parse(dgwTypes.Rows[e.RowIndex].Cells[0].Value.ToString()),
                dgwTypes.Rows[e.RowIndex].Cells[1].Value.ToString(), dgwTypes.Rows[e.RowIndex].Cells[2].Value.ToString());
            txtid.Text = type.ID.ToString();
            txtname.Text = type.Name;txtdescription.Text = type.Description;
            btndelete.Visible = btnUpdate.Visible = true; 
            btnSave.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (type.Name == txtname.Text && type.Description == txtdescription.Text)
            {
                MessageBox.Show("You do not change anything", "Not Change", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
            else
            {
                type.Name = txtname.Text;
                type.Description = txtdescription.Text;
                type.Username = HelpClass.CurrentUser.UserName;
                if (MessageBox.Show("Are you sure", "Sure", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (ItemBLL.UpdateItemType(type.ID, type))
                    {
                        HelpClass.VisibleButton(btnSave, btndelete, btnUpdate, txtname, txtdescription, txtid);
                        HelperClass.LoadGrid(ItemBLL.GetItemTypes(), dgwTypes);
                    }
                }
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure", "Sure", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (ItemBLL.DeleteItemType(type.ID))
                {
                    HelpClass.VisibleButton(btnSave, btndelete, btnUpdate, txtname, txtdescription, txtid);
                    HelperClass.LoadGrid(ItemBLL.GetItemTypes(), dgwTypes);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            HelpClass.VisibleButton(btnSave, btndelete, btnUpdate, txtname, txtdescription, txtid);
        }
    }
}
