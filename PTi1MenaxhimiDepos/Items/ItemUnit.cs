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
        private void ItemUnit_Load(object sender, EventArgs e)
        {
            HelperClass.LoadGrid(ItemBLL.GetItemUnits(), dgwTypes);
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
                    HelperClass.LoadGrid(ItemBLL.GetItemUnits(),dgwTypes);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.All(char.IsDigit))
            {
                BO.ItemUnit unit = ItemBLL.GetUnit(int.Parse(txtSearch.Text));
                HelperClass.DoesExist(unit, dgwTypes);
            }
            else
            {
                BO.ItemUnit unit = ItemBLL.GetUnit(txtSearch.Text);
                HelperClass.DoesExist(unit, dgwTypes);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text == "")
            {
                HelperClass.LoadGrid(ItemBLL.GetItemUnits(),dgwTypes);
            }
        }
    }
}
