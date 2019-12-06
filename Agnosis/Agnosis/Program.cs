using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agnosis.Util;
using FileAccess = Agnosis.Util.FileAccess;

namespace Agnosis
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Dictionary<string, string> fileMasks = new Dictionary<string, string>();

                Console.WriteLine("Getting file paths...");
                var filePaths = FileAccess.GetFilePathsInDirectory("Input");
                foreach (var path in filePaths)
                {
                    Console.WriteLine(path);
                }

                Console.WriteLine("Masking and copying files...");
                fileMasks = FileAccess.CopyFilesAndMask(filePaths,"Input","Output");
                Console.WriteLine("Creating Excel spreadsheet...");
                ExcelInteropAccess.CreateExcelSpreadsheet(fileMasks,"output\\test.xlsx");

            }
            catch (Exception e)
            {
                Console.WriteLine("D:");
                Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                Console.WriteLine("An error occurred while processing files. Some files may not have been copied. Please let Brandon know about this...",e);
                Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            }
            Console.WriteLine("DONE! :D");
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();

        }
    }
}
