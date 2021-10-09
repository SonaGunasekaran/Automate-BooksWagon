using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutomateBookWagon.Pages
{
    public class PaymentPage
    {
        public PaymentPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_cpBody_uplnCheckout']/div[2]/div[2]/div")]
        [CacheLookup]
        public IWebElement paymentTitle;

        [FindsBy(How = How.LinkText, Using = "Paypal")]
        [CacheLookup]
        public IWebElement payOptions;

        [FindsBy(How = How.Name, Using = "ctl00$cpBody$btnCCAvenue")]
        [CacheLookup]
        public IWebElement payBtn;
    }
}
