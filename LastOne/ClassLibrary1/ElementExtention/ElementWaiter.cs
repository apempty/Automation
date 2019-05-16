using OpenQA.Selenium;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.ElementExtention
{
   public static class ElementWaiter
    {
        public static IWebElement WaitFor(this IWebElement element, int timeautInSecond)

        {
            var driver = ((IWrapsDriver)element).WrappedDriver;

            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeautInSecond));
          
            wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException), typeof(WebDriverException));
                wait.Until(dr =>
            {
                return element.Displayed;
            });
            return element;
        }


    }
}
