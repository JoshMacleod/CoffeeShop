namespace Coffee_Shop
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmountToPay = new System.Windows.Forms.TextBox();
            this.txtPaymentAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPaymentMade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount to pay:";
            // 
            // txtAmountToPay
            // 
            this.txtAmountToPay.Location = new System.Drawing.Point(142, 25);
            this.txtAmountToPay.Name = "txtAmountToPay";
            this.txtAmountToPay.Size = new System.Drawing.Size(127, 20);
            this.txtAmountToPay.TabIndex = 1;
            // 
            // txtPaymentAmount
            // 
            this.txtPaymentAmount.Location = new System.Drawing.Point(142, 69);
            this.txtPaymentAmount.Name = "txtPaymentAmount";
            this.txtPaymentAmount.Size = new System.Drawing.Size(127, 20);
            this.txtPaymentAmount.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Payment amount:";
            // 
            // btnPaymentMade
            // 
            this.btnPaymentMade.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPaymentMade.Location = new System.Drawing.Point(101, 118);
            this.btnPaymentMade.Name = "btnPaymentMade";
            this.btnPaymentMade.Size = new System.Drawing.Size(112, 45);
            this.btnPaymentMade.TabIndex = 4;
            this.btnPaymentMade.Text = "Payment Made";
            this.btnPaymentMade.UseVisualStyleBackColor = true;
            this.btnPaymentMade.Click += new System.EventHandler(this.PaymentHasBeenMade);
            // 
            // Payment
            // 
            this.AcceptButton = this.btnPaymentMade;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 189);
            this.Controls.Add(this.btnPaymentMade);
            this.Controls.Add(this.txtPaymentAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAmountToPay);
            this.Controls.Add(this.label1);
            this.Name = "Payment";
            this.Text = "Payment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAmountToPay;
        private System.Windows.Forms.TextBox txtPaymentAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPaymentMade;
    }
}