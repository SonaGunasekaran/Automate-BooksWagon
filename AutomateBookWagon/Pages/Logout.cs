using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomateBookWagon.Pages
{
    public class Logout
    {
        public Logout(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.LinkText, Using = "Logout")]
        [CacheLookup]
        public IWebElement logoutBtn;
    }
}
