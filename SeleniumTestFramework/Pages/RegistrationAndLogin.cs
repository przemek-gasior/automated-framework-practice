using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTestFramework.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTestFramework.Pages
{
    public class RegistrationAndLogin : IRegistrationAndLogin
    {

        private readonly ISetup _setup;

        public IWebElement RegistrationTab => _setup.Driver.FindElement(By.Id("register-tab"));
        public IWebElement EmailInputField => _setup.Driver.FindElement(By.Id("user_userEmail"));
        public IWebElement PasswordInputField => _setup.Driver.FindElement(By.Id("user_plainPassword"));
        public ICollection<IWebElement> Sliders => _setup.Driver.FindElements(By.ClassName("slider"));
        public IWebElement SubmitButton => _setup.Driver.FindElement(By.XPath("//*[@id='register_form']/button"));
        public IWebElement UsernameLoginInputField => _setup.Driver.FindElement(By.Id("username"));
        public IWebElement PasswordLoginInputField => _setup.Driver.FindElement(By.Id("password-log"));
        public IWebElement LoginSubmitButton => _setup.Driver.FindElement(By.XPath("//*[@id='login_form']/button"));

        public RegistrationAndLogin(ISetup setup)
        {
            _setup = setup;
        }
        
        public void LoginExistingUser()
        {
            UsernameLoginInputField.Clear();
            UsernameLoginInputField.SendKeys(_setup.User.EmailAdress);
            PasswordLoginInputField.SendKeys(_setup.User.Password);
            LoginSubmitButton.Click();
        }

        public void RegisterNewUser()
        {
            RegistrationTab.Click();
            EmailInputField.SendKeys(_setup.User.EmailAdress);
            PasswordInputField.SendKeys(_setup.User.Password);
            foreach (var item in Sliders) item.Click();
            SubmitButton.Click();
        }


    }
}
