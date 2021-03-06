using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Automation
{
    public class Demo

    {
        [Test]
        public static void TestIf4ISEven()
        {
            int leftOver = 4 % 2;
            Assert.AreEqual(0, leftOver, "4 is not even!");
        }
        [Test]
        public static void TestNowIs19()
        {
            DateTime currentTime = DateTime.Now;
            Assert.AreEqual(19, currentTime.Hour, "Dabar ne 19 valanda");
        }
        [Test]
        public static void TestIfNumberIsEven()
        {
            int leftOver = 995 % 3;
            Assert.AreEqual(2, leftOver, "995 is not even");
        }
        [Test]
        public static void TestNowisMonday()
        {
            DateTime date = DateTime.Today;
            Assert.AreEqual(DayOfWeek.Monday, DayOfWeek.Monday, "Siandien pirmadienis");
        }
         [Test]
         public static void Wait5Seconds()
        {
            Thread.Sleep(5000);
        }

        
    }
}
