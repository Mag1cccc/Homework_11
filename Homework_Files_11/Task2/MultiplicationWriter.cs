using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Files_11.Task2
{
    internal class MultiplicationWriter
    {
        public void CreateTableFile()
        {
            var folderPath = @"C:\Users\morgo\source\repos\Homework_Files_11\Homework_Files_11\Task2\";

            Directory.CreateDirectory(folderPath);

            var filePath = Path.Combine(folderPath, "table.txt");

            Console.Write("Enter N: ");
            int.TryParse(Console.ReadLine(), out var n);

            List<string> lines = new List<string>();
            for(var i = 1; i <= 9; i++)
            {
                string row = "";
                for(var j = 1; j <= n; j++)
                {
                    row += $"{j} * {i} = {j * i}";

                    if (j < n)
                    {
                        row += " | ";
                    }
                }

                lines.Add(row); 
            }

            Console.WriteLine(filePath);

            File.WriteAllLines(filePath, lines);
            Console.WriteLine("Table has been saved successfully");

        }

    }
}
