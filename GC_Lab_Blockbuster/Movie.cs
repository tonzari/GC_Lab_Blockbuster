using System;
using System.Collections.Generic;
using System.Text;

namespace GC_Lab_Blockbuster
{
    public enum Genre
    {
        Drama,
        Comedy,
        Horror,
        Romance,
        Action
    }
    abstract class Movie
    {
        public string Title { get; set; }
        public int RunTime { get; set; }
        public Genre Catergory { get; set; }
        public List<string> Scenes { get; set; }

        public Movie(string Title, int RunTime, Genre Catergory, List<string> Scenes)
        {
            this.Title = Title;
            this.RunTime = RunTime;
            this.Catergory = Catergory;
            this.Scenes = Scenes;
        }

        public override string ToString()
        {
            string output = "";
            output += $"Title: {Title}\n";
            output += $"Run Time: {RunTime} Minutes\n";
            output += $"Genre: {Catergory}\n";
            return output;
        }

        public string PrintScenes()
        {
            string output = "";

            for (int i = 0; i < Scenes.Count; i++)
            {
                output += i + ". " + Scenes[i] + "\n";
            }

            return output;
        }

        public abstract void Play();
    }
}