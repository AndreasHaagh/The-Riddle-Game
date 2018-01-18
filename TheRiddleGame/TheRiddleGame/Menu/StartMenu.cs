using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRiddleGame
{
    class StartMenu : IMenu
    {
        private string[] startOptions = new string[] { "Play", "Tutorial", "High Score", "Settings", "Credits", "End" };

        public void Draw()
        {
            Console.Clear();
            Console.WriteLine("Type any of these commands below");
            for (int i = 0; i < startOptions.Length; i++)
            {
                Console.WriteLine("> " + startOptions[i]);
            }
        }

        public void TakeInput()
        {
            var input = Console.ReadLine();

            switch (input.ToLower())
            {
                case "play":
                    Console.Clear();
                    Game game = new Game();
                    game.StartGame();
                    break;
                case "tutorial":
                    Console.Clear();
                    Tutorial tutorial = new Tutorial();
                    tutorial.StartTutorial();
                    break;
                case "high score":
                    ShowHighScore();
                    break;
                case "settings":
                    Settings settings = new Settings();
                    settings.Draw();
                    settings.TakeInput();
                    break;
                case "credits":
                    Console.Clear();
                    Console.WriteLine("Made by Andreas Flyvholm Haagh \n" + "press any key to get back the menu");
                    Console.ReadKey();
                    break;
                case "end":
                    Program.end = true;
                    break;
            }
        }

        /// <summary>
        /// If the HighScore exists store all line in an array.
        /// Then sort it after descending by spliting each string in the array, 
        /// using the second half of the string and parse it to int(the score)
        /// </summary>
        private void ShowHighScore()
        {
            if (File.Exists("HighScore.txt"))
            {
                Console.Clear();
                Console.WriteLine("High score \n \n" + "Name: Score \n");
                string[] nameScore = File.ReadAllLines("HighScore.txt").ToArray();
                var orderedScore = nameScore.OrderByDescending(x => int.Parse(x.Split(':')[1]));

                foreach (string score in orderedScore)
                {
                    Console.WriteLine(score);
                }
            }
            else
            {
                Console.WriteLine("No scores registered");
            }
            
            Console.WriteLine("Press enter to continue");
            Console.ReadKey();
        }
    }
}
