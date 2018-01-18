using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TheRiddleGame
{
    class Game : Riddle
    {
        private static int score;
        private static string input;
        private static bool runGame;

        public static string fileName;
        public static int time;
        
        /// <summary>
        /// Starts the game and keep it runnning until the timer hits 0.
        /// If fileName is empty set normal difficulty
        /// </summary>
        public void StartGame()
        {
            if (fileName == null)
            {
                fileName = "Riddle_text_files/NormalRiddles.txt";
                time = 60;
            }

            MyTimer timer = new MyTimer(time, TimeHandler);

            score = 0;
            runGame = true;
            GetRiddle(fileName);
            timer.StartTimer();

            //To show the first  riddle
            Console.WriteLine(riddle);
            while (runGame)
            {
                input = Console.ReadLine();
                score = CheckGuess(input, fileName, score);
            }

            if (input.ToLower() == "save")
            {
                WriteHighScore();
            }
        }

        /// <summary>
        /// A handler that stops the game when the timer callback is called in the MyTimer class.
        /// </summary>
        public static void TimeHandler()
        {
            runGame = false;

            Console.WriteLine("Time's up. press enter to continue");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("Your score is {0}. Type 'Save' if you wanna save the score to high score, else press enter to continue", score);
        }

        /// <summary>
        /// Write the score to a text file for later to show the High score
        /// </summary>
        private static void WriteHighScore()
        {
            Console.Clear();
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();
            string savedScore = name + ": " + score + "\n";
            File.AppendAllText("HighScore.txt", savedScore);
        }
    }
}
