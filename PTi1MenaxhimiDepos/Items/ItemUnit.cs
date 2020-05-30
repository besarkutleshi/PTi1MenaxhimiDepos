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

        public ItemUnit(BO.ItemUnit unit)
        {
            this.unit = unit;
            InitializeComponent();
            txtID.Text = unit.ID.ToString();
            txtname.Text = unit.Name;
            txtdescription.Text = unit.Description;
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
                BO.ItemUnit unit = new BO.ItemUnit(0, txtname.Text, txtdescription.Text);
                unit.Username = HelpClass.CurrentUser.UserName;
                if (ItemBLL.InsertUnitType(unit))
                {
                    Refresh();
                }
            }
        }

      
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(unit.Name == txtname.Text && unit.Description == txtdescription.Text)
            {
                MessageBox.Show("You do not change anything", "Not Change", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if(MessageBox.Show("Are you sure","Sure",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                unit = new BO.ItemUnit(int.Parse(txtID.Text), txtname.Text, txtdescription.Text);
                unit.Username = HelpClass.CurrentUser.UserName;
                if (ItemBLL.UpdateUnitType(unit.ID, unit))
                {
                    Refresh();
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
                    Refresh();
                    unit = null;
                }
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            HelpClass.NotVisibleButton(btnSave, btnDelete, btnUpdate);
            HelpClass.Delete(txtname, txtdescription, txtID);
        }

        private void ItemUnit_FormClosing(object sender, FormClosingEventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
