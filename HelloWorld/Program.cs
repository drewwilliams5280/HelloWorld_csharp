using System;

namespace HelloWorld
{
    class Program
    {
        static int highscore = 555;
        static string highscorePlayer = "Scooby Doo";
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your player name:");
            string playerName = Console.ReadLine();
            Console.WriteLine("Please enter your score:");
            string scoreString = Console.ReadLine();
            int.TryParse(scoreString, out int score);
            CheckScore(score, playerName);
            Console.Read();
        }

        static void CheckScore(int score, string playerName)
        {
            if(score > highscore)
            {
                highscore = score;
                highscorePlayer = playerName;
                Console.WriteLine("New high score is {0}", highscore);
                Console.WriteLine("New high score holder is {0}", highscorePlayer);
            }
            else
            {
                Console.WriteLine("The old high score of {0} could not be broken and is still held by {1}", highscore, highscorePlayer);
            }
        }
    }
}
