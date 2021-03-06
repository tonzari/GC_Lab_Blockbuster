﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GC_Lab_Blockbuster
{
    class DVD : Movie
    {
        public DVD(string Title, int RunTime, Genre Catergory, List<string> Scenes) : base(Title, RunTime, Catergory, Scenes)
        {
            this.Title = Title;
            this.RunTime = RunTime;
            this.Catergory = Catergory;
            this.Scenes = Scenes;
        }

        public override void Play()
        {
            Console.WriteLine("Now Playing: " + Title);
            Console.WriteLine("Select a scene to watch: ");

            Console.WriteLine(PrintScenes());

            string userInput = Console.ReadLine();

            int userChoice = int.Parse(userInput);

            Console.WriteLine($"Scene: {userChoice}");
            Console.WriteLine(Scenes[userChoice]);

        }
    }
}
