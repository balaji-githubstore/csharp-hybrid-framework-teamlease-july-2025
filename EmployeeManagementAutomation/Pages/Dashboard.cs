using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementAutomation.Pages
{
    public class Dashboard
    {
        private IWebDriver _driver;

        public Dashboard(IWebDriver driver)
        {
            this._driver = driver;
        }
    }
}
