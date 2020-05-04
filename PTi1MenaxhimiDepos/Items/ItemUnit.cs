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

namespace PTi1MenaxhimiDepos.Items
{
    public partial class ItemUnit : Form
    {
        BO.ItemUnit unit = null;
        public ItemUnit()
        {
            InitializeComponent();
        }
        private void ItemUnit_Load(object sender, EventArgs e)
        {
            HelperClass.LoadGrid(ItemBLL.GetItemUnits(), dgwTypes);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtname.Text == "" || txtdescription.Text == "")
            {
                MessageBox.Show("Please fill in empty box's", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                BO.ItemUnit unit = new BO.ItemUnit(0, txtname.Text, txtdescription.Text);
                unit.Username = HelpClass.CurrentUser.UserName;
                if (ItemBLL.InsertUnitType(unit))
                {
                    HelperClass.LoadGrid(ItemBLL.GetItemUnits(),dgwTypes);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.All(char.IsDigit))
            {
                BO.ItemUnit unit = ItemBLL.GetUnit(int.Parse(txtSearch.Text));
                HelperClass.DoesExist(unit, dgwTypes);
            }
            else
            {
                BO.ItemUnit unit = ItemBLL.GetUnit(txtSearch.Text);
                HelperClass.DoesExist(unit, dgwTypes);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text == "")
            {
                HelperClass.LoadGrid(ItemBLL.GetItemUnits(),dgwTypes);
            }
        }

        private void dgwTypes_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            unit = new BO.ItemUnit(int.Parse(HelpClass.GetValue(e, dgwTypes, 0)), HelpClass.GetValue(e, dgwTypes, 1), HelpClass.GetValue(e, dgwTypes, 2));
            txtID.Text = unit.ID.ToString(); txtname.Text = unit.Name; txtdescription.Text = unit.Description;
            btnDelete.Visible = btnUpdate.Visible = true; btnSave.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(unit.Name == txtname.Text && unit.Description == txtdescription.Text)
            {
                MessageBox.Show("You do not change anything", "Not Change", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(MessageBox.Show("Are you sure","Sure",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                unit.Name = txtname.Text;
                unit.Description = txtdescription.Text;
                unit.Username = HelpClass.CurrentUser.UserName;
                if (ItemBLL.UpdateUnitType(unit.ID, unit))
                {
                    HelpClass.VisibleButton(btnSave, btnDelete, btnUpdate, txtname, txtdescription, txtID);
                    HelperClass.LoadGrid(ItemBLL.GetItemUnits(),dgwTypes);
                    unit = null;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure", "Sure", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (ItemBLL.DeleteUnitType(unit.ID))
                {
                    HelpClass.VisibleButton(btnSave, btnDelete, btnUpdate, txtname, txtdescription, txtID);
                    HelperClass.LoadGrid(ItemBLL.GetItemUnits(), dgwTypes);
                    unit = null;
                }
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            HelpClass.VisibleButton(btnSave, btnDelete, btnUpdate, txtname, txtdescription,txtID);
        }
    }
}
