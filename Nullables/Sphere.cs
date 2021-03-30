using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses
{
    class Sphere : Shape
    {
        public double Circumference { get; set; }

        public Sphere(double circumference)
        {
            Name = "Sphere";
            Circumference = circumference;
        }

        public double Radius()
        {
            return Circumference / 2;
        }

        public override double Volume()
        {
            return (4.0 / 3 * Math.PI * Math.Pow(Radius(), 3));
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"The Sphere has a circumference of {Circumference}");
            Console.WriteLine($"The Sphere has a volume of {Volume()}");
        }
    }
}