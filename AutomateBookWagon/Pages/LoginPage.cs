/*
 * Project:BooksWagon Application-Selenium WebDriver
 * Author:Sona G
 * Date :05/10/2021
 */
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutomateBookWagon.Pages
{
    public class LoginPage
    {
        public LoginPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.LinkText, Using = "Login")]
        [CacheLookup]
        public IWebElement signInBtn;

        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_phBody_SignIn_plnSignIn']/div/div[1]")]
        [CacheLookup]
        public IWebElement loginTitle;

        [FindsBy(How = How.Name, Using = "ctl00$phBody$SignIn$txtEmail")]
        [CacheLookup]
        public IWebElement email;

        [FindsBy(How = How.Name, Using = "ctl00$phBody$SignIn$txtPassword")]
        [CacheLookup]
        public IWebElement password;

        [FindsBy(How = How.Name, Using = "ctl00$phBody$SignIn$btnLogin")]
        [CacheLookup]
        public IWebElement continueBtn;

        [FindsBy(How = How.Id, Using = "ctl00_lblUser")]
        [CacheLookup]
        public IWebElement usermail;
        
        [FindsBy(How = How.Id, Using = "ctl00_phBody_SignIn_lblmsg")]
        [CacheLookup]
        public IWebElement invalid;
    }
}
