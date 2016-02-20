using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Coffee_Shop
{
    public partial class AddProduct : Form
    {
        private Byte[] byteBLOBData;
        private CoffeeShopDatabaseEntities1 cse = new CoffeeShopDatabaseEntities1();

        public AddProduct()
        {
            InitializeComponent();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'coffeeShopDatabaseDataSet.tblProductType' table. You can move, or remove it, as needed.
            this.tblProductTypeTableAdapter.Fill(this.coffeeShopDatabaseDataSet.tblProductType);

        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                FileStream fsBLOBFile = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);

                byteBLOBData = new Byte[fsBLOBFile.Length];

                fsBLOBFile.Read(byteBLOBData, 0, byteBLOBData.Length);

                fsBLOBFile.Close();

                MemoryStream stmBLOBData = new MemoryStream(byteBLOBData);

                pbImage.Image = Image.FromStream(stmBLOBData);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            tblProduct product = new tblProduct();

            product.Description = txtDescription.Text;
            product.Price = decimal.Parse(txtPrice.Text);
            product.Image = byteBLOBData;
            product.ProductType = (int)cboCategory.SelectedValue;

            cse.tblProducts.Add(product);
            cse.SaveChanges();

            MessageBox.Show("Record saved");
        }
    }
}
