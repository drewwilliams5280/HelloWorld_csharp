using System;

namespace DateTimeT
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myDateTime = new DateTime(1988, 12, 22);

            Console.WriteLine("My birthday is {0}", myDateTime);

            // Write today
            Console.WriteLine(DateTime.Today);
            // current time
            Console.WriteLine(DateTime.Now);

            // tomorrow
            Console.WriteLine(DateTime.Now.AddDays(1));

            // day of week
            Console.WriteLine(DateTime.Now.DayOfWeek);

            // days passed since bday

            TimeSpan daysPassed = DateTime.Now.Subtract(myDateTime);
            Console.WriteLine(daysPassed);
        }
    }
}
