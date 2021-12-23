using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;

using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;

using NUnit;
using OpenQA.Selenium.Support.UI;

namespace betmanAuto
{
    public class Program
    {
        ExtentReports extent = null;
        public IWebDriver driver;


        //sort out "no main class found" issue... tempo solution
        [STAThread]
        static void Main()
        {
        }

        [OneTimeSetUp]
        public void ExtentStart()
        {
            extent = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(@"C:\betmanAuto\ExtentReports\BetManAutomation.html");
            extent.AttachReporter(htmlReporter);
        }

        [OneTimeTearDown]
        public void ExtentClose()
        {
            extent.Flush();
        }
       
        [SetUp]
        public void TestSetup()
        {
            System.Environment.SetEnvironmentVariable("webdriver.chrome.driver", @"C:\\chromedriver_win32\\chromedriver.exe");
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://games.staging.playbetman.com/?o=03f365b2-9081-4b15-8d4a-bd64a182ae14&p=ed05d48a-280d-41ce-bb56-d2f415f7e54f");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void PlaceSingleBet()
        {
            driver.FindElement(By.Id("FootballGroup-grid-1")).Click();
            //takes a lot longer to load from lobby
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.Id("FootballGroup")).Click();
            driver.FindElement(By.Id("tab-FootballGroup")).Click();
            driver.FindElement(By.Id("GermanFastLeagueFootballSingleMatch")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div[1]/div/div[4]/nav/div[8]/div[2]/div/div[2]/div/div[5]/div/div/div[2]/div/div[1]/div/div[2]/div")).Click();
            driver.FindElement(By.Id("submit-bet-slip")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.Id("MyBetsHeader")).Click();
            //addViewBetResults
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
