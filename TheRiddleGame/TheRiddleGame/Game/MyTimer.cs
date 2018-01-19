using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TheRiddleGame
{
    public delegate void TimerDelegate();
    class MyTimer
    {
        public int startTime;
        private int time;
        TimerDelegate callback;

        public MyTimer(int startTime, TimerDelegate callback)
        {
            this.startTime = startTime;
            this.callback = callback;
        }

        /// <summary>
        /// Starts the timer. When it hits 0 it uses a callback to end the game
        /// </summary>
        public void StartTimer()
        {
            time = startTime;
            Console.WriteLine("The game has started you have {0} seconds to guess as many riddles as posible", time);

            //I'm using a lamda expression to create an anonymous function for the thread
            Task timer = new Task(() =>
            {
                while (time >= 0)
                {
                    Thread.Sleep(1000);
                    if ((time == startTime / 2) || (time == 15) || (time == 10) || (time == 5))
                    {
                        Console.WriteLine(" You have {0} seconds left", time);
                    }

                    if (time <= 0)
                    {
                        callback();
                    }
                    time = time - 1;
                }
            });
            timer.Start();
        }
    }
}
