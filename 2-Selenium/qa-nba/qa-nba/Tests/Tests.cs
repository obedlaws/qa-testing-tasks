using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using PasswordGenerator;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Randomizers;

namespace qa_nba.Tests
{
    public class Tests : DriverHelper
    {
        WaitHelper waitHelper = new WaitHelper();


        // All the Pages
        Pages.HomePage homePage = new Pages.HomePage();
        Pages.GameSchedulePage schedulePage = new Pages.GameSchedulePage();
        Pages.GamePage gamePage = new Pages.GamePage();
        Pages.StatsPage statsPage = new Pages.StatsPage();
        Pages.BoxScorePage boxScorePage = new Pages.BoxScorePage();
        Pages.PlayersPage playersPage = new Pages.PlayersPage();
        Pages.SCurryPage curryPage = new Pages.SCurryPage();
        Pages.NewsPage newsPage = new Pages.NewsPage();
        Pages.AwardsPage awardsPage = new Pages.AwardsPage();
        Pages.MVPNewsPage mvpPage = new Pages.MVPNewsPage();

        // Wait variable
        WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));



        [SetUp]
        public void StartBrowser()
        {
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("https://www.nba.com/");

        }


        [Test, Order(2)]
    public void SearchStats()
    {
            
            
            homePage.ClickStats();
            statsPage.ClickTools();
            waitHelper.IsVisible(statsPage.boxScoreTab);
            statsPage.ClickBoxScore();

            boxScorePage.SelectRebounds();
            boxScorePage.InputAmount("30");
            boxScorePage.RunQuery();
            wait.Until(Driver => boxScorePage.table);
            boxScorePage.OrganizeRebounds();

            Assert.IsTrue(boxScorePage.table.Displayed);
            

    }

    [Test, Order(1)]
    public void SignUpNewUser()
    {
            // Setting random variables to create new user
            var genFirstName = RandomizerFactory.GetRandomizer(new FieldOptionsFirstName());
            var genLastName = RandomizerFactory.GetRandomizer(new FieldOptionsLastName());
            var genEmail = RandomizerFactory.GetRandomizer(new FieldOptionsEmailAddress());
            var genPassword = new Password().IncludeUppercase().IncludeLowercase().IncludeSpecial();

            string email = genEmail.Generate();
            string firstName = genFirstName.Generate();
            string lastName = genLastName.Generate();
            string pswd = genPassword.Next();


            waitHelper.IsClickable(homePage.Cookies);
            homePage.ClickCookies();

            System.Threading.Thread.Sleep(700);
            homePage.SignInTab();
            homePage.SignIntoNBA();
            homePage.SignUp();
            homePage.InputEmailAddress(email);
            homePage.InputPassword(pswd);
            homePage.InputFirstName(firstName);
            homePage.InputLastName(lastName);
            homePage.InputDay();
            homePage.InputMonth();
            homePage.InputYear();
            homePage.InputCountry();
            homePage.CheckTermsOfService();
            homePage.CreateAccount();
            waitHelper.IsClickable(homePage.TeamLogo);
            homePage.SelectFavoriteTeam();
            homePage.NextTeam();
            homePage.CheckDailyMail();
            homePage.CheckPromotions();
            homePage.NextLetter();

            Assert.IsTrue(homePage.logInWindow.Displayed);

    }

    [Test, Order(3)]
    public void LookUpSinglePlayer()
    {
            

            homePage.ClickPlayers();
            playersPage.InsertName();
            Thread.Sleep(1000);
            playersPage.ClickPlayer();

            string name = curryPage.CurryName.Text;

            Assert.IsTrue(name.Contains("Stephen"));

    }

    [Test, Order(4)]
    public void LookUpPastGameScoreBox()
        {
            homePage.ClickSchedule();
            schedulePage.SelectTeam();
            schedulePage.SelectMonth();
            schedulePage.Scroll();
            schedulePage.ClickScoreBox();

            Assert.IsTrue(gamePage.GameScoreBox.Displayed);
        }


    [Test, Order(5)]
    public void LookForAwardsNews()
    {

            homePage.ClickNews();
            waitHelper.IsClickable(newsPage.awards);
            newsPage.ClickAwards();
            Thread.Sleep(1000);
            awardsPage.Scroll();
            awardsPage.ClickNewsMVP();


            string title = mvpPage.NewsTitle.Text;

            Assert.IsTrue(title.Contains("Jokic"));
            Driver.Quit();


        }



}


}


