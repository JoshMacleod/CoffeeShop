namespace Coffee_Shop
{
    partial class CoffeeShopPOS
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
            this.lstProductsChosen = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.txtInfoPanel = new System.Windows.Forms.TextBox();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstProductsChosen
            // 
            this.lstProductsChosen.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProductsChosen.FormattingEnabled = true;
            this.lstProductsChosen.ItemHeight = 14;
            this.lstProductsChosen.Location = new System.Drawing.Point(614, 12);
            this.lstProductsChosen.Name = "lstProductsChosen";
            this.lstProductsChosen.Size = new System.Drawing.Size(357, 424);
            this.lstProductsChosen.TabIndex = 0;
            this.lstProductsChosen.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.FormatListItem);
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(13, 54);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(595, 382);
            this.tabControl1.TabIndex = 2;
            // 
            // txtInfoPanel
            // 
            this.txtInfoPanel.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfoPanel.Location = new System.Drawing.Point(13, 13);
            this.txtInfoPanel.Name = "txtInfoPanel";
            this.txtInfoPanel.Size = new System.Drawing.Size(595, 35);
            this.txtInfoPanel.TabIndex = 3;
            this.txtInfoPanel.Text = "Next Customer";
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.BackColor = System.Drawing.Color.Red;
            this.btnDeleteItem.Location = new System.Drawing.Point(614, 443);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(93, 84);
            this.btnDeleteItem.TabIndex = 4;
            this.btnDeleteItem.Text = "&Delete";
            this.btnDeleteItem.UseVisualStyleBackColor = false;
            this.btnDeleteItem.Click += new System.EventHandler(this.DeleteItem);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.Lime;
            this.btnPay.Location = new System.Drawing.Point(13, 443);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(595, 84);
            this.btnPay.TabIndex = 5;
            this.btnPay.Text = "&Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.OpenPayment);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(856, 443);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(115, 20);
            this.txtTotal.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(815, 446);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Total";
            // 
            // CoffeeShopPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 539);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.txtInfoPanel);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lstProductsChosen);
            this.Name = "CoffeeShopPOS";
            this.Text = "Coffee Shop Till";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstProductsChosen;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox txtInfoPanel;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label1;
    }
}