/*
 * Project:BooksWagon Application-Selenium WebDriver
 * Author:Sona G
 * Date :05/10/2021
 */
using AutomateBookWagon.Pages;
using Microsoft.VisualBasic.FileIO;
using NUnit.Framework;
using System;

namespace AutomateBookWagon.NegativeTestCases
{
    public class NegativeAction:Base.Baseclass
    {
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
                        SignupPage nsignup = new SignupPage(driver);

                        //click on sign-in button
                        nsignup.signupBtn.Click();
                        System.Threading.Thread.Sleep(4000);

                        //Passing email id through sendkeys
                        nsignup.email.SendKeys(column[0]);

                        //Passing the password through sendkeys
                        nsignup.password.SendKeys(column[1]);

                        nsignup.confirmPwd.SendKeys(column[2]);
                        //continue
                        nsignup.continueBtn.Click();
                        Assert.IsTrue(nsignup.invalid.Displayed);

                        System.Threading.Thread.Sleep(2000);
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
                        LoginPage nlogin = new LoginPage(driver);

                        // click on sign-in button
                        nlogin.signInBtn.Click();

                        nlogin.email.SendKeys(column[0]);
                        System.Threading.Thread.Sleep(500);

                        //enter the password 
                        nlogin.password.SendKeys(column[1]);
                        System.Threading.Thread.Sleep(500);

                        //click on loginbutton
                        nlogin.continueBtn.Click();

                        Assert.IsTrue(nlogin.invalid.Displayed);
                    }
                    catch (Exception ex)
                    {
                        throw new CustomException(CustomException.ExceptionType.NO_SUCH_ELEMENT, "Unable to locate element");
                    }
                }
            }
        }
    }
}
