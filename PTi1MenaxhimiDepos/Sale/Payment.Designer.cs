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
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(13, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kthim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pagoi";
            // 
            // txtTotali
            // 
            this.txtTotali.Font = new System.Drawing.Font("Segoe UI", 30.25F);
            this.txtTotali.Location = new System.Drawing.Point(91, 26);
            this.txtTotali.Name = "txtTotali";
            this.txtTotali.Size = new System.Drawing.Size(406, 59);
            this.txtTotali.TabIndex = 14;
            this.txtTotali.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotali.TextChanged += new System.EventHandler(this.txtTotali_TextChanged);
            // 
            // txtKthimi
            // 
            this.txtKthimi.Font = new System.Drawing.Font("Segoe UI", 38.25F);
            this.txtKthimi.Location = new System.Drawing.Point(91, 108);
            this.txtKthimi.Name = "txtKthimi";
            this.txtKthimi.Size = new System.Drawing.Size(406, 90);
            this.txtKthimi.TabIndex = 16;
            this.txtKthimi.Text = "0.00";
            this.txtKthimi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // radButton2
            // 
            this.radButton2.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.radButton2.Image = global::PTi1MenaxhimiDepos.Properties.Resources.cancel_icon1;
            this.radButton2.Location = new System.Drawing.Point(213, 225);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(137, 46);
            this.radButton2.TabIndex = 17;
            this.radButton2.Text = "Close";
            this.radButton2.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.radButton2.Click += new System.EventHandler(this.radButton2_Click);
            // 
            // radButton1
            // 
            this.radButton1.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.radButton1.Image = global::PTi1MenaxhimiDepos.Properties.Resources.payment;
            this.radButton1.Location = new System.Drawing.Point(358, 225);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(137, 46);
            this.radButton1.TabIndex = 17;
            this.radButton1.Text = "Pay";
            this.radButton1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 283);
            this.Controls.Add(this.radButton2);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.txtKthimi);
            this.Controls.Add(this.txtTotali);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Payment";
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