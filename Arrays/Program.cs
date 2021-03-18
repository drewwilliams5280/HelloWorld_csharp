using System;
using System.Collections;
using System.Linq;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaring an ArrayList with undefined amount of object
            ArrayList myArrayList = new ArrayList();
            // declaring with defined amount of objects
            ArrayList myArrayList2 = new ArrayList(100);

            myArrayList.Add(25);
            myArrayList.Add("Hello");
            myArrayList.Add(44.567);
            myArrayList.Add("How is it going?");
            myArrayList.Add(25.3);
            // delete element with specific value
            myArrayList.Remove("Hello");
            // delete at index
            myArrayList.RemoveAt(0);
            // count
            Console.WriteLine(myArrayList.Count);

            
        }
    }
}