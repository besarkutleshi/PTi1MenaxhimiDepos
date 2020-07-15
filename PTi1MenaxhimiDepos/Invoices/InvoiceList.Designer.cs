namespace PTi1MenaxhimiDepos.Invoices
{
    partial class InvoiceList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceList));
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn13 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn14 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.dgwInvoices = new Telerik.WinControls.UI.RadGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearch = new Telerik.WinControls.UI.RadTextBox();
            this.btnRefresh = new Telerik.WinControls.UI.RadButton();
            this.btnInsertRole = new Telerik.WinControls.UI.RadButton();
            this.btnSearch = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgwInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwInvoices.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInsertRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwInvoices
            // 
            resources.ApplyResources(this.dgwInvoices, "dgwInvoices");
            // 
            // 
            // 
            this.dgwInvoices.MasterTemplate.AllowAddNewRow = false;
            this.dgwInvoices.MasterTemplate.AllowEditRow = false;
            this.dgwInvoices.MasterTemplate.AutoGenerateColumns = false;
            this.dgwInvoices.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.dgwInvoices.MasterTemplate.Caption = resources.GetString("dgwInvoices.MasterTemplate.Caption");
            resources.ApplyResources(gridViewTextBoxColumn8, "gridViewTextBoxColumn8");
            gridViewTextBoxColumn8.FieldName = "InvertoryID";
            gridViewTextBoxColumn8.Name = "ID";
            gridViewTextBoxColumn8.Width = 217;
            resources.ApplyResources(gridViewTextBoxColumn9, "gridViewTextBoxColumn9");
            gridViewTextBoxColumn9.FieldName = "DocNo";
            gridViewTextBoxColumn9.Name = "Invoice Number";
            gridViewTextBoxColumn9.Width = 217;
            resources.ApplyResources(gridViewTextBoxColumn10, "gridViewTextBoxColumn10");
            gridViewTextBoxColumn10.FieldName = "DocDate";
            gridViewTextBoxColumn10.Name = "Date";
            gridViewTextBoxColumn10.Width = 217;
            resources.ApplyResources(gridViewTextBoxColumn11, "gridViewTextBoxColumn11");
            gridViewTextBoxColumn11.FieldName = "DocType.Description";
            gridViewTextBoxColumn11.Name = "Invoice Type";
            gridViewTextBoxColumn11.Width = 217;
            resources.ApplyResources(gridViewTextBoxColumn12, "gridViewTextBoxColumn12");
            gridViewTextBoxColumn12.FieldName = "POS.Name";
            gridViewTextBoxColumn12.Name = "POS";
            gridViewTextBoxColumn12.Width = 217;
            resources.ApplyResources(gridViewTextBoxColumn13, "gridViewTextBoxColumn13");
            gridViewTextBoxColumn13.FieldName = "Description";
            gridViewTextBoxColumn13.Name = "Description";
            gridViewTextBoxColumn13.Width = 217;
            resources.ApplyResources(gridViewTextBoxColumn14, "gridViewTextBoxColumn14");
            gridViewTextBoxColumn14.FieldName = "Supplier.Name";
            gridViewTextBoxColumn14.Name = "Supplier";
            gridViewTextBoxColumn14.Width = 209;
            this.dgwInvoices.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11,
            gridViewTextBoxColumn12,
            gridViewTextBoxColumn13,
            gridViewTextBoxColumn14});
            this.dgwInvoices.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.dgwInvoices.Name = "dgwInvoices";
            this.dgwInvoices.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.dgwInvoices_CellDoubleClick);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // txtSearch
            // 
            resources.ApplyResources(this.txtSearch, "txtSearch");
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnRefresh
            // 
            resources.ApplyResources(this.btnRefresh, "btnRefresh");
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Image = global::PTi1MenaxhimiDepos.Properties.Resources.refresh_icon__1_;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnInsertRole
            // 
            resources.ApplyResources(this.btnInsertRole, "btnInsertRole");
            this.btnInsertRole.ForeColor = System.Drawing.Color.Black;
            this.btnInsertRole.Image = global::PTi1MenaxhimiDepos.Properties.Resources.add_icon;
            this.btnInsertRole.Name = "btnInsertRole";
            this.btnInsertRole.Click += new System.EventHandler(this.btnInsertRole_Click);
            // 
            // btnSearch
            // 
            resources.ApplyResources(this.btnSearch, "btnSearch");
            this.btnSearch.Image = global::PTi1MenaxhimiDepos.Properties.Resources.Search_icon;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // InvoiceList
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnInsertRole);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgwInvoices);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InvoiceList";
            this.Load += new System.EventHandler(this.InvoiceList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwInvoices.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInsertRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView dgwInvoices;
        private System.Windows.Forms.Label label7;
        private Telerik.WinControls.UI.RadButton btnSearch;
        private Telerik.WinControls.UI.RadTextBox txtSearch;
        private Telerik.WinControls.UI.RadButton btnRefresh;
        private Telerik.WinControls.UI.RadButton btnInsertRole;
    }
}