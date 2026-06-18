using Homework_Files_11.Task1;
using Homework_Files_11.Task2;
using Homework_Files_11.Task3;

namespace Homework_Files_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LineReader lineReader = new LineReader();

            //lineReader.ProcessFile();

            //MultiplicationWriter multiplicationWriter = new MultiplicationWriter();
            //multiplicationWriter.CreateTableFile();

            XmlSplitter xmlSplitter = new XmlSplitter();
            xmlSplitter.SplitAndCreateXML();
        }
    }
}
