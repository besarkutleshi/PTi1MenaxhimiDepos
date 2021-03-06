﻿using PTi1MenaxhimiDepos.BL;
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
using Telerik.WinControls.UI;

namespace PTi1MenaxhimiDepos.Items
{
    public partial class ItemType : Form
    {
        BO.ItemType type = null;
        public ItemType()
        {
            InitializeComponent();
        }

        public ItemType(BO.ItemType type)
        {
            InitializeComponent();
            this.type = type;
            txtid.Text = type.ID.ToString();
            txtname.Text = type.Name;
            txtdescription.Text = type.Description;
            HelpClass.VisibleButton(btnSave, btndelete, btnUpdate);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            PTi1MenaxhimiDepos.BO.ItemType itemtype = new BO.ItemType(0, txtname.Text, txtdescription.Text);
            itemtype.Username = HelpClass.CurrentUser.UserName;
            if (ItemBLL.InsertItemType(itemtype))
            {
                Refresh();
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (type.Name == txtname.Text && type.Description == txtdescription.Text)
            {
                MessageBox.Show("You do not change anything", "Not Change", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                type = new BO.ItemType(int.Parse(txtid.Text), txtname.Text, txtdescription.Text);
                type.Username = HelpClass.CurrentUser.UserName;
                if (MessageBox.Show("Are you sure", "Sure", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (ItemBLL.UpdateItemType(type.ID, type))
                    {
                        Refresh();
                    }
                }
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure", "Sure", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (ItemBLL.DeleteItemType(type.ID))
                {
                    Refresh();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            HelpClass.NotVisibleButton(btnSave, btndelete, btnUpdate);
            HelpClass.Delete(txtname, txtdescription, txtid);
        }

        private void ItemType_FormClosing(object sender, FormClosingEventArgs e)
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
