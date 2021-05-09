using Automation.Page;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Test
{
    public class SeleniumEasyTest
    {
        public static IWebDriver Driver { get; private set; }

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
