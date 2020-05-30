﻿namespace PTi1MenaxhimiDepos.Collab
{
    partial class EmployeePOSList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeePOSList));
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearch = new Telerik.WinControls.UI.RadTextBox();
            this.dgwEmpPos = new Telerik.WinControls.UI.RadGridView();
            this.btnRefresh = new Telerik.WinControls.UI.RadButton();
            this.btnSearch = new Telerik.WinControls.UI.RadButton();
            this.btnInsertRole = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwEmpPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwEmpPos.MasterTemplate)).BeginInit();
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
            // dgwEmpPos
            // 
            resources.ApplyResources(this.dgwEmpPos, "dgwEmpPos");
            // 
            // 
            // 
            this.dgwEmpPos.MasterTemplate.AllowAddNewRow = false;
            this.dgwEmpPos.MasterTemplate.AllowEditRow = false;
            this.dgwEmpPos.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.dgwEmpPos.MasterTemplate.Caption = resources.GetString("dgwEmpPos.MasterTemplate.Caption");
            resources.ApplyResources(gridViewTextBoxColumn1, "gridViewTextBoxColumn1");
            gridViewTextBoxColumn1.FieldName = "ID";
            gridViewTextBoxColumn1.Name = "ID";
            gridViewTextBoxColumn1.Width = 236;
            resources.ApplyResources(gridViewTextBoxColumn2, "gridViewTextBoxColumn2");
            gridViewTextBoxColumn2.FieldName = "Employee.Name";
            gridViewTextBoxColumn2.Name = "Employee";
            gridViewTextBoxColumn2.Width = 236;
            resources.ApplyResources(gridViewTextBoxColumn3, "gridViewTextBoxColumn3");
            gridViewTextBoxColumn3.FieldName = "POS.Name";
            gridViewTextBoxColumn3.Name = "Pos";
            gridViewTextBoxColumn3.Width = 236;
            resources.ApplyResources(gridViewTextBoxColumn4, "gridViewTextBoxColumn4");
            gridViewTextBoxColumn4.FieldName = "Description";
            gridViewTextBoxColumn4.Name = "Description";
            gridViewTextBoxColumn4.Width = 237;
            this.dgwEmpPos.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
            this.dgwEmpPos.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dgwEmpPos.Name = "dgwEmpPos";
            this.dgwEmpPos.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.dgwEmpPos_CellDoubleClick);
            // 
            // btnRefresh
            // 
            resources.ApplyResources(this.btnRefresh, "btnRefresh");
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Image = global::PTi1MenaxhimiDepos.Properties.Resources.refresh_icon__1_;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
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
            // EmployeePOSList
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgwEmpPos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnInsertRole);
            this.Name = "EmployeePOSList";
            this.Load += new System.EventHandler(this.EmployeePOSList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwEmpPos.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwEmpPos)).EndInit();
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
        private Telerik.WinControls.UI.RadGridView dgwEmpPos;
    }
}