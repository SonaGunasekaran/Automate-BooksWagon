

using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;

namespace AutomateBookWagon
{
    [TestFixture]
    [AllureNUnit]
    [AllureDisplayIgnored]
    public class BooksWagon : Base.Baseclass
    {
        string csvFilePath = @"C:\Users\sona.g\source\repos\AutomateBookWagon\AutomateBookWagon\CSVFile\Signup.csv";
        string emailFilePath = @"C:\Users\sona.g\source\repos\AutomateBookWagon\AutomateBookWagon\CSVFile\Emailfile.csv";
        string negativeFilePath = @"C:\Users\sona.g\source\repos\AutomateBookWagon\AutomateBookWagon\CSVFile\Negative.csv";
        string addressFilePath = @"C:\Users\sona.g\source\repos\AutomateBookWagon\AutomateBookWagon\CSVFile\Address.csv";

        [Test]
        public void TitleAfterLaunching()
        {
            DoActions.DoAction.TitleAfterLaunching();
        }

        [Test(Description = "Automate Signup")]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureTms("TMS-12")]
        [AllureOwner("Sona G")]
        [AllureSuite("PassedSuite")]
        [AllureSubSuite("NoAssert")]
        public void TestForSignupPage()
        {
            DoActions.DoAction.CreateBookWagonAccount(csvFilePath, "Email,Password,Confirm Password");
        }

        [Test(Description = "Automate Login")]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureTms("TMS-12")]
        [AllureOwner("Sona G")]
        [AllureSuite("PassedSuite")]
        [AllureSubSuite("NoAssert")]

        public void TestForLoginPage()
        {
            DoActions.DoAction.LoginIntoBooksWagon(csvFilePath, "Email,Password");
        }

        [Test(Description = "Automate BuyNow Action")]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureTms("TMS-12")]
        [AllureOwner("Sona G")]
        [AllureSuite("PassedSuite")]
        [AllureSubSuite("NoAssert")]

        public void TestForBuyNow()
        {
            DoActions.DoAction.CheckForBuyNow();
        }

        [Test(Description = "Automate Add to wishlist")]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureTms("TMS-12")]
        [AllureOwner("Sona G")]
        [AllureSuite("PassedSuite")]
        [AllureSubSuite("NoAssert")]

        public void TestForAddToWishList()
        {
            DoActions.DoAction.CheckForAddToWishList();
        }

        [Test(Description = "Automate Placeorder")]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureTms("TMS-12")]
        [AllureOwner("Sona G")]
        [AllureSuite("PassedSuite")]
        [AllureSubSuite("NoAssert")]

        public void TestForPlaceOrder()
        {
            DoActions.DoAction.CheckForPlaceOrder();
        }

        [Test(Description = "Automate Add new Address")]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureTms("TMS-12")]
        [AllureOwner("Sona G")]
        [AllureSuite("PassedSuite")]
        [AllureSubSuite("NoAssert")]

        public void TestAddressPage()
        {
            DoActions.DoAction.AddAddressIntoBooksWagon(addressFilePath, "Recipiant Name,Company Name,Street Address,Country,State,City,Pincode,Mobile Number");
        }

        [Test(Description = "Automate Previous Address")]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureTms("TMS-12")]
        [AllureOwner("Sona G")]
        [AllureSuite("PassedSuite")]
        [AllureSubSuite("NoAssert")]

        public void TestForPreviousAddress()
        {
            DoActions.DoAction.SelectPreviousAddress();
        }
        [Test(Description = "Automate Logout")]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureTms("TMS-12")]
        [AllureOwner("Sona G")]
        [AllureSuite("PassedSuite")]
        [AllureSubSuite("NoAssert")]

        public void TestForCheckoutPage()
        {
            DoActions.DoAction.CheckOut();
        }

        [Test(Description = "Automate Payment")]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureTms("TMS-12")]
        [AllureOwner("Sona G")]
        [AllureSuite("PassedSuite")]
        [AllureSubSuite("NoAssert")]

        public void TestForPaymentPage()
        {
            DoActions.DoAction.CheckForPayment();
        }

        [Test(Description = "Automate Logout")]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureTms("TMS-12")]
        [AllureOwner("Sona G")]
        [AllureSuite("PassedSuite")]
        [AllureSubSuite("NoAssert")]

        public void TestForLogout()
        {
            DoActions.DoAction.CheckForLogout();
        }

        [Test(Description = "Automate Email Sending")]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureTms("TMS-12")]
        [AllureOwner("Sona G")]
        [AllureSuite("PassedSuite")]
        [AllureSubSuite("NoAssert")]
        public void TestMethodForEmailSending()
        {
            Reports.Email.UserData(emailFilePath, "From,To,Password");
        }

        [Test(Description = "Automate Invalid Signup")]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureTms("TMS-12")]
        [AllureOwner("Sona G")]
        [AllureSuite("PassedSuite")]
        [AllureSubSuite("NoAssert")]
        public void TestMethodForNegativeLoginPage()
        {
            DoActions.DoAction.CreateBookWagonAccount(negativeFilePath, "Email,Password,Confirm Password");
        }

        [Test(Description = "Automate Invalid Login")]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureTms("TMS-12")]
        [AllureOwner("Sona G")]
        [AllureSuite("PassedSuite")]
        [AllureSubSuite("NoAssert")]
        public void TestForNegativeLoginPage()
        {
            DoActions.DoAction.LoginIntoBooksWagon(negativeFilePath, "Email,Password");
        }

    }


}

