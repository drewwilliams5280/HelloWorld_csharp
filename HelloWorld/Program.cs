using System;

namespace HelloWorld
{
    class Program
    {
  
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            string userInput = Console.ReadLine();

            try
            {
                int userInputAsInt = int.Parse(userInput);
            }
            catch (FormatException)
            {
                Console.WriteLine("Format Exception, please enter a number");
            }
            catch (Exception)
            {
                Console.WriteLine("General Exception, please enter a number");
            }
            finally
            {
                Console.WriteLine("This is called anyway.");
            }

            Console.ReadKey();
        }       
    }
}
