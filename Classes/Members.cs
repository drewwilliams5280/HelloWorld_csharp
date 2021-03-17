using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Members
    {
        // member - private field

        private string memberName;
        private string jobTitle;
        private int salary;

        public int age;

        // member - property - exposed jobTitle safely - properties start with capital letter
        public string JobTitle
        {
            get
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;
            }
        }
        // public member method which can be called from other classes
        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();

            }
            else
            {
                Console.WriteLine("Hi, my name is {0}, and my job title is {1}. I'm {2} years old.", memberName, jobTitle, age);
            }
        }

        private void SharingPrivateInfo()
        {
            Console.WriteLine($"My salary is {salary}");
        }

        // member constructor

        public Members()
        {
            salary = 20000;
            age = 30;
            memberName = "Lucy";
            jobTitle = "Developer";
            Console.WriteLine("Object created!");
        }

        // member - finalizer - destructor

        ~Members()
        {
            // cleanup statements
            Console.WriteLine("Deconstruction");
        }
    }
}
