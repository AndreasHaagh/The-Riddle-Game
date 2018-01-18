using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRiddleGame
{
    class Game : Riddle
    {
        private static int score;
        private static string input;
        private static bool runGame;

        //These variables are set to follow the normal difficulty, but it can be change the settings.
        public string fileName = "NormalRiddles.txt";
        public int time = 60;
        
        /// <summary>
        /// Starts the game and keep it runnning until the timer hits 0
        /// </summary>
        public void StartGame()
        {
            MyTimer timer = new MyTimer(time, TimeHandler);

            score = 0;
            runGame = true;
            GetRiddle(fileName);
            timer.StartTimer();

            while (runGame)
            {
                Console.WriteLine(riddleString);
                input = Console.ReadLine();
                score = CheckGuess(input, fileName, score);
                Console.Clear();
            }

            if (input.ToLower() == "save")
            {
                WriteHighScore();
            }
        }

        /// <summary>
        /// A handler that stops the game when the timer callback is called in the MyTimer class
        /// </summary>
        public static void TimeHandler()
        {
            runGame = false;
            Console.Clear();
            Console.WriteLine("Time's up. your score is {0}. Type 'Save' if you wanna save the score to high score, else press enter to continue", score);
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
