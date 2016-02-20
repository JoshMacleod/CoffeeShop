using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;

namespace Coffee_Shop
{
    public partial class ViewProducts : Form
    {
        private CoffeeShopDatabaseEntities1 cse = new CoffeeShopDatabaseEntities1();

        public ViewProducts()
        {
            InitializeComponent();
        }

        private void ViewProducts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'coffeeShopDatabaseDataSet.tblProductType' table. You can move, or remove it, as needed.
            this.tblProductTypeTableAdapter.Fill(this.coffeeShopDatabaseDataSet.tblProductType);
            // TODO: This line of code loads data into the 'coffeeShopDatabaseDataSet.tblProduct' table. You can move, or remove it, as needed.
            this.tblProductTableAdapter.Fill(this.coffeeShopDatabaseDataSet.tblProduct);

        }

        private void FilterList(object sender, EventArgs e)
        {
            var adapter = (IObjectContextAdapter)cse;
            var objectContext = adapter.ObjectContext;

            ObjectQuery<tblProduct> filteredProducts = new ObjectQuery<tblProduct>
                ("SELECT VALUE C FROM tblProducts AS C WHERE C.ProductType = " + cboFilter.SelectedValue, objectContext);

            dataGridView1.DataSource = filteredProducts;
        }
    }
}
