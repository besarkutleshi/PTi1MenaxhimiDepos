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
        BO.Item item = null;
        public RegisterItem()
        {
            InitializeComponent();
            this.cmbActive.DropDownListElement.DropDownWidth = 380;
            this.cmbcategory.DropDownListElement.DropDownWidth = 380;
            this.cmbtype.DropDownListElement.DropDownWidth = 380;
            this.cmbunit.DropDownListElement.DropDownWidth = 380;
            this.cmdSupplier.DropDownListElement.DropDownWidth = 380;
        }

        private void RegisterItem_Load(object sender, EventArgs e)
        {
            cmbcategory.DataSource = ItemBLL.GetCategories();
            cmbcategory.DisplayMember = "Name";
            cmbcategory.ValueMember = "ID";
            cmbtype.DataSource = ItemBLL.GetItemTypes();cmbtype.DisplayMember = "Name"; cmbtype.ValueMember = "ID";
            cmbunit.DataSource = ItemBLL.GetItemUnits();cmbunit.DisplayMember = "Name"; cmbunit.ValueMember = "ID";
            cmdSupplier.DataSource = CollaborationBLL.GetSuppliers(); cmdSupplier.DisplayMember = "Name";cmdSupplier.ValueMember = "ID";
            cmbActive.SelectedIndex = 0;
            dgwItems.DataSource = ItemBLL.GetItems();
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
                    Refresh();
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
                    DisplaySearchResult(item);
                }
                else
                {
                    BO.Item item = ItemBLL.GetItemByName(txtSearch.Text);
                    DisplaySearchResult(item);
                }
            }
            else
            {
                MessageBox.Show("Search box is empty", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void DisplaySearchResult(BO.Item obj)
        {
            List<BO.Item> items = null;
            if(HelperClass.DoesExists(obj,ref items))
            {
                dgwItems.DataSource = null;
                dgwItems.DataSource = items;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text == "")
            {
                dgwItems.DataSource = null;
                dgwItems.DataSource = ItemBLL.GetItems();
            }
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
                    item = new Item(ID, txtbarcode.Text, txtname.Text, unitid, categoryid, typeid, supplierid, IsActive(), int.Parse(txtstock.Text), txtDescription.Text);
                    item.Username = HelpClass.CurrentUser.UserName;
                    if (ItemBLL.UpdateItem(ID, item))
                    {
                        Refresh();
                    }
                    supplier = null;
                    units = null;
                    categories = null;
                    type = null;
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
                    Refresh();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            HelpClass.NotVisibleButton(btnSave, btnDelete, btnUpdate);
            HelpClass.Delete(txtbarcode, txtname, txtDescription, txtstock);
        }

        public override void Refresh()
        {
            HelpClass.NotVisibleButton(btnSave, btnDelete, btnUpdate);
            HelpClass.Delete(txtbarcode, txtname, txtDescription, txtstock);
            dgwItems.DataSource = null;
            dgwItems.DataSource = ItemBLL.GetItems();
            item = null;
        }

        private void dgwItems_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            item = (BO.Item)dgwItems.Rows[e.RowIndex].DataBoundItem;
            ID = item.ID;
            txtid.Text = ID.ToString();
            Barcode = item.Barcode;
            txtbarcode.Text = item.Barcode;
            txtname.Text = item.Name;
            cmbunit.Text = item.Unit.Name;
            cmbcategory.Text = item.Category.Name;
            cmbtype.Text = item.Type.Name;
            cmdSupplier.Text = item.Supplier.Name;
            cmbActive.SelectedIndex = 0;
            txtstock.Text = item.StockQuantity.ToString();
            txtDescription.Text = item.Description;
            HelpClass.VisibleButton(btnSave, btnDelete, btnUpdate);
        }

        private void RegisterItem_FormClosing(object sender, FormClosingEventArgs e)
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
