namespace PTi1MenaxhimiDepos.EntryExits.SupplierReports
{
    partial class SupplierInvoice
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.dgwClientInvoices = new Telerik.WinControls.UI.RadGridView();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgwClientInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwClientInvoices.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwClientInvoices
            // 
            this.dgwClientInvoices.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.dgwClientInvoices.Location = new System.Drawing.Point(13, 53);
            // 
            // 
            // 
            this.dgwClientInvoices.MasterTemplate.AllowAddNewRow = false;
            this.dgwClientInvoices.MasterTemplate.AllowEditRow = false;
            this.dgwClientInvoices.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "InvertoryID";
            gridViewTextBoxColumn1.HeaderText = "Invoice ID";
            gridViewTextBoxColumn1.Name = "InvertoryID";
            gridViewTextBoxColumn1.Width = 211;
            gridViewTextBoxColumn2.FieldName = "DocNo";
            gridViewTextBoxColumn2.HeaderText = "Invoice Number";
            gridViewTextBoxColumn2.Name = "DocNo";
            gridViewTextBoxColumn2.Width = 211;
            gridViewTextBoxColumn3.FieldName = "DocDate";
            gridViewTextBoxColumn3.HeaderText = "Invoice Date";
            gridViewTextBoxColumn3.Name = "DocDate";
            gridViewTextBoxColumn3.Width = 211;
            gridViewTextBoxColumn4.FieldName = "InvoiceType";
            gridViewTextBoxColumn4.HeaderText = "Invoice Type";
            gridViewTextBoxColumn4.Name = "InvoiveType";
            gridViewTextBoxColumn4.Width = 211;
            gridViewTextBoxColumn5.FieldName = "PosName";
            gridViewTextBoxColumn5.HeaderText = "POS";
            gridViewTextBoxColumn5.Name = "PosName";
            gridViewTextBoxColumn5.Width = 211;
            gridViewTextBoxColumn6.FieldName = "Amount";
            gridViewTextBoxColumn6.HeaderText = "Amount";
            gridViewTextBoxColumn6.Name = "Amount";
            gridViewTextBoxColumn6.Width = 209;
            this.dgwClientInvoices.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6});
            this.dgwClientInvoices.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dgwClientInvoices.Name = "dgwClientInvoices";
            this.dgwClientInvoices.Size = new System.Drawing.Size(1280, 687);
            this.dgwClientInvoices.TabIndex = 5;
            this.dgwClientInvoices.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.dgwClientInvoices_CellDoubleClick);
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
            // SupplierInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 747);
            this.Controls.Add(this.dgwClientInvoices);
            this.Controls.Add(this.radButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SupplierInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SupplierInvoice";
            ((System.ComponentModel.ISupportInitialize)(this.dgwClientInvoices.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwClientInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView dgwClientInvoices;
        private Telerik.WinControls.UI.RadButton radButton1;
    }
}