using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Shop
{
    public partial class DisplaySales : Form
    {
        public DisplaySales()
        {
            InitializeComponent();
            generateGraph();
        }

        private void generateGraph()
        {
            using (CoffeeShopDatabaseEntities1 cse = new CoffeeShopDatabaseEntities1())
            {
                var query = (from product in cse.tblTransactionItems
                            group product by product.tblProduct.Description into g
                            select new { ProductID = g.Key, TotalUnitsSold = g.Count() }).ToList();

                chart1.DataSource = query;

                chart1.Series["Series1"].XValueMember = "ProductID";
                chart1.Series["Series1"].YValueMembers = "TotalUnitsSold";
                chart1.Series["Series1"].Name = "Products";

                chart1.DataBind();

                chart1.Show();
            }
        }
    }
}
