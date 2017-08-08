using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfFiles = int.Parse(Console.ReadLine());

            var filesByRootFolder = new Dictionary<string, Dictionary<string, string>>();

            for (int i = 0; i < numberOfFiles; i++)
            {
                var fullFilePath = Console.ReadLine().Trim();

                var directoriesAndFiles = fullFilePath.Split('\\');

                var rootFolderName = directoriesAndFiles.First();

                var fileWithSize = directoriesAndFiles.Last().Split(';');

                var file = fileWithSize.First();

                var sizeOfFileInKB = fileWithSize.Last();

                if (!filesByRootFolder.ContainsKey(rootFolderName))
                {
                    filesByRootFolder.Add(rootFolderName, new Dictionary<string, string>());
                }

                if (filesByRootFolder[rootFolderName].ContainsKey(file))
                {
                    filesByRootFolder[rootFolderName][file] = sizeOfFileInKB;
                }
                else
                {
                    filesByRootFolder[rootFolderName].Add(file, sizeOfFileInKB);
                }
            }

            var query = Console.ReadLine().Split();
            var queryExtension = query.First();
            var queryRoot = query.Last();

            if (filesByRootFolder.ContainsKey(queryRoot))
            {
                if(filesByRootFolder[queryRoot].Count == 1)
                {
                    if(!filesByRootFolder[queryRoot].Keys.First().EndsWith(queryExtension))
                    {
                        Console.WriteLine("No");
                        return;
                    }
                }

                foreach (var root in filesByRootFolder[queryRoot].OrderByDescending(r => r.Value).ThenBy(r => r.Key).Where(r => r.Key.EndsWith(queryExtension)))
                {
                    Console.WriteLine($"{root.Key} - {root.Value} KB");
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
