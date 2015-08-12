namespace _08.TimerEvent
{
    using System;
    using System.Timers;

    public class Clock
    {
        public event EventHandler<ClockEventArgs> RaiseClockEvent;
        private Timer timer = new Timer();

        public void Run()
        {
            this.timer.Interval = 1000;
            this.timer.Elapsed += new ElapsedEventHandler(TimerEventIsRaised);
            this.timer.Start();
        }

        private void TimerEventIsRaised(object source, ElapsedEventArgs e)
        {
            EventHandler<ClockEventArgs> handler = RaiseClockEvent;
            if (handler != null)
                handler(this, new ClockEventArgs(e.SignalTime.TimeOfDay));
        }
    }
}
