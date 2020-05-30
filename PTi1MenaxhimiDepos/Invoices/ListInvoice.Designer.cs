namespace PTi1MenaxhimiDepos.Invoices
{
    partial class ListInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListInvoice));
            this.cmbSupplier = new Telerik.WinControls.UI.RadDropDownList();
            this.lblsupplier = new System.Windows.Forms.Label();
            this.cmbInoviceType = new Telerik.WinControls.UI.RadDropDownList();
            this.label1 = new System.Windows.Forms.Label();
            this.lbldescription = new System.Windows.Forms.Label();
            this.txtDescription = new Telerik.WinControls.UI.RadTextBox();
            this.lblinvoicenumber = new System.Windows.Forms.Label();
            this.txtInvoiceNumber = new Telerik.WinControls.UI.RadTextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.txtID = new Telerik.WinControls.UI.RadTextBox();
            this.cmbPos = new Telerik.WinControls.UI.RadDropDownList();
            this.lblPos = new System.Windows.Forms.Label();
            this.btnShowDetails = new Telerik.WinControls.UI.RadButton();
            this.btnUpdate = new Telerik.WinControls.UI.RadButton();
            this.btnClear = new Telerik.WinControls.UI.RadButton();
            this.btndelete = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbInoviceType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btndelete)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSupplier
            // 
            resources.ApplyResources(this.cmbSupplier, "cmbSupplier");
            this.cmbSupplier.ItemHeight = 40;
            this.cmbSupplier.Name = "cmbSupplier";
            // 
            // lblsupplier
            // 
            resources.ApplyResources(this.lblsupplier, "lblsupplier");
            this.lblsupplier.Name = "lblsupplier";
            // 
            // cmbInoviceType
            // 
            resources.ApplyResources(this.cmbInoviceType, "cmbInoviceType");
            this.cmbInoviceType.ItemHeight = 40;
            this.cmbInoviceType.Name = "cmbInoviceType";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lbldescription
            // 
            resources.ApplyResources(this.lbldescription, "lbldescription");
            this.lbldescription.Name = "lbldescription";
            // 
            // txtDescription
            // 
            resources.ApplyResources(this.txtDescription, "txtDescription");
            this.txtDescription.Name = "txtDescription";
            // 
            // lblinvoicenumber
            // 
            resources.ApplyResources(this.lblinvoicenumber, "lblinvoicenumber");
            this.lblinvoicenumber.Name = "lblinvoicenumber";
            // 
            // txtInvoiceNumber
            // 
            resources.ApplyResources(this.txtInvoiceNumber, "txtInvoiceNumber");
            this.txtInvoiceNumber.Name = "txtInvoiceNumber";
            // 
            // lblid
            // 
            resources.ApplyResources(this.lblid, "lblid");
            this.lblid.Name = "lblid";
            // 
            // txtID
            // 
            resources.ApplyResources(this.txtID, "txtID");
            this.txtID.Name = "txtID";
            // 
            // cmbPos
            // 
            resources.ApplyResources(this.cmbPos, "cmbPos");
            this.cmbPos.ItemHeight = 40;
            this.cmbPos.Name = "cmbPos";
            // 
            // lblPos
            // 
            resources.ApplyResources(this.lblPos, "lblPos");
            this.lblPos.Name = "lblPos";
            // 
            // btnShowDetails
            // 
            resources.ApplyResources(this.btnShowDetails, "btnShowDetails");
            this.btnShowDetails.Name = "btnShowDetails";
            this.btnShowDetails.Click += new System.EventHandler(this.btnShowDetails_Click);
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
            // ListInvoice
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnShowDetails);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cmbPos);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.lblPos);
            this.Controls.Add(this.cmbSupplier);
            this.Controls.Add(this.lblsupplier);
            this.Controls.Add(this.cmbInoviceType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbldescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblinvoicenumber);
            this.Controls.Add(this.txtInvoiceNumber);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.txtID);
            this.Name = "ListInvoice";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListInvoice_FormClosing);
            this.Load += new System.EventHandler(this.ListInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbInoviceType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btndelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadDropDownList cmbSupplier;
        private System.Windows.Forms.Label lblsupplier;
        private Telerik.WinControls.UI.RadDropDownList cmbInoviceType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbldescription;
        private Telerik.WinControls.UI.RadTextBox txtDescription;
        private System.Windows.Forms.Label lblinvoicenumber;
        private Telerik.WinControls.UI.RadTextBox txtInvoiceNumber;
        private System.Windows.Forms.Label lblid;
        private Telerik.WinControls.UI.RadTextBox txtID;
        private Telerik.WinControls.UI.RadDropDownList cmbPos;
        private System.Windows.Forms.Label lblPos;
        private Telerik.WinControls.UI.RadButton btnClear;
        private Telerik.WinControls.UI.RadButton btndelete;
        private Telerik.WinControls.UI.RadButton btnUpdate;
        private Telerik.WinControls.UI.RadButton btnShowDetails;
    }
}