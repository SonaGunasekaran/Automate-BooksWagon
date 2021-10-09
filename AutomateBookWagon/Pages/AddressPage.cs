using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutomateBookWagon.Pages
{
    public class AddressPage
    {
        public AddressPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_cpBody_plnCustomerAdd']/div/div[1]")]
        [CacheLookup]
        public IWebElement addressTitle;
        
        [FindsBy(How = How.Name, Using = "ctl00$cpBody$txtNewRecipientName")]
        [CacheLookup]
        public IWebElement repName;

        [FindsBy(How = How.Name, Using = "ctl00$cpBody$txtNewCompanyName")]
        [CacheLookup]
        public IWebElement cmpyName;

        [FindsBy(How = How.Name, Using = "ctl00$cpBody$txtNewAddress")]
        [CacheLookup]
        public IWebElement repaddress;
        
        [FindsBy(How = How.Name, Using = "ctl00$cpBody$ddlNewCountry")]
        [CacheLookup]
        public IWebElement country;
        
        [FindsBy(How = How.Name, Using = "ctl00$cpBody$ddlNewState")]
        [CacheLookup]
        public IWebElement state;

        [FindsBy(How = How.Id, Using = "ctl00_cpBody_ddlNewCities")]
        [CacheLookup]
        public IWebElement city;

        [FindsBy(How = How.Name, Using = "ctl00$cpBody$txtNewPincode")]
        [CacheLookup]
        public IWebElement pinCode;

        [FindsBy(How = How.Name, Using = "ctl00$cpBody$txtNewMobile")]
        [CacheLookup]
        public IWebElement mobNumber;

        [FindsBy(How = How.Name, Using = "ctl00$cpBody$imgSaveNew")]
        [CacheLookup]
        public IWebElement continueBtn;

        [FindsBy(How = How.Name, Using = "ctl00$cpBody$lvCustomerAdd$ctrl0$btnUseAddress")]
        [CacheLookup]
        public IWebElement addressBtn;
    }
}
