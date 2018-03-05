using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SeleniumFramworkLayer
{
    
    public class TestBase : ITestBase
    {
        public static IWebDriver driver;

        [SetUp]
        public void TestInitialize()
        {
            ChromeOptions option = new ChromeOptions();
            option.AddArgument("--headless");
            driver = new ChromeDriver(option);


            //driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            //driver.Manage().Window.Maximize();

            //driver.Navigate().GoToUrl("https://syneron-candela.com");

        }

        private string baseURL = "https://syneron-candela.com/int";
        //public static IWebDriver driver;
        //public RemoteWebDriver driver1;
        //private string browser;
        public TestContext TestContext { get; set; }

        [Test]
        public void RunTestBaseClass()
        {
            //ChromeOptions option = new ChromeOptions();
            //option.AddArgument("--headless");
            //driver = new ChromeDriver(option);

            driver.Navigate().GoToUrl(baseURL);

            var element = driver.FindElement(By.ClassName("wlcm-title"));
            Assert.IsTrue(element.Displayed);

            driver.FindElement(By.Id("cboxClose")).Click();

            var logo = driver.FindElement(By.Id("logo"));
            Assert.IsTrue(logo.Displayed);
            var element1 = driver.FindElement(By.ClassName("sgfgsfgs"));
            Assert.IsNotNull(element1);
            driver.Quit();
        }

        public void TestExecution()
        {
            TestInitialize();

            try
            {
                //CRunTests.GetTestMethod(CGlobals.TestRowIndex).Invoke();
            }
            catch (Exception exception)
            {
                //TestReport.TestFailed(exception);
            }
            finally
            {
                //TestReport.SaveHTMLFile();
            }

            TestCleanup();
        }

        public void MultipleTestExecution(int[] testIndex)
        {
            TestInitialize();
            for (int i = 0; i <= testIndex.Length; i++)
            {
                //CRunTests.GetTestMethod(testIndex[i]).Invoke();
            }
        }

        [TearDown]
        public void TestCleanup()
        {
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Quit();
        }

    }
}
