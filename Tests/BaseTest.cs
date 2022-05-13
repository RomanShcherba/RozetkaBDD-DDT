using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace RozetkaBDD_DDT.Tests
{
    [TestFixture]
    public class BaseTest
    {
        protected    IWebDriver driver;

        [OneTimeSetUp]
        protected void DoBeforeAllTheTests()
        {
            if (driver == null)
            {
                driver = new ChromeDriver();
            }
        }
        [SetUp]
        protected void DoBeforeEach()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://rozetka.com.ua/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

        }

        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }
        [BeforeScenario]
        protected void DoBeforeAllScenarios()
        {
            if (driver == null)
            {
                driver = new ChromeDriver();
            }
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("https://rozetka.com.ua/ua/");
            driver.Manage().Window.Maximize();
        }

        [AfterScenario]
        protected void DoAfterAllScenarios()
        {
            driver.Quit();
        }
    }
}
