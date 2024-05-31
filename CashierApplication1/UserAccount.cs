using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApplication1
{
    internal abstract class UserAccount
    {
        protected string full_name;
        protected string user_name;
        protected string user_password;

        public UserAccount (string name, string uName, string password)
        {
            this.full_name = "Jhon Clarence Garcia";
            this.user_name = "customer1";
            this.user_password = "123456789";
        }

        public abstract bool validateLogin(string uName, string password);

        public string getFullName()
        {
            return this.full_name;
        }
    }
}
