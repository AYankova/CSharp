namespace MobilePhone
{
    using System;

    public class Display
    {
        //Fields
        private double? size;
        private int? numberOfColours;

        //Constructor
        public Display(double? size = null, int? numberOfColours = null)
        {
            this.Size = size;
            this.NumberOfColours = numberOfColours;
        }

        //Properties
        public double?Size
        {
            get  
            {  
                return this.size;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Size cannot be a negative number!");
                }
                else
                {
                    this.size = value;
                }
            }
        }  

        public int? NumberOfColours
        {
            get 
            {
                return this.numberOfColours; 
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Number of colours cannot be a negative number!");
                }
                else
                {
                    this.numberOfColours = value;
                }
            }
        }

        public override string ToString()
        {
            return string.Format("Size: {0} \nNumberOfColours: {1}", this.Size == null ? "Unkown" : this.Size.ToString(), this.NumberOfColours == null ? "Unknown" : this.NumberOfColours.ToString());
        }
    }
}
