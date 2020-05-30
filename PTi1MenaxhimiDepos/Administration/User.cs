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
            this.cmbEmployee.DropDownListElement.DropDownWidth = 300;
            this.cmbRole.DropDownListElement.DropDownWidth = 300;
        }

        public User(BO.Account.User obj)
        {
            InitializeComponent();
            this.obj = obj;
            this.cmbEmployee.DropDownListElement.DropDownWidth = 300;
            this.cmbRole.DropDownListElement.DropDownWidth = 300;
            txtUsername.Text = obj.UserName;
            txtPasword.Text = Security.Decrypt(obj.Password);
            txtID.Text = obj.ID.ToString();
            txtDescription.Text = obj.Description;
            HelpClass.VisibleButton(btnSave, btndelete, btnUpdate);
            label7.Text = "Update User";
        }

        private void User_Load(object sender, EventArgs e)
        {
            cmbRole.DataSource = AdministrationBLL.GetRoles(); cmbRole.DisplayMember = "Name"; cmbRole.ValueMember = "ID";
            cmbEmployee.DataSource = CollaborationBLL.GetEmployees(); cmbEmployee.DisplayMember = "Fullname"; cmbEmployee.ValueMember = "ID";
            if(obj != null)
            {
                cmbRole.Text = obj.Role.Name;
                cmbEmployee.Text = obj.Employee.Name;
            }
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
                    Refresh();
                }
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            HelpClass.NotVisibleButton(btnSave, btndelete, btnUpdate);
            HelpClass.Delete(txtDescription, txtID, txtPasword, txtUsername);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (obj.UserName == txtUsername.Text && obj.Password == txtPasword.Text && txtDescription.Text == obj.Description
                && cmbEmployee.Text == obj.Employee.Name && cmbRole.Text == obj.Role.Name)
            {
                MessageBox.Show("Nothing Change", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                BO.Employee emp = (BO.Employee)cmbEmployee.SelectedItem.DataBoundItem;
                BO.Role role = (BO.Role)cmbRole.SelectedItem.DataBoundItem;
                obj = new BO.Account.User(int.Parse(txtID.Text), txtUsername.Text, Security.Encryptt(txtPasword.Text), txtDescription.Text, emp.ID,role.ID);
                obj.Username = HelpClass.CurrentUser.UserName; 
                if (AdministrationBLL.UpdateUser(obj.ID, obj))
                {
                    Refresh();
                }
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure","Sure",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (AdministrationBLL.DeleteUser(int.Parse(txtID.Text)))
                {
                    Refresh();
                }
            }
        }


        private void User_FormClosing(object sender, FormClosingEventArgs e)
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

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
