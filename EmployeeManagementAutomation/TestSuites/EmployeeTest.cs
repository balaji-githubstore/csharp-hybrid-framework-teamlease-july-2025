using EmployeeManagementAutomation.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementAutomation.TestSuites
{
    public class EmployeeTest : AutomationWrapper
    {
        [Test]
        public void AddValidEmployeeTest()
        {
            driver.FindElement(By.Name("username")).SendKeys("Admin");
            driver.FindElement(By.Name("password")).SendKeys("admin123");
            driver.FindElement(By.XPath("//button[normalize-space()='Login']")).Click();

            //Click on PIM menu
            //Click on Add Employee
            //Enter firstname as john
            //middle name as w
            //lastname as wick 
            //save 

            //Assert the profile name - john wick
            //Assert the firstname textbox contains - john
        }
    }
}
