﻿using OpenQA.Selenium;
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

        // Suggestion: instead of always using LoginInput() and LoginButtonClick() methods one by one, you could have single method which would enter username, password and click login button.
        public void LoginInput(string userName, string password)
        {
            UserNameInput.SendKeys(userName);
            PasswordInput.SendKeys(password);

        }
        public void LoginButtonClick()
        {
            LoginButton.Click();
        }
        public string LoginHeaderH2Text()
        {
            return LoginHeaderH2.Text;
        }

    }
}
