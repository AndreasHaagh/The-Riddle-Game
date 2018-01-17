using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRiddleGame
{
    class Program
    {
        public static bool end = false;
        static void Main(string[] args)
        {
            string[] startOptions = new string[] { "Play", "High Score", "Settings", "Credits", "End" };
            StartMenu startMenu = new StartMenu(startOptions);
            while (end == false)
            {
                startMenu.Draw();
                startMenu.TakeInput();
            }
        }
    }
}
