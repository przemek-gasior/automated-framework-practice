using OpenQA.Selenium;
using SeleniumTestFramework.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTestFramework.Pages
{
    public class CartPage : ICartPage
    {
        private readonly ISetup _setup;

        public IWebElement FirstItemInCart => _setup.Driver.FindElement(By.ClassName("img-container"));

        public CartPage(ISetup setup)
        {
            _setup = setup;
        }
        public bool CheckForItemsInCart()
        {
            if(FirstItemInCart != null)
            {
                return true;
            }
            return false;
        }
    }
}
