using System;

namespace HelloWorld
{
    class Program
    {
        const string friend1 = "Patrick";
        const string friend2 = "Nolan";
        const string friend3 = "Jack";
        static void Main(string[] args)
        {
            GreetFriend(friend1, friend2, friend3);
        }
        // access mmodifier (static) return type method name (parameter1, parameter2)
        public static void GreetFriend(string friend1, string friend2, string friend3)
        {
            Console.WriteLine(friend1);
            Console.WriteLine(friend2);
            Console.WriteLine(friend3);
        }
    }
}
