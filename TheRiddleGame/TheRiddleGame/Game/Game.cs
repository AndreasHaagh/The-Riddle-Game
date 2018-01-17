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
        public static bool runGame;
        static string input;
        public string fileName = "NormalRiddles.txt";
        public static int score;
        public int time = 10;
        
        public void StartGame()
        {
            MyTimer timer = new MyTimer(time, TimeHandler);

            score = 0;
            runGame = true;
            GetRiddle(fileName);
            timer.StartTimer();
            Console.WriteLine("The game has started. Start typing like it was your last day on earth!");
            while (runGame)
            {
                Console.WriteLine(riddleString);
                input = Console.ReadLine();
                score = CheckGuess(answerString, input, fileName, score);
                Console.Clear();
            }
            
        }

        public static void TimeHandler() //virker ikke helt som det skal
        {
            Console.Clear();
            Console.WriteLine("Time's up. your score is {0}. Type 'Save' if you wanna save the score to high score, else press enter to continue", score);
            input = Console.ReadLine();
            if (input.ToLower() == "save")
            {
                Console.WriteLine("Please enter your name");
                string name = Console.ReadLine();
                string savedScore = name + ": " + score;
                StreamWriter sw = new StreamWriter("HighScore.txt", true);
                sw.Write(savedScore);
                Console.ReadKey();
            }
        }
    }
}
