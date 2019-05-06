using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.PageObjects
{
    class ClientPage
    {
        private IWebDriver _driver;
        public ClientPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement ClientHeaderH2 => _driver.FindElement(By.XPath("//h2"));
        public IWebElement ClientHeaderH1 => _driver.FindElement(By.XPath("//a[contains(text(), 'admin')]"));
        public IWebElement LogOutButton => _driver.FindElement(By.XPath("//a[contains(text(), ' Logout')]"));
        public string ClientPageHeader()
        {
           return ClientHeaderH2.Text;
        }
        public string ClientPageHeaderAdmin()
        {
            return ClientHeaderH1.Text;
        }

        public void SelectLogOut()
        {
            ClientHeaderH1.Click();
            LogOutButton.Click();
           
        }


    }
}
