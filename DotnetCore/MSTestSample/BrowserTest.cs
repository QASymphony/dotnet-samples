using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Reflection;

namespace MSTestSample
{
    [TestClass]
    public class BrowserTest
    {
        readonly string BaseURL = "https://www.qasymphony.com";
        private IWebDriver _webDriver;

        [TestInitialize]
        public void Initialize()
        {
            _webDriver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            _webDriver.Manage().Window.Maximize();
        }

        /// <summary>
        /// Go to Tricentis website and navigate to qTest Launch product
        /// </summary>
        [TestMethod]
        public void GotoqTestLaunch()
        {
            // go to Tricentis's Agile Test Management page
            _webDriver.Navigate().GoToUrl("https://www.tricentis.com/products/agile-dev-testing-qtest/agile-test-management-qtest-manager/");


            // click on Automation link
            IWebElement elm = _webDriver.FindElement(By.CssSelector("#menu-item-51791 > a"));
            elm.Click();
        }

        [TestCleanup]
        public void Cleanup()
        {
            _webDriver.Close();
            _webDriver.Quit();
        }
    }
}
