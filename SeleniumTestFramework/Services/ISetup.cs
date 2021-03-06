﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTestFramework.Services
{
    public interface ISetup
    {
        public IWebDriver Driver { get; set; }
        public UserGenerator User { get; set; }
        public WebDriverWait Wait { get; set; }
    }
}
