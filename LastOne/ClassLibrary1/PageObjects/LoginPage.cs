using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.PageObjects
{
    class LoginPage
    {
       

        private IWebDriver _driver;
        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement UserNameInput => _driver.FindElement(By.Id("username"));
        private IWebElement PasswordInput => _driver.FindElement(By.Id("password"));
        private IWebElement LoginButton => _driver.FindElement(By.XPath("//button[@variant='primary']"));
        private IWebElement LoginHeaderH2 => _driver.FindElement(By.XPath("//h2[contains(text(), Login)]"));

        public void Login(string userName, string password)
        {
            UserNameInput.SendKeys(userName);
            PasswordInput.SendKeys(password);
            LoginButton.Click();
        }
       
        public string GetLoginHeaderH2()
        {
            return LoginHeaderH2.Text;
        }

    }
}
