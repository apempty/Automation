using ClassLibrary1.PageObjects;
using ClassLibrary1.TestData;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Test
{

    [TestFixture]
    class ClientSearchTest
    {
        [Test]
        public void ClientSearchPageTest()
        {
            var userName = "admin";
            var password = "2VLu=j^ykC";
            string email = "ilka@mailinator.com";

            using (var driver = new ChromeDriver())
            {

                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                driver.Navigate().GoToUrl("https://nitro.duckdns.org/sst-classes/login");

                var loginPage = new LoginPage(driver);
                var clientSearchPage = new ClientSearchPage(driver);
                
                loginPage.LoginInput(userName, password);
                loginPage.LoginButtonClick();
                clientSearchPage.SearchInputClick(email);
                clientSearchPage.SearchTableClient().ShouldContain("Iryna Shch");

            }
        }
    }
}
