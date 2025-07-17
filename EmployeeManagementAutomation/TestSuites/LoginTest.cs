using EmployeeManagementAutomation.Base;
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

        [Test]
        public void InvalidLoginTest()
        {
            driver.FindElement(By.Name("username")).SendKeys("john");
            driver.FindElement(By.Name("password")).SendKeys("admin123");
            driver.FindElement(By.XPath("//button[normalize-space()='Login']")).Click();

            string actualValue = driver.FindElement(By.XPath("//p[contains(normalize-space(),'Invalid')]")).Text;
            Assert.That(actualValue.Contains("Invalid credential"), "Assertion on Invalid credentials");
        }
    }
}
