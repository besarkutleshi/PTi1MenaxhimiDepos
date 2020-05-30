using PTi1MenaxhimiDepos.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTi1MenaxhimiDepos.EntryExits
{
    public partial class ListBodies : Form
    {
        private int _invertoryID;
        public ListBodies()
        {
            InitializeComponent();
        }

        public ListBodies(int invertoryID)
        {
            InitializeComponent();
            _invertoryID = invertoryID;
        }

        private void ListBodies_Load(object sender, EventArgs e)
        {
            if(_invertoryID != 0)
            {
                dgwBodies.DataSource = InvoiceBLL.GetInvertoryBodiesByHeader(_invertoryID);
            }
        }
    }
}
