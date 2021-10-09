using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomateBookWagon.Pages
{
    public class AddToWishList
    {
        public AddToWishList(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "/html/body/form/div[4]/div[2]/div[2]/div[2]/div[6]/table/tbody/tr/td[2]/div/a/input")]
        [CacheLookup]
        public IWebElement addTolistBtn;

        [FindsBy(How = How.XPath, Using = "/html/body/form/div[4]/div[2]/div[2]/div[1]/div[2]/div/div[2]/div/div[2]/div/div[2]/div[1]/div[4]/div[4]/table/tbody/tr[3]/td[1]/div/a/input")]
        [CacheLookup]
        public IWebElement buyNow;
    }
}
