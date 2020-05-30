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
    public partial class MonthProfits : Form
    {
        public MonthProfits()
        {
            InitializeComponent();
        }

        private void MonthProfits_Load(object sender, EventArgs e)
        {
            dgwMonthProfits.DataSource = EntriesExitsBL.GetMonthProfits();
        }
    }
}
