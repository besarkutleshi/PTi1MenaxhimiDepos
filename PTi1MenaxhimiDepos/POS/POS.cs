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

        public POS(PointofSale obj)
        {
            InitializeComponent();
            this.obj = obj;
            txtID.Text = obj.ID.ToString(); txtName.Text = obj.Name; txtCity.Text = obj.City; txtDescription.Text = obj.Description; txtPhone.Text = obj.Phone.ToString();
            HelpClass.VisibleButton(btnSave, btndelete, btnUpdate);
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
                    Refresh();
                }
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure","Error",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (PosBLL.DeletePos(int.Parse(txtID.Text)))
                {
                    Refresh();
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
                    Refresh();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            HelpClass.NotVisibleButton(btnSave, btndelete, btnUpdate);
            HelpClass.Delete(txtCity, txtDescription, txtID, txtName, txtPhone);
        }

        private void POS_FormClosing(object sender, FormClosingEventArgs e)
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

        private void POS_Load(object sender, EventArgs e)
        {

        }
    }
}
