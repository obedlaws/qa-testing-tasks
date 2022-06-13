using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace qa_nba
{
    public class WaitHelper : DriverHelper
    {





        public IWebElement IsClickable(string path)
        {
            var wait = new WebDriverWait(Driver, new TimeSpan(0, 0, 30));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(path)));
            return element;

        }


        public IWebElement IsVisible(string path)
        {
            var wait = new WebDriverWait(Driver, new TimeSpan(0, 0, 30));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(path)));
            return element;
        }




    }
}
