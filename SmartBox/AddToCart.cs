using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SmartBoxSDETCodingAssessment
{
    public class AddToCart
    {
        private IWebDriver driver;
        public AddToCart(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[(@id='box-type-ebox-classic')]/div/a")]
        private IWebElement AddtoBasket;

        [FindsBy(How = How.XPath, Using = "//*[(@id='addtocart-confirmation')]/div/div/p")]
        private IWebElement LblItemsAddedToCart;

        [FindsBy(How = How.XPath, Using = "//*[(@id='addtocart-confirmation')]/div/div/p")]
        private IWebElement ContinueShopping;

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Voir le panier')]")]
        private IWebElement BtnViewCart;

        public AddToCart BtnAddTobasket()
        {
            AddtoBasket.Click();
            return new AddToCart(driver);
        }

        public AddToCart ItemsAddedToCartDisplayed()
        {
            LblItemsAddedToCart.Displayed.Equals(true);
            ContinueShopping.Displayed.Equals(true);
            return new AddToCart(driver);
        }

        public CartCheckOutPage ClickViewCart()
        {
            BtnViewCart.Click();
            return new CartCheckOutPage(driver);
        }
    }
}
