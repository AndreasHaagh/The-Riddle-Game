using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRiddleGame
{
    class StartMenu : IMenu
    {
        private string[] options = new string[] { };

        public StartMenu(string[] options)
        {
            this.options = options;
        }

        public void Draw()
        {
            Console.Clear();
            Console.WriteLine("Type any of these commands below");
            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine("> " + options[i]);
            }
        }

        public void TakeInput()
        {
            var input = Console.ReadLine();

            switch (input.ToLower())
            {
                case "play":
                    Game game = new Game();
                    Console.Clear();
                    game.StartGame();
                    break;
                case "high score":
                    break;
                case "settings":
                    Settings settings = new Settings();
                    settings.Draw();
                    settings.TakeInput();
                    break;
                case "credits":
                    break;
                case "end":
                    Program.end = true;
                    break;
                default:
                    break;
            }
        }
    }
}
