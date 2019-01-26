using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
namespace SmartBoxSDETCodingAssessment
{
    public class HomePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//*[(@id='qa-megamenu-sport')]/a")]
        private IWebElement AlltheSportLink;
        public SportsAndAdventure goToSportsAndAdventurePage()
        {
            AlltheSportLink.Click();
            return new SportsAndAdventure(driver);
        }

    }
}
