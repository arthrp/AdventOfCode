using System;
using System.IO;

namespace AdventOfCodeSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputFilesFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var content = File.ReadAllText(Path.Combine(inputFilesFolder, "input2.txt"));
            var result = new DayTwo().Solve(content, true);
            Console.WriteLine("Result is: "+result);
        }
    }
}
