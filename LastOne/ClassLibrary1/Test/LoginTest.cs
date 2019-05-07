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
                
                loginPage.LoginInput(userName, password);
                loginPage.LoginButtonClick();

                var clientPage = new NavigationMenuPage(driver);

                clientPage.ClientPageHeader().ShouldContain("Clients");
                clientPage.ClientPageHeaderAdmin().ShouldContain("admin");
                clientPage.SelectLogOut();
                loginPage.LoginHeaderH2Text().ShouldContain("Login");
            }

        }
    }
}
