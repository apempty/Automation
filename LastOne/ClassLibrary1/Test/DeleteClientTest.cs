using ClassLibrary1.PageObjects;
using ClassLibrary1.TestData;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassLibrary1.Test
{
    [TestFixture]
    class DeleteClientTest
    {
        [Test]
        public void DeleteClient()
        {
            {
                var userName = "admin";
                var password = "2VLu=j^ykC";
                var customer = new Customer();

                using (var driver = new ChromeDriver())
                {
                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                    driver.Navigate().GoToUrl("https://nitro.duckdns.org/sst-classes/login");
                    var loginPage = new LoginPage(driver);
                    var navigationMenuPage = new NavigationMenuPage(driver);
                    var addClientPage = new AddClientPage(driver);
                    var clientSearchPage = new ClientSearchPage(driver);

                    loginPage.Login(userName, password);
                    navigationMenuPage.AddClientButtonClick();
                    addClientPage.FillOutContactInformation(customer, "Teacher Two", "Illinois", "60634");
                    addClientPage.GetClientId().ShouldContain(addClientPage.GetClientId());
         
                    addClientPage.DeleteButtonClick();

                    Thread.Sleep(1000);
                    
                    addClientPage.ConfirmDeleteButtonClick();

                    clientSearchPage.SearchInputId(addClientPage.GetClientId());
                    clientSearchPage.SearchInputClick();
                    clientSearchPage.GetAllSeargPage().ShouldContain(clientSearchPage.GetNoRecords());

                }




            }
        }
    }
}
