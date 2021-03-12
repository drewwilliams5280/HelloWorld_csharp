using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a sting and press Enter:");
            string readInput = Console.ReadLine();
            Console.WriteLine("You have entered {0}", readInput);

            Console.Write("Enter a string and press Enter:");
            int asciiValue = Console.Read();
            Console.WriteLine("ASCII value is {0}", asciiValue);
            Console.ReadKey();
    
           /* string myname = "Drew";

            string message = $"My name is {myname}";

            string capsMessage = message.ToUpper();

            Console.WriteLine(capsessage);
            Console.Read();

              int num1 = 13;
                int num2 = 5;
                int sum = num1 + num2;

                double d1 = 3.5;
                double d2 = 1.337;
                double sumD = d1 + d2;

                Console.WriteLine($"The sum of {num1} and {num2} is {sum}");
                Console.WriteLine($"The sum of {d1} and {d2} is {sumD}");
                Console.Read(); */
        }
    }
}
