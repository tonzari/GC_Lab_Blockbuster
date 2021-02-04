
using System;
using System.Threading;

namespace GC_Lab_Blockbuster
{
    class Program
    {
        public static string userInput;
        public static int userNumber;
        public static int availableOptions;
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

            blockBuster.PrintMovies();

            availableOptions = blockBuster.Movies.Count;

            Console.Write("Please select a movie you want to watch: ");

            userNumber = GetAndValidateUserNumber();

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine(blockBuster.Movies[userNumber - 1].ToString());

            Console.WriteLine("");

            Console.WriteLine("Do you want to watch the movie? Enter y or n: ");

            userInput = GetAndValidateYesOrNo();

            if (userInput.Equals("y"))
            {
                blockBuster.Movies[userNumber - 1].Play();
                if (blockBuster.Movies[userNumber - 1].Title == "Super Mario Bros. The Movie")
                {
                    MusicPlayer.PlaySuperMarioThemeSong();
                }
            }
            else if (userInput.Equals("n"))
            {
                return;
            }

            CheckUserWantsToContinue();
        }

        private static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to Antonio's Blockbuster!");
        }

        private static int GetAndValidateUserNumber()
        {
            // First checks if input is a number
            // Then checks if the number is within the current max range
            // The range updates each time a new menu is accessed. 

            userInput = Console.ReadLine();

            if (Int32.TryParse(userInput, out int result) && result >= 1 && result <= availableOptions)
            {
                return result;
            }
            else
            {
                Console.Write("Invalid input. Please Try again: ");
                Console.WriteLine("");
                return GetAndValidateUserNumber();
            }

        }

        private static string GetAndValidateYesOrNo()
        {
            userInput = Console.ReadLine();

            if (userInput.Equals("y"))
            {
                return "y";
            }
            else if (userInput.Equals("n"))
            {
                return "n";
            }
            else
            {
                Console.WriteLine("\tInvalid input. Please enter: y or n");
                return GetAndValidateYesOrNo();
            }
        }

        private static void CheckUserWantsToContinue()
        {
            // Prompt user to continue/quit
            Console.WriteLine(Environment.NewLine);

            Console.Write("Ok! Go back to the movie list? Enter y or n: ");

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
                Console.WriteLine("Invalid input. Please enter: y or n");
                CheckUserWantsToContinue();
            }
        }

        private static void ExitApp()
        {
            Console.WriteLine("Thanks for visiting my dying little Blockbuster! We had to borrow a few movies from Tommy's store due to budget constraints! Sorry!");
            Console.WriteLine("Exiting application...");
            System.Environment.Exit(1);
        }

    }


}