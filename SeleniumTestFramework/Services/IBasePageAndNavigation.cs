using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTestFramework.Services
{
    public interface IBasePageAndNavigation
    {
        bool CheckForLogoutButton();
        void ClickOnLoginRegisterButton();
        void GoTo();
        void HoverOverListItemAndPickFromList();
        void GoToCart();

    }
}