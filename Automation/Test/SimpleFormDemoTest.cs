using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Test
{
    class SimpleFormDemoTest
    {
        private static IWebDriver  _driver;

        [OneTimeSetUp]
         public void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Url = "http://www.seleniumeasy.com/test/basic-first-form-demo.html";
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(_driver => _driver.FindElement(By.Id("at-cv-lightbox-close")).Displayed);
            _driver.FindElement(By.Id("at-cv-lightbox-close")).Click();

        }
        [OneTimeTearDown]
        public static void TearDown()
        {
            _driver.Close();
        }
          

    }
}
