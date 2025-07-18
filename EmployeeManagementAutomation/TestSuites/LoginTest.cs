using EmployeeManagementAutomation.Base;
using EmployeeManagementAutomation.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
            driver.FindElement(By.Name("username")).SendKeys("Admin");
            driver.FindElement(By.Name("password")).SendKeys("admin123");
            driver.FindElement(By.XPath("//button[normalize-space()='Login']")).Click();

            string actualValue= driver.FindElement(By.XPath("//p[contains(normalize-space(),'Work')]")).Text;
            Assert.That(actualValue, Is.EqualTo("Time at Work"));
        }

      


        //[TestCase("saul", "saul123", "Invalid credential")]
        //[TestCase("kim", "kim123", "Invalid credential")]
        [Test,TestCaseSource(typeof(DataSource), nameof(DataSource.InvalidLoginTestData))]
        public void InvalidLoginTest(string username,string password,string expectedError)
        {
            driver.FindElement(By.Name("username")).SendKeys(username);
            driver.FindElement(By.Name("password")).SendKeys(password);
            driver.FindElement(By.XPath("//button[normalize-space()='Login']")).Click();

            string actualValue = driver.FindElement(By.XPath("//p[contains(normalize-space(),'Invalid')]")).Text;
            Assert.That(actualValue.Contains(expectedError), "Assertion on Invalid credentials");
        }
    }
}
