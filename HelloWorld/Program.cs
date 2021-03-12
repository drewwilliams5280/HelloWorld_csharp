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
            GreetFriend(friend1);
            GreetFriend(friend2);
            GreetFriend(friend3);
        }
        // access mmodifier (static) return type method name (parameter1, parameter2)
        public static void GreetFriend(string friend)
        {
            Console.WriteLine(friend);
        }
    }
}
