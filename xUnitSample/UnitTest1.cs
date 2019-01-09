using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;

namespace xUnitSample
{
    public class UnitTest1 : IDisposable
    {
        readonly IWebDriver _webDriver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));

        [Fact]
        public void Test1()
        {
            _webDriver.Navigate().GoToUrl("https://www.google.com");
        }

        public void Dispose()
        {
            _webDriver.Close();
            _webDriver.Quit();
        }
    }
}
