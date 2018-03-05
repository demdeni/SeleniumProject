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
using OpenQA.Selenium.Remote;

namespace SeleniumFramworkLayer
{
   
    public class Test1 : TestBase
    {
        private static string baseURL = "https://syneron-candela.com/int";
        //public IWebDriver driver;
        //public RemoteWebDriver driver1;
        //private string browser;
        public TestContext TestContext { get; set; }

        [Test]
        public void RunTest()
        {
            ChromeOptions option = new ChromeOptions();
            option.AddArgument("--headless");
            driver = new ChromeDriver(option);


            driver.Navigate().GoToUrl(baseURL);

            var element = driver.FindElement(By.ClassName("wlcm-title"));
            Assert.IsTrue(element.Displayed);

            driver.FindElement(By.Id("cboxClose")).Click();

            var logo = driver.FindElement(By.Id("logo"));
            Assert.IsTrue(logo.Displayed);
            //var element1 = driver.FindElement(By.ClassName("sgfgsfgs"));
            //Assert.IsNotNull(element1);
            driver.Quit();
        }
    }
}
