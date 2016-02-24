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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewProducts viewProducts = new ViewProducts();
            viewProducts.Show();
        }

        private void btnOpenTill_Click(object sender, EventArgs e)
        {
            CoffeeShopPOS coffeeShopPOS = new CoffeeShopPOS();
            coffeeShopPOS.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DisplaySales displaySales = new DisplaySales();
            displaySales.Show();
        }
    }
}
