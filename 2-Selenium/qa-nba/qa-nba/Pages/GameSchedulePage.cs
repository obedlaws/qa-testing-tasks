using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace qa_nba.Pages
{
    public class GameSchedulePage : DriverHelper
    {

        string selectorTeamHeat = "//*[@id='__next']/div[2]/div[3]/section/div/div[2]/div/div[2]/label/div/select/option[17]";
        string selectorMonth = "//*[@id='__next']/div[2]/div[3]/section/div/div[2]/div/div[1]/label/div/select/optgroup[1]/option[3]";
        string scoreBox = "//*[@id='__next']/div[2]/div[3]/section/div/div[3]/div[4]/div[1]/div[2]/div[2]/div/div[2]/div[2]/div[1]/ul/li[2]/a";
        string Exit = "/html/body/div[4]/div[2]/button";


        IWebElement MHeatSelector => Driver.FindElement(By.XPath(selectorTeamHeat));
        IWebElement MonthSelector => Driver.FindElement(By.XPath(selectorMonth));
        IWebElement GameScoreBox => Driver.FindElement(By.XPath(scoreBox));
        IWebElement Cross => Driver.FindElement(By.XPath(Exit));

        public void Scroll()
        {
            Actions scroll = new Actions(Driver);
            scroll.MoveToElement(GameScoreBox);
            scroll.Perform();
        }

        public void SelectTeam() => MHeatSelector.Click();
        public void SelectMonth() => MonthSelector.Click();
        public void ClickScoreBox() => GameScoreBox.Click();

        public void NoPop() => Cross.Click();


    }
}
