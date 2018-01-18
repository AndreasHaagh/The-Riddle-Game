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
            StartMenu startMenu = new StartMenu();
            while (end == false)
            {
                startMenu.Draw();
                startMenu.TakeInput();
            }
        }
    }
}
