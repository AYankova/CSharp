namespace MobilePhone
{
    using System;

    public class Call
    {
        //Fields
        private DateTime callDate;
        private int duration;
        private string dialledPhoneNumber;

        //Constructor
        public Call(DateTime callDate, string dialedPhoneNumber, int duration)
        {
            this.CallDate = callDate;
            this.DialledPhoneNumber = dialedPhoneNumber;
            this.Duration = duration;
        }

        //Properties
        public DateTime CallDate
        {
            get 
            { 
                return this.callDate;
            }

            private set
            {
                if (value > DateTime.Now)
                {
                    throw new ArgumentException("Invalid Time!");
                }
                else
                {
                    this.callDate = value;
                }
            }
        }

        public string DialledPhoneNumber
        {
            get 
            {
                return this.dialledPhoneNumber;
            }

            private set
            {
                ulong temp;
                if (ulong.TryParse(value, out temp))
                {
                    this.dialledPhoneNumber = value;
                }
                else
                {
                    throw new ArgumentException("Invalid phone number!");
                }
            }
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
                    throw new ArgumentException("Duration cannot be a negative number!");
                }
                else
                {
                    this.duration = value;
                }
            }
        }

        public override string ToString()
        {
            return string.Format("Date and time: {0:G} Dialled number: {1} Duration: {2}", this.CallDate, this.DialledPhoneNumber, this.Duration);
        } 
    }
}
