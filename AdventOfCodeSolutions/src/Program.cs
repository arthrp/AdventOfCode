using System;
using System.IO;

namespace AdventOfCodeSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputFilesFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var content = File.ReadAllText(Path.Combine(inputFilesFolder, "inputDayOne.txt"));
            var result = new DayOneAdv().Solve(content);
            Console.WriteLine("Result is: "+result);
        }
    }
}
