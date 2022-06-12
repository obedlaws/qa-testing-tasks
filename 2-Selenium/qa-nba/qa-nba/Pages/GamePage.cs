using System;
using OpenQA.Selenium;

namespace qa_nba.Pages
{
    public class GamePage : DriverHelper
    {
        string boxScore = "//*[@id='__next']/div[2]/div[4]/section[2]";

        public IWebElement GameScoreBox => Driver.FindElement(By.XPath(boxScore));

    }
}
