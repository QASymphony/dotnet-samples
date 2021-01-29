using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;

namespace xUnitSample
{
    /// <summary>
    /// Browser test suite
    /// </summary>
    public class BrowserTest : IDisposable
    {
        readonly IWebDriver _webDriver;

        public BrowserTest()
        {
            _webDriver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            _webDriver.Manage().Window.Maximize();
        }

        /// <summary>
        /// Go to Tricentis website and navigate to qTest Launch product
        /// </summary>
        [Fact]
        public void GotoqTestLaunch()
        {
            // go to Tricentis's Agile Test Management page
            _webDriver.Navigate().GoToUrl("https://www.tricentis.com/products/agile-dev-testing-qtest/agile-test-management-qtest-manager/");

            
            // click on Automation link
            IWebElement elm = _webDriver.FindElement(By.CssSelector("#menu-item-51791 > a"));
            elm.Click();
        }

        public void Dispose()
        {
            _webDriver.Close();
            _webDriver.Quit();
        }
    }
}
