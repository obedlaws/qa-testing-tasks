using System;
using SeleniumTests.SeleniumUtils.Wrapper;
using OpenQA.Selenium;

namespace SeleniumTests.SeleniumUtils
{
    public class LocalDriverBuilder
    {

        private readonly WebdriverFactory factory;
        internal LocalDriverBuilder(WebdriverFactory webdriverFactory)
        {
            this.factory = factory;
        }

        public virtual IWebDriver Launch(string browserTarget, string startUrl)
        {
            var driver = CreateWebDriver(browserTarget);
            driver.Navigate().GoToUrl(startUrl);
            return driver;
        }

        private IWebDriver CreateWebDriver(string browserTarget)
        {
            switch (browserTarget)
            {
                case BrowserTarget.Chrome:
                    return factory.CreateLocalChromeDriver();
                default:
                    throw new NotSupportedException($"{browserTarget} is not supported!");

            }
        }
    }
}
