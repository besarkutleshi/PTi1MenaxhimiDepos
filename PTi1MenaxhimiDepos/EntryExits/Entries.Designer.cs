namespace PTi1MenaxhimiDepos.EntryExits
{
    partial class Entries
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.CartesianArea cartesianArea3 = new Telerik.WinControls.UI.CartesianArea();
            Telerik.WinControls.UI.CartesianArea cartesianArea1 = new Telerik.WinControls.UI.CartesianArea();
            Telerik.WinControls.UI.CartesianArea cartesianArea4 = new Telerik.WinControls.UI.CartesianArea();
            this.chartMonths = new Telerik.WinControls.UI.RadChartView();
            this.chartWeek = new Telerik.WinControls.UI.RadChartView();
            this.radChartView1 = new Telerik.WinControls.UI.RadChartView();
            this.radDateTimePicker1 = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.chartMonths)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartWeek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartMonths
            // 
            this.chartMonths.AreaDesign = cartesianArea3;
            this.chartMonths.Location = new System.Drawing.Point(12, 677);
            this.chartMonths.Name = "chartMonths";
            this.chartMonths.ShowGrid = false;
            this.chartMonths.ShowLegend = true;
            this.chartMonths.ShowPanZoom = true;
            this.chartMonths.ShowTitle = true;
            this.chartMonths.ShowToolTip = true;
            this.chartMonths.ShowTrackBall = true;
            this.chartMonths.Size = new System.Drawing.Size(977, 282);
            this.chartMonths.TabIndex = 0;
            // 
            // chartWeek
            // 
            this.chartWeek.AreaDesign = cartesianArea1;
            this.chartWeek.Location = new System.Drawing.Point(12, 372);
            this.chartWeek.Name = "chartWeek";
            this.chartWeek.ShowGrid = false;
            this.chartWeek.ShowLegend = true;
            this.chartWeek.ShowPanZoom = true;
            this.chartWeek.ShowTitle = true;
            this.chartWeek.ShowToolTip = true;
            this.chartWeek.ShowTrackBall = true;
            this.chartWeek.Size = new System.Drawing.Size(977, 282);
            this.chartWeek.TabIndex = 0;
            // 
            // radChartView1
            // 
            this.radChartView1.AreaDesign = cartesianArea4;
            this.radChartView1.Location = new System.Drawing.Point(12, 60);
            this.radChartView1.Name = "radChartView1";
            this.radChartView1.ShowGrid = false;
            this.radChartView1.ShowLegend = true;
            this.radChartView1.ShowPanZoom = true;
            this.radChartView1.ShowTitle = true;
            this.radChartView1.ShowToolTip = true;
            this.radChartView1.ShowTrackBall = true;
            this.radChartView1.Size = new System.Drawing.Size(977, 282);
            this.radChartView1.TabIndex = 0;
            // 
            // radDateTimePicker1
            // 
            this.radDateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 15.25F);
            this.radDateTimePicker1.Location = new System.Drawing.Point(13, 13);
            this.radDateTimePicker1.Name = "radDateTimePicker1";
            this.radDateTimePicker1.Size = new System.Drawing.Size(358, 33);
            this.radDateTimePicker1.TabIndex = 1;
            this.radDateTimePicker1.TabStop = false;
            this.radDateTimePicker1.Text = "Wednesday, May 27, 2020";
            this.radDateTimePicker1.Value = new System.DateTime(2020, 5, 27, 16, 14, 47, 268);
            // 
            // radButton1
            // 
            this.radButton1.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.radButton1.Location = new System.Drawing.Point(377, 14);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(106, 40);
            this.radButton1.TabIndex = 2;
            this.radButton1.Text = "Check";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // Entries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1752, 971);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.radDateTimePicker1);
            this.Controls.Add(this.radChartView1);
            this.Controls.Add(this.chartWeek);
            this.Controls.Add(this.chartMonths);
            this.Name = "Entries";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entries";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Entries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartMonths)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartWeek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadChartView chartMonths;
        private Telerik.WinControls.UI.RadChartView chartWeek;
        private Telerik.WinControls.UI.RadChartView radChartView1;
        private Telerik.WinControls.UI.RadDateTimePicker radDateTimePicker1;
        private Telerik.WinControls.UI.RadButton radButton1;
    }
}