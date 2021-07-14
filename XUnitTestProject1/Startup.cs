using Microsoft.Extensions.DependencyInjection;
using SeleniumTestFramework;
using SeleniumTestFramework.Pages;
using SeleniumTestFramework.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTestProject1
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IRegistrationAndLogin, RegistrationAndLogin>();
            services.AddTransient<ISearchPage, SearchPage>();
            services.AddTransient<ICartPage, CartPage>();
            services.AddTransient<IBasePageAndNavigation, BasePageAndNavigation>();
            services.AddSingleton<ISetup, Setup>();
        }
    }
}
