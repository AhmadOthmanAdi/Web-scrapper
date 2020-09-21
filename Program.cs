using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Scraper
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            for (i = 0; i < 15; i++)
            {
                IWebDriver driver = new FirefoxDriver(@"C:\Users\Adiat\Downloads\Scraper\bin\Debug\netcoreapp3.1");
                driver.Url = "https://bing.com";

                Console.WriteLine(driver.Title);
                IWebElement textbox = driver.FindElement(By.Name("q"));
                textbox.SendKeys("Hello World");
                textbox.Submit();
                Console.WriteLine(driver.Title);

                driver.Quit();
            }
        }
    }
}