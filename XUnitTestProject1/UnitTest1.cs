using SeleniumTestFramework;
using SeleniumTestFramework.Services;
using System;
using Xunit;

namespace XUnitTestProject1
{


    public class TestsForECommerce
    {
        private readonly IRegistrationAndLogin _registrationAndLogin;
        private readonly IBasePageAndNavigation _basePageAndNavigation;
        private readonly ICartPage _cartPage;
        private readonly ISearchPage _searchPage;

        public TestsForECommerce(IRegistrationAndLogin registrationAndLogin,
            IBasePageAndNavigation basePageAndNavigation,
            ICartPage cartPage,
            ISearchPage searchPage)
        {
            _registrationAndLogin = registrationAndLogin;
            _basePageAndNavigation = basePageAndNavigation;
            _cartPage = cartPage;
            _searchPage = searchPage;
        }

        [Fact]
        public void TestLoginFlow()
        {
            _basePageAndNavigation.GoTo();
            _basePageAndNavigation.ClickOnLoginRegisterButton();
            _registrationAndLogin.LoginExistingUser();
            Assert.True(_basePageAndNavigation.CheckForLogoutButton());
        }

        [Fact]
        public void TestRegistrationFlow()
        {
            _basePageAndNavigation.GoTo();
            _basePageAndNavigation.ClickOnLoginRegisterButton();
            _registrationAndLogin.RegisterNewUser();
        }

        [Fact]
        public void TestShopFlowFromSideList()
        {
            _basePageAndNavigation.GoTo();
            _basePageAndNavigation.HoverOverListItemAndPickFromList();
            _searchPage.AddItemToTheCart();
            _searchPage.ClosePopUpWindow();
            _basePageAndNavigation.GoToCart();
            Assert.True(_cartPage.CheckForItemsInCart());
        }

    }
}
