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
        /// Go to QASymphony website and search for qTest Launch product
        /// </summary>
        [Fact]
        public void SearchForQtestLaunch()
        {
            _webDriver.Navigate().GoToUrl("https://www.google.com");

            // click on Search icon to open search input
            //IWebElement searchIcon = _webDriver.FindElement(By.Name("q"));
            //searchIcon.Click();

            // find the search input element and search for `qTest Launch`
            IWebElement searchInput = _webDriver.FindElement(By.Name("q"));
            searchInput.SendKeys("qTest Launch");
            searchInput.SendKeys(Keys.Enter);

            // from search result, look for h2 elament containing text qTest Launch, and click on it
            IWebElement h2Element = _webDriver.FindElement(By.LinkText("https://www.tricentis.com/resources/qtest-launch-test-automation-management/"));
            h2Element.Click();
        }

        public void Dispose()
        {
            _webDriver.Close();
            _webDriver.Quit();
        }
    }
}
