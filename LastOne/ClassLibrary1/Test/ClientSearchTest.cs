using ClassLibrary1.Configuration;
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
                URLs.OpenUrl(driver);

                var loginPage = new LoginPage(driver);
                var clientSearchPage = new ClientSearchPage(driver);

                loginPage.Login(userName, password);
                clientSearchPage.SearchInputId(email);
                clientSearchPage.SearchInputClick();
                clientSearchPage.GetSearchTableClient().ShouldContain("Iryna Shch");

            }
        }
    }
}
