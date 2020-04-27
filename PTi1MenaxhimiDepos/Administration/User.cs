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

namespace PTi1MenaxhimiDepos.Administration
{
    public partial class User : Form
    {
        BO.Account.User obj = null;
        public User()
        {
            InitializeComponent();
        }

        private void User_Load(object sender, EventArgs e)
        {
            HelperClass.LoadGrid(AdministrationBLL.GetUsers(), dgwUser);
            cmbRole.DataSource = AdministrationBLL.GetRoles(); cmbRole.DisplayMember = "Name"; cmbRole.ValueMember = "ID";
            cmbEmployee.DataSource = CollaborationBLL.GetEmployees(); cmbEmployee.DisplayMember = "Fullname"; cmbEmployee.ValueMember = "ID";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "" || txtDescription.Text == "" || txtPasword.Text == "" || cmbEmployee.SelectedIndex == -1 || cmbRole.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in empty box's", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                BO.Account.User obj = new BO.Account.User(0, txtUsername.Text, Security.Encryptt(txtPasword.Text), txtDescription.Text, (int)cmbEmployee.SelectedValue, (int)cmbRole.SelectedValue);
                obj.Username = HelpClass.CurrentUser.UserName;
                if (AdministrationBLL.InsertUser(obj))
                {
                    HelperClass.LoadGrid(AdministrationBLL.GetUsers(), dgwUser);
                }
            }
        }

        private void dgwUser_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            obj = new BO.Account.User(
                int.Parse(HelpClass.GetValue(e,dgwUser,0)),HelpClass.GetValue(e,dgwUser,1),Security.Decrypt(HelpClass.GetValue(e,dgwUser,2))
                ,HelpClass.GetValue(e,dgwUser,3)
                );
            obj.Role = new BO.Role(HelpClass.GetValue(e, dgwUser, 4));
            obj.Employee = new BO.Employee(HelpClass.GetValue(e, dgwUser, 5));
            cmbRole.Text = obj.Role.Name;
            cmbEmployee.Text = obj.Employee.Name;
            txtUsername.Text = obj.UserName; txtPasword.Text = obj.Password; txtID.Text = obj.ID.ToString(); txtDescription.Text = obj.Description;
            btnSave.Visible = false;btndelete.Visible = btnUpdate.Visible = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.All(char.IsDigit))
            {
                BO.Account.User obj = AdministrationBLL.GetUser(int.Parse(txtSearch.Text));
                HelperClass.DoesExist(obj, dgwUser);
            }
            else
            {
                BO.Account.User obj = AdministrationBLL.GetUser(txtSearch.Text);
                HelperClass.DoesExist(obj, dgwUser);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text == "")
            {
                HelperClass.LoadGrid(AdministrationBLL.GetUsers(), dgwUser);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            HelpClass.OnChange(btnSave, btndelete, btnUpdate, txtDescription, txtID, txtPasword, txtUsername);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (obj.Username == txtUsername.Text || obj.Password == txtPasword.Text || txtDescription.Text == obj.Description
                || cmbEmployee.Text == obj.Employee.Name || cmbRole.Text == obj.Role.Name)
            {
                MessageBox.Show("Nothing Change", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                Employee emp = (Employee)cmbEmployee.SelectedItem.DataBoundItem;
                Role role = (Role)cmbRole.SelectedItem.DataBoundItem;
                obj = new BO.Account.User(int.Parse(txtID.Text), txtUsername.Text, Security.Encryptt(txtPasword.Text), txtDescription.Text, emp.ID, role.ID);
                obj.Username = HelpClass.CurrentUser.UserName; 
                if (AdministrationBLL.UpdateUser(obj.ID, obj))
                {
                    HelperClass.LoadGrid(AdministrationBLL.GetUsers(), dgwUser);
                    HelpClass.OnChange(btnSave, btndelete, btnUpdate, txtDescription, txtID, txtPasword, txtUsername);
                }
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure","Sure",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (AdministrationBLL.DeleteUser(int.Parse(txtID.Text)))
                {
                    HelperClass.LoadGrid(AdministrationBLL.GetUsers(), dgwUser);
                    HelpClass.OnChange(btnSave, btndelete, btnUpdate, txtDescription, txtID, txtPasword, txtUsername);
                }
            }
        }
    }
}
