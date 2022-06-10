using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTests.SeleniumUtils.Wrapper
{
    internal class WebdriverFactory
    {
        public virtual IWebDriver CreateLocalChromeDriver()
        {
            ChromeOptions options = new ChromeOptions();
            options.SetLoggingPreference(LogType.Browser, LogLevel.All);
            return new ChromeDriver(options);
        }
    }
}
