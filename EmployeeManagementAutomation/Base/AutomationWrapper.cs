using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementAutomation.Base
{
    public class AutomationWrapper
    {
        protected IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Url = "https://opensource-demo.orangehrmlive.com/";
        }

        [TearDown]
        public void TearDown()
        {
            if (driver != null)
            {
                driver.Dispose();
            }
        }
    }
}
