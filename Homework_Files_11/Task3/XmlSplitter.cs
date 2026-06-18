using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Homework_Files_11.Task3
{
    internal class XmlSplitter
    {
        public void SplitAndCreateXML()
        {
            var filePath = @"C:\Users\morgo\source\repos\Homework_Files_11\Homework_Files_11\Task3\testxml.xml";

            Console.WriteLine("Enter word and N (e.g. programming 2): ");

            var inputLine = Console.ReadLine();

            var parts = inputLine.Split(' ');

            var word = parts[0];
            int.TryParse(parts[1], out var n);

            var partLength = (int)Math.Ceiling((double)word.Length / n);

            XElement root = new XElement("root");

            for (var i = 0; i < n; i++)
            {
                var startIndex = i * partLength;
                var currentLength = Math.Min(partLength, word.Length - startIndex);
                var sub = word.Substring(startIndex, currentLength);

                XElement node = new XElement(sub, $"string {i + 1}");
                root.Add(node);
                Console.WriteLine($"Added node: <{sub}>string {i + 1}</{sub}>");
            }

            root.Save(filePath);

            Console.WriteLine($"XML file successfully saved to: {filePath}");

        }
    }
}
