using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRiddleGame
{
    class Settings : IMenu
    {
        private string[] settingsOptions = new string[] { "Difficulty", "Color", "Back" };

        public void Draw()
        {
            Console.Clear();
            for (int i = 0; i < settingsOptions.Length; i++)
            {
                Console.WriteLine("> " + settingsOptions[i]);
            }
        }

        public void TakeInput()
        {
            var input = Console.ReadLine();

            switch (input.ToLower())
            {
                case "difficulty":
                    Console.WriteLine("You can pick between 'Easy', 'Normal' or 'Hard'");
                    Console.WriteLine("please note that Normal is the defualt \n");
                    input = Console.ReadLine();
                    ChangeDifficulty(input);
                    break;
                case "color":
                    Console.WriteLine("Pick one of these colors 'Green', 'Red' or 'Yellow'. Leave it empty to change it back to 'White'");
                    input = Console.ReadLine();
                    ChangeColor(input);
                    break;
                case "back":
                    Console.WriteLine("Going back");
                    break;
            }
        }

        /// <summary>
        /// Changes the font color based on input from the player
        /// </summary>
        /// <param name="color">string input from the player</param>
        private void ChangeColor(string color)
        {
            switch (color.ToLower())
            {
                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "yellow":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        }

        /// <summary>
        /// Changes the difficulty of the gamne
        /// </summary>
        /// <param name="difficulty"></param>
        private void ChangeDifficulty(string difficulty)
        {
            string folder = "Riddle_text_files/";
            if (difficulty.ToLower() == "easy")
            {
                Game.fileName = folder + "EasyRiddles.txt";
                Game.time = 40;
            }
            else if (difficulty.ToLower() == "hard")
            {
                Game.fileName = folder + "HardRiddles.txt";
                Game.time = 80;
            }
            else
            {
                Game.fileName = folder + "NormalRiddles.txt";
                Game.time = 60;
            }
        }
    }
}
