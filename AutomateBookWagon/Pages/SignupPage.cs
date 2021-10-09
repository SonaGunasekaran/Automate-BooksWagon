/*
 * Project:BooksWagon Application-Selenium WebDriver
 * Author:Sona G
 * Date :05/10/2021
 */
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutomateBookWagon.Pages
{
    public class SignupPage
    {
        public SignupPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.LinkText, Using = "Signup")]
        [CacheLookup]
        public IWebElement signupBtn;

        [FindsBy(How = How.XPath, Using = "//*[@id='signup']/div[1]")]
        [CacheLookup]
        public IWebElement signupTitle;


        [FindsBy(How = How.Name, Using = "ctl00$phBody$SignUp$txtEmail")]
        [CacheLookup]
        public IWebElement email;

        [FindsBy(How = How.Name, Using = "ctl00$phBody$SignUp$txtPassword")]
        [CacheLookup]
        public IWebElement password;

        [FindsBy(How = How.Name, Using = "ctl00$phBody$SignUp$txtConfirmPwd")]
        [CacheLookup]
        public IWebElement confirmPwd;

        [FindsBy(How = How.Name, Using = "ctl00$phBody$SignUp$btnSubmit")]
        [CacheLookup]
        public IWebElement continueBtn;

        [FindsBy(How = How.Id, Using = "ctl00_phBody_SignUp_cvPassword")]
        [CacheLookup]
        public IWebElement invalid;

    }
}
