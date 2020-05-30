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

namespace PTi1MenaxhimiDepos.Administration
{
    public partial class RoleList : Form
    {
        BO.Role role = null;
        public RoleList()
        {
            InitializeComponent();
        }

        private void RoleList_Load(object sender, EventArgs e)
        {
            dgwRoles.DataSource = AdministrationBLL.GetRoles();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                dgwRoles.DataSource = null;
                dgwRoles.DataSource = AdministrationBLL.GetRoles();
            }
        }

        private void DisplaySearchResult(BO.Role obj)
        {
            List<BO.Role> roles = null;
            if (HelperClass.DoesExists(obj, ref roles))
            {
                dgwRoles.DataSource = null;
                dgwRoles.DataSource = roles;
            }
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.All(char.IsDigit))
            {
                BO.Role obj = AdministrationBLL.GetRole(int.Parse(txtSearch.Text));
                DisplaySearchResult(obj);
            }
            else
            {
                BO.Role obj = AdministrationBLL.GetRole(txtSearch.Text);
                DisplaySearchResult(obj);
            }
        }

        private void dgwRoles_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            this.role = (BO.Role)dgwRoles.Rows[e.RowIndex].DataBoundItem;
            Role role = new Role(this.role);
            role.ShowDialog();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            Role role = new Role();
            role.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgwRoles.DataSource = null;
            dgwRoles.DataSource = AdministrationBLL.GetRoles();
        }
    }
}
