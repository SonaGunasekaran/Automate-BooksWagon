/*
 * Project:BooksWagon Application-Selenium WebDriver
 * Author:Sona G
 * Date :05/10/2021
 */
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;

namespace AutomateBookWagon.Reports
{
    [TestFixture]
    public class ExtendReports
    {
        public static ExtentHtmlReporter htmlReporter;
        public static ExtentReports extent;
        public static ExtentTest test;
        public static ExtentReports report()
        {
            if (extent == null)
            {
                string reportPath = @"C:\Users\sona.g\source\repos\AutomateBookWagon\AutomateBookWagon\Reports\ExtendReport.html";
                htmlReporter = new ExtentHtmlReporter(reportPath);
                extent = new ExtentReports();
                extent.AttachReporter(htmlReporter);
                extent.AddSystemInfo("OS", "Windows");
                extent.AddSystemInfo("UserName", "Sona");
                extent.AddSystemInfo("ProviderName", "Sona");
                extent.AddSystemInfo("Domain", "QA");
                extent.AddSystemInfo("ProjectName", " Automation");
                string conifgPath = @"C:\Users\sona.g\source\repos\AutomateBookWagon\AutomateBookWagon\Reports\extend-config.xml";
                htmlReporter.LoadConfig(conifgPath);
            }
            return extent;
        }
    }
}
