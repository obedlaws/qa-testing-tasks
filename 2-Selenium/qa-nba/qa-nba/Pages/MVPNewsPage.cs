using System;
using OpenQA.Selenium;

namespace qa_nba.Pages
{
    public class MVPNewsPage : DriverHelper
    {
        string title = "//*[@id='__next']/div[2]/div[3]/section[1]/div/article/div[1]/div[1]/h1";

        public IWebElement NewsTitle => Driver.FindElement(By.XPath(title));

    }
}
