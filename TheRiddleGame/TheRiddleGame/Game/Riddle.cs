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

        public string GetRiddle(string fileName)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), fileName);
            var file = File.ReadAllLines(path).ToList();

            int count = file.Count();
            Random rand = new Random();
            int skip = rand.Next(0, count);
            string line = file.Skip(skip).First();

            int rFrom = line.IndexOf("Riddle: ") + "Riddle: ".Length;
            int rto = line.LastIndexOf("Answer: ");
            int aFrom = line.IndexOf("Answer: ") + "Answer: ".Length;

            riddleString = line.Substring(rFrom, rto - rFrom);
            answerString = line.Substring(aFrom);

            return "";
        }

        public int CheckGuess(string anwser, string guess, string file, int score)
        {
            if (guess.ToLower() == answerString)
            {
                GetRiddle(file);
                return ++score;
            }
            else
            {
                return score;
            }
        }
    }
}
