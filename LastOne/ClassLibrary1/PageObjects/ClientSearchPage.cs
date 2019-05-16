using ClassLibrary1.ElementExtention;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.PageObjects
{
    class ClientSearchPage
    {
        private IWebDriver _driver;
        public ClientSearchPage(IWebDriver driver)
        {
            _driver = driver;
        }
        private IWebElement SearchInput => _driver.FindElement(By.Id("q"));
        private IWebElement SearchButton => _driver.FindElement(By.XPath("//button[@type='submit']"));
        private IWebElement SearchTable => _driver.FindElement(By.XPath("//table[@class='table']"));
        private IWebElement NoRecords => _driver.FindElement(By.XPath("//div[contains(text(), 'No records')]"));
        private IWebElement AllSearchPage => _driver.FindElement(By.XPath("//div[@id= 'content-wrap']"));
        private IWebElement ClientIdInput => _driver.FindElement(By.XPath("//a[@title=  'Click to Edit']"));



        public void SearchInputClick()
        {
           
            SearchButton.Click();
        }
        public string GetSearchTableClient()
        {
            return SearchTable.Text;
        }
        public void SearchInputId(string Value)
        {
            SearchInput.SendKeys(Value);
        }
        public string GetNoRecords()
        {
            return NoRecords.Text;
        }
        public string GetAllSeargPage()
        {
            return AllSearchPage.Text;
        }

        public void EditeClientId()
        {
            ClientIdInput.Click();

        }


    }
}
