using OpenQA.Selenium;

namespace qa_nba.Pages
{
    public class BoxScorePage : DriverHelper
    {
        string rebounds = "/html/body/main/div/div/div[2]/section/div[2]/div/div[1]/div/div/table/tbody/tr/td[1]/select/option[2]";
        string inputBlank = "/html/body/main/div/div/div[2]/section/div[2]/div/div[1]/div/div/table/tbody/tr/td[3]/input";
        string runIt = "/html/body/main/div/div/div[2]/section/div[2]/div/div[2]/querytool-run-it/button";
        string rebColumn = "/html/body/main/div/div/div[2]/section[2]/querytool-stat-table/div[1]/div[1]/table/thead/tr/th[19]";
        string playersTable = "/html/body/main/div/div/div[2]/section[2]/querytool-stat-table/div[1]";


        public IWebElement reboundsOption => Driver.FindElement(By.XPath(rebounds));
        public IWebElement textInput => Driver.FindElement(By.XPath(inputBlank));
        public IWebElement runItButton => Driver.FindElement(By.ClassName("run-it"));
        public IWebElement reboundsColumn => Driver.FindElement(By.XPath(rebColumn));
        public IWebElement table => Driver.FindElement(By.XPath(playersTable));


        public void SelectRebounds() => reboundsOption.Click();
        public void InputAmount(string amount)
        {
            textInput.Clear();
            textInput.SendKeys(amount);
        }
        public void RunQuery() => runItButton.Click();
        public void OrganizeRebounds() => reboundsColumn.Click();



    }
}
