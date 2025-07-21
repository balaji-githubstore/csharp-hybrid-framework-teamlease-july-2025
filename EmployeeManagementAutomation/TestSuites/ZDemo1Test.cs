using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementAutomation.TestSuites
{
    public class ZDemo1Test
    {
        [Test]
        public void ExcelTest()
        {
            XLWorkbook book = new XLWorkbook(@"D:\Balaji\Company\TeamL July 2025\AutomationFrameworkSolution\EmployeeManagementAutomation\TestData\orange-test-data.xlsx");

            var sheet = book.Worksheet("InvalidLoginTest");

            var range = sheet.RangeUsed();

            int rowCount=range.RowCount();
            int columnCount=range.ColumnCount();

            //total number of testcases
            object[] main = new object[rowCount-1];

            for (int r = 2; r <= rowCount; r++)
            {
                string[] data=new string[columnCount];
                for (int c = 1; c <= 3; c++)
                {
                    string cellValue = range.Cell(r, c).GetString();
                    Console.WriteLine(cellValue);
                    data[c-1] = cellValue;
                }

                main[r-2] = data;
            }
            book.Dispose();

        }
    }
}
