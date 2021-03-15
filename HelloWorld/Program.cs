using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isAdmin = false;
            bool isRegistered = true;
            string userName = "";
            Console.WriteLine("Please enter username");
            userName = Console.ReadLine();

            if(isRegistered && userName != "" && userName.Equals("Admin"))
            {
                Console.WriteLine("Hi there registered user");
              
                Console.WriteLine("Hi there, {0}", userName);
               
                Console.WriteLine("Hi there, Admin");
            }
        }
    }
}
