namespace PTi1MenaxhimiDepos.Items
{
    partial class ItemList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemList));
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.dgwItems = new Telerik.WinControls.UI.RadGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearch = new Telerik.WinControls.UI.RadTextBox();
            this.btnSearch = new Telerik.WinControls.UI.RadButton();
            this.btnRefresh = new Telerik.WinControls.UI.RadButton();
            this.btnInsertRole = new Telerik.WinControls.UI.RadButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.albaniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgwItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwItems.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInsertRole)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwItems
            // 
            resources.ApplyResources(this.dgwItems, "dgwItems");
            // 
            // 
            // 
            this.dgwItems.MasterTemplate.AllowAddNewRow = false;
            this.dgwItems.MasterTemplate.AllowEditRow = false;
            this.dgwItems.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.dgwItems.MasterTemplate.Caption = resources.GetString("dgwItems.MasterTemplate.Caption");
            resources.ApplyResources(gridViewTextBoxColumn1, "gridViewTextBoxColumn1");
            gridViewTextBoxColumn1.FieldName = "ID";
            gridViewTextBoxColumn1.Name = "ID";
            gridViewTextBoxColumn1.Width = 189;
            resources.ApplyResources(gridViewTextBoxColumn2, "gridViewTextBoxColumn2");
            gridViewTextBoxColumn2.FieldName = "Barcode";
            gridViewTextBoxColumn2.Name = "Barcode";
            gridViewTextBoxColumn2.Width = 189;
            resources.ApplyResources(gridViewTextBoxColumn3, "gridViewTextBoxColumn3");
            gridViewTextBoxColumn3.FieldName = "Name";
            gridViewTextBoxColumn3.Name = "Name";
            gridViewTextBoxColumn3.Width = 189;
            resources.ApplyResources(gridViewTextBoxColumn4, "gridViewTextBoxColumn4");
            gridViewTextBoxColumn4.FieldName = "Unit.Name";
            gridViewTextBoxColumn4.Name = "Unit";
            gridViewTextBoxColumn4.Width = 189;
            resources.ApplyResources(gridViewTextBoxColumn5, "gridViewTextBoxColumn5");
            gridViewTextBoxColumn5.FieldName = "Category.Name";
            gridViewTextBoxColumn5.Name = "Category";
            gridViewTextBoxColumn5.Width = 189;
            resources.ApplyResources(gridViewTextBoxColumn6, "gridViewTextBoxColumn6");
            gridViewTextBoxColumn6.FieldName = "Type.Name";
            gridViewTextBoxColumn6.Name = "Type";
            gridViewTextBoxColumn6.Width = 189;
            resources.ApplyResources(gridViewTextBoxColumn7, "gridViewTextBoxColumn7");
            gridViewTextBoxColumn7.FieldName = "Supplier.Name";
            gridViewTextBoxColumn7.Name = "Supplier";
            gridViewTextBoxColumn7.Width = 189;
            resources.ApplyResources(gridViewTextBoxColumn8, "gridViewTextBoxColumn8");
            gridViewTextBoxColumn8.FieldName = "Active";
            gridViewTextBoxColumn8.Name = "Active";
            gridViewTextBoxColumn8.Width = 189;
            resources.ApplyResources(gridViewTextBoxColumn9, "gridViewTextBoxColumn9");
            gridViewTextBoxColumn9.FieldName = "StockQuantity";
            gridViewTextBoxColumn9.Name = "Stock Quantity";
            gridViewTextBoxColumn9.Width = 189;
            resources.ApplyResources(gridViewTextBoxColumn10, "gridViewTextBoxColumn10");
            gridViewTextBoxColumn10.FieldName = "Description";
            gridViewTextBoxColumn10.Name = "Description";
            gridViewTextBoxColumn10.Width = 187;
            this.dgwItems.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10});
            this.dgwItems.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dgwItems.Name = "dgwItems";
            this.dgwItems.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.dgwItems_CellDoubleClick);
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
            // btnSearch
            // 
            resources.ApplyResources(this.btnSearch, "btnSearch");
            this.btnSearch.Image = global::PTi1MenaxhimiDepos.Properties.Resources.Search_icon;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpsToolStripMenuItem,
            this.languageToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // helpsToolStripMenuItem
            // 
            resources.ApplyResources(this.helpsToolStripMenuItem, "helpsToolStripMenuItem");
            this.helpsToolStripMenuItem.Name = "helpsToolStripMenuItem";
            this.helpsToolStripMenuItem.Click += new System.EventHandler(this.helpsToolStripMenuItem_Click);
            // 
            // languageToolStripMenuItem
            // 
            resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.albaniaToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            // 
            // englishToolStripMenuItem
            // 
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // albaniaToolStripMenuItem
            // 
            resources.ApplyResources(this.albaniaToolStripMenuItem, "albaniaToolStripMenuItem");
            this.albaniaToolStripMenuItem.Name = "albaniaToolStripMenuItem";
            this.albaniaToolStripMenuItem.Click += new System.EventHandler(this.albaniaToolStripMenuItem_Click);
            // 
            // ItemList
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnInsertRole);
            this.Controls.Add(this.dgwItems);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ItemList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ItemList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwItems.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInsertRole)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView dgwItems;
        private System.Windows.Forms.Label label7;
        private Telerik.WinControls.UI.RadTextBox txtSearch;
        private Telerik.WinControls.UI.RadButton btnSearch;
        private Telerik.WinControls.UI.RadButton btnRefresh;
        private Telerik.WinControls.UI.RadButton btnInsertRole;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem albaniaToolStripMenuItem;
    }
}