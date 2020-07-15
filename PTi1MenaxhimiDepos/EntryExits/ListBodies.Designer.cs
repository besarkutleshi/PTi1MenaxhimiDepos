namespace PTi1MenaxhimiDepos.EntryExits
{
    partial class ListBodies
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.dgwBodies = new Telerik.WinControls.UI.RadGridView();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBodies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBodies.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwBodies
            // 
            this.dgwBodies.Font = new System.Drawing.Font("Segoe UI", 13.25F);
            this.dgwBodies.Location = new System.Drawing.Point(12, 49);
            // 
            // 
            // 
            this.dgwBodies.MasterTemplate.AllowAddNewRow = false;
            this.dgwBodies.MasterTemplate.AllowEditRow = false;
            this.dgwBodies.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "HeaderID";
            gridViewTextBoxColumn1.HeaderText = "Header ID";
            gridViewTextBoxColumn1.Name = "HeaderID";
            gridViewTextBoxColumn1.Width = 257;
            gridViewTextBoxColumn2.FieldName = "Item.Name";
            gridViewTextBoxColumn2.HeaderText = "Item";
            gridViewTextBoxColumn2.Name = "Item";
            gridViewTextBoxColumn2.Width = 257;
            gridViewTextBoxColumn3.FieldName = "Price";
            gridViewTextBoxColumn3.HeaderText = "Price";
            gridViewTextBoxColumn3.Name = "Price";
            gridViewTextBoxColumn3.Width = 257;
            gridViewTextBoxColumn4.FieldName = "Quantity";
            gridViewTextBoxColumn4.HeaderText = "Quantity";
            gridViewTextBoxColumn4.Name = "Quantity";
            gridViewTextBoxColumn4.Width = 257;
            gridViewTextBoxColumn5.FieldName = "Discount";
            gridViewTextBoxColumn5.HeaderText = "Discount";
            gridViewTextBoxColumn5.Name = "Discount";
            gridViewTextBoxColumn5.Width = 255;
            this.dgwBodies.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5});
            this.dgwBodies.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dgwBodies.Name = "dgwBodies";
            this.dgwBodies.Size = new System.Drawing.Size(1300, 681);
            this.dgwBodies.TabIndex = 9;
            // 
            // radButton1
            // 
            this.radButton1.Font = new System.Drawing.Font("Segoe UI", 15.25F);
            this.radButton1.Image = global::PTi1MenaxhimiDepos.Properties.Resources.exel;
            this.radButton1.Location = new System.Drawing.Point(12, 12);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(183, 35);
            this.radButton1.TabIndex = 3;
            this.radButton1.Text = "Export To Exel";
            this.radButton1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ListBodies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 742);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.dgwBodies);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ListBodies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListBodies";
            this.Load += new System.EventHandler(this.ListBodies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwBodies.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBodies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView dgwBodies;
        private Telerik.WinControls.UI.RadButton radButton1;
    }
}