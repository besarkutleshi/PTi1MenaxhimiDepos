namespace PTi1MenaxhimiDepos.Sale
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotali = new Telerik.WinControls.UI.RadTextBox();
            this.txtKthimi = new Telerik.WinControls.UI.RadTextBox();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotali)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKthimi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtTotali
            // 
            resources.ApplyResources(this.txtTotali, "txtTotali");
            this.txtTotali.Name = "txtTotali";
            this.txtTotali.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotali.TextChanged += new System.EventHandler(this.txtTotali_TextChanged);
            // 
            // txtKthimi
            // 
            resources.ApplyResources(this.txtKthimi, "txtKthimi");
            this.txtKthimi.Name = "txtKthimi";
            this.txtKthimi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // radButton2
            // 
            resources.ApplyResources(this.radButton2, "radButton2");
            this.radButton2.Image = global::PTi1MenaxhimiDepos.Properties.Resources.cancel_icon1;
            this.radButton2.Name = "radButton2";
            this.radButton2.Click += new System.EventHandler(this.radButton2_Click);
            // 
            // radButton1
            // 
            resources.ApplyResources(this.radButton1, "radButton1");
            this.radButton1.Image = global::PTi1MenaxhimiDepos.Properties.Resources.payment;
            this.radButton1.Name = "radButton1";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // Payment
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radButton2);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.txtKthimi);
            this.Controls.Add(this.txtTotali);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTotali)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKthimi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadTextBox txtTotali;
        private Telerik.WinControls.UI.RadTextBox txtKthimi;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadButton radButton2;
    }
}