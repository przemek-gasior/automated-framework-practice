using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTestFramework.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTestFramework.Pages
{
    public class BasePageAndNavigation : IBasePageAndNavigation
    {
        private readonly ISetup _setup;

        public IWebElement LoginRegisterButton => _setup.Driver.FindElement(By.ClassName("icon-user"));
        public IWebElement LogoutButton => _setup.Driver.FindElement(By.ClassName("un-logout"));

        public BasePageAndNavigation(ISetup setup)
        {
            _setup = setup;
        }

        public bool CheckForLogoutButton()
        {
            if(LogoutButton != null)
            {
                return true;
            }
            return false;
        }

        public void ClickOnLoginRegisterButton()
        {
            LoginRegisterButton.Click();
        }

        public void GoTo()
        {
            _setup.Driver.Navigate().GoToUrl("http://morele.net");          
        }
    }
}
