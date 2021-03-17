using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];

            for(int i = 0; i < 10; i++)
            {
                nums[i] = i*i;
            }

            foreach(int num in nums)
            {
                Console.WriteLine(num);
            }

            string[] friends = { "Nolan", "Patrick", "Victoria", "Keegan", "Colin" };

            foreach(string friend in friends)
            {
                Console.WriteLine($"Hi there, {friend}!");
            } 
        }
    }
}
