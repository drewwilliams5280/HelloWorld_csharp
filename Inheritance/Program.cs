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
            VideoPost videoPost1 = new VideoPost("Cool skateboarding moves", "Drew", "www.youtube.com/ssssddddffff", "3:04", true);
            Console.WriteLine(videoPost1.ToString());
            Console.ReadLine();
        }
    }
}
