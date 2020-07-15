namespace PTi1MenaxhimiDepos.Sale
{
    partial class SaleInvoices
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.btnRefresh = new Telerik.WinControls.UI.RadButton();
            this.btnInsertRole = new Telerik.WinControls.UI.RadButton();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSearch = new Telerik.WinControls.UI.RadButton();
            this.txtSearch = new Telerik.WinControls.UI.RadTextBox();
            this.dgwInvoices = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInsertRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwInvoices.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 13.25F);
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Image = global::PTi1MenaxhimiDepos.Properties.Resources.refresh_icon__1_;
            this.btnRefresh.Location = new System.Drawing.Point(178, 45);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(137, 43);
            this.btnRefresh.TabIndex = 52;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnInsertRole
            // 
            this.btnInsertRole.Font = new System.Drawing.Font("Segoe UI", 13.25F);
            this.btnInsertRole.ForeColor = System.Drawing.Color.Black;
            this.btnInsertRole.Image = global::PTi1MenaxhimiDepos.Properties.Resources.add_icon;
            this.btnInsertRole.Location = new System.Drawing.Point(12, 45);
            this.btnInsertRole.Name = "btnInsertRole";
            this.btnInsertRole.Size = new System.Drawing.Size(160, 43);
            this.btnInsertRole.TabIndex = 53;
            this.btnInsertRole.Text = "Insert Invoice";
            this.btnInsertRole.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInsertRole.Click += new System.EventHandler(this.btnInsertRole_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(1218, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 24);
            this.label7.TabIndex = 51;
            this.label7.Text = "Search";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Image = global::PTi1MenaxhimiDepos.Properties.Resources.Search_icon;
            this.btnSearch.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.Location = new System.Drawing.Point(1486, 51);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(52, 37);
            this.btnSearch.TabIndex = 50;
            this.btnSearch.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtSearch.Location = new System.Drawing.Point(1222, 51);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(258, 37);
            this.txtSearch.TabIndex = 49;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgwInvoices
            // 
            this.dgwInvoices.AutoScroll = true;
            this.dgwInvoices.Font = new System.Drawing.Font("Segoe UI", 13.25F);
            this.dgwInvoices.Location = new System.Drawing.Point(12, 94);
            // 
            // 
            // 
            this.dgwInvoices.MasterTemplate.AllowAddNewRow = false;
            this.dgwInvoices.MasterTemplate.AllowEditRow = false;
            this.dgwInvoices.MasterTemplate.AutoGenerateColumns = false;
            this.dgwInvoices.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "InvertoryID";
            gridViewTextBoxColumn1.HeaderText = "ID";
            gridViewTextBoxColumn1.Name = "ID";
            gridViewTextBoxColumn1.Width = 217;
            gridViewTextBoxColumn2.FieldName = "DocNo";
            gridViewTextBoxColumn2.HeaderText = "InvoiceNumber";
            gridViewTextBoxColumn2.Name = "Invoice Number";
            gridViewTextBoxColumn2.Width = 217;
            gridViewTextBoxColumn3.FieldName = "DocDate";
            gridViewTextBoxColumn3.HeaderText = "Date";
            gridViewTextBoxColumn3.Name = "Date";
            gridViewTextBoxColumn3.Width = 217;
            gridViewTextBoxColumn4.FieldName = "DocType.Description";
            gridViewTextBoxColumn4.HeaderText = "Invoice Type";
            gridViewTextBoxColumn4.Name = "Invoice Type";
            gridViewTextBoxColumn4.Width = 217;
            gridViewTextBoxColumn5.FieldName = "POS.Name";
            gridViewTextBoxColumn5.HeaderText = "POS";
            gridViewTextBoxColumn5.Name = "POS";
            gridViewTextBoxColumn5.Width = 217;
            gridViewTextBoxColumn6.FieldName = "Description";
            gridViewTextBoxColumn6.HeaderText = "Description";
            gridViewTextBoxColumn6.Name = "Description";
            gridViewTextBoxColumn6.Width = 217;
            gridViewTextBoxColumn7.FieldName = "Supplier.Name";
            gridViewTextBoxColumn7.HeaderText = "Supplier";
            gridViewTextBoxColumn7.Name = "Supplier";
            gridViewTextBoxColumn7.Width = 209;
            this.dgwInvoices.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7});
            this.dgwInvoices.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dgwInvoices.Name = "dgwInvoices";
            this.dgwInvoices.Size = new System.Drawing.Size(1526, 784);
            this.dgwInvoices.TabIndex = 48;
            this.dgwInvoices.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.dgwInvoices_CellDoubleClick);
            // 
            // SaleInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1546, 883);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnInsertRole);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgwInvoices);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SaleInvoices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaleInvoices";
            this.Load += new System.EventHandler(this.SaleInvoices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInsertRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwInvoices.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwInvoices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnRefresh;
        private Telerik.WinControls.UI.RadButton btnInsertRole;
        private System.Windows.Forms.Label label7;
        private Telerik.WinControls.UI.RadButton btnSearch;
        private Telerik.WinControls.UI.RadTextBox txtSearch;
        private Telerik.WinControls.UI.RadGridView dgwInvoices;
    }
}