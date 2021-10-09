using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutomateBookWagon.Pages
{
    public class CheckoutPage
    {
        public CheckoutPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_cpBody_ShoppingCart_uplnShopping']/div[2]/h3")]
        [CacheLookup]
        public IWebElement reviewTitle;
        
        [FindsBy(How = How.Name, Using = "ctl00$cpBody$ShoppingCart$lvCart$txtGiftMessage")]
        [CacheLookup]
        public IWebElement msg;

        [FindsBy(How = How.Name, Using = "ctl00$cpBody$ShoppingCart$lvCart$txtInstruction")]
        [CacheLookup]
        public IWebElement instructions;

        [FindsBy(How = How.Name, Using = "ctl00$cpBody$ShoppingCart$lvCart$savecontinue")]
        [CacheLookup]
        public IWebElement saveBtn;


    }
}
