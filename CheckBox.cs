using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation
{
    class CheckBox
    {
        private static IWebDriver _driver;

        [OneTimeSetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Manage().Window.Maximize();
            _driver.Url = "https://www.seleniumeasy.com/test/basic-checkbox-demo.html";

        }

        [OneTimeTearDown]

        public static void TearDown()
        {
            _driver.Close();
        }
        [Test]
        public static void TestOneCheckBox()
        {
            _driver.FindElement(By.Id("isAgeSelected")).Click();
            IWebElement result = _driver.FindElement(By.Id("txtAge"));
            Assert.IsTrue(result.Text.Equals("Success - Check Box is checked"));

        }

        public static void TestMultipleCheckBox()
        {
            IReadOnlyCollection<IWebElement> multipleCheckBox = _driver.FindElements(By.ClassName("cb1-element"));

            foreach(IWebElement element in multipleCheckBox)
            {
                element.Click();
                Assert.IsTrue(element.Selected);
            }
        }
    }
}
