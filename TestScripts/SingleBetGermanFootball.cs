using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;
using SeleniumExtras.PageObjects;
using NUnit;
using betmanAuto.PageObjects.German.Single;
using betmanAuto.BaseClass;
using System.Threading;

namespace betmanAuto.TestScripts
{

[TestFixture]
public class PlaceSingleBet : BaseTest
{
    [Test]
    public void TestMethod1()
    {
        var GermanFootballSingle = new GermanFootballSingle(driver);
        GermanFootballSingle.NavigateToRequestedGame();
        Thread.Sleep(5000);
    }
}
}