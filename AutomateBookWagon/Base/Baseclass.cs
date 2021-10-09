/*
 * Project:BooksWagon Application-Selenium WebDriver
 * Author:Sona G
 * Date :05/10/2021
 */
using AutomateBookWagon.Reports;
using AventStack.ExtentReports;
using log4net;
using log4net.Config;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;

namespace AutomateBookWagon.Base
{
    public class Baseclass
    {
        public static IWebDriver driver;

        public static ILog logger = LogManager.GetLogger(typeof(Tests));

        ExtentReports reports = ExtendReports.report();
        ExtentTest test;


        [SetUp]
        public void Setup()
        {
            // Load configuration
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));

            test = reports.CreateTest("Tests");
            test.Log(Status.Info, "BooksWagon Automation");

            driver = new ChromeDriver();

            //Maximize the window
            driver.Manage().Window.Maximize();

            //Get the URL
            driver.Url = "https://www.bookswagon.com/";

            System.Threading.Thread.Sleep(1000);

            logger.Info("Exit");
        }

        public static void Takescreenshot()
        {
            ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
            Screenshot screenshot = screenshotDriver.GetScreenshot();
            screenshot.SaveAsFile(@"C:\Users\sona.g\source\repos\AutomateBookWagon\AutomateBookWagon\Screenshots\Test.png");
        }

        [TearDown]
        public void TearDown()
        {
            Takescreenshot();
            test.Info("Details", MediaEntityBuilder.CreateScreenCaptureFromPath(@"C:\Users\sona.g\source\repos\AutomateBookWagon\AutomateBookWagon\Screenshots\\Test.png").Build());

            test.Log(Status.Pass, "Test Passes");

            reports.Flush();
            //Close the current window
            driver.Quit();
        }
    }
}
