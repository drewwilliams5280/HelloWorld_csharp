using System;
using System.Linq;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] happinessArray = { 5, 6, 5, 7, 6 };
            Console.WriteLine("Before the sun is shining, happiness levels are:");
            foreach(int num in happinessArray)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("After the sun is shining, happiness levels are:");
            SunIsShining(happinessArray);
            foreach(int num in happinessArray)
            {
                Console.WriteLine(num);
            }
            
        }

        static void SunIsShining(int[] happinessArray)
        {
            for(int i = 0; i < happinessArray.Length; i++)
            {
                happinessArray[i] += 2;
            }
        }
    }
}