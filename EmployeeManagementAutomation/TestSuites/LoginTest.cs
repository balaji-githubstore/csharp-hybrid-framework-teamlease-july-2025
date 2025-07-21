using EmployeeManagementAutomation.Base;
using EmployeeManagementAutomation.Pages;
using EmployeeManagementAutomation.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementAutomation.TestSuites
{
    public class LoginTest : AutomationWrapper
    {
        [Test]
        public void ValidLoginTest()
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.EnterUsername("Admin");
            loginPage.EnterPassword("admin123");

            driver.FindElement(By.XPath("//button[normalize-space()='Login']")).Click();

            string actualValue= driver.FindElement(By.XPath("//p[contains(normalize-space(),'Work')]")).Text;
            Assert.That(actualValue, Is.EqualTo("Time at Work"));
        }

      


        //[TestCase("saul", "saul123", "Invalid credential")]
        //[TestCase("kim", "kim123", "Invalid credential")]
        [Test,TestCaseSource(typeof(DataSource), nameof(DataSource.InvalidLoginTestDataFromExcel))]
        public void InvalidLoginTest(string username,string password,string expectedError)
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.EnterUsername(username);
            loginPage.EnterPassword(password);

            driver.FindElement(By.XPath("//button[normalize-space()='Login']")).Click();
            string actualValue = driver.FindElement(By.XPath("//p[contains(normalize-space(),'Invalid')]")).Text;
            Assert.That(actualValue.Contains(expectedError), "Assertion on Invalid credentials");
        }
    }
}
