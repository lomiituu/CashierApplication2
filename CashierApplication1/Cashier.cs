using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApplication1
{
    internal class Cashier : UserAccount
    {
        private string department;

        public Cashier(string name, string department, string uName, string password) : base(name, uName, password)
        {
            this.full_name = name;
            this.user_name = uName;
            this.user_password = password;
        }

        public override bool validateLogin(string uName, string password)
        {
            if (user_name == "customer1" && user_password == "123456789")
            {
                return true;
            } else
            {
                return false;
            }
        }

        public string getDepartment()
        {
            return department;
        }
    }
}
