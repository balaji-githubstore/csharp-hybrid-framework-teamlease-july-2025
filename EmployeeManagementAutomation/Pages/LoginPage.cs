using DocumentFormat.OpenXml.Bibliography;
using EmployeeManagementAutomation.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementAutomation.Pages
{
    public class LoginPage 
    {
        private IWebDriver _driver;

        public LoginPage(IWebDriver driver)
        {
            this._driver = driver;
        }


        public void EnterUsername(string username)
        {
            _driver.FindElement(By.Name("username")).SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            _driver.FindElement(By.Name("password")).SendKeys(password);
        }
    }
}
