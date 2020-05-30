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
using Telerik.WinControls.UI;

namespace PTi1MenaxhimiDepos.EntryExits
{
    public partial class Entries : Form
    {
        public Entries()
        {
            InitializeComponent();
        }

        private void Entries_Load(object sender, EventArgs e)
        {
            FillChart(ref chartMonths, "Month", "Profit", EntriesExitsBL.GetMonthProfits());
            FillChart(ref chartWeek, "Day", "Profit", EntriesExitsBL.GetWeekProfits());
        }

        private void FillChart<T>(ref RadChartView radChart,string category,string value,IEnumerable<T> data)
        {
            BarSeries lineSeries = new BarSeries();
            lineSeries.CategoryMember = category;
            lineSeries.ValueMember = value;
            lineSeries.DataSource = data;
            radChart.LegendTitle = "Sales";
            radChart.Series.Add(lineSeries);
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            string a = radDateTimePicker1.Text;
        }
    } 
}
