using System;
using System.IO;

namespace FileTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example 1 - reading text
            string text = System.IO.File.ReadAllText(@"C:\Users\DrewW\source\docs\textFile.txt");

            Console.WriteLine(text);
            //read each line
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\DrewW\source\docs\textFile.txt");

            foreach(string line in lines)
            {
                Console.WriteLine("\t" + line);
            }

            string[] writeLines = { "first line", "second line", "third line" };

            File.WriteAllLines(@"C:\Users\DrewW\source\docs\textFile.txt", writeLines);

            lines = System.IO.File.ReadAllLines(@"C:\Users\DrewW\source\docs\textFile.txt");

            foreach (string line in lines)
            {
                Console.WriteLine("\t\t" + line);
            }
        }
    }
}
