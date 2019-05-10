using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.PageObjects
{
    class NavigationMenuPage
    {
        private IWebDriver _driver;
        public NavigationMenuPage(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement ClientHeaderH2 => _driver.FindElement(By.XPath("//h2[contains(text(), 'Clients')]"));
        private IWebElement ClientHeaderH1 => _driver.FindElement(By.XPath("//a[contains(text(), 'admin')]"));
        private IWebElement LogOutButton => _driver.FindElement(By.XPath("//a[contains(text(), ' Logout')]"));
        private IWebElement AddClientButton => _driver.FindElement(By.XPath("//a[contains(text(), ' Add Client')]"));

        public string GetClientPageHeader()
        {
           return ClientHeaderH2.Text;
        }
        public string getClientPageHeaderAdmin()
        {
            return ClientHeaderH1.Text;
        }

        public void SelectLogOut()
        {
            ClientHeaderH1.Click();
            LogOutButton.Click();
        }

        public void AddClientButtonClick()
        {
            AddClientButton.Click();
        }

    }
}
