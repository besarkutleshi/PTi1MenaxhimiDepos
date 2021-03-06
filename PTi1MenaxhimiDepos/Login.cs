﻿using PTi1MenaxhimiDepos.Administration;
using PTi1MenaxhimiDepos.BL;
using PTi1MenaxhimiDepos.Languages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTi1MenaxhimiDepos
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if(txtusername.Text == "" || txtpassword.Text == "")
            {
                MessageBox.Show("Please fill in empty boxs", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                HelpClass.CurrentUser = AdministrationBLL.Login(txtusername.Text.Trim(), Security.Encryptt(txtpassword.Text.Trim()));
                if(HelpClass.CurrentUser != null)
                {
                    if(HelpClass.CurrentUser.Role.Name == "Manager")
                    {
                        this.Close();
                    }
                    else if(HelpClass.CurrentUser.Role.Name == "SaleMan")
                    {
                        Sale.Sale sale = new Sale.Sale();
                        sale.ShowDialog();
                    }
                }
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtpassword.Text = "besar123";
            txtusername.Text = "besarkutleshi";
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            //ChangeLanguage("sq");
            TranslateFormMultipleResource.ChangeLanguages("sq");
            HelpClass.language = "sq";
        }
        private void radButton2_Click(object sender, EventArgs e)
        {
            TranslateFormMultipleResource.ChangeLanguages("en-US");
            HelpClass.language = "en-US";
        }
    }
}
