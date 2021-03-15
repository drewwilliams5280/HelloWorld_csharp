using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp = -5;
            string stateOfMatter;

            if (temp < 0)
                stateOfMatter = "solid";
            else
                stateOfMatter = "liquid";

            Console.WriteLine("State of matter is {0}", stateOfMatter);

            temp = 130;

            stateOfMatter = temp > 100 ? "gas" : temp < 0 ? "solid" : "liquid";

            Console.WriteLine("State of matter is {0}", stateOfMatter);

            Console.Read();
        }
    }
}
