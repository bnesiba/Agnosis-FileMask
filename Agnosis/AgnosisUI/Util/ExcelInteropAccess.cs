using System;
using System.Collections.Generic;
using Microsoft.Office.Interop.Excel;

namespace Agnosis.Util
{
    public static class ExcelInteropAccess
    {
        private static List<int> usedIndicies = new List<int>();
        private static Random rng = new Random();
        public static void CreateExcelSpreadsheet(Dictionary<string,string> maskDictionary, string path)
        {
            Application excelApp = new Application();
            Workbook excelWorkBook = null;
            Worksheet excelWorkSheet = null;
            usedIndicies = new List<int>();

            excelWorkBook = excelApp.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);

            try
            {
                excelWorkSheet = excelWorkBook.Worksheets[1];
                int row;
                //write info to excel doc
                foreach (string mask in maskDictionary.Keys)
                {
                    row = generateUnusedRowIndex(maskDictionary.Keys.Count);
                    excelWorkSheet.Cells[1][row] = mask;
                    excelWorkSheet.Cells[2][row] = maskDictionary[mask];
                }

                //hide column
                var hiddenValueRange = excelWorkSheet.Range[excelWorkSheet.Cells[1, 2],
                    excelWorkSheet.Cells[maskDictionary.Count, 2]];
                excelWorkSheet.Columns.AutoFit();
                hiddenValueRange.EntireColumn.Hidden = true;


                excelWorkBook.SaveAs(path);
                excelWorkBook.Close();
                excelApp.Quit();
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred while creating excel spreadsheet");
                throw;
            }

        }

        private static int generateUnusedRowIndex(int maxInt)
        {          
            while (true)
            {
                int row = rng.Next(1,maxInt+1);
                if (!usedIndicies.Contains(row))
                {
                    usedIndicies.Add(row);
                    return row;
                }
            }
        }
    }
}
