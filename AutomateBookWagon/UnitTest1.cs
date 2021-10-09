/*
 * Project:BooksWagon Application-Selenium WebDriver
 * Author:Sona G
 * Date :05/10/2021
 */
using NUnit.Framework;

namespace AutomateBookWagon
{
    public class Tests : Base.Baseclass
    {
        string csvFilePath = @"C:\Users\sona.g\source\repos\AutomateBookWagon\AutomateBookWagon\CSVFile\Signup.csv";
        string emailFilePath = @"C:\Users\sona.g\source\repos\AutomateBookWagon\AutomateBookWagon\CSVFile\Emailfile.csv";
        string negativeFilePath = @"C:\Users\sona.g\source\repos\AutomateBookWagon\AutomateBookWagon\CSVFile\Negative.csv";
        string addressFilePath = @"C:\Users\sona.g\source\repos\AutomateBookWagon\AutomateBookWagon\CSVFile\Address.csv";
        [Test, Order(1)]
        public void TitleAfterLaunching()
        {
            DoActions.DoAction.TitleAfterLaunching();
        }

        [Test, Order(2)]
        public void TestForSignupPage()
        {
            DoActions.DoAction.CreateBookWagonAccount(csvFilePath, "Email,Password,Confirm Password");
        }

        [Test, Order(3)]
        public void TestForLoginPage()
        {
            DoActions.DoAction.LoginIntoBooksWagon(csvFilePath, "Email,Password");
        }

        [Test, Order(4)]
        public void TestForBuyNow()
        {
            DoActions.DoAction.CheckForBuyNow();
        }

        [Test, Order(5)]
        public void TestForAddToWishList()
        {
            DoActions.DoAction.CheckForAddToWishList();
        }

        [Test, Order(6)]
        public void TestForPlaceOrder()
        {
            DoActions.DoAction.CheckForPlaceOrder();
        }

        [Test, Order(7)]
        public void TestAddressPage()
        {
            DoActions.DoAction.AddAddressIntoBooksWagon(addressFilePath, "Recipiant Name,Company Name,Street Address,Country,State,City,Pincode,Mobile Number");
        }

        [Test, Order(8)]
        public void TestForPreviousAddress()
        {
            DoActions.DoAction.SelectPreviousAddress();
        }

        [Test, Order(9)]
        public void TestForCheckoutPage()
        {
            DoActions.DoAction.CheckOut();
        }

        [Test, Order(10)]
        public void TestForPaymentPage()
        {
            DoActions.DoAction.CheckForPayment();
        }

        [Test, Order(11)]
        public void TestForLogout()
        {
            DoActions.DoAction.CheckForLogout();
        }

        [Test, Order(12)]
        public void TestMethodForEmailSending()
        {
            Reports.Email.UserData(emailFilePath, "From,To,Password");
        }

        [Test, Order(13)]
        public void TestMethodForNegativeLoginPage()
        {
            DoActions.DoAction.CreateBookWagonAccount(negativeFilePath, "Email,Password,Confirm Password");
        }

        [Test, Order(14)]
        public void TestForNegativeLoginPage()
        {
            DoActions.DoAction.LoginIntoBooksWagon(negativeFilePath, "Email,Password");
        }

    }
}