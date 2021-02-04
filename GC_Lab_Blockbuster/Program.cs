
using System;
using System.Threading;

namespace GC_Lab_Blockbuster
{
    class Program
    {
        public static string userInput;
        public static bool userWantsToContinue;

        static void Main(string[] args)
        {
            
            PrintWelcomeMessage();

            do
            {
                AccessBlockBusterCatalog();
            } while (userWantsToContinue);

            ExitApp();
        }

        private static void AccessBlockBusterCatalog()
        {
            BlockBuster blockBuster = new BlockBuster();

            blockBuster.DisplayMovies();

            CheckUserWantsToContinue();
        }

        private static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to Antonio's Blockbuster!");
        }

        private static void CheckUserWantsToContinue()
        {
            // Prompt user to continue/quit
            Console.WriteLine(Environment.NewLine);

            Console.Write("\tOk! Go back to the main menu? Enter y or n: ");

            userInput = Console.ReadLine();

            Console.WriteLine("");

            if (userInput.Equals("y"))
            {
                userWantsToContinue = true;
            }
            else if (userInput.Equals("n"))
            {
                userWantsToContinue = false;
            }
            else
            {
                Console.WriteLine("\tInvalid input. Please enter: y or n");
                CheckUserWantsToContinue();
            }
        }

        private static void ExitApp()
        {
            Console.WriteLine("Thanks for visiting my dying little Blockbuster!");
            Console.WriteLine("Exiting application...");
            System.Environment.Exit(1);
        }

    }


}