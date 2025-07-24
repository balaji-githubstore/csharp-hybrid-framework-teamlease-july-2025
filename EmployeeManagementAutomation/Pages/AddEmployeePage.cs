using EmployeeManagementAutomation.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementAutomation.Pages
{
    public class AddEmployeePage : WebDriverKeywords
    {
        private IWebDriver _driver;

        public AddEmployeePage(IWebDriver driver) : base(driver)
        {
            this._driver = driver;
        }
    }
}
