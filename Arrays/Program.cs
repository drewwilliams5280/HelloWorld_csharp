using System;
using System.Linq;

namespace Arrays
{
    class Program
    {
        static string[,] board =
           {
                { "1", "2", "3" },
                { "4", "5", "6" },
                { "7", "8", "9" }
            };
        static int playerTurn = 1;
        static void Main(string[] args)
        {
            NextMove(playerTurn);
        }

        static void NextMove(int playerNumber)
        {
            Console.WriteLine(String.Format("|{0,5}|{1,5}|{2,5}|", "   ", "   ", "   "));
            Console.WriteLine(String.Format("|{0,5}|{1,5}|{2,5}|", board[0, 0] + "  ", board[0, 1] + "  ", board[0, 2] + "  "));
            Console.WriteLine(String.Format("|{0}|{1}|{2}|", "-----", "-----", "-----"));
            Console.WriteLine(String.Format("|{0,5}|{1,5}|{2,5}|", "   ", "   ", "   "));
            Console.WriteLine(String.Format("|{0,5}|{1,5}|{2,5}|", board[1, 0] + "  ", board[1, 1] + "  ", board[1, 2] + "  "));
            Console.WriteLine(String.Format("|{0}|{1}|{2}|", "-----", "-----", "-----"));
            Console.WriteLine(String.Format("|{0,5}|{1,5}|{2,5}|", "   ", "   ", "   "));
            Console.WriteLine(String.Format("|{0,5}|{1,5}|{2,5}|", board[2, 0] + "  ", board[2, 1] + "  ", board[2, 2] + "  "));
            Console.WriteLine(String.Format("|{0}|{1}|{2}|", "-----", "-----", "-----"));
            switch (playerNumber)
            {
                case 1:
                    Console.WriteLine("Player 1, choose your field!");
                    PlayerOneSelection();
                    PlayerOneCheckWin();
                    break;
                case 2:
                    Console.WriteLine("Player 2, choose your field!");
                    PlayerTwoSelection();
                    PlayerTwoCheckWin();
                    break;
            };
        }

        static void PlayerOneSelection()
        {
            string response = Console.ReadLine();
            if (int.TryParse(response, out int responseNumber) && Enumerable.Range(1, 9).Contains(responseNumber))
            {
                ReplaceNumberWithPlayerLetter(response, "O");
            }
            else
            {
                Console.WriteLine("That isn't a valid option, please try again.");
                NextMove(playerTurn);
            }
        }
        
        static void PlayerOneCheckWin()
        {
           if (OneDown("O") || TwoDown("O") || ThreeDown("O") || OneAcross("O") || FourAcross("O") || SevenAcross("O") || OneDiag("O") || ThreeDiag("O"))
            {
                Console.WriteLine("Player 1 Wins! Type 'start' to play again");
                string response = Console.ReadLine();
                if (response == "start" || response == "Start")
                {
                    ResetBoard();
                    NextMove(playerTurn);
                }
            }
            else
            {
                playerTurn = 2;
                NextMove(playerTurn);
            }
        }
        
        static void PlayerTwoSelection()
        {
            string response = Console.ReadLine();
            if (int.TryParse(response, out int responseNumber) && Enumerable.Range(1, 9).Contains(responseNumber))
            {
                ReplaceNumberWithPlayerLetter(response, "X");
            }
            else
            {
                Console.WriteLine("That isn't a valid option, please try again.");
                NextMove(playerTurn);
            }

        }
        
        static void PlayerTwoCheckWin()
        {
            if (OneDown("X") || TwoDown("X") || ThreeDown("X") || OneAcross("X") || FourAcross("X") || SevenAcross("X") || OneDiag("X") || ThreeDiag("X"))
            {
                Console.WriteLine("Player 2 Wins! Type 'start' to play again");
                string response = Console.ReadLine();
                if (response == "start" || response == "Start")
                {
                    ResetBoard();
                    NextMove(playerTurn);
                }
            }
            else
            {
                playerTurn = 1;
                NextMove(playerTurn);
            }

        }

