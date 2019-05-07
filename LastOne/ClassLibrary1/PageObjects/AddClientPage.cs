using Bogus;
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
        
        private IWebElement AddClientPageHeader => _driver.FindElement(By.XPath("//div[@class='center']"));
        private SelectElement TeacherDrop => new SelectElement(_driver.FindElement(By.Name("teacherId")));
        private IWebElement CompanyInput => _driver.FindElement(By.Name("company"));
        private IWebElement FirstNameInput => _driver.FindElement(By.Name("firstName"));
        private IWebElement LastNameInput => _driver.FindElement(By.Name("lastName"));
        private IWebElement CityeInput => _driver.FindElement(By.Name("city"));
        private SelectElement StateDrop => new SelectElement(_driver.FindElement(By.Name("state")));
        private IWebElement PhoneInput => _driver.FindElement(By.Name("phoneNumber"));
        private IWebElement EmailInput => _driver.FindElement(By.Name("email"));
        private IWebElement ZipCodeInput => _driver.FindElement(By.Name("zipCode"));
        private IWebElement UploadPhoto => _driver.FindElement(By.Id("filepond--drop-label-3hy6dau9s"));
        private IWebElement SaveButton => _driver.FindElement(By.XPath("//button[contains(text(), 'Save')]"));


        public string AddClientHeader()
        {
            return AddClientPageHeader.Text;
        }
        public void SelectTeacher(string teacherText)
        {
            TeacherDrop.SelectByText(teacherText);
        }

        public void FillOutContactInformation(Customer customer)
        {
            FirstNameInput.SendKeys(customer.FirstName);
            LastNameInput.SendKeys(customer.LastName);
            PhoneInput.SendKeys(customer.PhoneNumber);
            EmailInput.SendKeys(customer.Email);
            CompanyInput.SendKeys(customer.Company);
        }
        public void SelectState(string stateValue)
        {
            StateDrop.SelectByText(stateValue);
        }
        public void SelectZipCode(string zipValue)
        {
            ZipCodeInput.SendKeys(zipValue);
        }
        public void SaveButtonClick()
        {
            SaveButton.Click();

        }


    }
}
