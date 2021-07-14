using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
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
        public IWebElement LaptopListItem => _setup.Driver.FindElement(By.XPath("//span[contains(@class,'cn-name-value')][contains(text(),'Laptopy')]"));
        public IWebElement LaptopExpandedListItem => _setup.Driver.FindElement(By.XPath("//a[contains(@href,'/kategoria/laptopy-31/')]"));
        public IWebElement CartButton => _setup.Driver.FindElement(By.XPath("//a[contains(@href,'/koszyk/')]"));



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
            _setup.Wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("icon-user")));
            LoginRegisterButton.Click();
        }

        public void GoTo()
        {
            _setup.Driver.Navigate().GoToUrl("http://morele.net");          
        }

        public void HoverOverListItemAndPickFromList()
        {
            var action = new Actions(_setup.Driver);
            action.MoveToElement(LaptopListItem).Perform();
            LaptopExpandedListItem.Click();
            
        }

        public void GoToCart()
        {
            var result = _setup.Wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[contains(@href,'/koszyk/')]")));            
            result.Click();
        }

    }
}
