using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int sum = 0;
            double totalEntries = 0;
            Console.WriteLine("Enter numbers between 0 and 20 to calculate average. Enter -1 to stop.");
            while (result >= 0 && result <= 20)
            {
                string stringResult = Console.ReadLine();
                if (int.TryParse(stringResult, out result) && result >= 0 && result <= 20)
                {
                    sum += result;
                    totalEntries++;
                }
                else if (int.TryParse(stringResult, out result) && result == -1)
                {
                    double average = sum / totalEntries;
                    Console.WriteLine("The sum of your numbers is {0} and the total number of entries was {1}, making the average: {2}", sum, totalEntries, average);
                }
                else
                {
                    Console.WriteLine("Error: Please enter a number between 1 and 20, or -1 to stop the count.");
                    result = 0;
                }
            }
        }
    }
}
