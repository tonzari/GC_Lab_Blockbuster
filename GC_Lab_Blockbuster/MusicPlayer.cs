using System;
using System.Threading;

namespace GC_Lab_Blockbuster
{
    public enum Note
    {
        C2 = 65, D2 = 73, E2 = 82, F2 = 87, G2 = 98, A2 = 110, B2 = 123, 
        C3 = 131, D3 = 147, E3 = 165, F3 = 175, G3 = 196, A3 = 220, B3 = 247, 
        C4 = 262, D4 = 294, E4 = 330, F4 = 349, G4 = 392, A4 = 440, B4 = 494, 
        C5 = 523, D5 = 587, E5 = 658, F5 = 698, G5 = 784, A5 = 880, B5 = 988, 
        C6 = 1047, D6 = 1175, E6 = 1319, F6 = 1397, G6 = 1568, A6 = 1760, B6 = 1976, 
        C7 = 2093, D7 = 2349, E7 = 2637, F7 = 2794, G7 = 3136, A7 = 3520, B7 = 3951, 
        C8 = 4186
    }

    public static class MusicPlayer
    {
        // Change the tempo by editing the wholeNote value
        // I've found that <= 1000 sounds unstable and loses its rythym
        // 1600 feels okay on my machine

        // Eventually I'd like to build this out to looke like this:
        // ConsoleBeepFun.PlaySound(Songs.SuperMarioTheme);
        // ConsoleBeepFun.PlaySound(Fx.Pause);

        public static int wholeNote = 1600;
        public static int halfNote = wholeNote / 2;
        public static int quarterNote = wholeNote / 4;
        public static int eighthNote = wholeNote / 8;


        // These functions will be a tad more readable, musically speaking.
        public static void PlayNote(Note musicalNote, int duration)
        {
            int note = (int)musicalNote;

            Console.Beep(note, duration);
        }

        public static void Rest(int duration)
        {
            Thread.Sleep(duration);
        }


        /// <summary>
        /// I found the super mario theme on reddit. I edited it A LOT. It had wrong notes and poor rhythm, and I refactored it to be easier to read, and made use of some primitive timing division variables.
        /// This song exists in my head since I memorized how to play it on the piano many years ago, so it was not too much trouble to fix, thankfully!
        /// I plan to swap out the Console methods for my custom methods some other time.
        /// </summary>
        public static void PlaySuperMarioThemeSong()
        {
            Intro();
            PhraseA();
            PhraseA();
            PhraseBa();
            PhraseBb();

            static void Intro()
            {
                Console.Beep(659, eighthNote); Console.Beep(659, eighthNote); Thread.Sleep(eighthNote); Console.Beep(659, eighthNote);
                Thread.Sleep(eighthNote); Console.Beep(523, eighthNote); Console.Beep(659, eighthNote); Thread.Sleep(eighthNote); 
                Console.Beep(784, eighthNote); Thread.Sleep(quarterNote + eighthNote); 
                Console.Beep(392, eighthNote); Thread.Sleep(quarterNote + eighthNote);
            }

            static void PhraseA()
            {
                Console.Beep(523, eighthNote); Thread.Sleep(quarterNote); Console.Beep(392, eighthNote); 
                Thread.Sleep(quarterNote); Console.Beep(330, eighthNote); Thread.Sleep(eighthNote);
                Thread.Sleep(eighthNote); Console.Beep(440, eighthNote); Thread.Sleep(eighthNote); Console.Beep(494, eighthNote); 
                Thread.Sleep(eighthNote); Console.Beep(466, eighthNote); Console.Beep(440, eighthNote); Thread.Sleep(eighthNote);

                
                Console.Beep(392, eighthNote); Console.Beep(659, eighthNote); Thread.Sleep(eighthNote); Console.Beep(784, eighthNote); 
                Console.Beep(880, eighthNote); Thread.Sleep(eighthNote); Console.Beep(698, eighthNote); Console.Beep(784, eighthNote); 
                Thread.Sleep(eighthNote); Console.Beep(659, eighthNote); Thread.Sleep(eighthNote); Console.Beep(523, eighthNote); 
                Console.Beep(587, eighthNote); Console.Beep(494, eighthNote); Thread.Sleep(eighthNote); Thread.Sleep(eighthNote);
            }

            static void PhraseBa()
            {
                Thread.Sleep(quarterNote); Console.Beep(784, eighthNote); Console.Beep(740, eighthNote); 
                Console.Beep(698, eighthNote); Console.Beep(622, eighthNote); Thread.Sleep(eighthNote); Console.Beep(659, eighthNote);
                
                Thread.Sleep(eighthNote); Console.Beep(415, eighthNote); Console.Beep(440, eighthNote); Console.Beep(523, eighthNote); 
                Thread.Sleep(eighthNote); Console.Beep(440, eighthNote); Console.Beep(523, eighthNote); Console.Beep(587, eighthNote); 
                
                Thread.Sleep(quarterNote); Console.Beep(784, eighthNote); Console.Beep(740, eighthNote); 
                Console.Beep(698, eighthNote); Console.Beep(622, eighthNote); Thread.Sleep(eighthNote); Console.Beep(659, eighthNote); 
                Thread.Sleep(eighthNote); Console.Beep(1046, eighthNote); Thread.Sleep(eighthNote); Console.Beep(1046, eighthNote); 
                Console.Beep(1046, eighthNote); Thread.Sleep(halfNote + quarterNote);
            }

            static void PhraseBb()
            {
                Console.Beep(784, eighthNote); Console.Beep(740, eighthNote); Console.Beep(698, eighthNote); Thread.Sleep(42); Console.Beep(622, eighthNote); Thread.Sleep(eighthNote); Console.Beep(659, eighthNote); Thread.Sleep(167); Console.Beep(415, eighthNote); Console.Beep(440, eighthNote); Console.Beep(523, eighthNote); Thread.Sleep(eighthNote); Console.Beep(440, eighthNote); Console.Beep(523, eighthNote); Console.Beep(587, eighthNote); Thread.Sleep(500);
                Console.Beep(622, eighthNote); Thread.Sleep(quarterNote); Console.Beep(587, eighthNote); Thread.Sleep(quarterNote); Console.Beep(523, eighthNote); Thread.Sleep(1125);
            }
        }

