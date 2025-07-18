using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementAutomation.Utilities
{
    /// <summary>
    /// This class contains all [TestCaseSource] method 
    /// </summary>
    public class DataSource
    {
        public static object[] InvalidLoginTestData()
        {
            string[] dataSet1 = new string[3]; //number of parameters
            dataSet1[0] = "saul";
            dataSet1[1] = "saul123";
            dataSet1[2] = "Invalid credential";

            string[] dataSet2 = new string[3]; //number of parameters
            dataSet2[0] = "jack";
            dataSet2[1] = "kim";
            dataSet2[2] = "Invalid credential";


            object[] main = new object[2]; // number of testcases
            main[0] = dataSet1;
            main[1] = dataSet2;

            return main;
        }



    }
}
