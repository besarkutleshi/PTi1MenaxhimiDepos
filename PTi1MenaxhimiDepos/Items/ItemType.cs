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

namespace PTi1MenaxhimiDepos.Items
{
    public partial class ItemType : Form
    {
        public ItemType()
        {
            InitializeComponent();
        }

        private void ItemType_Load(object sender, EventArgs e)
        {
            List<PTi1MenaxhimiDepos.BO.ItemType> items = ItemBLL.GetItemTypes();
            LoadGrid(items);
        }

        public void LoadGrid(List<BO.ItemType> itemTypes)
        {
            dgwTypes.DataSource = ItemBLL.ReturnDt(itemTypes);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            PTi1MenaxhimiDepos.BO.ItemType itemtype = new BO.ItemType(0, txtname.Text, txtdescription.Text);
            itemtype.Username = "besarkutleshi";
            ItemBLL.InsertItemType(itemtype);
            LoadGrid(ItemBLL.GetItemTypes());
            txtdescription.Text = txtname.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.All(char.IsDigit))
            {
                BO.ItemType item = ItemBLL.GetItemType(int.Parse(txtSearch.Text));
                if(item == null)
                {
                    MessageBox.Show("Nothing To Show", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                else
                {
                    List<BO.ItemType> items = new List<BO.ItemType>();
                    items.Add(item);
                    LoadGrid(items);
                }
            }
            else
            {
                BO.ItemType item = ItemBLL.GetItemType(txtSearch.Text);
                if (item == null)
                {
                    MessageBox.Show("Nothing To Show", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                else
                {
                    List<BO.ItemType> items = new List<BO.ItemType>();
                    items.Add(item);
                    LoadGrid(items);
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text == "")
            {
                LoadGrid(ItemBLL.GetItemTypes());
            }
        }
    }
}
