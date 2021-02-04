using System;
using System.Collections.Generic;
using System.Text;

namespace GC_Lab_Blockbuster
{
    class VHS : Movie
    {
        private int currentTime;
        public int CurrentTime { get => currentTime; set => currentTime = value; }

        public VHS(string Title, int RunTime, Genre Catergory, List<string> Scenes) : base(Title, RunTime, Catergory, Scenes)
        {
            this.Title = Title;
            this.RunTime = RunTime;
            this.Catergory = Catergory;
            this.Scenes = Scenes;
            CurrentTime = 0;
        }

        public override void Play()
        {
            Console.WriteLine(Scenes[currentTime]);
        }

        public void Rewind()
        {
            CurrentTime = 0;
        }
    }
}