        public static void PlayTetrisThemeSong()
        {
            Console.Beep(658, eighthNote); Console.Beep(1320, 500); Console.Beep(990, quarterNote); Console.Beep(1056, quarterNote); Console.Beep(1188, quarterNote); Console.Beep(1320, eighthNote); Console.Beep(1188, eighthNote); Console.Beep(1056, quarterNote); Console.Beep(990, quarterNote); Console.Beep(880, 500); Console.Beep(880, quarterNote); Console.Beep(1056, quarterNote); Console.Beep(1320, 500); Console.Beep(1188, quarterNote); Console.Beep(1056, quarterNote); Console.Beep(990, 750); Console.Beep(1056, quarterNote); Console.Beep(1188, 500); Console.Beep(1320, 500); Console.Beep(1056, 500); Console.Beep(880, 500); Console.Beep(880, 500); Thread.Sleep(quarterNote); Console.Beep(1188, 500); Console.Beep(1408, quarterNote); Console.Beep(1760, 500); Console.Beep(1584, quarterNote); Console.Beep(1408, quarterNote); Console.Beep(1320, 750); Console.Beep(1056, quarterNote); Console.Beep(1320, 500); Console.Beep(1188, quarterNote); Console.Beep(1056, quarterNote); Console.Beep(990, 500); Console.Beep(990, quarterNote); Console.Beep(1056, quarterNote); Console.Beep(1188, 500); Console.Beep(1320, 500); Console.Beep(1056, 500); Console.Beep(880, 500); Console.Beep(880, 500); Thread.Sleep(500); Console.Beep(1320, 500); Console.Beep(990, quarterNote); Console.Beep(1056, quarterNote); Console.Beep(1188, quarterNote); Console.Beep(1320, eighthNote); Console.Beep(1188, eighthNote); Console.Beep(1056, quarterNote); Console.Beep(990, quarterNote); Console.Beep(880, 500); Console.Beep(880, quarterNote); Console.Beep(1056, quarterNote); Console.Beep(1320, 500); Console.Beep(1188, quarterNote); Console.Beep(1056, quarterNote); Console.Beep(990, 750); Console.Beep(1056, quarterNote); Console.Beep(1188, 500); Console.Beep(1320, 500); Console.Beep(1056, 500); Console.Beep(880, 500); Console.Beep(880, 500); Thread.Sleep(quarterNote); Console.Beep(1188, 500); Console.Beep(1408, quarterNote); Console.Beep(1760, 500); Console.Beep(1584, quarterNote); Console.Beep(1408, quarterNote); Console.Beep(1320, 750); Console.Beep(1056, quarterNote); Console.Beep(1320, 500); Console.Beep(1188, quarterNote); Console.Beep(1056, quarterNote); Console.Beep(990, 500); Console.Beep(990, quarterNote); Console.Beep(1056, quarterNote); Console.Beep(1188, 500); Console.Beep(1320, 500); Console.Beep(1056, 500); Console.Beep(880, 500); Console.Beep(880, 500); Thread.Sleep(500); Console.Beep(660, 1000); Console.Beep(528, 1000); Console.Beep(594, 1000); Console.Beep(495, 1000); Console.Beep(528, 1000); Console.Beep(440, 1000); Console.Beep(419, 1000); Console.Beep(495, 1000); Console.Beep(660, 1000); Console.Beep(528, 1000); Console.Beep(594, 1000); Console.Beep(495, 1000); Console.Beep(528, 500); Console.Beep(660, 500); Console.Beep(880, 1000); Console.Beep(838, 2000); Console.Beep(660, 1000); Console.Beep(528, 1000); Console.Beep(594, 1000); Console.Beep(495, 1000); Console.Beep(528, 1000); Console.Beep(440, 1000); Console.Beep(419, 1000); Console.Beep(495, 1000); Console.Beep(660, 1000); Console.Beep(528, 1000); Console.Beep(594, 1000); Console.Beep(495, 1000); Console.Beep(528, 500); Console.Beep(660, 500); Console.Beep(880, 1000); Console.Beep(838, 2000);
        }
    }
}
