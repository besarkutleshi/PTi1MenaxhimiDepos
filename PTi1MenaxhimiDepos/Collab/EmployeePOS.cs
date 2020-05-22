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
using PTi1MenaxhimiDepos.BO;
using PTi1MenaxhimiDepos.BO.Employees;

namespace PTi1MenaxhimiDepos.Collab
{
    public partial class EmployeePOS : Form
    {
        BO.Employees.EmployeePOS emppos = null;
        public EmployeePOS()
        {
            InitializeComponent();
            this.cmbPos.DropDownListElement.DropDownWidth = 380;
            this.cmbEmployee.DropDownListElement.DropDownWidth = 380;
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cmbEmployee.SelectedIndex == -1 || cmbPos.SelectedIndex == -1 || txtDescription.Text == "")
            {
                MessageBox.Show("Please fill in empty box's");
            }
            else
            {
                if(emppos != null)
                {
                    BO.Employee emp = (BO.Employee)cmbEmployee.SelectedItem.DataBoundItem;
                    BO.PointofSale pos = (BO.PointofSale)cmbPos.SelectedItem.DataBoundItem;
                    emppos = new BO.Employees.EmployeePOS(int.Parse(txtID.Text), emp.ID, pos.ID, txtDescription.Text);
                    emppos.Username = HelpClass.CurrentUser.UserName;
                    if (CollaborationBLL.UpdateEmpPos(emppos.ID, emppos))
                    {
                        Refresh();
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(cmbEmployee.SelectedIndex == -1 || cmbPos.SelectedIndex == -1 || txtDescription.Text == "")
            {
                MessageBox.Show("Please fill in empty box's");
            }
            else
            {
                BO.Employees.EmployeePOS obj = new BO.Employees.EmployeePOS(0, (int)cmbEmployee.SelectedValue, (int)cmbPos.SelectedValue, txtDescription.Text);
                obj.Username = HelpClass.CurrentUser.UserName;
                if (CollaborationBLL.InsertEmployeePos(obj))
                {
                    Refresh();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            HelpClass.Delete(txtDescription,txtID);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(emppos != null)
            {
                if (CollaborationBLL.DeleteEmpPos(emppos.ID))
                {
                    Refresh();
                }
            }
        }

        private void EmployeePOS_Load(object sender, EventArgs e)
        {
            cmbEmployee.DataSource = CollaborationBLL.GetEmployees();cmbEmployee.DisplayMember = "Fullname";cmbEmployee.ValueMember = "ID";
            cmbPos.DataSource = PosBLL.GetPointofSales();cmbPos.DisplayMember = "Name";cmbPos.ValueMember = "ID";
            dgwEmpPos.DataSource = CollaborationBLL.GetEmployeePos();
        }

        public override void Refresh()
        {
            dgwEmpPos.DataSource = null;
            dgwEmpPos.DataSource = CollaborationBLL.GetEmployeePos();
            HelpClass.NotVisibleButton(btnSave, btnDelete, btnUpdate);
            HelpClass.Delete(txtDescription, txtID);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text == "")
            {
                dgwEmpPos.DataSource = null;
                dgwEmpPos.DataSource = CollaborationBLL.GetEmployeePos();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.All(char.IsDigit))
            {
                BO.Employees.EmployeePOS obj = CollaborationBLL.GetEmployeePos(int.Parse(txtSearch.Text));
                DisplaySearchResult(obj);
            }
            else
            {
                BO.Employees.EmployeePOS obj = CollaborationBLL.GetEmployeePos(txtSearch.Text);
                DisplaySearchResult(obj);
            }
        }

        private void DisplaySearchResult(BO.Employees.EmployeePOS obj)
        {
            List<BO.Employees.EmployeePOS> employeePOs = null;
            if(HelperClass.DoesExists(obj,ref employeePOs))
            {
                dgwEmpPos.DataSource = null;
                dgwEmpPos.DataSource = employeePOs;
            }
        }

        private void dgwEmpPos_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            emppos = (BO.Employees.EmployeePOS)dgwEmpPos.Rows[e.RowIndex].DataBoundItem;
            cmbEmployee.Text = emppos.Employee.Name;
            cmbPos.Text = emppos.POS.Name;
            txtID.Text = emppos.ID.ToString();
            txtDescription.Text = emppos.Description;
            HelpClass.VisibleButton(btnSave, btnDelete, btnUpdate);
        }

        private void EmployeePOS_FormClosing(object sender, FormClosingEventArgs e)
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
