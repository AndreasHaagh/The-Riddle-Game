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
            Game game = new Game();
            if (difficulty == "Easy")
            {
                game.fileName = "EasyRiddles.txt";
                game.time = 40;
            }
            else if (difficulty == "Hard")
            {
                game.fileName = "HardRiddles.txt";
                game.time = 80;
            }
            else
            {
                game.fileName = "NormalRiddles.txt";
                game.time = 60;
            }
        }
    }
}
