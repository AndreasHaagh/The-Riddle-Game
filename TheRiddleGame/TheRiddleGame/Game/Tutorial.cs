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
        private int controlTutorial;
        private string input;

        /// <summary>
        /// starts a tutorial with a random riddle from the EasyRiddle.txt. 
        /// </summary>
        public void StartTutorial()
        {
            controlTutorial = 0;
            GetRiddle(fileName);

            Console.WriteLine("The tutorial has started. Normaly there is a timer on, but since this is a tutorial the timer is then disable. \nSo take your time");
            Console.WriteLine("If you want to stop the tutorial type 'Stop tutorial'");
            Console.WriteLine("Try and see if you can guess the riddle \n");

            Console.WriteLine(riddle);
            while (controlTutorial <= 0)
            {
                input = Console.ReadLine();
                controlTutorial = CheckGuess(input, fileName, controlTutorial);

                if (input.ToLower() == "stop tutorial")
                {
                    controlTutorial = 2;
                }
            }

            //simple way to write if statement.
            Console.WriteLine(controlTutorial == 1 ? "You guess the corect answer and finish the tutorial hurray. \n" + "press enter to continue" : "You have ended the tutorial. press enter to continue");

            Console.ReadKey();
        }
    }
}
