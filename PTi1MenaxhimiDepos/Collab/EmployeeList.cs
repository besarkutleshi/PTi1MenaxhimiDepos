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
    public partial class EmployeeList : Form
    {
        private BO.Employee employee;

        public EmployeeList()
        {
            InitializeComponent();
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
            if (txtSearch.Text == "")
            {
                dgwEmployees.DataSource = null;
                dgwEmployees.DataSource = CollaborationBLL.GetEmployees();
            }
        }

        private void EmployeeList_Load(object sender, EventArgs e)
        {
            dgwEmployees.DataSource = CollaborationBLL.GetEmployees();
        }

        private void btnInsertRole_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgwEmployees.DataSource = null;
            dgwEmployees.DataSource = CollaborationBLL.GetEmployees();
        }

        private void dgwEmployees_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            employee = (BO.Employee)dgwEmployees.Rows[e.RowIndex].DataBoundItem;
            Employee emp = new Employee(employee);
            emp.ShowDialog();
        }
    }
}
