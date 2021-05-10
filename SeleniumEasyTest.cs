using Automation.Page;
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
    public class SeleniumEasyTest
    {
        private static IWebDriver Driver;
        [OneTimeSetUp]

        public void SetUp()
        {
            Driver = new ChromeDriver();
            Driver.Url = "https://www.seleniumeasy.com/test/basic-checkbox-demo.html";
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

        }
        [OneTimeTearDown]
        public static void TearDown()
        {
            Driver.Close();
        }

        public static void TestSeleniumEasy(string text, bool shouldbeuncheckall)
        {
            SeleniumEasyPage page = new SeleniumEasyPage(Driver);

            page.clickSingleCheckBox();
            page.resultMessage(text);
            page.clickMultiple1();
            page.clickMultiple2();
            page.clickMultiple3();
            page.clickMultiple4();
            page.checkAllButton(shouldbeuncheckall);

        }
    }
}