        static void ReplaceNumberWithPlayerLetter(string response, string letter)
        {
            switch (response)
            {
                case "1":
                    if (board[0, 0] == "1")
                    {
                        board[0, 0] = letter;
                    }
                    else
                    {
                        Console.WriteLine("This number has already been guessed, please choose another number");
                        NextMove(playerTurn);
                    }
                    break;
                case "2":
                    if (board[0, 1] == "2")
                    {
                        board[0, 1] = letter;
                    }
                    else
                    {
                        Console.WriteLine("This number has already been guessed, please choose another number");
                        NextMove(playerTurn);
                    }
                    break;
                case "3":
                    if (board[0, 2] == "3")
                    {
                        board[0, 2] = letter;
                    }
                    else
                    {
                        Console.WriteLine("This number has already been guessed, please choose another number");
                        NextMove(playerTurn);
                    }
                    break;
                case "4":
                    if (board[1, 0] == "4")
                    {
                        board[1, 0] = letter;
                    }
                    else
                    {
                        Console.WriteLine("This number has already been guessed, please choose another number");
                        NextMove(playerTurn);
                    }
                    break;
                case "5":
                    if (board[1, 1] == "5")
                    {
                        board[1, 1] = letter;
                    }
                    else
                    {
                        Console.WriteLine("This number has already been guessed, please choose another number");
                        NextMove(playerTurn);
                    }
                    break;
                case "6":
                    if (board[1, 2] == "6")
                    {
                        board[1, 2] = letter;
                    }
                    else
                    {
                        Console.WriteLine("This number has already been guessed, please choose another number");
                        NextMove(playerTurn);
                    }
                    break;
                case "7":
                    if (board[2, 0] == "7")
                    {
                        board[2, 0] = letter;
                    }
                    else
                    {
                        Console.WriteLine("This number has already been guessed, please choose another number");
                        NextMove(playerTurn);
                    }
                    break;
                case "8":
                    if (board[2, 1] == "8")
                    {
                        board[2, 1] = letter;
                    }
                    else
                    {
                        Console.WriteLine("This number has already been guessed, please choose another number");
                        NextMove(playerTurn);
                    }
                    break;
                case "9":
                    if (board[2, 2] == "9")
                    {
                        board[2, 2] = letter;
                    }
                    else
                    {
                        Console.WriteLine("This number has already been guessed, please choose another number");
                        NextMove(playerTurn);
                    }
                    break;
            }
        }

        static bool OneDown(string letter)
        {
            if (board[0, 0] == letter && board[1, 0] == letter && board[2, 0] == letter)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        static bool TwoDown(string letter)
        {
            if (board[0, 1] == letter && board[1, 1] == letter && board[2, 1] == letter)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool ThreeDown(string letter)
        {
            if (board[0, 2] == letter && board[1, 2] == letter && board[2, 2] == letter)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool OneAcross(string letter)
        {
            if (board[0, 0] == letter && board[0, 1] == letter && board[0, 2] == letter)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool FourAcross(string letter)
        {
            if (board[1, 0] == letter && board[1, 1] == letter && board[1, 2] == letter)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool SevenAcross(string letter)
        {
            if (board[2, 0] == letter && board[2, 1] == letter && board[2, 2] == letter)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool OneDiag(string letter)
        {
            if (board[0, 0] == letter && board[1, 1] == letter && board[2, 2] == letter)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool ThreeDiag(string letter)
        {
            if (board[0, 2] == letter && board[1, 1] == letter && board[2, 0] == letter)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void ResetBoard()
        {
            board[0, 0] = "1";
            board[0, 1] = "2";
            board[0, 2] = "3";
            board[1, 0] = "4";
            board[1, 1] = "5";
            board[1, 2] = "6";
            board[2, 0] = "7";
            board[2, 1] = "8";
            board[2, 2] = "9";
        }
    }
}
