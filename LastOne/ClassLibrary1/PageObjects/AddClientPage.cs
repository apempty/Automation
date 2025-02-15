﻿using Bogus;
using ClassLibrary1.ElementExtention;
using ClassLibrary1.TestData;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.PageObjects
{
    class AddClientPage
    {
        private IWebDriver _driver;
        public AddClientPage(IWebDriver driver)
        {
            _driver = driver;
        }
        

        private IWebElement PageHeader => _driver.FindElement(By.XPath("//div[@class='center']"));

        private SelectElement TeacherDrop => new SelectElement(_driver.FindElement(By.Name("teacherId")));
        private IWebElement CompanyInput => _driver.FindElement(By.Name("company"));
        private IWebElement FirstNameInput => _driver.FindElement(By.Name("firstName"));
        private IWebElement LastNameInput => _driver.FindElement(By.Name("lastName"));
        private IWebElement CityeInput => _driver.FindElement(By.Name("city"));
        private SelectElement StateDrop => new SelectElement(_driver.FindElement(By.Name("state")));
        private IWebElement PhoneInput => _driver.FindElement(By.Name("phoneNumber"));
        private IWebElement EmailInput => _driver.FindElement(By.Name("email"));
        private IWebElement ZipCodeInput => _driver.FindElement(By.Name("zipCode"));

        internal void FillOutContactInformation(Customer customer, object teacherTwo, object state, object zip)
        {
            throw new NotImplementedException();
        }

        private IWebElement UploadPhoto => _driver.FindElement(By.Id("filepond--drop-label-3hy6dau9s"));
        private IWebElement SaveButton => _driver.FindElement(By.XPath("//button[contains(text(), 'Save')]"));
        private IWebElement ClientHeader => _driver.FindElement(By.XPath("//h2[contains(text(), 'Client')]"));
        private IWebElement DeleteButton => _driver.FindElement(By.XPath("//a[@title= 'delete']"));
        private IWebElement ConfirmDeleteButton => _driver.FindElement(By.XPath("//b[contains(text(),  'Confirm')]"));
        private IWebElement ClientId => _driver.FindElement(By.XPath("//a[@title=  'Click to Edit']"));
        


        public void FillOutContactInformation(Customer customer)
        {
            FirstNameInput.SendKeys(customer.FirstName);
            LastNameInput.SendKeys(customer.LastName);
            PhoneInput.SendKeys(customer.PhoneNumber);
            EmailInput.SendKeys(customer.Email);
            CompanyInput.SendKeys(customer.Company);
            TeacherDrop.SelectByText(customer.TeacherTwo);
            StateDrop.SelectByText(customer.State);
            ZipCodeInput.SendKeys(customer.Zip);
            SaveButton.Click();

        }
      
        public string GetClientHeader()
        {
            return ClientHeader.Text;
        }

        public string AddClientHeader()

        {
            return PageHeader.Text;
        }
        public void DeleteButtonClick()
        {
            DeleteButton.Click();
        }
        public void ConfirmDeleteButtonClick()
        {
            ConfirmDeleteButton.WaitFor(3).Click();
        }
        public string GetClientId()
        {
            return ClientId.Text;
        }
        public void EditeFirstLast(string FirstName, string LastName, string Email)
        {
            FirstNameInput.SendKeys(FirstName);
            LastNameInput.SendKeys(LastName);
            EmailInput.SendKeys(Email);
            SaveButton.Click();

        }




    }
}
