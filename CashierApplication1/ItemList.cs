using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApplication1
{
    public abstract class ItemList
    {
        protected string item_name;
        protected double item_price;
        protected int item_quantity;
        protected double total_price;

        public ItemList(string name, double price, int quantity)
        {
            this.item_name = name;
            this.item_price = price;
            this.item_quantity = quantity;
            this.total_price = 0.0;
        }

        public abstract double getTotalPrice();

        public abstract void setPayment(double amount);
    }
}
