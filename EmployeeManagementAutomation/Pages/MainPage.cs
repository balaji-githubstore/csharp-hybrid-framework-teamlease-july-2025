using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementAutomation.Pages
{
    /// <summary>
    /// This class handles all menu and also handles all common elements of the application
    /// </summary>
    public class MainPage
    {
        private IWebDriver _driver;

        public MainPage(IWebDriver driver)
        {
            this._driver = driver;
        }
    }
}
