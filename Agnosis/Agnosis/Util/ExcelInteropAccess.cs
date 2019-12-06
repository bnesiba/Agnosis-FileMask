using System;
using System.Collections.Generic;
using System.Net.Mime;
using Microsoft.Office.Interop.Excel;

namespace Agnosis.Util
{
    public static class ExcelInteropAccess
    {
        public static void CreateExcelSpreadsheet(Dictionary<string,string> maskDictionary, string path)
        {
            Application excelApp = new Application();
            Workbook excelWorkBook = null;
            Worksheet excelWorkSheet = null;

            excelWorkBook = excelApp.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);

            try
            {
                excelWorkSheet = excelWorkBook.Worksheets[1];
                int row = 1;
                //write info to excel doc
                foreach (string mask in maskDictionary.Keys)
                {
                    excelWorkSheet.Cells[1][row] = mask;
                    excelWorkSheet.Cells[2][row] = maskDictionary[mask];
                    row++;
                }
                //mask cells
                var maskedValueRange = excelWorkSheet.Range[excelWorkSheet.Cells[1, 2],
                    excelWorkSheet.Cells[maskDictionary.Count, 2]];
                maskedValueRange.Interior.Color = XlRgbColor.rgbBlack;

                excelWorkSheet.Columns[1].ColumnWidth = 40;
                excelWorkSheet.Columns[2].ColumnWidth = 32;


                excelWorkBook.SaveAs($"{Environment.CurrentDirectory}\\{path}");
                excelWorkBook.Close();
                excelApp.Quit();
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred while creating excel spreadsheet");
                throw;
            }

        }
    }
}
