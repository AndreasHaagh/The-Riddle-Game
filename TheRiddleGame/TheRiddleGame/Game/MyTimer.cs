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

        public void StartTimer()
        {
            time = startTime;
            Console.WriteLine("timer has started with {0} seconds", time);
            Task timer = new Task(() =>
            {
                while (time >= 0)
                {
                    Thread.Sleep(1000);
                    if (time <= 0)
                    {
                        Game.runGame = false;
                        callback();
                    }
                    time = time - 1;
                }
            });
            timer.Start();
        }
    }
}
