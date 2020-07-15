namespace PTi1MenaxhimiDepos.Invoices
{
    partial class InvoiceBody
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceBody));
            this.cmbItem = new Telerik.WinControls.UI.RadDropDownList();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txtDiscount = new Telerik.WinControls.UI.RadTextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new Telerik.WinControls.UI.RadTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtID = new Telerik.WinControls.UI.RadTextBox();
            this.txtPrice = new Telerik.WinControls.UI.RadTextBox();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.btnUpdate = new Telerik.WinControls.UI.RadButton();
            this.btnClear = new Telerik.WinControls.UI.RadButton();
            this.btndelete = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.cmbItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btndelete)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbItem
            // 
            resources.ApplyResources(this.cmbItem, "cmbItem");
            this.cmbItem.ItemHeight = 40;
            this.cmbItem.Name = "cmbItem";
            // 
            // lblItem
            // 
            resources.ApplyResources(this.lblItem, "lblItem");
            this.lblItem.Name = "lblItem";
            // 
            // lblDiscount
            // 
            resources.ApplyResources(this.lblDiscount, "lblDiscount");
            this.lblDiscount.Name = "lblDiscount";
            // 
            // txtDiscount
            // 
            resources.ApplyResources(this.txtDiscount, "txtDiscount");
            this.txtDiscount.Name = "txtDiscount";
            // 
            // lblQuantity
            // 
            resources.ApplyResources(this.lblQuantity, "lblQuantity");
            this.lblQuantity.Name = "lblQuantity";
            // 
            // txtQuantity
            // 
            resources.ApplyResources(this.txtQuantity, "txtQuantity");
            this.txtQuantity.Name = "txtQuantity";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lblPrice
            // 
            resources.ApplyResources(this.lblPrice, "lblPrice");
            this.lblPrice.Name = "lblPrice";
            // 
            // txtID
            // 
            resources.ApplyResources(this.txtID, "txtID");
            this.txtID.Name = "txtID";
            // 
            // txtPrice
            // 
            resources.ApplyResources(this.txtPrice, "txtPrice");
            this.txtPrice.Name = "txtPrice";
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Image = global::PTi1MenaxhimiDepos.Properties.Resources.add_1_icon;
            this.btnSave.Name = "btnSave";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            resources.ApplyResources(this.btnUpdate, "btnUpdate");
            this.btnUpdate.Image = global::PTi1MenaxhimiDepos.Properties.Resources.update;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.Image = global::PTi1MenaxhimiDepos.Properties.Resources.Actions_edit_clear_icon;
            this.btnClear.Name = "btnClear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btndelete
            // 
            resources.ApplyResources(this.btndelete, "btndelete");
            this.btndelete.Image = global::PTi1MenaxhimiDepos.Properties.Resources.cancel_icon;
            this.btndelete.Name = "btndelete";
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // InvoiceBody
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.cmbItem);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtPrice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InvoiceBody";
            this.Load += new System.EventHandler(this.InvoiceBody_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btndelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadDropDownList cmbItem;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblDiscount;
        private Telerik.WinControls.UI.RadTextBox txtDiscount;
        private System.Windows.Forms.Label lblQuantity;
        private Telerik.WinControls.UI.RadTextBox txtQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrice;
        private Telerik.WinControls.UI.RadTextBox txtID;
        private Telerik.WinControls.UI.RadTextBox txtPrice;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadButton btnUpdate;
        private Telerik.WinControls.UI.RadButton btnClear;
        private Telerik.WinControls.UI.RadButton btndelete;
    }
}