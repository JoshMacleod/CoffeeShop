namespace Coffee_Shop
{
    partial class ViewProducts
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.tblProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coffeeShopDatabaseDataSet = new Coffee_Shop.CoffeeShopDatabaseDataSet();
            this.tblProductTableAdapter = new Coffee_Shop.CoffeeShopDatabaseDataSetTableAdapters.tblProductTableAdapter();
            this.cboFilter = new System.Windows.Forms.ComboBox();
            this.tblProductTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblProductTypeTableAdapter = new Coffee_Shop.CoffeeShopDatabaseDataSetTableAdapters.tblProductTypeTableAdapter();
            this.tblProductBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeShopDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.productTypeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.Image});
            this.dataGridView1.DataSource = this.tblProductBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(676, 359);
            this.dataGridView1.TabIndex = 0;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.productIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // productTypeDataGridViewTextBoxColumn
            // 
            this.productTypeDataGridViewTextBoxColumn.DataPropertyName = "ProductType";
            this.productTypeDataGridViewTextBoxColumn.HeaderText = "ProductType";
            this.productTypeDataGridViewTextBoxColumn.Name = "productTypeDataGridViewTextBoxColumn";
            this.productTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.productTypeDataGridViewTextBoxColumn.Visible = false;
            this.productTypeDataGridViewTextBoxColumn.Width = 93;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 85;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.priceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 56;
            // 
            // Image
            // 
            this.Image.DataPropertyName = "Image";
            this.Image.HeaderText = "Image";
            this.Image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            this.Image.Width = 42;
            // 
            // tblProductBindingSource
            // 
            this.tblProductBindingSource.DataMember = "tblProduct";
            this.tblProductBindingSource.DataSource = this.coffeeShopDatabaseDataSet;
            // 
            // coffeeShopDatabaseDataSet
            // 
            this.coffeeShopDatabaseDataSet.DataSetName = "CoffeeShopDatabaseDataSet";
            this.coffeeShopDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblProductTableAdapter
            // 
            this.tblProductTableAdapter.ClearBeforeFill = true;
            // 
            // cboFilter
            // 
            this.cboFilter.DataSource = this.tblProductTypeBindingSource;
            this.cboFilter.DisplayMember = "Description";
            this.cboFilter.FormattingEnabled = true;
            this.cboFilter.Location = new System.Drawing.Point(12, 390);
            this.cboFilter.Name = "cboFilter";
            this.cboFilter.Size = new System.Drawing.Size(268, 21);
            this.cboFilter.TabIndex = 1;
            this.cboFilter.ValueMember = "ProductType";
            this.cboFilter.SelectionChangeCommitted += new System.EventHandler(this.FilterList);
            // 
            // tblProductTypeBindingSource
            // 
            this.tblProductTypeBindingSource.DataMember = "tblProductType";
            this.tblProductTypeBindingSource.DataSource = this.coffeeShopDatabaseDataSet;
            // 
            // tblProductTypeTableAdapter
            // 
            this.tblProductTypeTableAdapter.ClearBeforeFill = true;
            // 
            // tblProductBindingSource1
            // 
            this.tblProductBindingSource1.DataMember = "tblProduct";
            this.tblProductBindingSource1.DataSource = this.coffeeShopDatabaseDataSet;
            // 
            // ViewProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 423);
            this.Controls.Add(this.cboFilter);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewProducts";
            this.Text = "View Products";
            this.Load += new System.EventHandler(this.ViewProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeShopDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private CoffeeShopDatabaseDataSet coffeeShopDatabaseDataSet;
        private System.Windows.Forms.BindingSource tblProductBindingSource;
        private CoffeeShopDatabaseDataSetTableAdapters.tblProductTableAdapter tblProductTableAdapter;
        private System.Windows.Forms.ComboBox cboFilter;
        private System.Windows.Forms.BindingSource tblProductTypeBindingSource;
        private CoffeeShopDatabaseDataSetTableAdapters.tblProductTypeTableAdapter tblProductTypeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.BindingSource tblProductBindingSource1;
    }
}