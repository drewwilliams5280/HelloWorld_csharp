using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box(5, 5, 5);
        
            box.DisplayInfo();
            Console.WriteLine($"The front surface of the box is {box.FrontSurface}");
        }
    }
}
