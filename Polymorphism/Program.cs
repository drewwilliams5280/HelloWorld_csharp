using System;
using System.Collections.Generic;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>
            {
                new Audi(200, "blue", "A4"),
                new BMW(250, "red", "M3")
            };

            cars[0].SetCardIDInfo(34150248, "New Car Owner");
            cars[1].SetCardIDInfo(86454, "New Car Owner");

            foreach(var car in cars)
            {
                car.ShowDetails();
                car.Repair();
                car.GetCarIDInfo();
                Console.WriteLine("------------------------------------------------------------------");
            }
            Console.ReadKey();
        }
    }
}
