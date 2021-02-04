
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

            Movie currentMovie = blockBuster.CheckOut();
         
            Console.WriteLine(currentMovie.ToString());

            Console.WriteLine("");

            Console.WriteLine("Do you want to watch the movie? Enter y or n: ");

            userInput = GetAndValidateYesOrNo();

            if (userInput.Equals("y"))
            {
               currentMovie.Play();
                if (currentMovie.Title == "Super Mario Bros. The Movie")
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



        public static string GetAndValidateYesOrNo()
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