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

namespace PTi1MenaxhimiDepos.Collab
{
    public partial class Employee : Form
    {
        BO.Employee employee = null;
        public Employee()
        {
            InitializeComponent();
        }

        public Employee(BO.Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            txtcity.Text = employee.Address.City;
            txtCountry.Text = employee.Address.Country;
            txtemail.Text = employee.Email;
            txtID.Text = employee.ID.ToString();
            txtname.Text = employee.Name;
            txtsurname.Text = employee.Surname;
            txtPhone.Text = employee.Phone;
            txtstreet.Text = employee.Address.Street;
            txtPostalCode.Text = employee.Address.PostalCode.ToString();
            txtsurname.Text = employee.Address.Street;
            HelpClass.VisibleButton(btnSave, btnDelete, btnUpdate);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtcity.Text == "" || txtCountry.Text == "" || txtname.Text == "" || txtPhone.Text == "" || txtPostalCode.Text == ""
                  || txtstreet.Text == "" || txtsurname.Text == "")
            {
                MessageBox.Show("Please fill in empty box's", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                BO.Employee emp = new BO.Employee(0, txtname.Text, txtsurname.Text, txtemail.Text, txtPhone.Text,
                    new Address(txtstreet.Text, txtcity.Text, txtCountry.Text, txtPostalCode.Text));
                emp.Username = HelpClass.CurrentUser.UserName;
                if (CollaborationBLL.InsertEmployee(emp))
                {
                    Refresh();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            HelpClass.Delete(txtcity, txtCountry, txtemail, txtID, txtname, txtPhone, txtPostalCode, txtstreet, txtsurname);
            HelpClass.NotVisibleButton(btnSave, btnDelete, btnUpdate);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtcity.Text == "" || txtCountry.Text == "" || txtname.Text == "" || txtPhone.Text == "" || txtPostalCode.Text == ""
                 || txtstreet.Text == "" || txtsurname.Text == "")
            {
                MessageBox.Show("Please fill in empty box's", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                if(employee != null)
                {
                    employee = new BO.Employee(int.Parse(txtID.Text), txtname.Text, txtsurname.Text, txtemail.Text, txtPhone.Text,
                    new Address(txtstreet.Text, txtcity.Text, txtCountry.Text, txtPostalCode.Text));
                    employee.Username = HelpClass.CurrentUser.UserName;
                    if (CollaborationBLL.UpdateEmployee(employee.ID,employee))
                    {
                        Refresh();
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(employee != null)
            {
                if (MessageBox.Show("Are you sure ?", "Sure", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (CollaborationBLL.DeleteEmployee(employee.ID))
                    {
                        Refresh();
                    }
                }
            }
        }


        private void Employee_FormClosing(object sender, FormClosingEventArgs e)
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
