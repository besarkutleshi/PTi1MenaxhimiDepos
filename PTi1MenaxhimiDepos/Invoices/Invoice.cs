using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTi1MenaxhimiDepos.Invoices
{
    public partial class Invoice : Form
    {
        int counter = 0;
        public Invoice()
        {
            InitializeComponent();
        }

        private void radGridView1_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            counter++;
            if(counter == 1)
            {
                // paraqit artikujt brenda fatures se klikuar
            }
            else if(counter == 2)
            {
                // paraqit te dhenat e artikujve ne textboxa per faturen e klikuar
            }
        }
    }
}
