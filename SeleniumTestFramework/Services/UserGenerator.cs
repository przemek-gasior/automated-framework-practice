using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTestFramework.Services
{
    public class UserGenerator
    {
        public string EmailAdress { get; set; }
        public string Password { get; set; }

        public UserGenerator()
        {
            EmailAdress = "nowysuperemail@gmail.com";
            Password = "passwordpassword";
        }
    }
}
