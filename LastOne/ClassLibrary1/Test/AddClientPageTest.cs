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
    class AddClientPageTest
    {
        [Test]
        public void ClientTestPage()
        {
            // TODO: think how to avoid duplicating the same username and password in each test. Also what if another environment the credentials are different?
            var userName = "admin";
            var password = "2VLu=j^ykC";
            var customer = new Customer();
          
            using (var driver = new ChromeDriver())
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                
                URLs.OpenUrl(driver);
                var loginPage = new LoginPage(driver);
                var navigationMenuPage = new NavigationMenuPage(driver);
                var addClientPage = new AddClientPage(driver);

                loginPage.Login(userName, password);

                navigationMenuPage.AddClientButtonClick();
                addClientPage.AddClientHeader().ShouldContain("Add Client");
                addClientPage.FillOutContactInformation(customer);

                addClientPage.GetClientHeader().ShouldContain("Client");


            }





        }

    }
}
