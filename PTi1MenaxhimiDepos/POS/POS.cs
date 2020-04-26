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

namespace PTi1MenaxhimiDepos.POS
{
    public partial class POS : Form
    {
        BO.PointofSale obj = null;
        public POS()
        {
            InitializeComponent();
        }

        private void POS_Load(object sender, EventArgs e)
        {
            HelperClass.LoadGrid(PosBLL.GetPointofSales(), dgwPos);
        }

        private void dgwPos_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            obj = new BO.PointofSale(
                    int.Parse(HelpClass.GetValue(e,dgwPos,0)),
                    HelpClass.GetValue(e,dgwPos,1),
                    HelpClass.GetValue(e,dgwPos,2),
                    HelpClass.GetValue(e,dgwPos,3),
                    HelpClass.GetValue(e,dgwPos,4)
                );
            txtID.Text = obj.ID.ToString();txtName.Text = obj.Name;txtCity.Text = obj.City;txtDescription.Text = obj.Description;txtPhone.Text = obj.Phone.ToString();
            btnSave.Visible = false;btndelete.Visible = btnUpdate.Visible = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.All(char.IsDigit))
            {
                PointofSale obj = PosBLL.GetPointofSale(int.Parse(txtSearch.Text));
                obj.Username = "besarkutleshi";
                HelperClass.DoesExist(obj, dgwPos);
            }
            else
            {
                PointofSale obj = PosBLL.GetPointofSale(txtSearch.Text);
                obj.Username = "besarkutleshi";
                HelperClass.DoesExist(obj, dgwPos);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text == "")
            {
                HelperClass.LoadGrid(PosBLL.GetPointofSales(),dgwPos);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(obj.Name == txtName.Text && obj.Description == txtDescription.Text && txtPhone.Text == obj.Phone.ToString() && txtCity.Text == obj.City)
            {
                MessageBox.Show("You do not change anything", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                obj = new PointofSale(int.Parse(txtID.Text), txtName.Text, txtCity.Text, txtPhone.Text, txtDescription.Text);
                obj.Username = "besarkutleshi";
                if (PosBLL.UpdatePos(obj.ID, obj))
                {
                    HelperClass.LoadGrid(PosBLL.GetPointofSales(), dgwPos);
                    HelpClass.OnChange(btnSave, btndelete, btnUpdate, txtCity, txtDescription, txtName, txtPhone, txtID);
                }
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure","Error",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (PosBLL.DeletePos(int.Parse(txtID.Text)))
                {
                    HelperClass.LoadGrid(PosBLL.GetPointofSales(), dgwPos);
                    HelpClass.OnChange(btnSave, btndelete, btnUpdate, txtCity, txtDescription, txtName, txtPhone, txtID);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtName.Text == "" || txtCity.Text == "" || txtDescription.Text == "" || txtCity.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("Please fill in empty box's", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                BO.PointofSale obj = new PointofSale(0, txtName.Text, txtCity.Text, txtPhone.Text, txtDescription.Text);
                obj.Username = "besarkutleshi";
                if (PosBLL.InsertPos(obj))
                {
                    HelperClass.LoadGrid(PosBLL.GetPointofSales(), dgwPos);
                    HelpClass.OnChange(btnSave, btndelete, btnUpdate, txtCity, txtDescription, txtName, txtPhone, txtID);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            HelpClass.OnChange(btnSave, btndelete, btnUpdate, txtCity, txtDescription, txtName, txtPhone, txtID);
        }
    }
}
