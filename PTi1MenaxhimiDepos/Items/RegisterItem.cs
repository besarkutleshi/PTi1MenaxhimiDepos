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
            LoadDataGrid(ItemBLL.GetItems());
        }

        private void LoadDataGrid(List<Item> items)
        {
            dgwItems.DataSource = ItemBLL.ConvertToDataTableItems(items);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtname.Text == "" || txtbarcode.Text == "" || txtstock.Text == "" || cmbActive.SelectedIndex == -1 || cmbcategory.SelectedIndex == -1 || cmbtype.SelectedIndex == -1
                || cmbunit.SelectedIndex == -1 || cmdSupplier.SelectedIndex == -1)
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
                LoadDataGrid(ItemBLL.GetItems());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text != "")
            {
                if (txtSearch.Text.All(char.IsDigit))
                {
                    BO.Item item = ItemBLL.GetItem(int.Parse(txtSearch.Text));
                    if(item == null)
                    {
                        MessageBox.Show("Nothing to show", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    }
                    else
                    {
                        List<BO.Item> items = new List<Item>();
                        items.Add(item);
                        LoadDataGrid(items);
                    }
                }
                else
                {
                    BO.Item item = ItemBLL.GetItemByName(txtSearch.Text);
                    if (item == null)
                    {
                        MessageBox.Show("Nothing to show", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    }
                    else
                    {
                        List<BO.Item> items = new List<Item>();
                        items.Add(item);
                        LoadDataGrid(items);
                    }
                }
            }
            else
            {
                MessageBox.Show("Search box is empty", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text == "")
            {
                LoadDataGrid(ItemBLL.GetItems());
            }
        }
    }
}
