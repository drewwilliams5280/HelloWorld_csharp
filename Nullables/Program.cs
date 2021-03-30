using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Cube myCube = new Cube(4.0);
            myCube.GetInfo();

            Sphere mySphere = new Sphere(12.0);
            mySphere.GetInfo();
        }
    }
}
