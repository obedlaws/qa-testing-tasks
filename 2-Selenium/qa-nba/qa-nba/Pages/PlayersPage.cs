using System;
using OpenQA.Selenium;

namespace qa_nba.Pages
{
    public class PlayersPage : DriverHelper
    {
        string searchPlayer = "//*[@id='__next']/div[2]/div[3]/section/div/div[1]/div/input";
        string SCurry = "//*[@id='__next']/div[2]/div[3]/section/div/div[2]/div[2]/div/div/div/table/tbody/tr[2]/td[1]";



        IWebElement inputSearchPlayer => Driver.FindElement(By.XPath(searchPlayer));
        
        IWebElement Curry => Driver.FindElement(By.XPath(SCurry));


        public void InsertName() => inputSearchPlayer.SendKeys("Curry");
        public void ClickPlayer() => Curry.Click();

    }
}
