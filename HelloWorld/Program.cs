using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string enteredText = "";
            while(enteredText.Equals(""))
            {
                Console.WriteLine("Please press enter to increase count or enter any text to stop the count.");
                enteredText = Console.ReadLine();
                counter++;
                Console.WriteLine(counter);
            }
            Console.Read();
        }
    }
}
