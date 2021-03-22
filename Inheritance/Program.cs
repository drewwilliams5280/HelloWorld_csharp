using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Thanks for the birthday wishes", true, "Drew");
            Console.WriteLine(post1.ToString());
            ImagePost imagePost1 = new ImagePost("Check out my new shoes!", "Drew", "www.images.com/shoes", true);
            Console.WriteLine(imagePost1.ToString());
            Console.ReadLine();
        }
    }
}
