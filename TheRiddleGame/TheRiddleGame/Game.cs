using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRiddleGame
{
    class Game : Riddle
    {
        MyTimer timer = new MyTimer(40, TimeHandler);
        public static bool runGame;
        static string input;
        public void StartGame()
        {
            Console.WriteLine("The game has started. Start typing like it was your last day on earth!");
            timer.StartTimer();
            runGame = true;
            while(runGame)
            {
                input = Console.ReadLine();
            }
        }

        public static void TimeHandler()
        {
            Console.WriteLine("Time's up. press any key to continue");
            input = "";
            Console.ReadKey();
            runGame = false;
        }
    }
}
