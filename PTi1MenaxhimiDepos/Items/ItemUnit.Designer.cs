namespace PTi1MenaxhimiDepos.Items
{
    partial class ItemUnit
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition4 = new Telerik.WinControls.UI.TableViewDefinition();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new Telerik.WinControls.UI.RadButton();
            this.txtSearch = new Telerik.WinControls.UI.RadTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgwTypes = new Telerik.WinControls.UI.RadGridView();
            this.btnUpdate = new Telerik.WinControls.UI.RadButton();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.txtdescription = new Telerik.WinControls.UI.RadTextBox();
            this.txtname = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTypes.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtname)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label3.Location = new System.Drawing.Point(10, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 21;
            this.label3.Text = "Search";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = global::PTi1MenaxhimiDepos.Properties.Resources.Search_icon;
            this.btnSearch.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.Location = new System.Drawing.Point(278, 145);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(52, 38);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtSearch.Location = new System.Drawing.Point(14, 145);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(258, 37);
            this.txtSearch.TabIndex = 19;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label2.Location = new System.Drawing.Point(226, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label1.Location = new System.Drawing.Point(19, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Name";
            // 
            // dgwTypes
            // 
            this.dgwTypes.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.dgwTypes.Location = new System.Drawing.Point(14, 188);
            // 
            // 
            // 
            this.dgwTypes.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.dgwTypes.MasterTemplate.ViewDefinition = tableViewDefinition4;
            this.dgwTypes.Name = "dgwTypes";
            this.dgwTypes.Size = new System.Drawing.Size(776, 278);
            this.dgwTypes.TabIndex = 18;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Image = global::PTi1MenaxhimiDepos.Properties.Resources.update;
            this.btnUpdate.Location = new System.Drawing.Point(655, 16);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(137, 56);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::PTi1MenaxhimiDepos.Properties.Resources.add_1_icon;
            this.btnSave.Location = new System.Drawing.Point(483, 16);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(137, 56);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtdescription
            // 
            this.txtdescription.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtdescription.Location = new System.Drawing.Point(221, 35);
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(174, 37);
            this.txtdescription.TabIndex = 13;
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtname.Location = new System.Drawing.Point(14, 35);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(174, 37);
            this.txtname.TabIndex = 12;
            // 
            // ItemUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 477);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwTypes);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtdescription);
            this.Controls.Add(this.txtname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ItemUnit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemUnit";
            this.Load += new System.EventHandler(this.ItemUnit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTypes.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtname)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private Telerik.WinControls.UI.RadButton btnSearch;
        private Telerik.WinControls.UI.RadTextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadGridView dgwTypes;
        private Telerik.WinControls.UI.RadButton btnUpdate;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadTextBox txtdescription;
        private Telerik.WinControls.UI.RadTextBox txtname;
    }
}