using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string response;

            Console.WriteLine("Please enter your name and press enter");
            response = Console.ReadLine();
            Console.WriteLine(response.ToUpper());
            Console.WriteLine(response.ToLower());
            Console.WriteLine(response.Trim());
            Console.WriteLine(response.Substring(2));
        }
    }
}
