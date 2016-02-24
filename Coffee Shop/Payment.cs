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
    public partial class Payment : Form
    {
        public delegate void PaymentMadeEvent(object sender, PaymentMadeEventArgs e);

        public event PaymentMadeEvent PaymentMade;

        private decimal paymentAmount;

        public decimal PaymentAmount
        {
            get { return paymentAmount; }
            set
            {
                paymentAmount = value;
                txtAmountToPay.Text = String.Format("{0:c}", paymentAmount);
            }
        }

        public Payment()
        {
            InitializeComponent();
        }


        private void PaymentHasBeenMade(object sender, EventArgs e)
        {
            decimal total = 0;

            try
            {
                total = decimal.Parse(txtAmountToPay.Text.TrimStart('£')) - decimal.Parse(txtPaymentAmount.Text);
            }
            catch
            {
                MessageBox.Show("An error has occurred, please enter a valid amount");
                return;
            }

            if (total > 0)
            {
                txtAmountToPay.Text = total.ToString();
            }
            else if (total == 0)
            {
                PaymentMade(this, new PaymentMadeEventArgs()
                {
                    PaymentSuccess = true
                });
                this.Close();
            }
            else
            {
                MessageBox.Show("Change: " + String.Format("{0:c}", -total));
                PaymentMade(this, new PaymentMadeEventArgs() { PaymentSuccess = true });
                this.Close();
            }
        }
    }

    public class PaymentMadeEventArgs : EventArgs
    {
        private bool paymentSuccess;

        public bool PaymentSuccess
        {
            get { return paymentSuccess; }
            set { paymentSuccess = value; }
        }
    }
}