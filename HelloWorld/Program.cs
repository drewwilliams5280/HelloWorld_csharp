using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringtemp = Console.ReadLine();
            int temp = int.Parse(stringtemp);

            if(temp < 10)
            {
                Console.WriteLine("Put on a coat");
            }
            else if(temp > 10)
            {
                Console.WriteLine("It's hot");
            }
            else
            {
                Console.WriteLine("It's 10 degrees");
            }
        }
    }
}
