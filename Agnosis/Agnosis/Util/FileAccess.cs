﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Agnosis.Util
{
    public static class FileAccess
    {
        public static List<string> GetFilePathsInDirectory(string path)
        {
            try
            {
                return Directory.GetFiles(path, "*", SearchOption.AllDirectories).ToList();
            }
            catch (Exception)
            {
                Console.WriteLine("An error occurred while getting file paths");
                throw;
            }
        }

        public static Dictionary<string, string> CopyFilesAndMask(List<string> filePaths,string inputDirectory, string outputDirectory)
        {
            Dictionary<string,string> fileNameMasks = new Dictionary<string, string>();
            try
            {
                foreach (string filePath in filePaths)
                {
                    //get filename
                    int fileNameStart = filePath.LastIndexOf('\\');
                    int fileNameEnd = filePath.LastIndexOf('.');
                    string fileName = filePath.Substring(fileNameStart + 1, fileNameEnd - fileNameStart - 1);
                    Guid fileGuid = Guid.NewGuid();
                    fileNameMasks.Add(fileGuid.ToString(), fileName);

                    //replace filename with guid
                    string newFilePath = filePath.Remove(fileNameStart + 1, fileNameEnd - fileNameStart - 1);
                    newFilePath = newFilePath.Insert(fileNameStart + 1, fileGuid.ToString());

                    //replace "input" with outputdir
                    int inputDirStart = newFilePath.IndexOf(inputDirectory,StringComparison.InvariantCulture);
                    newFilePath = newFilePath.Remove(inputDirStart, inputDirectory.Length);
                    newFilePath =  newFilePath.Insert(inputDirStart, outputDirectory);
                    
                    //write file to new path;
                    CopyFileToNewLocation(filePath,newFilePath);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("An error occurred while copying files.");
                throw;
            }

            return fileNameMasks;
        }

        public static void RemoveFiles(List<string> filePaths)
        {
            foreach (string path in filePaths)
            {
                File.Delete(path);
            }
        }

        public static void WriteLogFile(List<string> message)
        {
            System.IO.File.WriteAllLines($"{Environment.CurrentDirectory}\\ErrorLog.txt",message);
        }

        private static void CopyFileToNewLocation(string originalPath, string outputPath)
        {
            int fileNameStart = outputPath.LastIndexOf("\\", StringComparison.InvariantCulture);
            Directory.CreateDirectory(outputPath.Substring(0,fileNameStart+1));
            File.Copy(originalPath, outputPath,true);
        }
    }
}
