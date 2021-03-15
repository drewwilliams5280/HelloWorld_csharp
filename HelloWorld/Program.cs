using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine(counter);
                if(counter == 3)
                {
                    Console.WriteLine("At 3 we stop!");
                    break;
                }
            }
        }
    }
}
