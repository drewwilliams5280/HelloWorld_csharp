using System;
using System.Linq;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // declars 2 array
            string[,] matrix;
            //3D array
            int[,,] threeD;
            // 2D array
            int[,] array2D = new int[,]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };
            Console.WriteLine($"{array2D[2,0]}");

            threeD = new int[,,]
            {
                {
                    { 000,001 },
                    { 002,003 }
                },
                {
                    {100,101 },
                    {102, 103 }
                }
            };
            Console.WriteLine($"{threeD[1,1,1]}");

        }
    }
}
