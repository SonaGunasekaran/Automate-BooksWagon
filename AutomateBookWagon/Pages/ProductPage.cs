/*
 * Project:BooksWagon Application-Selenium WebDriver
 * Author:Sona G
 * Date :05/10/2021
 */
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutomateBookWagon.Pages
{
    public class ProductPage
    {
        public ProductPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Name, Using = "ctl00$TopSearch1$txtSearch")]
        [CacheLookup]
        public IWebElement searchItem;

        [FindsBy(How = How.Name, Using = "ctl00$TopSearch1$Button1")]
        [CacheLookup]
        public IWebElement searchIcon;

        [FindsBy(How = How.XPath, Using = "//*[@id='site-wrapper']/div[2]/div[3]/div[1]/div[1]/h1/span")]
        [CacheLookup]
        public IWebElement searchResult;

        [FindsBy(How = How.XPath, Using = "//*[@id='listSearchResult']/div[1]/div[2]/a/img")]
        [CacheLookup]
        public IWebElement product;

        [FindsBy(How = How.Id, Using = "ctl00_phBody_ProductDetail_divAddtoCart")]
        [CacheLookup]
        public IWebElement buyNowBtn;

        [FindsBy(How = How.XPath, Using = "//*[@id='form1']/div[3]/div[1]/a")]
        [CacheLookup]
        public IWebElement siteLogo;

        [FindsBy(How = How.Id, Using = "ctl00_phBody_ProductDetail_lblTitle")]
        [CacheLookup]
        public IWebElement productTitle;

    }
}
