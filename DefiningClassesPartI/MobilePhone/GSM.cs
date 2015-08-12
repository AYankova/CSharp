namespace MobilePhone
{
    using System;
    using System.Collections.Generic;

    public class GSM
    {
        //Fields
        private static readonly GSM iPhone4S = new GSM("IPhone 4S", "Apple", 1500M, "Peter Petrov", new Battery(Battery.BatteryType.LiIon, 20, 200), new Display(5.5, 16000000));
        private string model;           
        private string manufacturer;    
        private decimal? price;        
        private string owner;          
        private Battery battery;        
        private Display display;
        private List<Call> callHistory = new List<Call>();

        //Constructors
        //Initialize the mandatory fields,setring others to some default values
        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
        }

        //Full constructor
        public GSM(string model, string manufacturer, decimal? price = null, string owner = null, Battery battery = null, Display display = null)
            : this(model, manufacturer)
        {
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
        }

        //Properties
        public static GSM IPhone4S
        {
            get { return iPhone4S; }
        }

        public string Manufacturer
        {
            get
            {
                if (String.IsNullOrEmpty(this.manufacturer))
                {
                    throw new NullReferenceException();
                }

                return this.manufacturer;
            }

            private set
            {
                this.manufacturer = value;
            }
        }

        public string Model
        {
            get
            {
                if (String.IsNullOrEmpty(this.model))
                {
                    throw new NullReferenceException();
                }

                return this.model;
            }

            private set
            {
                this.model = value;
            }
        }

        public decimal?Price
        {
            get
            {
                return this.price; 
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price cannot ne a negative number!");
                }

                this.price = value;
            }
        }

        public string Owner
        {
            get 
            { 
                return this.owner;
            }

            private set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Owner cannot be an empty field!");
                }

                this.owner = value;
            }
        }

        public Battery Battery
        {
            get { return this.battery; }
            private set { this.battery = value; }
        }

        public Display Display
        {
            get { return this.display; }
            private set { this.display = value; }
        }

        public List<Call> CallHistory
        {
            get { return this.callHistory; }
            private set { this.callHistory = value; }
        }

        //Methods
        public List<Call> AddCalls(Call call)
        {
            this.CallHistory.Add(call);
            return this.CallHistory;
        }

        public List<Call> DeleteCalls(Call call)
        {
            this.CallHistory.Remove(call);
            return this.CallHistory;
        }

        public List<Call> ClearCallHistory()
        {
            this.CallHistory.Clear();
            return this.CallHistory;
        }

        public decimal CalculateTotalCallsPrice(decimal price)
        {
            int totalDuration = 0;

            for (int i = 0; i < this.callHistory.Count; i++)
            {
                totalDuration += this.CallHistory[i].Duration;
            }

            decimal totalPrice = totalDuration * price;

            return totalPrice;
        }

        public string PrintCallHistory()
        {
            return string.Format("Calls history:\n{0}", string.Join(Environment.NewLine, this.callHistory));
        }

        public override string ToString()
        {
            return string.Format("Model: {0}\nManufacturer: {1}\nPrice: {2}\nOwner: {3}\nBattery: {4}\nDisplay: {5}", this.Model, this.Manufacturer, this.Price == null ? "Unknown" : this.Price.ToString(), this.Owner == null ?  "Unknown" : this.Owner.ToString(), this.Battery == null ? "Unknown" : this.Battery.ToString(), this.Display == null ? "Unknown" : this.Display.ToString());
        }
    }
}
