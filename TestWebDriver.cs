using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Automation
{
    class TestWebDriver

    {
        private static double expectedlErrorMessage;

        [Test]
        public static void TestChromeDriver()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Manage().Window.Maximize(); //atidaro dideli langa
            chrome.Url = "https://autoplius.lt";
            chrome.Close();
        }
        [Test]
        public static void TestFirefoxDriver()
        {
            IWebDriver firefox = new FirefoxDriver();
            firefox.Url = "https://autoplius.lt";
            firefox.Close();

        }

        [Test]
        public static void TestYahooPage()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Url = "https://login.yahoo.com";
            IWebElement emailInputField = chrome.FindElement(By.Id("login-username"));
            emailInputField.SendKeys("Test@Automation.com");
            IWebElement nextButton = chrome.FindElement(By.CssSelector("#login-signin"));
            nextButton.Click();
            string expectedErrorMessage = "Sorry, we don't recognise this email";
            IWebElement actualErrorMessage = chrome.FindElement(By.Id("username-error"));
            Thread.Sleep(1000);

            Assert.AreEqual(expectedlErrorMessage, actualErrorMessage.Text );
            //chrome.Close();
        }

        [Test]
        public static void SingleInputField()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Url = "https://www.seleniumeasy.com/test/basic-first-form-demo.html";

            IWebElement enterMessageInput = chrome.FindElement(By.Id("user-message"));
            string expectedText = "Vasara";
            enterMessageInput.SendKeys(expectedText);
            IWebElement showMessageButton = chrome.FindElement(By.CssSelector("#get - input > button"));
            showMessageButton.Click();
            IWebElement result = chrome.FindElement(By.Id("display"));
            Assert.AreEqual("Vasara", result.Text, "Message is wrong!");
            chrome.Close();
                
        }
    }
}
