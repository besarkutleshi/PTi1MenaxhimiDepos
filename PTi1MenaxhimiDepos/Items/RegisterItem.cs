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
        string Barcode = null;
        int ID = 0;
        public RegisterItem()
        {
            InitializeComponent();
        }

        private void RegisterItem_Load(object sender, EventArgs e)
        {
            cmbcategory.DataSource = ItemBLL.GetCategories();cmbcategory.DisplayMember = "Name";cmbcategory.ValueMember = "ID";
            cmbtype.DataSource = ItemBLL.GetItemTypes();cmbtype.DisplayMember = "Name"; cmbtype.ValueMember = "ID";
            cmbunit.DataSource = ItemBLL.GetItemUnits();cmbunit.DisplayMember = "Name"; cmbunit.ValueMember = "ID";
            cmdSupplier.DataSource = Collaboration.GetSuppliers(); cmdSupplier.DisplayMember = "Name";cmdSupplier.ValueMember = "ID";
            cmbActive.SelectedIndex = 0;
            HelperClass.LoadGridItem(ItemBLL.GetItems(),dgwItems);
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtname.Text == "" || txtbarcode.Text == "" || txtstock.Text == "" || cmbActive.SelectedIndex == -1 || cmbcategory.SelectedIndex == -1 || cmbtype.SelectedIndex == -1
                || cmbunit.SelectedIndex == -1 || cmdSupplier.SelectedIndex == -1)
            {
                MessageBox.Show("Please Fill In Empty Box's", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                Item obj = new Item(0,txtbarcode.Text, txtname.Text, (int)cmbunit.SelectedValue, (int)cmbcategory.SelectedValue, (int)cmbtype.SelectedValue, (int)cmdSupplier.SelectedValue,IsActive(), int.Parse(txtstock.Text), txtDescription.Text);
                if (ItemBLL.InsertItem(obj))
                {
                    HelperClass.LoadGridItem(ItemBLL.GetItems(), dgwItems);
                    txtbarcode.Text = txtDescription.Text = txtname.Text = txtSearch.Text = txtstock.Text = "";
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text != "")
            {
                if (txtSearch.Text.All(char.IsDigit))
                {
                    BO.Item item = ItemBLL.GetItem(int.Parse(txtSearch.Text));
                    HelperClass.DoesExist(item, dgwItems);
                }
                else
                {
                    BO.Item item = ItemBLL.GetItemByName(txtSearch.Text);
                    HelperClass.DoesExist(item, dgwItems);
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
                HelperClass.LoadGridItem(ItemBLL.GetItems(),dgwItems);
            }
        }

        private void dgwItems_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            ID = int.Parse(HelpClass.GetValue(e, dgwItems, 0));
            txtid.Text = ID.ToString();
            Barcode = HelpClass.GetValue(e, dgwItems, 1);
            txtbarcode.Text = HelpClass.GetValue(e, dgwItems, 1);
            txtname.Text = HelpClass.GetValue(e, dgwItems, 2);
            cmbunit.SelectedIndex = -1;
            cmbcategory.SelectedIndex = -1;
            cmbtype.SelectedIndex = -1;
            cmdSupplier.SelectedIndex = -1;
            cmbActive.SelectedIndex = -1;
            txtstock.Text = HelpClass.GetValue(e, dgwItems, 8);
            txtDescription.Text = HelpClass.GetValue(e, dgwItems, 9);
            btnDelete.Visible = btnUpdate.Visible = true; btnSave.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtname.Text == "" || txtbarcode.Text == "" || txtstock.Text == "" || cmbActive.SelectedIndex == -1 || cmbcategory.SelectedIndex == -1 || cmbtype.SelectedIndex == -1
                || cmbunit.SelectedIndex == -1 || cmdSupplier.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Fill In Empty Box's", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                else
                {
                    Item obj = new Item(ID, txtbarcode.Text, txtname.Text, (int)cmbunit.SelectedValue, (int)cmbcategory.SelectedValue, (int)cmbtype.SelectedValue, (int)cmdSupplier.SelectedValue, IsActive(), int.Parse(txtstock.Text), txtDescription.Text);
                    if (ItemBLL.UpdateItem(ID,obj))
                    {
                        HelpClass.OnChange(btnSave, btnDelete, btnUpdate, txtbarcode, txtname, txtDescription, txtstock);
                        HelperClass.LoadGridItem(ItemBLL.GetItems(), dgwItems);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private bool IsActive()
        {
            if (cmbActive.SelectedIndex == 0)
                return true;
            else
                return false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure","Sure",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (ItemBLL.DeleteItem(Barcode))
                {
                    HelpClass.OnChange(btnSave, btnDelete, btnUpdate, txtbarcode, txtname, txtDescription, txtstock);
                    HelperClass.LoadGridItem(ItemBLL.GetItems(), dgwItems);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            HelpClass.OnChange(btnSave, btnDelete, btnUpdate, txtbarcode, txtname, txtDescription, txtstock);
        }
    }
}
