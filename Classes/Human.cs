using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Human
    {
        // member variables
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;

        // constructor
        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }

        //member method
        public void IntroduceMyself()
        {
            Console.WriteLine("Hi, I'm {0} {1}. I've got {2} eyes and am {3} years old.", firstName, lastName, eyeColor, age);
        }
    }
}
