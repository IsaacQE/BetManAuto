using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;
using SeleniumExtras.PageObjects;
using NUnit;
using OpenQA.Selenium.Support.UI;


namespace betmanAuto.BaseClass
{
    public class BaseTest
    {
        public IWebDriver driver;

    [SetUp]
            public void TestSetup()
            {
            // System.Environment.SetEnvironmentVariable("webdriver.chrome.driver", @"C:\\betmanAuto\\chromedriver.exe");
                //Try removing Chromedriver below
                ChromeDriver driver = new ChromeDriver(@"C:\betmanAuto\");
                driver.Manage().Window.Maximize();
                driver.Url = "https://games.staging.playbetman.com/?o=03f365b2-9081-4b15-8d4a-bd64a182ae14&p=ed05d48a-280d-41ce-bb56-d2f415f7e54f";
                driver.Quit();
    }
    }
}




