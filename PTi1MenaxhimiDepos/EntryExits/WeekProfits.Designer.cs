namespace PTi1MenaxhimiDepos.EntryExits
{
    partial class WeekProfits
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.dgwWeekProfits = new Telerik.WinControls.UI.RadGridView();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgwWeekProfits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwWeekProfits.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwWeekProfits
            // 
            this.dgwWeekProfits.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.dgwWeekProfits.Location = new System.Drawing.Point(12, 53);
            // 
            // 
            // 
            this.dgwWeekProfits.MasterTemplate.AllowAddNewRow = false;
            this.dgwWeekProfits.MasterTemplate.AllowEditRow = false;
            this.dgwWeekProfits.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "Day";
            gridViewTextBoxColumn1.HeaderText = "Day";
            gridViewTextBoxColumn1.Name = "Day";
            gridViewTextBoxColumn1.Width = 542;
            gridViewTextBoxColumn2.FieldName = "Profit";
            gridViewTextBoxColumn2.HeaderText = "Profit";
            gridViewTextBoxColumn2.Name = "Profit";
            gridViewTextBoxColumn2.Width = 542;
            this.dgwWeekProfits.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2});
            this.dgwWeekProfits.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dgwWeekProfits.Name = "dgwWeekProfits";
            this.dgwWeekProfits.Size = new System.Drawing.Size(1104, 656);
            this.dgwWeekProfits.TabIndex = 0;
            // 
            // radButton1
            // 
            this.radButton1.Font = new System.Drawing.Font("Segoe UI", 15.25F);
            this.radButton1.Image = global::PTi1MenaxhimiDepos.Properties.Resources.exel;
            this.radButton1.Location = new System.Drawing.Point(12, 12);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(183, 35);
            this.radButton1.TabIndex = 5;
            this.radButton1.Text = "Export To Exel";
            this.radButton1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WeekProfits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 721);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.dgwWeekProfits);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "WeekProfits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WeekProfits";
            this.Load += new System.EventHandler(this.WeekProfits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwWeekProfits.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwWeekProfits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView dgwWeekProfits;
        private Telerik.WinControls.UI.RadButton radButton1;
    }
}