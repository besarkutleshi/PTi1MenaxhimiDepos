namespace PTi1MenaxhimiDepos.EntryExits
{
    partial class MonthProfits
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.dgwMonthProfits = new Telerik.WinControls.UI.RadGridView();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMonthProfits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMonthProfits.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwMonthProfits
            // 
            this.dgwMonthProfits.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.dgwMonthProfits.Location = new System.Drawing.Point(12, 53);
            // 
            // 
            // 
            this.dgwMonthProfits.MasterTemplate.AllowAddNewRow = false;
            this.dgwMonthProfits.MasterTemplate.AllowEditRow = false;
            this.dgwMonthProfits.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "Month";
            gridViewTextBoxColumn1.HeaderText = "Month";
            gridViewTextBoxColumn1.Name = "Month";
            gridViewTextBoxColumn1.Width = 541;
            gridViewTextBoxColumn2.FieldName = "Profit";
            gridViewTextBoxColumn2.HeaderText = "Profit";
            gridViewTextBoxColumn2.Name = "Profit";
            gridViewTextBoxColumn2.Width = 541;
            this.dgwMonthProfits.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2});
            this.dgwMonthProfits.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dgwMonthProfits.Name = "dgwMonthProfits";
            this.dgwMonthProfits.Size = new System.Drawing.Size(1102, 672);
            this.dgwMonthProfits.TabIndex = 0;
            // 
            // radButton1
            // 
            this.radButton1.Font = new System.Drawing.Font("Segoe UI", 15.25F);
            this.radButton1.Image = global::PTi1MenaxhimiDepos.Properties.Resources.exel;
            this.radButton1.Location = new System.Drawing.Point(12, 12);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(183, 35);
            this.radButton1.TabIndex = 4;
            this.radButton1.Text = "Export To Exel";
            this.radButton1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MonthProfits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 737);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.dgwMonthProfits);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MonthProfits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MonthProfits";
            this.Load += new System.EventHandler(this.MonthProfits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMonthProfits.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMonthProfits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView dgwMonthProfits;
        private Telerik.WinControls.UI.RadButton radButton1;
    }
}