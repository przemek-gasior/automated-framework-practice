using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTestFramework.Services
{
    public interface IRegistrationAndLogin
    {
        void LoginExistingUser();
        void RegisterNewUser();

    }
}
