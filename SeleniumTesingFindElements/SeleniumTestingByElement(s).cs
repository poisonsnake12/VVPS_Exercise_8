using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;

namespace SeleniumTesingFindElements
{
    public class NameDemo
        {
            public static void main(String[] args)
            {
                IWebDriver driver = new FirefoxDriver();
                driver.Manage().Window.Maximize();

                driver.Url = "http://demo.guru99.com/test/ajax.html";

                driver.FindElement(By.Id("no")).Click();

                driver.FindElement(By.Id("buttoncheck")).Click();
            }
    }
}
