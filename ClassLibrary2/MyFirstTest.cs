using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;

namespace ClassLibrary2
{
    public class MyFirstTest
    {
        IWebDriver driver = new ChromeDriver();
        [Test]
        
        public void myFirstTest()
        {
            driver.Navigate().GoToUrl("http://www.google.com");
            Assert.AreEqual("Google", driver.Title);
            IWebElement gBox = driver.FindElement(By.Name("q"));
            gBox.SendKeys("MBA systems LTD");
            gBox.Submit();

            driver.Close();
            driver.Quit();
            Console.WriteLine("Test Completed");
        }
    }
}
