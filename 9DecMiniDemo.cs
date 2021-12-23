using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;
using System.Threading;
using NUnit;
using OpenQA.Selenium.Support.UI;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace betmanAuto
{
    [TestFixture]
        public class GameSite1
        {
        public IWebDriver driver;
        ExtentReports extent = null;

        //BetManQA Report setup START
        [OneTimeSetUp]
        public void ExtentStart()
        {
            extent = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(@"C:\betmanAuto\ExtentReports\BetManAutomation.html");
            extent.AttachReporter(htmlReporter);
        }

        //Flush method below used to erase any previous data on the report and create a new one
        [OneTimeTearDown]
        public void ExtentClose()
        {
            extent.Flush();
        }
        //BetManQA Report setup END

        //environment setup
        [SetUp]
        public void TestSetup1()
        {
            driver = new ChromeDriver(@"C:\betmanAuto\");
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://games.staging.playbetman.com/?o=03f365b2-9081-4b15-8d4a-bd64a182ae14&p=ed05d48a-280d-41ce-bb56-d2f415f7e54f");
        }

         [Test]
        public void PlaceSingleBet2()
        {
            //test = extent.CreateTest("PlaceSingleBet").Info("Single Bet Test Started");
            driver.FindElement(By.Id("FootballGroup-grid-1")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.Id("ItalianFastLeagueFootballSingleMatch")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div[1]/div/div/nav/div[8]/div[2]/div/div[2]/div/div[5]/div/div/div[2]/div/div[1]/div/div[2]/div/span")).Click();
            driver.FindElement(By.Id("submit-bet-slip")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.Id("MyBetsHeader")).Click();

            /**
            if (driver.FindElement(By.XPath("html/body/div[4]/div[1]/div[2]/div/div[2]/nav/div[2]/div[1]/div/div/nav/section[1]")).Displayed)
            {
                test.Log(Status.Info, "'Bet successfully placed!' displayed");
            }
            else
            {
                test.Log(Status.Info, "'Bet successfully placed!' NOT displayed, therefore place bet failed");
            }
            **/
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            driver.Quit();
        }   
    }
}
