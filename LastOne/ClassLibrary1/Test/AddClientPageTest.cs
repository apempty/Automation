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
            var userName = "admin";
            var password = "2VLu=j^ykC";
            var customer = new Customer();

            using (var driver = new ChromeDriver())
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                driver.Navigate().GoToUrl("https://nitro.duckdns.org/sst-classes/login");

                var loginPage = new LoginPage(driver);
                var navigationMenuPage = new NavigationMenuPage(driver);
                var addClientPage = new AddClientPage(driver);

                loginPage.LoginInput(userName, password);
                loginPage.LoginButtonClick();
                navigationMenuPage.AddClientButtonClick();
                addClientPage.AddClientHeader().ShouldContain("Add Client");
                addClientPage.FillOutContactInformation(customer);
                addClientPage.SelectTeacher("Teacher Two");
                addClientPage.SelectState("Illinois");
                addClientPage.SelectZipCode("60634");
                addClientPage.SaveButtonClick();
            }





        }

    }
}
