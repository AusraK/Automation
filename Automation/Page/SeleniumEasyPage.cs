using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Page
{
    public class SeleniumEasyPage
    {
        private static IWebDriver Driver;
        private IWebElement singleCheckBox => Driver.FindElement(By.Id("txtAge"));
        private IWebElement checkBoxMessage => Driver.FindElement(By.CssSelector("#txtAge"));
        private IWebElement option1Field => Driver.FindElement(By.CssSelector("#easycont > div > div.col-md-6.text-left > div:nth-child(5) > div.panel-body > div:nth-child(3) > label > input"));
        private IWebElement option2Field => Driver.FindElement(By.ClassName("cb1-element"));
        private IWebElement option3Field => Driver.FindElement(By.Id("check1"));
        private IWebElement option4Field => Driver.FindElement(By.Id("check1"));
        private IWebElement checkBoxButton => Driver.FindElement(By.CssSelector("#check1"));

        public SeleniumEasyPage (IWebDriver webdriver)
        {
            Driver = webdriver;
        }
        public void clickSingleCheckBox()
        {
            singleCheckBox.Clear();
            singleCheckBox.Click();
        }
        public void resultMessage(string text)
        {
            Assert.That(checkBoxMessage.Text.Contains(text), "Success-check box is checked");
        }
        public void clickMultiple1()
        {
            option1Field.Clear();
            option1Field.Click();
        }
        public void clickMultiple2()
        {
            option2Field.Clear();
            option2Field.Click();
        }
        public void clickMultiple3()
        {
            option3Field.Clear();
            option3Field.Click();
        }
        public void clickMultiple4()
        {
            option4Field.Clear();
            option4Field.Click();
        }
        public void checkAllButton(bool shouldbeUncheckAll)
        {
            
            if (shouldbeUncheckAll != checkBoxButton.Selected)
            {
                checkBoxButton.Click();
            }
        }


        

    }
}
