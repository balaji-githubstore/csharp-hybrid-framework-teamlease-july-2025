using EmployeeManagementAutomation.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementAutomation.TestSuites
{
    /// <summary>
    /// Please complete the below code
    /// </summary>
    public class EmployeeTest : AutomationWrapper
    {
        //[Test]
        public void AddValidEmployeeTest(string username,string password,string firstName,string middleName,string lastName)
        {
            driver.FindElement(By.Name("username")).SendKeys("Admin");
            driver.FindElement(By.Name("password")).SendKeys("admin123");
            driver.FindElement(By.XPath("//button[normalize-space()='Login']")).Click();

            driver.FindElement(By.XPath("//span[text()='PIM']")).Click();
            driver.FindElement(By.LinkText("Add Employee")).Click();
            driver.FindElement(By.Name("firstName")).SendKeys("john");
            driver.FindElement(By.Name("middleName")).SendKeys("w");
            driver.FindElement(By.Name("lastName")).SendKeys("jack");
            driver.FindElement(By.XPath("//button[normalize-space()='Save']")).Click();

            //Assert the profile name - john wick
            string actualProfileName= driver.FindElement(By.XPath("//h6[contains(normalize-space(),'jack')]")).Text;
            //Assert the firstname textbox contains - john
            string actualFirstName=driver.FindElement(By.Name("firstName")).GetAttribute("value");

            Assert.Multiple(() =>
            {
                Assert.That(actualProfileName, Is.EqualTo("john jack"));
                Assert.That(actualFirstName, Is.EqualTo("john"));
            });
        }
    }
}
