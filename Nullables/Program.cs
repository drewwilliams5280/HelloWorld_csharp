using System;

namespace NullablesE
{
    class Program
    {
        static void Main(string[] args)
        {
            int? num1 = null;
            int? num2 = 1337;

            double? num3 = new Double?();
            double? num4 = 3.14;

            bool? boolval = new bool?();

            Console.WriteLine("Numbers: {0} {1} {2} {3} {4}", num1, num2, num3, num4, boolval);

            double? num5 = null;

        }
    }
}
