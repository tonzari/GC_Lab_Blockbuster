using System;
using System.Collections.Generic;
using System.Text;

namespace GC_Lab_Blockbuster
{
    class BlockBuster
    {
        public List<Movie> Movies { get; set; }
        public int userNumber;
        public int availableOptions;
        public string userInput;

        public BlockBuster()
        {
            Movies = new List<Movie>();

            Movies.Add(new VHS("Super Mario Bros. The Movie", 104, Genre.Action, new List<string>() { "Mario discovers he has a brother named Luigi", "The two brothers grieve over losing their Italian traditions", "Mario buys a ticket to Italy to reconnect with his family", "Meanwhile, Luigi gets stuck in the NYC sewers and needs Mario's help", "Mario flies home and saves Luigi while bragging about how great Italy was" }));
            Movies.Add(new VHS("Beverly Hills Ninja", 120, Genre.Comedy, new List<string>() { "Chris Farley learns how to ninja", "Chris Rock shows up and says some funny stuff", "Bad ninjas do the bad stuff", "Chris Farley mistakes a man for a woman and it's so funny because it's like wait a second you have LONG hair!! THAT'S FOR GIRLS!", "Everything works out after Chris Farley uses a palm tree as a catapult" }));
            Movies.Add(new VHS("Footloose", 300, Genre.Drama, new List<string>() { "Well, David Spade dances so hard that his feet hurt", "David Spade goes to the doctor, and the prognosis is wobble-foot, where your feet get loose and might fall off", "David vows to never dance again, loose feet got no balance", "David's doctor quits the medical business and dances in David's place, the TOWN GOES WILD" }));
            Movies.Add(new DVD("Shrek", 120, Genre.Comedy, new List<string>() { "Swamp scene", "Deep Onion Scene", "Shrek save Anime" }));
            Movies.Add(new DVD("Dawn of the Dead", 150, Genre.Horror, new List<string>() { "Shopping mall scene", "Bikers show up", "Zombies overrun the mall", "Shrek Saves the day" }));
            Movies.Add(new DVD("Saving Private Ryan", 180, Genre.Action, new List<string>() { "D-Day", "Shrek takes a bullet to save Matt Damon", "Mortally wounded Shrek beats Hitler at Tic Tac Toe, winning the war" }));
        }

        public void PrintMovies()
        {
            for (int i = 0; i < Movies.Count; i++)
            {
                Console.WriteLine($"\t{i + 1}. {Movies[i].Title}");
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

        public Movie CheckOut()
        {
            PrintMovies();

            availableOptions = Movies.Count;

            Console.Write("Please select a movie you want to watch: ");

            userNumber = GetAndValidateUserNumber();

            Console.WriteLine(Environment.NewLine);

            return Movies[userNumber - 1];

        }

        public int GetAndValidateUserNumber()
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
    }
}
