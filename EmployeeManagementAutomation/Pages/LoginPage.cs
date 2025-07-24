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
    public class LoginPage : WebDriverKeywords
    {
        private By usernameLocator = By.Name("username");
        private By passwordLocator = By.Name("password");
        private By loginLocator = By.XPath("//button[normalize-space()='Login']");
        private By errorLocator = By.XPath("//p[contains(normalize-space(),'Invalid')]");

     //   private IWebDriver _driver;

        public LoginPage(IWebDriver driver) : base(driver)
        {
            //this._driver = driver;
        }

        public void EnterUsername(string username)
        {
            //_driver.FindElement(usernameLocator).SendKeys(username);
            SetTextToElement(usernameLocator, username);
        }

        public void EnterPassword(string password)
        {
            //_driver.FindElement(passwordLocator).SendKeys(password);
            base.SetTextToElement(passwordLocator, password);
        }

        public void ClickOnLogin()
        {
            //_driver.FindElement(loginLocator).Click();
            ClickOnElement(loginLocator);
        }

        public void LoginToDashboard(string username, string password)
        {
            EnterUsername(username);
            EnterPassword(password);
            ClickOnLogin();
        }
        public string GetInvalidErrorMessage()
        {
            //return _driver.FindElement(errorLocator).Text;
            return GetTextFromElement(errorLocator);
        }

        public string GetUsernamePlaceholder()
        {
            //return _driver.FindElement(usernameLocator).GetAttribute("placeholder");
            return GetAtrributeValueOfElement(usernameLocator, "placeholder");
        }
    }
}
