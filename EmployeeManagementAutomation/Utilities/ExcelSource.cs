using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementAutomation.Utilities
{
    public class ExcelSource
    {
        /// <summary>
        /// This method coverts the given sheet into object[]
        /// </summary>
        /// <param name="file"> Excel Details</param>
        /// <param name="sheetName"> Sheetname</param>
        /// <returns>object[]</returns>
        public static object[] GetSheetIntoObjectArray(string file,string sheetName)
        {
            XLWorkbook book = new XLWorkbook(file);

            var sheet = book.Worksheet(sheetName);

            var range = sheet.RangeUsed();

            int rowCount = range.RowCount();
            int columnCount = range.ColumnCount();

            //total number of testcases
            object[] main = new object[rowCount - 1];

            for (int r = 2; r <= rowCount; r++)
            {
                string[] data = new string[columnCount];
                for (int c = 1; c <= columnCount; c++)
                {
                    string cellValue = range.Cell(r, c).GetString();
                    Console.WriteLine(cellValue);
                    data[c - 1] = cellValue;
                }

                main[r - 2] = data;
            }
            book.Dispose();

            return main;
        }
    }
}
