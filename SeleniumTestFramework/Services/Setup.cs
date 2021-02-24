using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTestFramework.Services
{
    public class Setup : IDisposable, ISetup
    {
        public IWebDriver Driver { get; set; }

        public UserGenerator User { get; set; }

        public Setup()
        {
            Driver = new ChromeDriver(SetOptions());           
            User = new UserGenerator();
        }

        public void Dispose()
        {
            Driver.Dispose();
            Driver.Close();
        }

        private ChromeOptions SetOptions()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("start-maximized");
            options.AddArguments("--incognito");
            return options;
        }
    }
}
