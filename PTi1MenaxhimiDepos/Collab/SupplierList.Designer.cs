namespace PTi1MenaxhimiDepos.Collab
{
    partial class SupplierList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierList));
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn13 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn14 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn15 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn16 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn17 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn18 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition3 = new Telerik.WinControls.UI.TableViewDefinition();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearch = new Telerik.WinControls.UI.RadTextBox();
            this.dgwSuppliers = new Telerik.WinControls.UI.RadGridView();
            this.btnRefresh = new Telerik.WinControls.UI.RadButton();
            this.btnSearch = new Telerik.WinControls.UI.RadButton();
            this.btnInsertRole = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSuppliers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSuppliers.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInsertRole)).BeginInit();
            this.SuspendLayout();
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
            // dgwSuppliers
            // 
            resources.ApplyResources(this.dgwSuppliers, "dgwSuppliers");
            // 
            // 
            // 
            this.dgwSuppliers.MasterTemplate.AllowAddNewRow = false;
            this.dgwSuppliers.MasterTemplate.AllowEditRow = false;
            this.dgwSuppliers.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.dgwSuppliers.MasterTemplate.Caption = resources.GetString("dgwSuppliers.MasterTemplate.Caption");
            resources.ApplyResources(gridViewTextBoxColumn13, "gridViewTextBoxColumn13");
            gridViewTextBoxColumn13.FieldName = "ID";
            gridViewTextBoxColumn13.Name = "ID";
            gridViewTextBoxColumn13.Width = 198;
            resources.ApplyResources(gridViewTextBoxColumn14, "gridViewTextBoxColumn14");
            gridViewTextBoxColumn14.FieldName = "Name";
            gridViewTextBoxColumn14.Name = "Name";
            gridViewTextBoxColumn14.Width = 198;
            resources.ApplyResources(gridViewTextBoxColumn15, "gridViewTextBoxColumn15");
            gridViewTextBoxColumn15.FieldName = "City";
            gridViewTextBoxColumn15.Name = "City";
            gridViewTextBoxColumn15.Width = 198;
            resources.ApplyResources(gridViewTextBoxColumn16, "gridViewTextBoxColumn16");
            gridViewTextBoxColumn16.FieldName = "Phone";
            gridViewTextBoxColumn16.Name = "Phone";
            gridViewTextBoxColumn16.Width = 198;
            resources.ApplyResources(gridViewTextBoxColumn17, "gridViewTextBoxColumn17");
            gridViewTextBoxColumn17.FieldName = "Mail";
            gridViewTextBoxColumn17.Name = "Email";
            gridViewTextBoxColumn17.Width = 198;
            resources.ApplyResources(gridViewTextBoxColumn18, "gridViewTextBoxColumn18");
            gridViewTextBoxColumn18.FieldName = "Description";
            gridViewTextBoxColumn18.Name = "Description";
            gridViewTextBoxColumn18.Width = 196;
            this.dgwSuppliers.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn13,
            gridViewTextBoxColumn14,
            gridViewTextBoxColumn15,
            gridViewTextBoxColumn16,
            gridViewTextBoxColumn17,
            gridViewTextBoxColumn18});
            this.dgwSuppliers.MasterTemplate.ViewDefinition = tableViewDefinition3;
            this.dgwSuppliers.Name = "dgwSuppliers";
            this.dgwSuppliers.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.dgwSuppliers_CellDoubleClick);
            // 
            // btnRefresh
            // 
            resources.ApplyResources(this.btnRefresh, "btnRefresh");
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Image = global::PTi1MenaxhimiDepos.Properties.Resources.refresh_icon__1_;
            this.btnRefresh.Name = "btnRefresh";
            // 
            // btnSearch
            // 
            resources.ApplyResources(this.btnSearch, "btnSearch");
            this.btnSearch.Image = global::PTi1MenaxhimiDepos.Properties.Resources.Search_icon;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnInsertRole
            // 
            resources.ApplyResources(this.btnInsertRole, "btnInsertRole");
            this.btnInsertRole.ForeColor = System.Drawing.Color.Black;
            this.btnInsertRole.Image = global::PTi1MenaxhimiDepos.Properties.Resources.add_icon;
            this.btnInsertRole.Name = "btnInsertRole";
            this.btnInsertRole.Click += new System.EventHandler(this.btnInsertRole_Click);
            // 
            // SupplierList
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgwSuppliers);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnInsertRole);
            this.Name = "SupplierList";
            this.Load += new System.EventHandler(this.SupplierList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSuppliers.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSuppliers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInsertRole)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private Telerik.WinControls.UI.RadTextBox txtSearch;
        private Telerik.WinControls.UI.RadButton btnRefresh;
        private Telerik.WinControls.UI.RadButton btnSearch;
        private Telerik.WinControls.UI.RadButton btnInsertRole;
        public Telerik.WinControls.UI.RadGridView dgwSuppliers;
    }
}