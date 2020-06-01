namespace PTi1MenaxhimiDepos.EntryExits
{
    partial class MonthExits
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
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.dgwMonthProfits = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMonthProfits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMonthProfits.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // radButton1
            // 
            this.radButton1.Font = new System.Drawing.Font("Segoe UI", 15.25F);
            this.radButton1.Image = global::PTi1MenaxhimiDepos.Properties.Resources.exel;
            this.radButton1.Location = new System.Drawing.Point(12, 12);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(183, 35);
            this.radButton1.TabIndex = 6;
            this.radButton1.Text = "Export To Exel";
            this.radButton1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
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
            this.dgwMonthProfits.Size = new System.Drawing.Size(1102, 659);
            this.dgwMonthProfits.TabIndex = 5;
            // 
            // MonthExits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 719);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.dgwMonthProfits);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MonthExits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MonthExits";
            this.Load += new System.EventHandler(this.MonthExits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMonthProfits.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMonthProfits)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadGridView dgwMonthProfits;
    }
}