using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierApplication1
{
    public partial class frmPurchaseDiscountedItem : Form
    {
        private ItemDiscount discountedItem;
        public frmPurchaseDiscountedItem()

        {
            InitializeComponent();
        }

        private void frmPurchaseDiscountedItem_Load(object sender, EventArgs e)
        {

        }

        private void ComputeButton_Click(object sender, EventArgs e)
        {
            string name = ItemTextBox.Text;
            double price = Convert.ToDouble(PriceTextBox.Text);
            int quantity = Convert.ToInt32(QuantityTextBox.Text);
            double discount = Convert.ToDouble(DiscountTextBox.Text);

            discountedItem = new ItemDiscount(name, price, quantity, discount);
            double totalPrice = discountedItem.getTotalPrice();
            TotalAmountLabel.Text = totalPrice.ToString();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            double paymentAmount = Convert.ToDouble(PaymentReceiveTextBox.Text);
            discountedItem.setPayment(paymentAmount);
            double change = discountedItem.getChange();
            ChangeLabel.Text = change.ToString();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLoginAccount loginForm = new frmLoginAccount();
            loginForm.ShowDialog();
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
