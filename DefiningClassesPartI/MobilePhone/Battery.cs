namespace MobilePhone
{
    using System;

    public class Battery
    {
        //Fields
        private BatteryType model;
        private double? hoursTalk;
        private double? hoursIdle;

        //Constructors
        public Battery()
            : this(BatteryType.LiIon, null, null)
        {
        }

        public Battery(BatteryType model, double? hoursTalk, double? hoursIdle)
        {
            this.Model = model;
            this.HoursTalk = hoursTalk;
            this.HoursIdle = hoursIdle;
        }

        //enums
        public enum BatteryType 
        {
         LiIon,
         NiMH,
         NiCD
        }

        //Properties
        public BatteryType Model
        {
            get { return this.model; }
            private set { this.model = value; }
        }

        public double? HoursTalk
        {
            get 
            { 
                return this.hoursTalk; 
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid battery property-talk hours cannot be negative!");
                }
                else
                {
                    this.hoursTalk = value;
                }
            }
        }

        public double?HoursIdle
        {
            get 
            { 
                return this.hoursIdle;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid battery property-idle hours cannot be negative!");
                }
                else
                {
                    this.hoursIdle = value;
                }
            }
        }

        public override string ToString()
        {
            return string.Format("Model: {0} \nHours talk: {1} \nHours idle: {2}", this.Model, this.HoursTalk == null ? "Unknown" : this.HoursTalk.ToString(), this.HoursIdle == null ? "Unknown" : this.HoursIdle.ToString());
        }
    }
}
