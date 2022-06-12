using System;
using OpenQA.Selenium;

namespace qa_nba.Pages
{
    public class NewsPage : DriverHelper
    {
        string awards = "//*[@id='__next']/div[2]/div[1]/div[3]/nav/ul/li[6]";

        IWebElement awardsTab => Driver.FindElement(By.XPath(awards));

        public void ClickAwards() => awardsTab.Click();

    }
}
