using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTestFramework.Services
{
    public class Setup : IDisposable, ISetup
    {
        public IWebDriver Driver { get; set; }

        public UserGenerator User { get; set; }
        public WebDriverWait Wait { get ; set; }

        public Setup()
        {
            Driver = new ChromeDriver(SetOptions());           
            User = new UserGenerator();
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
        }

        public void Dispose()
        {
            Driver.Dispose();
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
