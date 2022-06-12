using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace qa_nba.Pages
{
    public class AwardsPage : DriverHelper
    {
        string MVP = "//*[@id='__next']/div[2]/main/section/div/div/div[1]/a/article/div[2]/div[1]/header/h2/span";

        IWebElement JokicMVP => Driver.FindElement(By.XPath(MVP));


        public void Scroll()
        {
            Actions scroll = new Actions(Driver);
            scroll.MoveToElement(JokicMVP);
            scroll.Perform();
        }

        public void ClickNewsMVP() => JokicMVP.Click();


    }
}
