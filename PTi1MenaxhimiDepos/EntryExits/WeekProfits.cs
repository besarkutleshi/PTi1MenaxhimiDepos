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
    public partial class WeekProfits : Form
    {
        public WeekProfits()
        {
            InitializeComponent();
        }

        private void WeekProfits_Load(object sender, EventArgs e)
        {
            dgwWeekProfits.DataSource = EntriesExitsBL.GetWeekProfits();
        }
    }
}
