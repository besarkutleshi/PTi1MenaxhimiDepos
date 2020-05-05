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
    public partial class Client : Form
    {
        BO.Client client = null;
        public Client()
        {
            InitializeComponent();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            dgwClients.DataSource = CollaborationBLL.GetClients();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtcity.Text == "" || txtCountry.Text == "" || txtname.Text == "" || txtPhone.Text == "" || txtPostalCode.Text == ""
               || txtstreet.Text == "" || txtsurname.Text == "" || txtemail.Text == "")
            {
                MessageBox.Show("Please fill in empty box's", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                if (txtcity.Text == client.Address.City && txtCountry.Text == client.Address.Country && txtname.Text == client.Name && txtPhone.Text == client.Phone && txtPostalCode.Text == client.Address.PostalCode.ToString()
                    && txtsurname.Text == client.Surname && txtstreet.Text == client.Address.Street && txtemail.Text == client.Email)
                {
                    MessageBox.Show("Nothing Change", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                else
                {
                    client = new BO.Client(int.Parse(txtID.Text), txtname.Text, txtsurname.Text, txtPhone.Text, txtemail.Text
                        , new Address(txtstreet.Text, txtcity.Text, txtCountry.Text, txtPostalCode.Text));
                    client.Address = new Address(txtstreet.Text, txtcity.Text, txtCountry.Text, txtPostalCode.Text);
                    client.Username = HelpClass.CurrentUser.UserName;
                    if (CollaborationBLL.UpdateClient(client.ID, client))
                    {
                        Refresh();
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtcity.Text == "" || txtCountry.Text == "" || txtname.Text == "" || txtPhone.Text == "" || txtPostalCode.Text == ""
                || txtstreet.Text == "" || txtsurname.Text == "")
            {
                MessageBox.Show("Please fill in empty box's", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                BO.Client obj = new BO.Client(0, txtname.Text, txtsurname.Text, txtPhone.Text, txtemail.Text,
                    new Address(txtstreet.Text, txtcity.Text, txtCountry.Text,txtPostalCode.Text));
                obj.Username = HelpClass.CurrentUser.UserName;
                if (CollaborationBLL.InsertClient(obj))
                {
                    Refresh();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure ?","Error",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(client != null)
                {
                    if (CollaborationBLL.DeleteClient(client.ID))
                    {
                        Refresh();
                    }
                }
                else
                {
                    MessageBox.Show("Please double click\nin a specific row in table", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            HelpClass.Delete(txtcity, txtCountry, txtemail, txtID, txtname, txtPhone, txtPostalCode, txtSearch, txtstreet, txtsurname);
            HelpClass.NotVisibleButton(btnSave, btnDelete, btnUpdate);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.All(char.IsDigit))
            {
                BO.Client obj = CollaborationBLL.GetClient(int.Parse(txtSearch.Text));
                DisplaySearchResult(obj);
            }
            else
            {
                BO.Client obj = CollaborationBLL.GetClient(txtSearch.Text);
                DisplaySearchResult(obj);
            }
        }

        private void DisplaySearchResult(BO.Client obj)
        {
            List<BO.Client> clients = null;
            if(HelperClass.DoesExists(obj,ref clients))
            {
                dgwClients.DataSource = null;
                dgwClients.DataSource = clients;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text == "")
            {
                dgwClients.DataSource = null;
                dgwClients.DataSource = CollaborationBLL.GetClients();
            }
        }

        private void radGridView1_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            client = (BO.Client)dgwClients.Rows[e.RowIndex].DataBoundItem;
            txtcity.Text = client.Address.City;
            txtCountry.Text = client.Address.Country;
            txtemail.Text = client.Email;
            txtID.Text = client.ID.ToString();
            txtname.Text = client.Name;
            txtsurname.Text = client.Surname;
            txtPhone.Text = client.Phone;
            txtstreet.Text = client.Address.Street;
            txtPostalCode.Text = client.Address.PostalCode.ToString();
            txtsurname.Text = client.Address.Street;
            HelpClass.VisibleButton(btnSave, btnDelete, btnUpdate);
        }

        public override void Refresh()
        {
            client = null;
            dgwClients.DataSource = null;
            dgwClients.DataSource = CollaborationBLL.GetClients();
            HelpClass.Delete(txtcity, txtCountry, txtemail, txtID, txtname, txtPhone, txtPostalCode, txtSearch, txtstreet, txtsurname);
            HelpClass.NotVisibleButton(btnSave, btnDelete, btnUpdate);
        }
    }
}
