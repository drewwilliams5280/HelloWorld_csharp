using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            byte myByte = 45;
            Console.WriteLine(myByte);
            sbyte mySbyte = -120;
            Console.WriteLine(mySbyte);
            int myInt = 465658;
            Console.WriteLine(myInt);
            uint myUint = 9636963;
            Console.WriteLine(myUint);

            string value1 = "I control text";
            string value2 = "23";
            int intFromString = Int32.Parse(value2);
            Console.WriteLine(value1);
            Console.WriteLine(value2);
            Console.WriteLine(intFromString);
        }
    }
}
