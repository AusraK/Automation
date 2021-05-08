using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation
{
    public class Nd1
    {
        [Test]
        public static void TestSum()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Url = "https://www.seleniumeasy.com/test/basic-first-form-demo.html";

            IWebElement firstInput = chrome.FindElement(By.Id("sum1"));
            IWebElement secondInput = chrome.FindElement(By.Id("sum2"));
            firstInput.SendKeys("2");
            secondInput.SendKeys("2");
            IWebElement getTotalButton = chrome.FindElement(By.CssSelector("#gettotal>button"));
            getTotalButton.Click();
            IWebElement result = chrome.FindElement(By.Id("displayvalue"));
            Assert.AreEqual("4", result.Text, "Sum is incorrect");
            chrome.Close();
        }

        [Test]
        public static void TestSum1()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Url = "https://www.seleniumeasy.com/test/basic-first-form-demo.html";

            IWebElement firstInput = chrome.FindElement(By.Id("sum1"));
            IWebElement secondInput = chrome.FindElement(By.Id("sum2"));
            firstInput.SendKeys("-5");
            secondInput.SendKeys("3");
            IWebElement getTotalButton = chrome.FindElement(By.CssSelector("#gettotal > button"));
            getTotalButton.Click();
            IWebElement result = chrome.FindElement(By.Id("displayvalue"));
            Assert.AreEqual("-2", result.Text, "Sum is incorrect");
            chrome.Close();

        }

        [Test]
        public static void TestSum2()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Url = "https://www.seleniumeasy.com/test/basic-first-form-demo.html";

            IWebElement firstInput = chrome.FindElement(By.Id("sum1"));
            IWebElement secondInput = chrome.FindElement(By.Id("sum2"));
            firstInput.SendKeys("a");
            secondInput.SendKeys("b");
            IWebElement getTotalButton = chrome.FindElement(By.CssSelector("#gettotal > button"));
            getTotalButton.Click();
            IWebElement result = chrome.FindElement(By.Id("displayvalue"));
            Assert.AreEqual("NaN", result.Text, "Sum is incorrect");
            chrome.Close();

        }

        

        private static IWebDriver _driver;

        [OneTimeSetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Url = "https://www.seleniumeasy.com/test/basic-first-form-demo.html";
            IWebElement popUp = _driver.FindElement(By.Id("at-cv-lightbox-close"));
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10)); //jei norim,kad driveris lauktu 10 s 
            wait.Until(d => popUp.Displayed);
            popUp.Click();
        }

        [OneTimeTearDown]
        public static void TearDown()
        {
            _driver.Close();
        }
        [TestCase("2", "2", "4", TestName = "2 + 2 = 4")]
        [TestCase("-5", "3", "-2", TestName = "-5 +3 = -2")]
        [TestCase("a", "b", "NaN", TestName = "a + b = Nan")]
        public static void TestSumBlock(string firstInput, string secondInput, string result)
        {
            IWebElement firstInputField = _driver.FindElement(By.Id("sum1"));
            IWebElement secondInputField = _driver.FindElement(By.Id("sum2"));
            firstInputField.Clear();
            firstInputField.SendKeys(firstInput);
            secondInputField.Clear();
            secondInputField.SendKeys(secondInput);
            IWebElement getTotalButton = _driver.FindElement(By.XPath("//*[@id='gettotal']/button"));
          
            getTotalButton.Click();
            IWebElement actualResult = _driver.FindElement(By.Id("displayvalue"));
            Assert.AreEqual(result, actualResult.Text, "Sum is Incorrect");


        }

    }


}        
        

    


