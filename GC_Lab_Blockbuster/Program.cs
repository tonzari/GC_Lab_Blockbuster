
using System;
using System.Threading;

namespace GC_Lab_Blockbuster
{
    class Program
    {
        static void Main(string[] args)
        {
            
            PrintWelcomeMessage();

            do
            {
                AccessBlockBusterCatalog();
            } while (userWantsToContinue);

            ExitApp();
        }

        private static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to Antonio's Blockbuster!");
        }

        private static void ExitApp()
        {
            Console.WriteLine("Thanks for visiting my dying little Blockbuster!");
            Console.WriteLine("Exiting application...");
            System.Environment.Exit(1);
        }

    }


}