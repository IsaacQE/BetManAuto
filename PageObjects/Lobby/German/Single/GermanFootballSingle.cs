using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using FindsByAttribute = SeleniumExtras.PageObjects.FindsByAttribute;
using How = SeleniumExtras.PageObjects.How;
using System.Threading;

namespace betmanAuto.PageObjects.German.Single
{
    public class GermanFootballSingle 
    {
        IWebDriver driver;

        //Constructor defined below
        public GermanFootballSingle (IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver,this);
        }

        //Web page element defined below
        //line 28 replaces line 30-31
        public IWebElement FootballGroupLobbyImage => driver.FindElement(By.Id("FootballGroup-grid-1"));
        /*older below... to be deleted
        [FindsBy (How = How.Id, Using = "FootballGroup-grid-1")]
        public IWebElement FootballGroupLobbyImage {get; set;}
        */
        
        //Behavioural method
        public void NavigateToRequestedGame()
        {
            Thread.Sleep(5000);
            FootballGroupLobbyImage.Click();
        }
        
    }
}