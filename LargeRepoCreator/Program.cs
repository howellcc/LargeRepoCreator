using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace LargeRepoCreator
{
   class Program
   {
      static void Main(string[] args)
      {
         const string OutputDir = "C:\\Workspaces\\LCSLargeRepo-GitHub\\";
         const string WarAndPeacePath = "C:\\Workspaces\\LargeRepoCreator\\LargeRepoCreator\\WarAndPeace.txt";

         const int filesToCreate = 5000;
         const int filesPerFolder = 25;
         const int minLength = 40;
         const int maxLength = 2000;


         string[] book = File.ReadAllLines(WarAndPeacePath);
         Random r = new Random(DateTime.Now.Millisecond);
         string currentOutputDir = string.Empty;

         for (int i = 0; i < filesToCreate; i++)
         {
            if(i%filesPerFolder == 0)
            {
               currentOutputDir = OutputDir + GetFolderPath(i, filesPerFolder);
               Directory.CreateDirectory(currentOutputDir);
            }
            File.WriteAllLines(currentOutputDir + i.ToString() + ".txt", book.Take(r.Next(minLength, maxLength)));
         }
      }



      public static string GetFolderPath(int fileNumber, int filesPerFolder)
      {
         if (fileNumber < filesPerFolder)
            return "0\\";

         string folderNumber = (fileNumber / filesPerFolder).ToString();

         return Regex.Replace(folderNumber, ".{1}", "$0\\");
      }
   }
}
