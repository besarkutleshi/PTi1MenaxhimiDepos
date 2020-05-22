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

namespace PTi1MenaxhimiDepos.Administration
{
    public partial class Role : Form
    {
        BO.Role role = null;
        public Role()
        {
            InitializeComponent();
        }


        private void btndelete_Click(object sender, EventArgs e)
        {
            if(role != null)
            {
                if(MessageBox.Show("Are you sure ?","Sure",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (AdministrationBLL.DeleteRole(role.ID))
                    {
                        Refresh();
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "" || txtDescription.Text == "" || txtCode.Text == "")
            {
                MessageBox.Show("Please fill in empty box's", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                if (role != null)
                {
                    role = new BO.Role(int.Parse(txtID.Text), txtname.Text, txtCode.Text, txtDescription.Text);
                    role.Username = HelpClass.CurrentUser.UserName;
                    if (AdministrationBLL.UpdateRole(role.ID, role))
                    {
                        Refresh();
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            HelpClass.Delete(txtCode, txtDescription, txtID, txtname, txtSearch);
            HelpClass.NotVisibleButton(btnSave, btndelete, btnUpdate);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtname.Text == ""||txtDescription.Text == "" || txtCode.Text == "")
            {
                MessageBox.Show("Please fill in empty box's", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                BO.Role obj = new BO.Role(0, txtname.Text, txtCode.Text, txtDescription.Text);
                obj.Username = HelpClass.CurrentUser.UserName;
                if (AdministrationBLL.InsertRole(obj))
                {
                    Refresh();
                }
            }
        }

        private void dgwRoles_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            role = (BO.Role)dgwRoles.Rows[e.RowIndex].DataBoundItem;
            txtID.Text = role.ID.ToString();
            txtname.Text = role.Name;
            txtDescription.Text = role.Description;
            txtCode.Text = role.Code;
            HelpClass.VisibleButton(btnSave, btndelete, btnUpdate);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text == "")
            {
                dgwRoles.DataSource = null;
                dgwRoles.DataSource = AdministrationBLL.GetRoles();
            }
        }

        private void Role_Load(object sender, EventArgs e)
        {
            dgwRoles.DataSource = AdministrationBLL.GetRoles();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.All(char.IsDigit))
            {
                BO.Role obj = AdministrationBLL.GetRole(int.Parse(txtSearch.Text));
                DisplaySearchResult(obj);
            }
            else
            {
                BO.Role obj = AdministrationBLL.GetRole(txtSearch.Text);
                DisplaySearchResult(obj);
            }
        }

        private void DisplaySearchResult(BO.Role obj)
        {
            List<BO.Role> roles = null;
            if(HelperClass.DoesExists(obj,ref roles))
            {
                dgwRoles.DataSource = null;
                dgwRoles.DataSource = roles;
            }
        }

        public override void Refresh()
        {
            HelpClass.Delete(txtCode, txtDescription, txtID, txtname, txtSearch);
            HelpClass.NotVisibleButton(btnSave, btndelete, btnUpdate);
            dgwRoles.DataSource = null;
            dgwRoles.DataSource = AdministrationBLL.GetRoles();
            txtname.Focus();
        }

        private void Role_FormClosing(object sender, FormClosingEventArgs e)
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
