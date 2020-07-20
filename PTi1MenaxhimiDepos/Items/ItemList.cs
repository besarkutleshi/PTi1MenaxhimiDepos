using PTi1MenaxhimiDepos.BL;
using PTi1MenaxhimiDepos.BO;
using PTi1MenaxhimiDepos.Languages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTi1MenaxhimiDepos.Items
{
    public partial class ItemList : Form
    {
        private Item item;

        public ItemList()
        {
            InitializeComponent();
        }

        private void btnInsertRole_Click(object sender, EventArgs e)
        {
            RegisterItem obj = new RegisterItem();
            obj.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgwItems.DataSource = null;
            dgwItems.DataSource = ItemBLL.GetItems();
        }

        private void dgwItems_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            item = (BO.Item)dgwItems.Rows[e.RowIndex].DataBoundItem;
            RegisterItem obj = new RegisterItem(item);
            obj.ShowDialog();
        }

        private void ItemList_Load(object sender, EventArgs e)
        {
            dgwItems.DataSource = ItemBLL.GetItems();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
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
            if (HelperClass.DoesExists(obj, ref items))
            {
                dgwItems.DataSource = null;
                dgwItems.DataSource = items;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                dgwItems.DataSource = null;
                dgwItems.DataSource = ItemBLL.GetItems();
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helpsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpClass.ShowHelp(this, "Regjistrimi-i-Produkteve.html");
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TranslateFormMultipleResource.ChangeLanguages("en-US");
            dgwItems.Columns[0].HeaderText = "ID";
            dgwItems.Columns[1].HeaderText = "Barcode";
            dgwItems.Columns[2].HeaderText = "Name";
            dgwItems.Columns[3].HeaderText = "Unit";
            dgwItems.Columns[4].HeaderText = "Category";
            dgwItems.Columns[5].HeaderText = "Type";
            dgwItems.Columns[6].HeaderText = "Supplier";
            dgwItems.Columns[7].HeaderText = "Active";
            dgwItems.Columns[8].HeaderText = "Stock Quantity";
            dgwItems.Columns[9].HeaderText = "Description";
        }

        private void albaniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TranslateFormMultipleResource.ChangeLanguages("sq");
            dgwItems.Columns[0].HeaderText = "ID";
            dgwItems.Columns[1].HeaderText = "Barkodi";
            dgwItems.Columns[2].HeaderText = "Emri";
            dgwItems.Columns[3].HeaderText = "Njeisa";
            dgwItems.Columns[4].HeaderText = "Kategoria";
            dgwItems.Columns[5].HeaderText = "Lloji";
            dgwItems.Columns[6].HeaderText = "Funitori";
            dgwItems.Columns[7].HeaderText = "Aktiv";
            dgwItems.Columns[8].HeaderText = "Sasia";
            dgwItems.Columns[9].HeaderText = "Pershkrimi";
        }
    }
}
