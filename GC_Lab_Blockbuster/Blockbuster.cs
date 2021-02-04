using System;
using System.Collections.Generic;
using System.Text;

namespace GC_Lab_Blockbuster
{
    class BlockBuster
    {
        public List<Movie> Movies { get; set; }

        public BlockBuster()
        {
            Movies = new List<Movie>();
            Movie m = new DVD("Shrek", 120, Genre.Comedy,
                new List<string>() { "Swamp scene", "Deep Onion Scene", "Shrek save Anime" });
            Movie m1 = new DVD("Dawn of the Dead", 150, Genre.Horror,
                new List<string>() { "Shopping mall scene", "Bikers show up", "Zombies overrun the mall", "Shrek Saves the day" });
            Movie m2 = new DVD("Saving Private Ryan", 180, Genre.Action,
                new List<string>() { "D-Day", "Shrek takes a bullet to save Matt Damon", "Mortally wounded Shrek beats Hitler at Tic Tac Toe, winning the war" });
            Movies.Add(m);
            Movies.Add(m1);
            Movies.Add(m2);
        }

        public void DisplayMovies()
        {
            //Print all our movies
            foreach (Movie m in Movies)
            {
                //Console write line may only take in a string 
                //But all objects may be convert into a string 
                //ToString gets called automatically any time I try 
                //to try and treat something as a string 
                Console.WriteLine(m);
            }
        }

        public void DisplayByGenre(Genre search)
        {
            foreach (Movie m in Movies)
            {
                if (m.Catergory == search)
                {
                    Console.WriteLine(m);
                }
            }
        }

        public void SearchByIndex(int index)
        {
            string[] genreNames = Enum.GetNames(typeof(Genre));
            string name = genreNames[index];
            Console.WriteLine(name);
        }

        public Movie GetMovie(int index)
        {
            return Movies[index];
        }
    }
}
