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
using Convert = PTi1MenaxhimiDepos.BL.Convert;

namespace PTi1MenaxhimiDepos
{
    public partial class RegisterItem : Form
    {
        public RegisterItem()
        {
            InitializeComponent();
        }

        private void RegisterItem_Load(object sender, EventArgs e)
        {
            cmbcategory.DataSource = ItemBLL.GetCategories();cmbcategory.DisplayMember = "Name";cmbcategory.ValueMember = "ID";
            cmbtype.DataSource = ItemBLL.GetItemTypes();cmbtype.DisplayMember = "Name"; cmbtype.ValueMember = "ID";
            cmbunit.DataSource = ItemBLL.GetItemUnits();cmbunit.DisplayMember = "Name"; cmbunit.ValueMember = "ID";
            LoadDataGrid();
        }

        private void LoadDataGrid()
        {
            List<Item> items = ItemBLL.GetItems();
            dgwItems.DataSource = ItemBLL.ConvertToDataTable(items);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtname.Text == "" || txtbarcode.Text == "" || txtstock.Text == "" || cmbActive.SelectedIndex == 0 || cmbcategory.SelectedIndex == 0 || cmbtype.SelectedIndex == 0
                || cmbunit.SelectedIndex == 0 || cmdSupplier.SelectedIndex == 0)
            {
                MessageBox.Show("Please Fill In Empty Box's", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }
            bool isAvtive = false;
            if(cmbActive.SelectedIndex == 0)
            {
                isAvtive = true;
            }
            else
            {
                isAvtive = false;
            }
            int a = (int)cmbunit.SelectedValue;
            Item obj = new Item(txtbarcode.Text, txtname.Text,(int)cmbunit.SelectedValue,(int)cmbcategory.SelectedValue,(int)cmbtype.SelectedValue,isAvtive,int.Parse(txtstock.Text),txtDescription.Text);
            if (ItemBLL.InsertItem(obj))
            {
                LoadDataGrid();
            }
        }
    }
}
