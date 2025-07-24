using EmployeeManagementAutomation.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementAutomation.Pages
{
    public class PersonalDetailsPage : WebDriverKeywords
    {
        private IWebDriver _driver;

        public PersonalDetailsPage(IWebDriver driver) : base(driver)
        {
            this._driver = driver;
        }
    }
}
