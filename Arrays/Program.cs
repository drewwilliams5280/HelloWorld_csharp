using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] grades = new int[5];

            grades[0] = 97;
            grades[1] = 67;
            grades[2] = 77;
            grades[3] = 73;
            grades[4] = 89;

            Console.WriteLine($"There are {grades.Length} grades total. They are:");

            foreach (var grade in grades)
            {
                Console.WriteLine(grade);
            }

            string[] newGrades = { "97", "87", "77", "67", "60" };

            Console.WriteLine("String grades:");

            foreach (string grade in newGrades)
            {
                Console.WriteLine(grade);
            }
        }
    }
}
