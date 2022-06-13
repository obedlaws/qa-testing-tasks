using System;
using OpenQA.Selenium;

namespace qa_nba.Pages
{
    public class HomePage : DriverHelper
    {
        // NavBar Tabs
        string Stats = "/html/body/div[1]/div[2]/div[1]/div[1]/nav/ul/li[8]";
        string Players = "//*[@id='nav-ul']/li[11]";
        string Schedule = "//*[@id='nav-ul']/li[2]";
        string News = "//*[@id='nav-ul']/li[4]";
        public string signInButton = "/html/body/div[1]/div[2]/div[1]/div[1]/nav/div/div/div[2]";
        string signIntoNBA = "/html/body/div[1]/div[2]/div[1]/div[1]/nav/div/div/div[2]/div/div[1]/a[2]";
        

        // Common Elements
        public string Cookies = "//*[@id='onetrust-accept-btn-handler']";
        public string SearchBar = "//*[@id='search-icon-desktop']/svg";
        public string AdBanner = "//*[@id='home_ad_b_1']";
        
        // SignUp Elements
        string signUpLink = "/html/body/div[8]/div/div[1]/div[2]/div[2]";
        public string TeamLogo = "//*[@id='nbaSelectFavoriteTeamsModal']/div[2]/div[2]/div";
        string day = "//*[@id='nbaSignUpModal']/form/div[7]/div[1]/select/option[6]";
        string month = "//*[@id='nbaSignUpModal']/form/div[7]/div[2]/select/option[7]";
        string year = "//*[@id='nbaSignUpModal']/form/div[7]/div[3]/select/option[25]";
        string country = "//*[@id='nbaSignUpModal']/form/div[8]/div[1]/select/option[44]";
        string checkboxTOS = "//*[@id='nbaSignUpModalTAC']";
        string logIn = "//*[@id='nbaExplorePackagesModal']";
        string exit = "//*[@id='nbaExplorePackagesModal']/div[3]";
        string nextButton = "//*[@id='nbaSelectFavoriteTeamsModal']/div[3]/div/button";
        string nextButtonTwo = "//*[@id='nbaNewslettersModal']/div[3]/div/button";
        public string checkBoxDaily = "//*[@id='nbaNewsletters0']";
        string checkBoxPromotions = "//*[@id='nbaNewsletters4']";



        // HomePage Elements

        IWebElement playersTab => Driver.FindElement(By.XPath(Players));
       
        IWebElement newsTab => Driver.FindElement(By.XPath(News));
        IWebElement scheduleTab => Driver.FindElement(By.XPath(Schedule));

        public IWebElement cookiesBtn => Driver.FindElement(By.XPath(Cookies));

        public IWebElement statsTab => Driver.FindElement(By.XPath(Stats));

        IWebElement signIn => Driver.FindElement(By.XPath(signInButton));

        public IWebElement signInMenu => Driver.FindElement(By.XPath(signIntoNBA));

        public IWebElement signUpButton => Driver.FindElement(By.ClassName("nba-login-link"));

        public IWebElement emailInput => Driver.FindElement(By.Name("emailAddress"));

        IWebElement passwordInput => Driver.FindElement(By.Name("password"));

        IWebElement firstNameInput => Driver.FindElement(By.Name("firstName"));

        IWebElement lastNameInput => Driver.FindElement(By.Name("lastName"));

        IWebElement formDay => Driver.FindElement(By.XPath(day));

        IWebElement formMonth => Driver.FindElement(By.XPath(month));

        IWebElement formYear => Driver.FindElement(By.XPath(year));

        IWebElement formCountry => Driver.FindElement(By.XPath(country));

        IWebElement termsCheckBox => Driver.FindElement(By.XPath(checkboxTOS));

        IWebElement createAccountButton => Driver.FindElement(By.Id("nbaSignUpModalCreate"));

        public IWebElement teamLogo => Driver.FindElement(By.XPath(TeamLogo));

        IWebElement nextBtn => Driver.FindElement(By.XPath(nextButton));

        public IWebElement dailyMailCheckbox => Driver.FindElement(By.XPath(checkBoxDaily));

        IWebElement promotionsCheckBox => Driver.FindElement(By.XPath(checkBoxPromotions));

        public IWebElement crossTopRight => Driver.FindElement(By.XPath(exit));

        public IWebElement logInWindow => Driver.FindElement(By.XPath(logIn));

        IWebElement nextBtnTwo => Driver.FindElement(By.XPath(nextButtonTwo));



        // Methods
        public void ClickStats() => statsTab.Click();
        public void ClickSchedule() => scheduleTab.Click();
        public void ClickNews() => newsTab.Click();
        public void ClickPlayers() => playersTab.Click();
        public void SignInTab() => signIn.Click();
        public void SignIntoNBA() => signInMenu.Click();
        public void SignUp() => signUpButton.Click();
        public void InputEmailAddress(string email) => emailInput.SendKeys(email);
        public void InputPassword(string password) => passwordInput.SendKeys(password);
        public void InputFirstName(string firstName) => firstNameInput.SendKeys(firstName);
        public void InputLastName(string lastName) => lastNameInput.SendKeys(lastName);
        public void InputDay() => formDay.Click();
        public void InputMonth() => formMonth.Click();
        public void InputYear() => formYear.Click();
        public void InputCountry() => formCountry.Click();

        public void CheckTermsOfService()
        {   
            IJavaScriptExecutor executor = (IJavaScriptExecutor)Driver;
            executor.ExecuteScript("arguments[0].click()", termsCheckBox);
        }

        public void CreateAccount() => createAccountButton.Click();
        public void SelectFavoriteTeam() => teamLogo.Click();
        public void NextTeam() => nextBtn.Click();
        public void NextLetter() => nextBtnTwo.Click();


        public void CheckDailyMail()
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)Driver;
            executor.ExecuteScript("arguments[0].click()", dailyMailCheckbox);
        }


        public void CheckPromotions()
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)Driver;
            executor.ExecuteScript("arguments[0].click()", promotionsCheckBox);
        }


        public void ExitBtn() => crossTopRight.Click();
        public void ClickCookies() => cookiesBtn.Click();

        public bool IsItVisible(IWebElement element)
        {
            return element.Displayed;
        }


    }
}
