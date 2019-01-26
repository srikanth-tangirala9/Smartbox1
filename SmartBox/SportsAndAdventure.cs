using System.Collections.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SmartBoxSDETCodingAssessment
{
    public class SportsAndAdventure
    {
        private IWebDriver driver;

        public SportsAndAdventure(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "location")]
        private IWebElement SearchBox;

        [FindsBy(How = How.XPath, Using = "//*[@id='ac-cloudSearchResults']/article/a")]
        private IWebElement searchResults;

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Découvrir plus')]")]
        private IWebElement Découvrirplus;

        [FindsBy(How = How.XPath, Using = "//*[@id='ac-cloudSearchResults']/article[1]")]
        private IWebElement Box;

        public SportsAndAdventure Search()
        {
            SearchBox.SendKeys("Saut en parachute");
            SearchBox.SendKeys(Keys.Enter);
            return new SportsAndAdventure(driver);
        }

        public SportsAndAdventure VerifyBoxDisplayed()
        {
            ReadOnlyCollection<IWebElement> Boxes = driver.FindElements(By.XPath("//*[@id='ac-cloudSearchResults']/article/a"));
            Assert.IsTrue(Boxes.Count > 0);
            Assert.IsTrue(Boxes[0].FindElement(By.XPath("//div[contains(text(),'Découvrir plus')]")).Displayed);
            return new SportsAndAdventure(driver);
        }

        public AddToCart SelectABox()
        {
            driver.FindElement(By.XPath("//*[@id='ac-cloudSearchResults']/article[1]"));
            Box.Click();
            return new AddToCart(driver);
        }
    }
}
