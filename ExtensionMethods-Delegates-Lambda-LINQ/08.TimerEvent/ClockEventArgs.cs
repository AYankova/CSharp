namespace _08.TimerEvent
{
    using System;

    public class ClockEventArgs:EventArgs
    {
        public TimeSpan Span { get; private set; }

        public ClockEventArgs(TimeSpan ts)
        {
            this.Span = ts;
        }

        public TimeSpan GetTime
        {
            get
            {
                return this.Span;
            }

            private set
            {
                this.Span=value;
            }
        }
    }
}
