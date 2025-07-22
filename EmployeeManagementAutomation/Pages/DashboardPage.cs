using DocumentFormat.OpenXml.Bibliography;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementAutomation.Pages
{
    public class DashboardPage
    {
        private By timeAtWorkLocator = By.XPath("//p[contains(normalize-space(),'Work')]");
        private IWebDriver _driver;

        public DashboardPage(IWebDriver driver)
        {
            this._driver = driver;
        }

        public string GetTimeAtWorkHeader()
        {
            return _driver.FindElement(timeAtWorkLocator).Text; 
        }
    }
}
