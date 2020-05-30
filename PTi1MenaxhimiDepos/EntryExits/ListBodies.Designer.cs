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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn13 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn14 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn15 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition3 = new Telerik.WinControls.UI.TableViewDefinition();
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
            gridViewTextBoxColumn11.FieldName = "HeaderID";
            gridViewTextBoxColumn11.HeaderText = "Header ID";
            gridViewTextBoxColumn11.Name = "HeaderID";
            gridViewTextBoxColumn11.Width = 257;
            gridViewTextBoxColumn12.FieldName = "Item.Name";
            gridViewTextBoxColumn12.HeaderText = "Item";
            gridViewTextBoxColumn12.Name = "Item";
            gridViewTextBoxColumn12.Width = 257;
            gridViewTextBoxColumn13.FieldName = "Price";
            gridViewTextBoxColumn13.HeaderText = "Price";
            gridViewTextBoxColumn13.Name = "Price";
            gridViewTextBoxColumn13.Width = 257;
            gridViewTextBoxColumn14.FieldName = "Quantity";
            gridViewTextBoxColumn14.HeaderText = "Quantity";
            gridViewTextBoxColumn14.Name = "Quantity";
            gridViewTextBoxColumn14.Width = 257;
            gridViewTextBoxColumn15.FieldName = "Discount";
            gridViewTextBoxColumn15.HeaderText = "Discount";
            gridViewTextBoxColumn15.Name = "Discount";
            gridViewTextBoxColumn15.Width = 255;
            this.dgwBodies.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn11,
            gridViewTextBoxColumn12,
            gridViewTextBoxColumn13,
            gridViewTextBoxColumn14,
            gridViewTextBoxColumn15});
            this.dgwBodies.MasterTemplate.ViewDefinition = tableViewDefinition3;
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