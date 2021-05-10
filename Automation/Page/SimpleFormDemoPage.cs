using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Page
{
    public class SimpleFormDemoPage
    {
        private static IWebDriver _driver;
        private IWebElement enterMessageInput => _driver.FindElement(By.Id("user-message"));
        private IWebElement showMessageButton => _driver.FindElement(By.CssSelector("#get-input > button"));
        private IWebElement singleInputResult => _driver.FindElement(By.Id("display"));

        public SimpleFormDemoPage(IWebDriver webdriver)
        {
            _driver = webdriver;

        }
        public void InsertTextToSingleInputField (string text)
        {
            enterMessageInput.Clear();
            enterMessageInput.SendKeys(text);
        }
        public void ClickShowMessageButton()
        {
            showMessageButton.Click();

        }
        public void VerifySingleInputField(string expectedResult)
        {
            Assert.AreEqual(expectedResult, singleInputResult.Text, "Test is not equal");
        }
    }
}
