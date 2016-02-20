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
using System.Drawing.Printing;

namespace Coffee_Shop
{
    public partial class CoffeeShopPOS : Form
    {
        private BindingList<tblProduct> products = new BindingList<tblProduct>();
        private CoffeeShopDatabaseEntities1 cse = new CoffeeShopDatabaseEntities1();

        private decimal transactionTotal;

        public decimal TransactionTotal
        {
            get { return transactionTotal; }
            set
            {
                transactionTotal = value;
                txtTotal.Text = String.Format("{0:c}", transactionTotal);
            }
        }

        public CoffeeShopPOS()
        {
            InitializeComponent();

            lstProductsChosen.DataSource = products;
            lstProductsChosen.DisplayMember = "Description";

            CreateTabbedPanel();

            AddProductsToTabbedPanel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tblProduct p = new tblProduct() { Description = "Product A", Price = 1.99M };
            products.Add(p);
        }

        private void FormatListItem(object sender, ListControlConvertEventArgs e)
        {
            string currentDescription = ((tblProduct)e.ListItem).Description;
            string currentPrice = String.Format("{0:c}",((tblProduct)e.ListItem).Price);
            string currentDescriptionPadded = currentDescription.PadRight(30);

            e.Value = currentDescriptionPadded + currentPrice;
        }

        private void CreateTabbedPanel()
        {
            foreach (tblProductType pt in cse.tblProductTypes)
            {
                tabControl1.TabPages.Add(pt.ProductType.ToString(), pt.Description);
            }
        }

        private void AddProductsToTabbedPanel()
        {
            var adapter = (IObjectContextAdapter)cse;
            var objectContext = adapter.ObjectContext;

            int i = 1;
            foreach (TabPage tp in tabControl1.TabPages)
            {
                ObjectQuery<tblProduct> filteredProduct = new ObjectQuery<tblProduct>
                    ("SELECT VALUE P FROM tblProducts AS P WHERE P.ProductType = " + i.ToString(), objectContext);

                FlowLayoutPanel flp = new FlowLayoutPanel();

                flp.Dock = DockStyle.Fill;

                foreach (tblProduct tProd in filteredProduct)
                {
                    Button b = new Button();
                    b.Size = new Size(100, 100);
                    b.Text = tProd.Description;
                    b.Tag = tProd;
                    b.Click += UpdateProductList;
                    flp.Controls.Add(b);
                }

                tp.Controls.Add(flp);
                i++;
            }
        }

        private void UpdateProductList(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            tblProduct p = (tblProduct)b.Tag;

            products.Add(p);

            UpdateCustomerInformationPanel(p);

            TransactionTotal = TransactionTotal + (decimal)p.Price;

            lstProductsChosen.SelectedIndex = lstProductsChosen.Items.Count - 1;
        }

        private void UpdateCustomerInformationPanel(tblProduct product)
        {
            string currentDescription = product.Description;
            string currentPrice = String.Format("{0:c}", product.Price);
            string currentDescriptionPadded = currentDescription.PadRight(30);

            txtInfoPanel.Text = currentDescriptionPadded + currentPrice;
        }

        private void DeleteItem(object sender, EventArgs e)
        {
            tblProduct selectedProduct = (tblProduct)lstProductsChosen.SelectedItem;
            products.Remove(selectedProduct);
            TransactionTotal = TransactionTotal - (decimal)selectedProduct.Price;
        }

        private void OpenPayment(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            payment.PaymentAmount = TransactionTotal;
            payment.ShowDialog();
            payment.PaymentMade += paymentSuccess;
        }

        private void paymentSuccess(object sender, PaymentMadeEventArgs e)
        {
            //tblTransaction transaction = new tblTransaction();
            //transaction.TransactionDate = DateTime.Now;

            //if (e.PaymentSuccess == true)
            //{
            //    foreach (tblProduct product in products)
            //    {
            //        transaction.tblTransactionItems.Add(new tblTransactionItem() { ProductID = product.ProductID });
            //    }

            //    cse.tblTransactions.Add(transaction);
            //    cse.SaveChanges();

            MessageBox.Show(e.PaymentSuccess.ToString());
            //}
        }

        private void PrintReceipt()
        {
            PrintDialog printDialog = new PrintDialog();

            PrintDocument printDocument = new PrintDocument();

            printDialog.Document = printDocument;

            printDocument.PrintPage += PrintDocument_PrintPage;

            DialogResult result = printDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;

            Font font = new Font("Courier New", 12);
            SolidBrush brush = new SolidBrush(Color.Black);

            float fontHeight = font.GetHeight();

            int startX = 10;
            int startY = 10;
            int offset = 40;

            graphic.DrawString("Welcome to the coffee shop", new Font("Courier New", 18), brush, startX, startY);

            foreach (tblProduct product in products)
            {
                string productDescription = product.Description.PadRight(30);
                string productTotal = String.Format("{0:c}", product.Price);
                string productLine = productDescription + productTotal;

                graphic.DrawString(productLine, font, brush, startX, startY + offset);

                offset = offset + (int)fontHeight + 5;
            }

            offset = offset + 20;

            graphic.DrawString("Total to pay: ".PadRight(30) + String.Format("{0:c}", transactionTotal), font, brush, startX, startY + offset);
        }
    }
}
