using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetSelenium
{
    public class SeleniumCustomeMethods
    {
        public static void Click(IWebDriver driver,By locator)
        {
             driver.FindElement(locator).Click();
        }

      
     
    }
}
