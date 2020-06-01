namespace PTi1MenaxhimiDepos.EntryExits.ItemReports
{
    partial class ItemExitReports
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition3 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.dgwItemReport = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwItemReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwItemReport.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // radButton1
            // 
            this.radButton1.Font = new System.Drawing.Font("Segoe UI", 15.25F);
            this.radButton1.Image = global::PTi1MenaxhimiDepos.Properties.Resources.exel;
            this.radButton1.Location = new System.Drawing.Point(12, 12);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(183, 35);
            this.radButton1.TabIndex = 5;
            this.radButton1.Text = "Export To Exel";
            this.radButton1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgwItemReport
            // 
            this.dgwItemReport.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.dgwItemReport.Location = new System.Drawing.Point(12, 53);
            // 
            // 
            // 
            this.dgwItemReport.MasterTemplate.AllowAddNewRow = false;
            this.dgwItemReport.MasterTemplate.AllowEditRow = false;
            gridViewTextBoxColumn7.FieldName = "Barcode";
            gridViewTextBoxColumn7.HeaderText = "Barcode";
            gridViewTextBoxColumn7.Name = "Barcode";
            gridViewTextBoxColumn7.Width = 353;
            gridViewTextBoxColumn8.FieldName = "Name";
            gridViewTextBoxColumn8.HeaderText = "Name";
            gridViewTextBoxColumn8.Name = "Name";
            gridViewTextBoxColumn8.Width = 353;
            gridViewTextBoxColumn9.FieldName = "Quantity";
            gridViewTextBoxColumn9.HeaderText = "Quantity";
            gridViewTextBoxColumn9.Name = "Quantity";
            gridViewTextBoxColumn9.Width = 352;
            this.dgwItemReport.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9});
            this.dgwItemReport.MasterTemplate.ViewDefinition = tableViewDefinition3;
            this.dgwItemReport.Name = "dgwItemReport";
            this.dgwItemReport.Size = new System.Drawing.Size(1077, 667);
            this.dgwItemReport.TabIndex = 4;
            // 
            // ItemExitReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 726);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.dgwItemReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ItemExitReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemExitReports";
            this.Load += new System.EventHandler(this.ItemExitReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwItemReport.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwItemReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadGridView dgwItemReport;
    }
}