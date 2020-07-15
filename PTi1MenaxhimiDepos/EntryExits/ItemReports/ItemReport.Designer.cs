namespace PTi1MenaxhimiDepos.EntryExits.ItemReports
{
    partial class ItemReport
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.dgwItemReport = new Telerik.WinControls.UI.RadGridView();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgwItemReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwItemReport.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwItemReport
            // 
            this.dgwItemReport.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.dgwItemReport.Location = new System.Drawing.Point(12, 63);
            // 
            // 
            // 
            this.dgwItemReport.MasterTemplate.AllowAddNewRow = false;
            this.dgwItemReport.MasterTemplate.AllowEditRow = false;
            gridViewTextBoxColumn1.FieldName = "Barcode";
            gridViewTextBoxColumn1.HeaderText = "Barcode";
            gridViewTextBoxColumn1.Name = "Barcode";
            gridViewTextBoxColumn1.Width = 353;
            gridViewTextBoxColumn2.FieldName = "Name";
            gridViewTextBoxColumn2.HeaderText = "Name";
            gridViewTextBoxColumn2.Name = "Name";
            gridViewTextBoxColumn2.Width = 353;
            gridViewTextBoxColumn3.FieldName = "Quantity";
            gridViewTextBoxColumn3.HeaderText = "Quantity";
            gridViewTextBoxColumn3.Name = "Quantity";
            gridViewTextBoxColumn3.Width = 352;
            this.dgwItemReport.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3});
            this.dgwItemReport.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dgwItemReport.Name = "dgwItemReport";
            this.dgwItemReport.Size = new System.Drawing.Size(1077, 667);
            this.dgwItemReport.TabIndex = 0;
            // 
            // radButton1
            // 
            this.radButton1.Font = new System.Drawing.Font("Segoe UI", 15.25F);
            this.radButton1.Image = global::PTi1MenaxhimiDepos.Properties.Resources.exel;
            this.radButton1.Location = new System.Drawing.Point(12, 22);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(183, 35);
            this.radButton1.TabIndex = 3;
            this.radButton1.Text = "Export To Exel";
            this.radButton1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ItemReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 742);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.dgwItemReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ItemReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemReport";
            this.Load += new System.EventHandler(this.ItemReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwItemReport.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwItemReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView dgwItemReport;
        private Telerik.WinControls.UI.RadButton radButton1;
    }
}