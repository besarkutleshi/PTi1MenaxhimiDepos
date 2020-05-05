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

namespace PTi1MenaxhimiDepos.Collab
{
    public partial class Supplier : Form
    {
        BO.Supplier supplier = null;
        public Supplier()
        {
            InitializeComponent();
        }
        private void Supplier_Load(object sender, EventArgs e)
        {
            dgwSuppliers.DataSource = CollaborationBLL.GetSuppliers();
        }

        private void btnRuaj_Click(object sender, EventArgs e)
        {
            if(txtname.Text == "" || txtdecription.Text == "" || txtcity.Text == "" || txtemail.Text == "" || txtphone.Text == "")
            {
                MessageBox.Show("Please fill in empty box's", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                BO.Supplier obj = new BO.Supplier(0, txtname.Text, txtdecription.Text, txtcity.Text, txtphone.Text, txtemail.Text);
                obj.Username = HelpClass.CurrentUser.UserName;
                if (CollaborationBLL.InsertSupplier(obj))
                {
                    Refresh();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure ?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (CollaborationBLL.DeleteSupplier(int.Parse(txtID.Text)))
                {
                    Refresh();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "" || txtphone.Text == "" || txtcity.Text == "" || txtdecription.Text ==  "" || txtemail.Text == "")
            {
                MessageBox.Show("Please fill in empty box's", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                if (txtname.Text == supplier.Name && txtphone.Text == supplier.Phone && txtcity.Text == supplier.City && txtdecription.Text == supplier.Description && txtemail.Text == supplier.Mail)
                {
                    MessageBox.Show("Nothing Changed", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                else
                {
                    supplier.City = txtcity.Text;
                    supplier.Description = txtdecription.Text;
                    supplier.Mail = txtemail.Text;
                    supplier.Name = txtname.Text;
                    supplier.Phone = txtphone.Text;
                    supplier.Username = HelpClass.CurrentUser.UserName;
                    if (CollaborationBLL.UpdateSupplier(supplier.ID, supplier))
                    {
                        Refresh();
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            HelpClass.Delete(txtID, txtcity, txtdecription, txtemail, txtname, txtphone, txtSearch);
            HelpClass.NotVisibleButton(btnSave, btnDelete, btnUpdate);
        }

        private void dgwSuppliers_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            supplier = (BO.Supplier)dgwSuppliers.Rows[e.RowIndex].DataBoundItem;
            txtID.Text = supplier.ID.ToString();
            txtname.Text = supplier.Name;
            txtcity.Text = supplier.City;
            txtdecription.Text = supplier.Description;
            txtphone.Text = supplier.Phone;
            txtemail.Text = supplier.Mail;
            HelpClass.VisibleButton(btnSave, btnDelete, btnUpdate);
        }

        public override void Refresh()
        {
            HelpClass.Delete(txtID, txtcity, txtdecription, txtemail, txtname, txtphone, txtSearch);
            HelpClass.NotVisibleButton(btnSave, btnDelete, btnUpdate);
            dgwSuppliers.DataSource = null;
            dgwSuppliers.DataSource = CollaborationBLL.GetSuppliers();
            supplier = null;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text == "")
            {
                dgwSuppliers.DataSource = null;
                dgwSuppliers.DataSource = CollaborationBLL.GetSuppliers();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.All(char.IsDigit))
            {
                BO.Supplier obj = CollaborationBLL.GetSupplier(int.Parse(txtSearch.Text));
                DisplaySearchResult(obj);
            }
            else
            {
                BO.Supplier obj = CollaborationBLL.GetSupplier(txtSearch.Text);
                DisplaySearchResult(obj);
            }
        }

        private void DisplaySearchResult(BO.Supplier obj)
        {
            List<BO.Supplier> suppliers = null;
            if(HelperClass.DoesExists(obj,ref suppliers))
            {
                dgwSuppliers.DataSource = null;
                dgwSuppliers.DataSource = suppliers;
            }
        }
    }
}
