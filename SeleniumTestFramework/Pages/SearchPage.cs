using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using SeleniumTestFramework.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTestFramework.Pages
{
    public class SearchPage : ISearchPage
    {
        private readonly ISetup _setup;
       
        public IWebElement FirstItemOnTheList => _setup.Driver.FindElement(By.XPath("//span[contains(@class,'hidden-sm')][contains(text(),'Do koszyka')]"));
        public IWebElement CloseButtonPopUpWindow => _setup.Driver.FindElement(By.ClassName("md-header-close-btn"));
        

        public SearchPage(ISetup setup)
        {
            _setup = setup;
        }
        public void AddItemToTheCart()
        {            
            _setup.Wait.Until(ExpectedConditions.ElementExists(By.Id("pushpushgo-container")));
            FirstItemOnTheList.Click();
        }

        public void ClosePopUpWindow()
        {            
            var result = _setup.Wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("md-header-close-btn")));
            result.Click();          
        }
    }
}
