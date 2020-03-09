using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Utitlitymethod
    {

        public static string Sendkeys_method(IWebDriver driver, String element, String value, String elementType)
        {
            if (elementType == "XPath")
            {
                driver.FindElement(By.XPath(element)).SendKeys(value);
            }
            if(elementType == "Id")
            {
                driver.FindElement(By.Id(element)).SendKeys(value);
            }
           if (elementType == "Name")
            {
                driver.FindElement(By.Name(element)).SendKeys(value);
            }
            return string.Empty;
        }

        public static string Click_method(IWebDriver driver, String element, String elementType)
        {
            if (elementType == "XPath")
            {
                driver.FindElement(By.XPath(element)).Click();
            }
            if (elementType == "Id")
            {
                driver.FindElement(By.Id(element)).Click();
            }
            if (elementType == "Name")
            {
                driver.FindElement(By.Name(element)).Click();
            }

            return string.Empty;
        }

    }
}
