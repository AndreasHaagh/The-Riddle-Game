using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRiddleGame
{
    class Tutorial : Riddle
    {
        private string fileName = "EasyRiddles.txt";
        private int score;
        private string input;
        public void StartTutorial()
        {
            score = 0;
            GetRiddle(fileName);
            Console.WriteLine("The turorial has started");
            while (score <= 0)
            {
                Console.WriteLine(riddleString);
                input = Console.ReadLine();
                score = CheckGuess(answerString, input, fileName, score);
                if (input.ToLower() == "end tutorial")
                {
                    score = 2;
                }
            }
            if (score == 1)
            {
                Console.WriteLine("You guess the corect answer and finish the tutorial hurray. \n" + "press enter to continue");
            }
            else
            {
                Console.WriteLine("You have ended the tutorial. press enter to continue");
            }
            Console.ReadKey();
        }
    }
}
