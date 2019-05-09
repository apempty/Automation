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
        private IWebElement SearchButton => _driver.FindElement(By.XPath("//button[contains(text(), 'Search')]"));
        private IWebElement SearchTable => _driver.FindElement(By.XPath("//table[@class='table']"));



        public void SearchInputClick(string email)
        {
            SearchInput.SendKeys(email);
            SearchButton.Click();
        }
        public string SearchTableClient()
        {
            return SearchTable.Text;
        }
    }
}
