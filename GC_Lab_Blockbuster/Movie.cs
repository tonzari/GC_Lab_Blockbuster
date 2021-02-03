using System;
using System.Collections.Generic;
using System.Text;

namespace GC_Lab_Blockbuster
{
    public enum Genre
    {
        Comedy,
        Horror,
        Romance,
        Kids,
        Action,
        Arthouse,
        Indie,
        Adventure,
        Propaganda,
        Animation
    }
    abstract class Movie
    {
        public string Title { get; set; }
        public int RunTime { get; set; }
        public Genre Genre { get; set; }

        public List<string> Scenes { get; set; }

        public Movie(string Title, int RunTime, Genre Genre, List<string> Scenes)
        {
            this.Title = Title;
            this.RunTime = RunTime;
            this.Genre = Genre;

            this.Scenes = Scenes;
        }

        public override string ToString()
        {
            string output = "";
            output += $"Title: {Title}\n";
            output += $"Run Time: {RunTime} Minutes\n";
            output += $"Genre: {Genre}\n";
            return output;
        }

        public abstract void Play();
    }
}