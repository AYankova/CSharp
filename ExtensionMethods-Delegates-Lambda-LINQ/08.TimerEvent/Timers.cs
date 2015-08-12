namespace _08.TimerEvent
{
    using System;

    public class Timers
    {
        private int ticks;
        public int Duration { get; private set; }
        public int Number { get; private set; }

        public Timers(int number,Clock clock,int duration)
        {
            this.Number = number;
            clock.RaiseClockEvent += HandleClockEvent;
            this.Duration=duration;
        }

        private void HandleClockEvent(object sender,ClockEventArgs e)
        {
            ticks++;
            if (ticks==this.Duration)
            {
                ticks = 0;
                System.Console.WriteLine("Timer {0} say: Time is {1}", this.Number,e.GetTime);
            }

        }
    }
}
