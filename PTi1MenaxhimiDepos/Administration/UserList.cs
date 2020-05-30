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
    public partial class UserList : Form
    {
        private BO.Account.User obj;

        public UserList()
        {
            InitializeComponent();
        }

        private void UserList_Load(object sender, EventArgs e)
        {
            dgwUser.DataSource = AdministrationBLL.GetUsers();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                dgwUser.DataSource = null;
                dgwUser.DataSource = AdministrationBLL.GetUsers();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.All(char.IsDigit))
            {
                BO.Account.User obj = AdministrationBLL.GetUser(int.Parse(txtSearch.Text));
                DisplaySearchResult(obj);
            }
            else
            {
                BO.Account.User obj = AdministrationBLL.GetUser(txtSearch.Text);
                DisplaySearchResult(obj);
            }
        }

        private void DisplaySearchResult(BO.Account.User obj)
        {
            List<BO.Account.User> users = null;
            if (HelperClass.DoesExists(obj, ref users))
            {
                dgwUser.DataSource = null;
                dgwUser.DataSource = users;
            }
        }

        private void dgwUser_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            obj = (BO.Account.User)dgwUser.Rows[e.RowIndex].DataBoundItem;
            User user = new User(obj);
            user.ShowDialog();
        }

        private void btnInsertRole_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgwUser.DataSource = null;
            dgwUser.DataSource = AdministrationBLL.GetUsers();
        }
    }
}
