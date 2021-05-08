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
    class Nd2
    {

        private static IWebDriver driver;

        

       [Test]
       public static void TestTheDriver()
        {
            driver = new ChromeDriver();
            
            driver.Url = "https://developers.whatismybrowser.com/useragents/parse/?analyse-my-user-agent=yes#parse-useragent";
            driver.Close();

        }

        [TestCase("chrome","chrome","chrome 90 on windows 10", TestName = "ChromeDriver")]

        public static void TestChrome(string chrome, string chrome1, string result)
        {
            IWebElement resultBox = driver.FindElement(By.Id("primary-detection"));
            driver.Close();
            Assert.IsTrue(resultBox.Text.Contains(result));

        }


       
         
        
    }
}
