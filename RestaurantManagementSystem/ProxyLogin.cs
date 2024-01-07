using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{
    class ProxyLogin : ILogin
    {
        private ILogin iLogin;
        private string userName;
        private string password;
        private string secretKey;
        public ProxyLogin(string userName, string password, string secretKey)
        {
            this.userName = userName;
            this.password = password;
            this.secretKey = secretKey;
        }
        public bool performLogin()
        {
            if ((userName == "Sameer" || userName == "sameer" || userName == "Hadi" || userName == "Taqi") && password == "123" && secretKey == "786")
            {
                iLogin = new Login();
                iLogin.performLogin();
                Console.WriteLine("Login Successful");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
