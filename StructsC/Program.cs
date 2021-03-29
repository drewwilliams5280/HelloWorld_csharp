using System;

namespace StructsC
{
    struct Game
    {
        public string name;
        public string developer;
        public double rating;
        public string releaseDate;

        public void Display()
        {
            Console.WriteLine(name);
            Console.WriteLine(developer);
            Console.WriteLine(rating);
            Console.WriteLine(releaseDate);
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Game game1;
            game1.name = "Pokemon Go";
            game1.developer = "Niantic";
            game1.rating = 3.5;
            game1.releaseDate = "01.07.20";

            game1.Display();
        }
    }
}
