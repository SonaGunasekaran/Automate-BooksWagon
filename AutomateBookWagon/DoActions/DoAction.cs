/*
 * Project:BooksWagon Application-Selenium WebDriver
 * Author:Sona G
 * Date :05/10/2021
 */
using AutomateBookWagon.Pages;
using Microsoft.VisualBasic.FileIO;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace AutomateBookWagon.DoActions
{
    public class DoAction : Base.Baseclass
    {
        public static void TitleAfterLaunching()
        {
            string title1 = "Online Bookstore | Buy Books Online | Read Books Online";
            string title = driver.Title;
            Assert.AreEqual(title1, title);
        }

        public static void CreateBookWagonAccount(string csvFilePath, string dataHeader)
        {
            using (TextFieldParser csvParser = new TextFieldParser(csvFilePath))
            {
                csvParser.SetDelimiters(new string[] { "," });
                csvParser.HasFieldsEnclosedInQuotes = true;

                //Skip the row with the column names
                csvParser.ReadLine();
                while (!csvParser.EndOfData)
                {
                    // Read current line fields, pointer moves to the next line.
                    string[] column = csvParser.ReadFields();
                    try
                    {
                        SignupPage signup = new SignupPage(driver);

                        //click on sign-in button
                        signup.signupBtn.Click();
                        System.Threading.Thread.Sleep(1000);

                        //validate whether the signup title is equal or not
                        string expected = "New Customers";
                        string actual = signup.signupTitle.Text;
                        Assert.AreEqual(actual, expected);

                        //Passing email id through sendkeys
                        signup.email.SendKeys(column[0]);

                        //Passing the password through sendkeys
                        signup.password.SendKeys(column[1]);

                        //Passing the password through sendkeys
                        signup.confirmPwd.SendKeys(column[2]);

                        //Click on continue button
                        signup.continueBtn.Click();
                        logger.Info("Account Created Successfully");
                        
                        System.Threading.Thread.Sleep(1000);
                    }
                    catch (Exception ex)
                    {
                        throw new CustomException(CustomException.ExceptionType.NO_SUCH_ELEMENT, "Unable to locate element");
                    }
                }
            }
        }

        public static void LoginIntoBooksWagon(string csvFilePath1, string dataHeader)
        {
            using (TextFieldParser csvParser = new TextFieldParser(csvFilePath1))
            {
                csvParser.SetDelimiters(new string[] { "," });
                csvParser.HasFieldsEnclosedInQuotes = true;

                // Skip the row with the column names
                csvParser.ReadLine();

                while (!csvParser.EndOfData)
                {
                    // Read current line fields, pointer moves to the next line.
                    string[] column = csvParser.ReadFields();
                    try
                    {
                        LoginPage login = new LoginPage(driver);

                        // click on sign-in button
                        login.signInBtn.Click();

                        //validate whether the login title is equal or not
                        string actual = login.loginTitle.Text;
                        string expected = "Existing Customers";
                        Assert.AreEqual(expected, actual);

                        //Passing email id through sendkeys
                        login.email.SendKeys(column[0]);
                        System.Threading.Thread.Sleep(500);

                        //Passing the password through sendkeys
                        login.password.SendKeys(column[1]);
                        System.Threading.Thread.Sleep(500);

                        //click on loginbutton
                        login.continueBtn.Click();

                        //validate whether the login id is displayed or not
                        Assert.IsTrue(login.usermail.Displayed);
                        logger.Info("Logged in successfully");

                    }
                    catch (Exception ex)
                    {
                        throw new CustomException(CustomException.ExceptionType.NO_SUCH_ELEMENT, "Unable to locate element");
                    }
                }
            }
        }

        public static void SearchForProduct()
        {
            try
            {
                string loginFilePath = @"C:\Users\sona.g\source\repos\AutomateBookWagon\AutomateBookWagon\CSVFile\Signup.csv";

                LoginIntoBooksWagon(loginFilePath, "Email,Password");

                ProductPage product = new ProductPage(driver);

                //enter the search item to search
                product.searchItem.SendKeys("Stories we never tell");

                //click on search icon
                product.searchIcon.Click();
                System.Threading.Thread.Sleep(2000);

                //check whether the result is same or not
                string expected = "\"stories we never tell\"";
                string actual = product.searchResult.Text;
                Assert.AreEqual(actual, expected);

                //click the desired product
                product.product.Click();
                logger.Info("Product is found");
                System.Threading.Thread.Sleep(10000);

                Assert.IsTrue(product.productTitle.Displayed);
            }
            catch (Exception ex)
            {
                throw new CustomException(CustomException.ExceptionType.NO_SUCH_ELEMENT, "Unable to locate element");
            }
        }

        public static void CheckForBuyNow()
        {
            try
            {
                SearchForProduct();
                ProductPage product = new ProductPage(driver);

                //switch to the frame
                driver.SwitchTo().Frame(0);

                //click on buy now button
                product.buyNowBtn.Click();
                System.Threading.Thread.Sleep(4000);
                logger.Info("Product is Availbale to buy");
                Takescreenshot();

                Assert.IsTrue(product.siteLogo.Displayed);
                System.Threading.Thread.Sleep(2000);
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }
        }

        public static void CheckForAddToWishList()
        {
            try
            {
                SearchForProduct();
                AddToWishList cart = new AddToWishList(driver);

                //click on add to wishlist button
                cart.addTolistBtn.Click();

                //click on buy now button
                cart.buyNow.Click();
                logger.Info("Product is ready to buy");
                Takescreenshot();
                System.Threading.Thread.Sleep(2000);
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }
        }

        public static void CheckForPlaceOrder()
        {
            try
            {
                PlaceOrderPage order = new PlaceOrderPage(driver);

                CheckForAddToWishList();
                //switch to frame 
                driver.SwitchTo().Frame(0);

                //Click on quantity
                order.quantity.Click();
                order.quantity.SendKeys(Keys.Delete);
                order.quantity.SendKeys("2");
                order.quantity.SendKeys(Keys.Enter);
                System.Threading.Thread.Sleep(1000);

                //check whether the quantity updated message displayed or not
                Assert.IsTrue(order.updated.Displayed);
                
                //click on place order button
                order.placeorderbtn.Click();

                System.Threading.Thread.Sleep(1000);

                //Validate whether the current url and expected url are same or not
                string expected = "https://www.bookswagon.com/checkout-login";
                Assert.AreEqual(driver.Url, expected);
                Takescreenshot();
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }
        }

        public static void CheckYourCart()
        {
            CheckForPlaceOrder();

            CheckYourCart cart = new CheckYourCart(driver);

            //validate whether the checkout logo is displayed or not
            Assert.IsTrue(cart.checkoutLogo.Displayed);
            System.Threading.Thread.Sleep(2000);

            //click pn continue button
            cart.continueBtn.Click();

            //Validate whether the current url and expected url are same or not 
            string expected = "https://www.bookswagon.com/shippingoption.aspx";
            Assert.AreEqual(expected, driver.Url);
            System.Threading.Thread.Sleep(1000);
        }

        public static void AddAddressIntoBooksWagon(string csvFilePath, string dataHeader)
        {
            using (TextFieldParser csvParser = new TextFieldParser(csvFilePath))
            {
                csvParser.SetDelimiters(new string[] { "," });
                csvParser.HasFieldsEnclosedInQuotes = true;

                // Skip the row with the column names
                csvParser.ReadLine();

                while (!csvParser.EndOfData)
                {
                    // Read current line fields, pointer moves to the next line.
                    string[] column = csvParser.ReadFields();
                    try
                    {
                        //CheckForPlaceOrder();
                         AddressPage add = new AddressPage(driver);
                        
                        //enter the full name
                        add.repName.SendKeys(column[0]);
                        System.Threading.Thread.Sleep(500);

                        //Enter the company name
                        add.cmpyName.SendKeys(column[1]);
                        System.Threading.Thread.Sleep(500);

                        //Enter the recepiant address
                        add.repaddress.SendKeys(column[2]);
                        System.Threading.Thread.Sleep(1000);

                        //Select the country
                        SelectElement element = new SelectElement(add.country);
                        element.SelectByValue(column[3]);
                        System.Threading.Thread.Sleep(1000);

                        //Select the state
                        SelectElement element1 = new SelectElement(add.state);
                        element1.SelectByValue(column[4]);
                        System.Threading.Thread.Sleep(1000);

                        //Select the city
                        SelectElement element2 = new SelectElement(add.city);
                        element2.SelectByValue(column[5]);
                        System.Threading.Thread.Sleep(1000);

                        //Enter the pincode
                        add.pinCode.SendKeys(column[6]);
                        System.Threading.Thread.Sleep(300);

                        //Enter the mobile number
                        add.mobNumber.SendKeys(column[7]);

                        //Click on Add Address
                        add.continueBtn.Click();

                        System.Threading.Thread.Sleep(6000);
                    }
                    catch (Exception ex)
                    {
                        throw new CustomException(CustomException.ExceptionType.NO_SUCH_ELEMENT, "Unable to locate element");
                    }
                }

            }
        }

        public static void SelectPreviousAddress()
        {
            try
            {
                CheckYourCart();
                AddressPage address = new AddressPage(driver);

                //Validate whether the expected and actual shipping title is equal or not
                string expectedTitle = "Shipping Address";
                string actualTitle = address.addressTitle.Text;
                Assert.AreEqual(expectedTitle, actualTitle);
                System.Threading.Thread.Sleep(2000);

                //click on deliver address button
                address.addressBtn.Click();
                logger.Info ("Address added successfully");

                //Validate whether the current url and expected url are same or not 
                string expectedUrl = "https://www.bookswagon.com/viewshoppingcart.aspx";
                Assert.AreEqual(expectedUrl, driver.Url);
                Takescreenshot();
                System.Threading.Thread.Sleep(2000);
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }
        }

        public static void CheckOut()
        {
            try
            {
                SelectPreviousAddress();
                CheckoutPage check = new CheckoutPage(driver);

                //check whether the review title is displayed or not
                Assert.IsTrue(check.reviewTitle.Displayed);

                //Passing the message through sendkeys
                check.msg.SendKeys("Enjoy your Book! With love Sona G");

                //Passing the instruction through sendkeys
                check.instructions.SendKeys("Return within 7 days");

                //click on save button
                check.saveBtn.Click();

                logger.Info("Message and Instruction saved successfully!");
                Takescreenshot();
                System.Threading.Thread.Sleep(2000);

                //Validate whether the current url and expected url are same or not 
                string expectedUrl = "https://www.bookswagon.com/checkout.aspx";
                Assert.AreEqual(expectedUrl, driver.Url);
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }
        }

        public static void CheckForPayment()
        {
            try
            {
                CheckOut();
                PaymentPage pay = new PaymentPage(driver);

                string expected = "Choose your mode of payment";
                Assert.AreEqual(expected, pay.paymentTitle.Text);

                //click on payment option button
                pay.payOptions.Click();
                
                //click on payment button
                pay.payBtn.Click();
                System.Threading.Thread.Sleep(10000);

                logger.Info("Payment successfully");
                Takescreenshot();

                //Validate whether the current url and expected url are same or not 
                string expectedUrl = "https://www.bookswagon.com/checkout.aspx";
                Assert.AreEqual(expectedUrl, driver.Url);
                System.Threading.Thread.Sleep(2000);
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }
        }

        public static void CheckForLogout()
        {
            try
            {
                CheckForPayment();

                Logout logout = new Logout(driver);
                
                //click on logout button
                logout.logoutBtn.Click();

                logger.Info("Logged out successfully");
                Takescreenshot();

                //Validate whether the current url and expected url are same or not 
                string expectedUrl = "https://www.bookswagon.com/login";
                Assert.AreEqual(expectedUrl, driver.Url);
                System.Threading.Thread.Sleep(2000);
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }
        }
    }
}





