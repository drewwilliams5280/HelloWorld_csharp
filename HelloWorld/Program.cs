using System;

namespace HelloWorld
{
    class Program
    {
  
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            string input1 = Console.ReadLine();
            Console.WriteLine("Enter number to add to first number:");
            string input2 = Console.ReadLine();
            int total = Int32.Parse(input1) + Int32.Parse(input2);
            Console.WriteLine(total);
            Console.Read();
        }
        // access mmodifier (static) return type method name (parameter1, parameter2)
       
    }
}
