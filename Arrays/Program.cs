using System;
using System.Linq;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic firstResponse;
            Console.WriteLine("Enter anything:");
            string firstResponseString = Console.ReadLine();
            if(int.TryParse(firstResponseString, out int firstResponseInt))
            {
                firstResponse = firstResponseInt;
            }
            else if(bool.TryParse(firstResponseString, out bool firstResponseBool))
            {
                firstResponse = firstResponseBool;
            }
            else
            {
                firstResponse = firstResponseString;
            }
            SecondStep(firstResponse);
        }

        static void SecondStep(dynamic firstResponse)
        {
            Console.WriteLine("Enter 1 for String");
            Console.WriteLine("Enter 2 for Integer");
            Console.WriteLine("Enter 3 for Boolean");
            int intResponse;
            string secondResponse = Console.ReadLine();
            if(int.TryParse(secondResponse, out intResponse) && Enumerable.Range(1,3).Contains(intResponse))
            {
                FinalStep(firstResponse, intResponse);
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
                SecondStep(firstResponse);
            }
        }

        static void FinalStep(dynamic firstResponse, int intResponse)
        {
            if(intResponse == 1)
            {
                Console.WriteLine($"Your first input was {firstResponse} and you claim it is a String. That is: {firstResponse.GetType() == typeof(string)}");
            }
            else if(intResponse == 2)
            {
                Console.WriteLine($"Your first input was {firstResponse} and you claim it is an Integer. That is: {firstResponse.GetType() == typeof(int)}");
            }
            else
            {
                Console.WriteLine($"Your first input was {firstResponse} and you claim it is a Boolean. That is: {firstResponse.GetType() == typeof(bool)}");
            }
        }
    }
}
