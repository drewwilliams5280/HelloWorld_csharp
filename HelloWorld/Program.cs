using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthOfText = 0;
            string wholeText = "";
            do
            {
                Console.WriteLine("Please enter the name of a friend:");
                string nameOfFriend = Console.ReadLine();
                int currentLength = nameOfFriend.Length;
                lengthOfText += currentLength;
                wholeText += nameOfFriend;
                Console.WriteLine(wholeText);
      
            } while (lengthOfText < 20);
            Console.WriteLine("Thanks, that was enough");
            Console.Read();
        }
    }
}
