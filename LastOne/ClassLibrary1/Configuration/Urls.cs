using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Configuration
{
    class URLs
    {

     
        
            public static void OpenUrl(IWebDriver driver)
            {
                driver.Navigate().GoToUrl(Config.GetURL("AlexsPetsURL"));
            }
    }
}

