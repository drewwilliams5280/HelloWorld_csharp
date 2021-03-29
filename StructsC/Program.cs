using System;

namespace MathE
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 13;
            int num2 = 9;
            int num3 = 5;
            Console.WriteLine(Math.Min(num1, num2));
            Console.WriteLine(Math.Max(num1, num2));
            Console.WriteLine(Math.Pow(num2, num3));
            Console.WriteLine(Math.PI);
            Console.WriteLine(Math.Sqrt(25));
            Console.WriteLine(Math.Sqrt(345.543));

            Console.ReadKey();
        }
    }
}
