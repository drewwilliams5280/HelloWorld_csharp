using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(15, 31)); 
            Console.WriteLine(Multiply(3, 5)); 
            Console.WriteLine(Divide(3.33, 2.75)); 
        }
        // access mmodifier (static) return type method name (parameter1, parameter2)
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
