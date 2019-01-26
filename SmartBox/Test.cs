using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Collections.ObjectModel;
namespace SmartBoxSDETCodingAssessment
{
    [TestClass]
    public class Tests
    {
        private IWebDriver driver;
        [TestInitialize]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.smartbox.com/fr/");
        }
        [TestMethod]
        public void AddABoxToCart()
        {
            HomePage homepage = new HomePage(driver);
            homepage.goToSportsAndAdventurePage().SelectABox().BtnAddTobasket()
            .ItemsAddedToCartDisplayed().ClickViewCart().ClickRemoveBox().confirmRemoveBox();
        }

        [TestMethod]
        public void VerifyBoxesAreDisplayed()
        {
            HomePage homepage = new HomePage(driver);
            homepage.goToSportsAndAdventurePage().Search().VerifyBoxDisplayed();
        }
    }
}
