using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace AutomateBookWagon.Pages
{
    public class CheckYourCart
    {
        public CheckYourCart(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='site-wrapper']/div[3]/div[1]/h1")]
        [CacheLookup]
        public IWebElement checkoutLogo;

        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_cpBody_plnLogged']/div/div/div/a")]
        [CacheLookup]
        public IWebElement continueBtn;
    }
}
