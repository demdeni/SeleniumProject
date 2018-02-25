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

            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("https://syneron-candela.com");

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
