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
            Task timer = new Task(() =>
            {
                time = startTime;
                Console.WriteLine("timer has started with {0} seconds", time);
                while (time >= 0)
                {
                    Thread.Sleep(1000);
                    if (time == startTime / 2)
                    {
                        Console.WriteLine("The time is halfed used. You have {0} left", time);
                    }
                    else if (time == 15 || time == 10 || time == 5)
                    {
                        Console.WriteLine(time + " seconds left");
                    }
                    else if (time <= 0)
                    {
                        callback();
                    }
                    time = time - 1;
                }
            });
            timer.Start();
            //callback();
        }
    }
}
