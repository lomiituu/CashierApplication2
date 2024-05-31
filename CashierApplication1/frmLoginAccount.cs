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
    public partial class frmLoginAccount : Form
    {
        public frmLoginAccount()
        {
            InitializeComponent();
        }

        private Cashier cashier;

        private void button1_Click(object sender, EventArgs e)
        {
            cashier = new Cashier("Jhon Clarence Garcia", "IT Dept", UsernameTextBox.Text, PasswordTextBox.Text);

            if(cashier.validateLogin(UsernameTextBox.Text, PasswordTextBox.Text))
            {
                MessageBox.Show("Welcome " + cashier.getFullName() + " of " + cashier.getDepartment(), "Succesfully Login", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    
                frmPurchaseDiscountedItem form = new frmPurchaseDiscountedItem();
                this.Hide();
                form.Show();
            } else
            {
                MessageBox.Show("Login failed.", "Failed", MessageBoxButtons.RetryCancel);
            }
        }
    }
}
