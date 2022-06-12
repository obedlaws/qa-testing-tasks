using System;
using OpenQA.Selenium.Support.UI;
using PasswordGenerator;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Randomizers;

namespace qa_nba.Tests
{
    public class Tests : DriverHelper
    {

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




    [Test, Order(2)]
    public void SearchStats()
    {
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("https://www.nba.com/");


            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(2));
            
            
            homePage.ClickStats();
            System.Threading.Thread.Sleep(1000);
            statsPage.ClickTools();
            wait.Until(Driver => statsPage.boxScoreMenu);
            System.Threading.Thread.Sleep(500);
            statsPage.ClickBoxScore();
            boxScorePage.SelectRebounds();
            boxScorePage.InputAmount("30");
            boxScorePage.RunQuery();
            wait.Until(Driver => boxScorePage.table);
            System.Threading.Thread.Sleep(1000);
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

            Driver.Manage().Window.Maximize();
            
            Driver.Navigate().GoToUrl("https://www.nba.com/");


            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));

            System.Threading.Thread.Sleep(1000);
            homePage.ClickCookies();
            System.Threading.Thread.Sleep(1400);
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
            System.Threading.Thread.Sleep(2500);
            homePage.SelectFavoriteTeam();
            homePage.NextTeam();
            System.Threading.Thread.Sleep(1000);
            homePage.CheckDailyMail();
            homePage.CheckPromotions();
            homePage.NextLetter();
            System.Threading.Thread.Sleep(100);

            Assert.IsTrue(homePage.logInWindow.Displayed);

    }

    [Test, Order(3)]
    public void LookUpSinglePlayer()
    {
            string player = "Stephen";

            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("https://www.nba.com/");


            homePage.ClickPlayers();
            System.Threading.Thread.Sleep(150);
            playersPage.InsertName();
            System.Threading.Thread.Sleep(1000);
            playersPage.ClickPlayer();

            string name = curryPage.CurryName.Text;

            Assert.IsTrue(player.Contains(name));


    }

    [Test, Order(4)]
    public void LookUpPastGameScoreBox()
    {
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("https://www.nba.com/");

            Pages.HomePage homePage = new Pages.HomePage();


            System.Threading.Thread.Sleep(1000);
            homePage.ClickSchedule();
            schedulePage.SelectTeam();
            schedulePage.SelectMonth();
            schedulePage.Scroll();
            System.Threading.Thread.Sleep(2000);
            schedulePage.NoPop();
            System.Threading.Thread.Sleep(2000);
            schedulePage.ClickScoreBox();

            Assert.IsTrue(gamePage.GameScoreBox.Displayed);





        }


    [Test, Order(5)]
    public void LookForAwardsNews()
    {
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("https://www.nba.com/");

            homePage.ClickNews();
            System.Threading.Thread.Sleep(2000);
            newsPage.ClickAwards();
            System.Threading.Thread.Sleep(2000);
            awardsPage.Scroll();
            awardsPage.ClickNewsMVP();
            System.Threading.Thread.Sleep(2000);


            string title = mvpPage.NewsTitle.Text;

            Assert.IsTrue(title.Contains("Jokic"));
            Driver.Quit();


        }



}


}


