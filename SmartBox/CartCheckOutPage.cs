using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SmartBoxSDETCodingAssessment
{
    public class CartCheckOutPage
    {
        private IWebDriver driver;
        public CartCheckOutPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[(@title='Supprimer')]")]
        private IWebElement RemoveBox;

        [FindsBy(How = How.Id, Using = "cart-remove-confirm-accept")]
        private IWebElement ConfirmRemoveBox;


        public CartCheckOutPage ClickRemoveBox()
        {
            RemoveBox.Click();
            return new CartCheckOutPage(driver);
        }
        public HomePage confirmRemoveBox()
        {
            ConfirmRemoveBox.Click();
            return new HomePage(driver);
        }

    }
}
