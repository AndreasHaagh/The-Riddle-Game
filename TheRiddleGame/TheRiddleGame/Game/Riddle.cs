using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRiddleGame
{
    class Riddle
    {
        public string riddleString;
        public string answerString;

         /// <summary>
         /// Gets random riddle and it's answer from a collection of riddles in a file
         /// </summary>
         /// <param name="riddleFile">file with riddles</param>
        public void GetRiddle(string riddleFile)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), riddleFile);
            var file = File.ReadAllLines(path).ToList();

            int count = file.Count();
            Random rand = new Random();
            int skip = rand.Next(0, count);
            string line = file.Skip(skip).First();

            int riddleFrom = line.IndexOf("Riddle: ") + "Riddle: ".Length;
            int riddleTo = line.LastIndexOf("Answer: ");
            int answerFrom = line.IndexOf("Answer: ") + "Answer: ".Length;

            riddleString = line.Substring(riddleFrom, riddleTo - riddleFrom);
            answerString = line.Substring(answerFrom);
        }

        /// <summary>
        /// Check if the playes guess matchs the anwser to the current riddle
        /// </summary>
        /// <param name="guess">the player's input</param>
        /// <param name="riddleFile">file with riddles</param>
        /// <param name="score">the players score</param>
        /// <returns></returns>
        public int CheckGuess(string guess, string riddleFile, int score)
        {
            if (guess.ToLower() == answerString)
            {
                GetRiddle(riddleFile);
                return ++score;
            }
            else
            {
                return score;
            }
        }
    }
}
