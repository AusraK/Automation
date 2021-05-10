using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationSolution.Page
{
    public class VartuTechnikaPage
    {
        private static IWebDriver _driver;
        private IWebElement widthInput => _driver.FindElement(By.Id("doors_width"));
        private IWebElement heightInput => _driver.FindElement(By.Id("doors_height"));
        private IWebElement automatikaCheckBox => _driver.FindElement(By.Id("automatika"));
        private IWebElement darbaiCheckBox => _driver.FindElement(By.Id("darbai"));
        private IWebElement calculatePriceButton => _driver.FindElement(By.Id("calc_submit"));
        private IWebElement resultBox => _driver.FindElement(By.CssSelector("#calc_result > div"));

        public VartuTechnikaPage(IWebDriver webdriver)
        {
            _driver = webdriver;
        }

        public VartuTechnikaPage InsertWidth(string width)
        {
            widthInput.Clear();
            widthInput.SendKeys(width);

            return this;
        }

        public VartuTechnikaPage InsertHeight(string height)
        {
            heightInput.Clear();
            heightInput.SendKeys(height);

            return this;
        }

        public VartuTechnikaPage InsertWidthAndHeight(string width, string height)
        {
            InsertWidth(width);
            InsertHeight(height);

            return this;
        }

        public VartuTechnikaPage CheckAutoCheckBox(bool shouldBeChecked)
        {
            if (shouldBeChecked != automatikaCheckBox.Selected)
            {
                automatikaCheckBox.Click();
            }

            return this;
        }

        public VartuTechnikaPage CheckWorksCheckBox(bool shouldBeChecked)
        {
            if (shouldBeChecked != darbaiCheckBox.Selected)
            {
                darbaiCheckBox.Click();
            }

            return this;
        }

        public VartuTechnikaPage ClickCalculateButton()
        {
            calculatePriceButton.Click();

            return this;
        }

        public VartuTechnikaPage CheckResult(string result)
        {
            Assert.IsTrue(resultBox.Text.Contains(result), $"Suma neteisinga. Expected value is {result}, but actual result is {resultBox.Text}");

            return this;
        }
    }
}
