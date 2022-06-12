using OpenQA.Selenium;


namespace qa_nba.Pages
{
    public class StatsPage : DriverHelper
    {

        public IWebElement toolMenu => Driver.FindElement(By.XPath("/html/body/div[2]/div/div/nav/div[6]/button"));
        public IWebElement boxScoreMenu => Driver.FindElement(By.XPath("/html/body/div[2]/section[5]/ul/li[1]/a"));

        public void ClickTools() => toolMenu.Click();
        public void ClickBoxScore() => boxScoreMenu.Click();

    }
}
