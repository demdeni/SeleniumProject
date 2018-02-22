using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using System.IO;
using System.Reflection;

namespace SeleniumFramworkLayer
{
    public class Test1
    {
        [Test]
        public static void RunTest()
        {
            TestBase.driver = new FirefoxDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));


            TestBase.driver.Navigate().GoToUrl("https://syneron-candela.com");
        }
    }
}
