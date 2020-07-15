namespace PTi1MenaxhimiDepos.EntryExits.ClientRaports
{
    partial class ClientRaport
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
            this.dgwClientReports = new Telerik.WinControls.UI.RadGridView();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgwClientReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwClientReports.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwClientReports
            // 
            this.dgwClientReports.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.dgwClientReports.Location = new System.Drawing.Point(12, 42);
            // 
            // 
            // 
            this.dgwClientReports.MasterTemplate.AllowAddNewRow = false;
            this.dgwClientReports.MasterTemplate.AllowEditRow = false;
            this.dgwClientReports.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "ID";
            gridViewTextBoxColumn1.HeaderText = "ClientID";
            gridViewTextBoxColumn1.Name = "ClientID";
            gridViewTextBoxColumn1.Width = 348;
            gridViewTextBoxColumn2.FieldName = "Name";
            gridViewTextBoxColumn2.HeaderText = "Client Name";
            gridViewTextBoxColumn2.Name = "Name";
            gridViewTextBoxColumn2.Width = 348;
            gridViewTextBoxColumn3.FieldName = "Amount";
            gridViewTextBoxColumn3.HeaderText = "Amount";
            gridViewTextBoxColumn3.Name = "Amount";
            gridViewTextBoxColumn3.Width = 348;
            this.dgwClientReports.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3});
            this.dgwClientReports.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dgwClientReports.Name = "dgwClientReports";
            this.dgwClientReports.Size = new System.Drawing.Size(1063, 700);
            this.dgwClientReports.TabIndex = 0;
            this.dgwClientReports.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.dgwClientReports_CellDoubleClick);
            // 
            // radButton1
            // 
            this.radButton1.Font = new System.Drawing.Font("Segoe UI", 15.25F);
            this.radButton1.Image = global::PTi1MenaxhimiDepos.Properties.Resources.exel;
            this.radButton1.Location = new System.Drawing.Point(12, 6);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(183, 30);
            this.radButton1.TabIndex = 1;
            this.radButton1.Text = "Export To Exel";
            this.radButton1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ClientRaport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 754);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.dgwClientReports);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ClientRaport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientRaport";
            this.Load += new System.EventHandler(this.ClientRaport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwClientReports.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwClientReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView dgwClientReports;
        private Telerik.WinControls.UI.RadButton radButton1;
    }
}