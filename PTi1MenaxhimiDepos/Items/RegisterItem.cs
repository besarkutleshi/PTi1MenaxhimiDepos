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
            cmdSupplier.DataSource = CollaborationBLL.GetSuppliers(); cmdSupplier.DisplayMember = "Name";cmdSupplier.ValueMember = "ID";
            cmbActive.SelectedIndex = 0;
            HelperClass.LoadGrid(ItemBLL.GetItems(),dgwItems);
            dgwItems.TableElement.SearchHighlightColor = Color.LightBlue;
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
                obj.Username = HelpClass.CurrentUser.UserName;
                if (ItemBLL.InsertItem(obj))
                {
                    HelperClass.LoadGrid(ItemBLL.GetItems(), dgwItems);
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
                HelperClass.LoadGrid(ItemBLL.GetItems(),dgwItems);
            }
        }

        private void dgwItems_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            ID = int.Parse(HelpClass.GetValue(e, dgwItems, 0));
            txtid.Text = ID.ToString();
            Barcode = HelpClass.GetValue(e, dgwItems, 1);
            txtbarcode.Text = HelpClass.GetValue(e, dgwItems, 1);
            txtname.Text = HelpClass.GetValue(e, dgwItems, 2);
            cmbunit.Text = HelpClass.GetValue(e, dgwItems, 3);
            cmbcategory.Text = HelpClass.GetValue(e, dgwItems, 4);
            cmbtype.Text = HelpClass.GetValue(e, dgwItems, 5);
            cmdSupplier.Text = HelpClass.GetValue(e, dgwItems, 6);
            cmbActive.SelectedIndex = 0;
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
                    List<BO.ItemUnit> units = (List<BO.ItemUnit>)cmbunit.DataSource;
                    List<BO.ItemCategory> categories = (List<BO.ItemCategory>)cmbcategory.DataSource;
                    List<BO.ItemType> type = (List<BO.ItemType>)cmbtype.DataSource;
                    List<BO.Supplier> supplier = (List<BO.Supplier>)cmdSupplier.DataSource;
                    int unitid = units.Where(u => u.Name == cmbunit.Text).Select(u => u.ID).FirstOrDefault();
                    int categoryid = categories.Where(c => c.Name == cmbcategory.Text).Select(c => c.ID).FirstOrDefault();
                    int typeid = type.Where(t => t.Name == cmbtype.Text).Select(t => t.ID).FirstOrDefault();
                    int supplierid = supplier.Where(s => s.Name == cmdSupplier.Text).Select(s => s.ID).FirstOrDefault();
                    Item obj = new Item(ID, txtbarcode.Text, txtname.Text, unitid, categoryid, typeid, supplierid, IsActive(), int.Parse(txtstock.Text), txtDescription.Text);
                    obj.Username = HelpClass.CurrentUser.UserName;
                    if (ItemBLL.UpdateItem(ID,obj))
                    {
                        HelpClass.VisibleButton(btnSave, btnDelete, btnUpdate, txtbarcode, txtname, txtDescription, txtstock);
                        HelperClass.LoadGrid(ItemBLL.GetItems(), dgwItems);
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
                    HelpClass.VisibleButton(btnSave, btnDelete, btnUpdate, txtbarcode, txtname, txtDescription, txtstock);
                    HelperClass.LoadGrid(ItemBLL.GetItems(), dgwItems);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            HelpClass.VisibleButton(btnSave, btnDelete, btnUpdate, txtbarcode, txtname, txtDescription, txtstock);
        }
    }
}
