using ClassLibrary1.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shouldly;

namespace ClassLibrary1.Test
{
    [TestFixture]
    class LoginTest
    {
        [Test]

         public void LoginPageTest()
        {
            
            var userName = "admin";
           var password = "2VLu=j^ykC";


            using (var driver = new ChromeDriver())
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                driver.Navigate().GoToUrl("https://nitro.duckdns.org/sst-classes/login");
                var loginPage = new LoginPage(driver);

                loginPage.Login(userName, password);

                var clientPage = new NavigationMenuPage(driver);

                clientPage.GetClientPageHeader().ShouldContain("Clients");
                clientPage.getClientPageHeaderAdmin().ShouldContain("admin");
                clientPage.SelectLogOut();
                loginPage.GetLoginHeaderH2().ShouldContain("Login");
            }

        }
    }
}
