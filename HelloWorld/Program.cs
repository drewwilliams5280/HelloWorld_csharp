using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string response;
            Console.WriteLine("Enter a string here:");
            response = Console.ReadLine();
            string search;
            Console.WriteLine("Enter the character to search:");
            search = Console.ReadLine();
            int searchIndex = response.IndexOf(search);
            Console.WriteLine(searchIndex);
            string firstName;
            string lastName;
            Console.WriteLine("Enter your first name:");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name:");
            lastName = Console.ReadLine();
            Console.WriteLine(String.Format("{0} {1}", firstName, lastName));
        }
    }
}
