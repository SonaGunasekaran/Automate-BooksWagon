/*
 * Project:BooksWagon Application-Selenium WebDriver
 * Author:Sona G
 * Date :05/10/2021
 */
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutomateBookWagon.Pages
{
    public class PlaceOrderPage
    {
        public PlaceOrderPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Name, Using = "BookCart$lvCart$imgPayment")]
        [CacheLookup]
        public IWebElement placeorderbtn;

        [FindsBy(How = How.Name, Using = "BookCart$lvCart$ctrl0$txtQty")]
        [CacheLookup]
        public IWebElement quantity;

        [FindsBy(How = How.Id, Using = "BookCart_lvCart_lblMsg")]
        [CacheLookup]
        public IWebElement updated;

        [FindsBy(How = How.LinkText, Using = "International Shipping Calculator")]
        [CacheLookup]
        public IWebElement calculator;

        [FindsBy(How = How.XPath, Using = "/html/body/form/div[3]/div[2]/div/div/div[3]/div[2]/div/table/tbody/tr[4]/td[4]/div[1]/div/div[1]/table/tbody/tr[4]/td/select/option[104]")]
        [CacheLookup]
        public IWebElement country;

        [FindsBy(How = How.XPath, Using = "//*[@id='BookCart_lvCart_lblNetAmount']")]
        [CacheLookup]
        public IWebElement amountpayable;

        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_cpBody_plnLogged']/div/div/div/a")]
        [CacheLookup]
        public IWebElement continueBtn;
    }
}
