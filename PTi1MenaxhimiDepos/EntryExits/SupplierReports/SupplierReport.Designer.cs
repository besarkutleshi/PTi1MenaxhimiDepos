namespace PTi1MenaxhimiDepos.EntryExits.SupplierReports
{
    partial class SupplierReport
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
            this.dgwSupplierReports = new Telerik.WinControls.UI.RadGridView();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSupplierReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSupplierReports.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwSupplierReports
            // 
            this.dgwSupplierReports.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.dgwSupplierReports.Location = new System.Drawing.Point(12, 56);
            // 
            // 
            // 
            this.dgwSupplierReports.MasterTemplate.AllowAddNewRow = false;
            this.dgwSupplierReports.MasterTemplate.AllowEditRow = false;
            this.dgwSupplierReports.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "SupplierID";
            gridViewTextBoxColumn1.HeaderText = "Supplier ID";
            gridViewTextBoxColumn1.Name = "SupplierID";
            gridViewTextBoxColumn1.Width = 335;
            gridViewTextBoxColumn2.FieldName = "Name";
            gridViewTextBoxColumn2.HeaderText = "Name";
            gridViewTextBoxColumn2.Name = "Name";
            gridViewTextBoxColumn2.Width = 335;
            gridViewTextBoxColumn3.FieldName = "Amount";
            gridViewTextBoxColumn3.HeaderText = "Amount";
            gridViewTextBoxColumn3.Name = "Amount";
            gridViewTextBoxColumn3.Width = 335;
            this.dgwSupplierReports.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3});
            this.dgwSupplierReports.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dgwSupplierReports.Name = "dgwSupplierReports";
            this.dgwSupplierReports.Size = new System.Drawing.Size(1024, 672);
            this.dgwSupplierReports.TabIndex = 0;
            this.dgwSupplierReports.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.dgwSupplierReports_CellDoubleClick);
            // 
            // radButton1
            // 
            this.radButton1.Font = new System.Drawing.Font("Segoe UI", 15.25F);
            this.radButton1.Image = global::PTi1MenaxhimiDepos.Properties.Resources.exel;
            this.radButton1.Location = new System.Drawing.Point(12, 15);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(183, 35);
            this.radButton1.TabIndex = 5;
            this.radButton1.Text = "Export To Exel";
            this.radButton1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SupplierReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 740);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.dgwSupplierReports);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SupplierReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SupplierReport";
            this.Load += new System.EventHandler(this.SupplierReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwSupplierReports.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSupplierReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView dgwSupplierReports;
        private Telerik.WinControls.UI.RadButton radButton1;
    }
}