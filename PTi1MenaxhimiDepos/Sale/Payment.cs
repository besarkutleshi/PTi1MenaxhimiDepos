using PTi1MenaxhimiDepos.BL;
using PTi1MenaxhimiDepos.BO.Invoices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTi1MenaxhimiDepos.Sale
{
    public partial class Payment : Form
    {
        string Totali= "";
        private  InvertoryHeader _invertoryheader = null;
        public static string Pay = "";
        public static string Back = "";
        public static bool Closed = false;
        public Payment()
        {
            InitializeComponent();
        }

        public Payment(string totali,InvertoryHeader invertoryHeader)
        {
            InitializeComponent();
            Totali = totali;
            _invertoryheader = invertoryHeader;
            _invertoryheader.Username = HelpClass.CurrentUser.UserName;
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            txtTotali.Text = Totali;
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            Closed = true;
            this.Close();
        }

        private void txtTotali_TextChanged(object sender, EventArgs e)
        {
            if(txtTotali.Text != "")
            {
                double pagoi = double.Parse(txtTotali.Text);
                double kthimi = pagoi - double.Parse(Totali);
                txtKthimi.Text = kthimi.ToString("0.00");
            }
            else
            {
                txtKthimi.Text = "-" + Totali;
            }
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            if(txtTotali.Text == "")
            {
                MessageBox.Show("Payment box is empty", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                if (InvoiceBLL.InsertPurchaseInvoice(_invertoryheader))
                {
                    Pay = txtTotali.Text;
                    Back = txtKthimi.Text;
                    this.Close();
                }
            }
        }
    }
}
