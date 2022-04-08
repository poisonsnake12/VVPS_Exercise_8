using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;

namespace ToolsQA.Selenium_Basics
{
    public class NameDemo
    {

        public static void main(String[] args)
        {
            System.setProperty("webdriver.chrome.driver", "D:\\3rdparty\\chrome\\chromedriver.exe");
            WebDriver driver = new ChromeDriver();
            driver.manage().window().maximize();

            driver.get("http://demo.guru99.com/test/ajax.html");

            driver.findElement(By.id("no")).click();

            driver.findElement(By.id("buttoncheck")).click();

        }

    }
}