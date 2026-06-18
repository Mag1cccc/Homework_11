using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Files_11.Task1
{
    internal class LineReader
    {

        public void ProcessFile()
        {
            var folderPath = @"C:\Users\morgo\source\repos\Homework_Files_11\Homework_Files_11\Task1\";

            Directory.CreateDirectory(folderPath);

            var filePath = Path.Combine(folderPath, "random.txt");

            if(!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }

            Console.Write("Enter line count: ");
            int.TryParse(Console.ReadLine(), out var n);

            List<string> lines = new List<string>();

            for(var i = 0; i < n; i++)
            {
                lines.Add(Console.ReadLine());
            }

            File.WriteAllLines(filePath, lines);

            var fileLines = File.ReadAllLines(filePath);

            Console.WriteLine($"Output: {fileLines[fileLines.Length - 1]}");
        }



    }
}
