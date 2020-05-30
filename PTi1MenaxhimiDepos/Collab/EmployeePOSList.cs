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
    public partial class EmployeePOSList : Form
    {
        private BO.Employees.EmployeePOS emppos;

        public EmployeePOSList()
        {
            InitializeComponent();
        }

        private void btnInsertRole_Click(object sender, EventArgs e)
        {
            EmployeePOS employeePOS = new EmployeePOS();
            employeePOS.ShowDialog();   
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgwEmpPos.DataSource = null;
            dgwEmpPos.DataSource = CollaborationBLL.GetEmployeePos();
        }

        private void EmployeePOSList_Load(object sender, EventArgs e)
        {
            dgwEmpPos.DataSource = CollaborationBLL.GetEmployeePos();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
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
            if (HelperClass.DoesExists(obj, ref employeePOs))
            {
                dgwEmpPos.DataSource = null;
                dgwEmpPos.DataSource = employeePOs;
            }
        }

        private void dgwEmpPos_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            emppos = (BO.Employees.EmployeePOS)dgwEmpPos.Rows[e.RowIndex].DataBoundItem;
            EmployeePOS employeePOS = new EmployeePOS(emppos);
            employeePOS.ShowDialog();
        }
    }
}
