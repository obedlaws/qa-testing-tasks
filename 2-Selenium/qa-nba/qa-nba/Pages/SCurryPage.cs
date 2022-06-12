using System;
using OpenQA.Selenium;

namespace qa_nba.Pages
{
    public class SCurryPage : DriverHelper
    {

        string firstNameCurry = "//*[@id='__next']/div[2]/section/div[1]/section[1]/div[2]/div/div[2]/div[1]/p[2]";

        public IWebElement CurryName => Driver.FindElement(By.XPath(firstNameCurry));


    }
}
