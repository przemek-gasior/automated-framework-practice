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


        public TestsForECommerce(IRegistrationAndLogin registrationAndLogin,
            IBasePageAndNavigation basePageAndNavigation)
        {
            _registrationAndLogin = registrationAndLogin;
            _basePageAndNavigation = basePageAndNavigation;
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

    }
}
