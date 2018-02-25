using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using System.IO;
using System.Reflection;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace SeleniumFramworkLayer
{
    public class Test1 : TestBase
    {
        [Test]
        public static void RunTest()
        {
            IWebDriver driver1 = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver1.Manage().Window.Maximize();

            driver1.Navigate().GoToUrl("https://syneron-candela.com");
        }
    }
}
