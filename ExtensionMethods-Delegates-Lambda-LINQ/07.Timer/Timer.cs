namespace Timer
{
    using System;
    using System.Threading;
    
    public class Timer
    {
        public delegate void TimerEvent();
        private int duration;
        private byte ticks;
        public TimerEvent timerEvent{get;set;}

        public Timer(int seconds, byte ticks=byte.MaxValue)
        {
            this.Duration = seconds;
            this.Ticks = ticks;
        }

        public int Duration
        {
            get
            {
                return this.duration;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }

                this.duration = value*1000;
            }
        }

        public byte Ticks
        {
            get
            {
                return this.ticks;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }

                this.ticks = value;
            }
        }

        public void Run()
        {
            while (ticks>0)
            {
                timerEvent();
                Thread.Sleep(this.Duration);
                --ticks;
            }
        }
    }
}
