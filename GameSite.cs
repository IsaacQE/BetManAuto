using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;
using SeleniumExtras.PageObjects;


using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;

using NUnit;
using OpenQA.Selenium.Support.UI;

namespace betmanAuto
{
    [TestFixture]
        public class GameSite
    {

        // ExtentReports extent = null;

        // [OneTimeSetUp]
        // public void ExtentStart()
        // {
            // extent = new ExtentReports();
            // var htmlReporter = new ExtentHtmlReporter(@"C:\betmanAuto\ExtentReports\BetManAutomation.html");
            // extent.AttachReporter(htmlReporter);
        // }

        //Flush method below used to erase any previous data on the report and create a new one
        // [OneTimeTearDown]
        // public void ExtentClose()
        // {
            // extent.Flush();
        // }
        IWebDriver driver;
        
        // ExtentTest test = null;
        
        //sort out "CSC : error CS5001: Program does not contain a static 'Main' method suitable for an entry point" issue... tempo solution
        /**[STAThread]
        static void Main() {}
        **/
        
        //public static int Add(int pOne, int pTwo) => (pOne+pTwo);
       
        [SetUp]
        public void TestSetup()
        {
            //System.Environment.SetEnvironmentVariable("webdriver.chrome.driver", @"C:\chromedriver_win32\");
            ChromeDriver driver = new ChromeDriver(@"C:\betmanAuto\");
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://games.staging.playbetman.com/?o=03f365b2-9081-4b15-8d4a-bd64a182ae14&p=ed05d48a-280d-41ce-bb56-d2f415f7e54f");
        }
 
        [Test]
        public void PlaceSingleBet()
        {
            //test = extent.CreateTest("PlaceSingleBet").Info("Single Bet Test Started");
            driver.FindElement(By.Id("FootballGroup-grid-1")).Click();
            //takes a lot longer to load from lobby
           // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
           // driver.FindElement(By.Id("FootballGroup")).Click();
            //driver.FindElement(By.Id("tab-FootballGroup")).Click();
           // driver.FindElement(By.Id("GermanFastLeagueFootballSingleMatch")).Click();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            
            //driver.FindElement(By.XPath("//*[contains(@Id, 'Primary')][@Class='Bet']")).Click();
            //driver.FindElement(By.ClassName("Bet")).FindElement(By.XPath("//*[contains(@Id, 'Primary')]")).Click();
            
            //driver.FindElement(By.XPath("//*[@id='3-58-23168722_7_X_Primary'][@Class='Bet']")).Click();
            //driver.FindElement(By.XPath("//*[contains(., 'Primary')]")).Click();
            //<span id="3-58-23005939_7_X_Primary" class="Bet" bet-market-split="">3.63</span>
///html/body/div[4]/div[1]/div[1]/div[1]/div/div[4]/nav/div[8]/div[2]/div/div[2]/div/div[5]/div/div/div[2]/div/div[1]/div/div[2]/div/span
            //driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div[1]/div/div[4]/nav/div[8]/div[2]/div/div[2]/div/div[5]/div/div/div[2]/div/div[1]/div/div[2]/div")).Click();
            //click denomination
            //driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[2]/div/div[2]/nav/div[2]/div[1]/div/div/nav/section[1]/div[2]/div/button[1]")).Click();
            //driver.FindElement(By.Id("submit-bet-slip")).Click();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            
            //driver.PageSource.Contains("tab-single-bets");
            //bool eleSelected= driver.FindElement(By.XPath("html/body/div[4]/div[1]/div[2]/div/div[2]/nav/div[2]/div[1]/div/div/nav/section[1]")).Displayed;
            
            //UNCOMMENT
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

            //UNCOMMENT
            /**
            //1 screenshot at location
            ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
            Screenshot screenshot = screenshotDriver.GetScreenshot();
            screenshot.SaveAsFile(@"C:\\betmanAuto\\betplacedsuccessfully.png", ScreenshotImageFormat.Png);
            test.Log(Status.Info, "Screenshot captured");
            **/
            
            //UNCOMMENT driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            //UNCOMMENT driver.FindElement(By.Id("MyBetsHeader")).Click();
            //addViewBetResults
            //UNCOMMENT test.Log(Status.Pass, "Test Passed");
        }

        /**[TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
        **/
        
    }
}

/**
namespace betmanAuto2
{
    [TestFixture]

    public class GameSite
    {
        public IWebDriver driver;   

        [SetUp]
        public void TestSetup()
        {
            System.Environment.SetEnvironmentVariable("webdriver.chrome.driver", @"C:\\chromedriver_win32\\chromedriver.exe");
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://games.staging.playbetman.com/?o=03f365b2-9081-4b15-8d4a-bd64a182ae14&p=ed05d48a-280d-41ce-bb56-d2f415f7e54f&eg=58");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void ExclusiveGamePlaceSingleBet()
        {
            

            //driver.Navigate().GoToUrl("https://games.staging.playbetman.com/?o=03f365b2-9081-4b15-8d4a-bd64a182ae14&p=ed05d48a-280d-41ce-bb56-d2f415f7e54f&eg=58");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[6]/div[2]/div/div[2]/div/div[7]/div/div/div[2]/div/div[3]/div/div[1]/div")).Click();
            driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[6]/div[2]/div/div[2]/div/div[7]/div/div/div[2]/div/div[3]/div/div[2]/div")).Click();
            driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[6]/div[2]/div/div[2]/div/div[7]/div/div/div[2]/div/div[3]/div/div[3]/div")).Click();
            //10EUR Deno
            driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[2]/div/div[2]/nav/div[2]/div[1]/div/div/nav/section[1]/div[2]/div/button[2]")).Click();
            driver.FindElement(By.Id("submit-bet-slip")).Click();
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Quit();
        }

    }
}
**/