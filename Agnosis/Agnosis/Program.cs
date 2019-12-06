using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agnosis
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Dictionary<string, string> fileMasks = new Dictionary<string, string>();
                List<string> filePaths = new List<string>();

                Console.WriteLine("Getting file paths...");
                filePaths = FileAccess.GetFilePathsInDirectory("Input");
                foreach (var path in filePaths)
                {
                    Console.WriteLine(path);
                }

                fileMasks = FileAccess.CopyFilesAndMask(filePaths,"Input","Output");

                foreach (var file in fileMasks.Keys)
                {
                    Console.WriteLine($"Key: {file} - Value: {fileMasks[file]}");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                Console.WriteLine("An error occurred while processing files. Some files may not have been copied. Please let Brandon know about this...",e);
                Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            }

            Console.WriteLine("Press any key to continue");
            Console.ReadLine();

        }
    }
}
