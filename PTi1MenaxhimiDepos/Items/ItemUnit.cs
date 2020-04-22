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
    public partial class ItemUnit : Form
    {
        public ItemUnit()
        {
            InitializeComponent();
        }

        private void LoadGrid(List<BO.ItemUnit> itemUnits)
        {
            dgwTypes.DataSource = ItemBLL.ReturnDt(itemUnits);
        }
        private void ItemUnit_Load(object sender, EventArgs e)
        {
            LoadGrid(ItemBLL.GetItemUnits());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtname.Text == "" || txtdescription.Text == "")
            {
                MessageBox.Show("Please fill in empty box's", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                BO.ItemUnit unit = new BO.ItemUnit(0, txtname.Text, txtdescription.Text);
                unit.Username = "besarkutleshi";
                if (ItemBLL.InsertUnitType(unit))
                {
                    LoadGrid(ItemBLL.GetItemUnits());
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.All(char.IsDigit))
            {
                BO.ItemUnit unit = ItemBLL.GetUnit(int.Parse(txtSearch.Text));
                Search(unit);
            }
            else
            {
                BO.ItemUnit unit = ItemBLL.GetUnit(txtSearch.Text);
                Search(unit);
            }
        }

        private void Search(BO.ItemUnit unit)
        {
            if (unit == null)
            {
                MessageBox.Show("Nothing to show", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                List<BO.ItemUnit> units = new List<BO.ItemUnit>();
                units.Add(unit);
                LoadGrid(units);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text == "")
            {
                LoadGrid(ItemBLL.GetItemUnits());
            }
        }
    }
}
