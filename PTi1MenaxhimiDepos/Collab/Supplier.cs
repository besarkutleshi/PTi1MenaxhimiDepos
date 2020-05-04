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

        private void btnRuaj_Click(object sender, EventArgs e)
        {
            if (txtFurnitori.Text == "")
            {
                MessageBox.Show("Please fill in Furnitorin box's", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                BO.Supplier supplier = new BO.Supplier(0, txtFurnitori.Text, txtPershkrimi.Text, txtQyteti.Text, txtPhone.Text, txtEmail.Text);
                supplier.Username = HelpClass.CurrentUser.Username;
                if (CollaborationBLL.InsertSupplier(supplier))
                {
                    HelperClass.LoadGrid(CollaborationBLL.GetSuppliers(), dgvParaqitja);
                    HelpClass.OnChange(btnRuaj, btnFshij, btnEdito, txtFurnitori, txtPershkrimi, txtId);
                }

            }
        }

        private void btnKerkoFurnitorin_Click(object sender, EventArgs e)
        {
            if (txtkerkoFurnitor.Text != "")
            {
                BO.Supplier supplier = CollaborationBLL.GetSupplier(txtkerkoFurnitor.Text);
                HelperClass.DoesExist(supplier, dgvParaqitja);
            }
        }

        private void txtkerkoFurnitor_TextChanged(object sender, EventArgs e)
        {

            if (txtkerkoFurnitor.Text == "")
            {
                HelperClass.LoadGrid(CollaborationBLL.GetSuppliers(), dgvParaqitja);
            }
        }

        private void btnFshij_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure", "Sure", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (CollaborationBLL.DeleteSupplier(supplier.ID));
                {
                    HelpClass.OnChange(btnRuaj, btnFshij, btnEdito, txtFurnitori, txtPershkrimi, txtId);
                    HelperClass.LoadGrid(CollaborationBLL.GetSuppliers(),dgvParaqitja);
                }
            }
        }

        private void btnEdito_Click(object sender, EventArgs e)
        {
            if (supplier.Name == txtFurnitori.Text)
            {
                MessageBox.Show("You do not change anything", "Not Change", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
            else
            {
                supplier.Name = txtFurnitori.Text;
                supplier.Username = HelpClass.CurrentUser.UserName;
                if (MessageBox.Show("Are you sure", "Sure", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (CollaborationBLL.UpdateSupplier(supplier.ID, supplier))
                    {
                        HelpClass.OnChange(btnRuaj, btnFshij, btnEdito, txtFurnitori, txtPershkrimi, txtId);
                        HelperClass.LoadGrid(CollaborationBLL.GetSuppliers(), dgvParaqitja);
                    }
                }
            }
        }
    }
}
