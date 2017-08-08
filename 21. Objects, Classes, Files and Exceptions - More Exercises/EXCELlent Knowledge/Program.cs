using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace EXCELlent_Knowledge
{
    class Program
    {
        static void Main(string[] args)
        {
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"D:\Software University\Programming Fundamentals\Homework\ObjectsClassesFilesAndExceptionsMoreExe\EXCELlent Knowledge\bin\Debug\sample_table.xlsx");
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;

            int rowCount = 5;
            int colCount = 5;

            var output = new List<string>();

            for (int i = 1; i <= rowCount; i++)
            {
                for (int j = 1; j <= colCount; j++)
                {
                    if (xlRange.Cells[i, j] != null && xlRange.Cells[i, j].Value2 != null)
                    {
                        output.Add(xlRange.Cells[i, j].Value2.ToString() + "|");
                    }
                }

                output.Add("\r\n");
            }

            File.WriteAllText("output.txt", string.Join("", output));
        }
    }
}
