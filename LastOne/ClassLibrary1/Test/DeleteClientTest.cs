﻿using ClassLibrary1.Configuration;
using ClassLibrary1.PageObjects;
using ClassLibrary1.TestData;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
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
        string userName = "admin";
        string password = "2VLu=j^ykC";
        Customer customer = new Customer();
   





        [Test]
        public void DeleteClient()
        {
            {
                using (var driver = new ChromeDriver())
                {

                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                    URLs.OpenUrl(driver);
                    var loginPage = new LoginPage(driver);
                    var navigationMenuPage = new NavigationMenuPage(driver);
                    var addClientPage = new AddClientPage(driver);
                    var clientSearchPage = new ClientSearchPage(driver);
                  
                    loginPage.Login(userName, password);
                    navigationMenuPage.AddClientButtonClick();
                    addClientPage.FillOutContactInformation(customer);

                    string id = addClientPage.GetClientId();

                    addClientPage.GetClientId().ShouldContain(id);
                    
                    addClientPage.DeleteButtonClick();

                   

                    addClientPage.ConfirmDeleteButtonClick();

                    clientSearchPage.SearchInputId(id);

                    clientSearchPage.SearchInputClick();
                    clientSearchPage.GetAllSeargPage().ShouldContain(clientSearchPage.GetNoRecords());

                }




            }
        }
    }
}
