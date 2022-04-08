using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;

namespace SeleniumFindElement
{
    public class FindElement
    {

        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver("C:");
            driver.Manage().Window.Maximize();

            driver.Url = "http://demo.guru99.com/test/ajax.html";

            var elements = driver.FindElements(By.Name("name"));


            driver.FindElement(By.Id("no")).Click();

            driver.FindElement(By.Id("buttoncheck")).Click();

        }

    }
}