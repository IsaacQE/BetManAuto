using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;
using FindsByAttribute = SeleniumExtras.PageObjects.FindsByAttribute;
using How = SeleniumExtras.PageObjects.How;
using OpenQA.Selenium.Support.UI;

namespace betmanAuto.PageObjects.German.Single
{
    public class Lobby
    {
        IWebDriver driver;
        public Lobby (IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver,this);
        }

        [FindsBy (How = How.Id, Using = "DashingDerby-grid-1")]
        public IWebElement DashingDerbyLobbyImage {get; set;}


        [FindsBy (How = How.Id, Using = "PlatinumHounds-grid-1")]
        public IWebElement PlatinumHoundsLobbyImage {get; set;}
        

        [FindsBy (How = How.Id, Using = "HarnessRacing-grid-1")]
        public IWebElement HarnessRacingLobbyImage {get; set;}


        [FindsBy (How = How.Id, Using = "FootballGroup-grid-1")]
        public IWebElement FootballGroupLobbyImage {get; set;}


        public GermanFootballSingle NavigateToRequestedGame()
        {
            FootballGroupLobbyImage.Click();
            return new GermanFootballSingle(driver);
        }
    }
}