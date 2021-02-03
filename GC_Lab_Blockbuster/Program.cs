
using System;
using System.Threading;

namespace GC_Lab_Blockbuster
{
    class Program
    {
        static void Main(string[] args)
        {
            int freq;
            Random rnd = new Random();
/*
            for (int i = 1; i < 10; i++)
            {
                //x = rnd.Next(200, 1800);
                freq = 200 * (i * 2);
                Console.Beep(freq, 70);
                Console.WriteLine(i);
            }

            for (int i = 1; i < 10; i++)
            {
                //x = rnd.Next(200, 1800);
                freq = 300 * (i * 2);
                Console.Beep(freq, 100);
                Console.WriteLine(i);
            }*/

            Music.PlaySuperMarioThemeSong();

        }


    }
}