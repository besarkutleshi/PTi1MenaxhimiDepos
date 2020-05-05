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
                if (CollaborationBLL.InsertEmployee(emp))
                {
                    Refresh();
                } // qikjo osht per me bo insert 
            }
        }

        private void dgwClients_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            employee = (BO.Employee)dgwEmployees.Rows[e.RowIndex].DataBoundItem; // qikjo osht kur tklikohet dy her per mi ni rresht ne grid hin ne qit metod edhe mushet qikjy objekt
            //employee edhe qato tdhana i qesum ne textboxa
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
            HelpClass.VisibleButton(btnSave, btnDelete, btnUpdate); // qikjo i bon show buttonat per delete edhe per update se nfillim osht veq butoni save e kqyrum ma von 
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            dgwEmployees.DataSource = CollaborationBLL.GetEmployees(); // qikjo i qet ne list 
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //qikjo i fshin textboxat  osht ni klas qe e kom bo un qe e ka ne parameter ni array te textboxav
            HelpClass.Delete(txtcity, txtCountry, txtemail, txtID, txtname, txtPhone, txtPostalCode, txtSearch, txtstreet, txtsurname);
            HelpClass.NotVisibleButton(btnSave, btnDelete, btnUpdate); // edhe tash kjo not visible i hjek butonat per delete edhe update ioke
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
                    new Address(txtstreet.Text, txtcity.Text, txtCountry.Text, txtPostalCode.Text));// tash per me bo update i mer apet qato tdhana qe i ke shenu
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

        public override void Refresh()
        {
            dgwEmployees.DataSource = null;
            dgwEmployees.DataSource = CollaborationBLL.GetClients();
            HelpClass.Delete(txtcity, txtCountry, txtemail, txtID, txtname, txtPhone, txtPostalCode, txtSearch, txtstreet, txtsurname);
            HelpClass.NotVisibleButton(btnSave, btnDelete, btnUpdate);
        }

        private void DisplaySearchResult(BO.Employee obj)
        {
            List<BO.Employee> clients = null;
            if (HelperClass.DoesExists(obj, ref clients))
            {
                dgwEmployees.DataSource = null;
                dgwEmployees.DataSource = clients;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text == "")
            {
                dgwEmployees.DataSource = null;
                dgwEmployees.DataSource = CollaborationBLL.GetEmployees();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.All(char.IsDigit))
            {
                BO.Employee obj = CollaborationBLL.GetEmployee(int.Parse(txtSearch.Text));
                DisplaySearchResult(obj);
            }
            else
            {
                BO.Employee obj = CollaborationBLL.GetEmployee(txtSearch.Text);
                DisplaySearchResult(obj);
            }
        }
    }
}
