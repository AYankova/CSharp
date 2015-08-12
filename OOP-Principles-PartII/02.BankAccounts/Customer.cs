namespace _02.BankAccounts
{
    using System;
using System.Text.RegularExpressions;

    public abstract class Customer
    {
        private string name;
        private CustomerType customerType;
        private string address;
        private string phoneNumber;

        protected Customer(string name, string address, string phoneNumber)
        {
            this.Name = name;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Customer name çan't be null or empty!");
                }

                this.name = value;
            }
        }

        public CustomerType CustomerType
        {
            get { return this.customerType; }
            protected set { this.customerType = value; }
        }

        public string Address
        {
            get { return this.address; }
            private set { this.address = value; }
        }

        public string PhoneNumber
        {
            get 
            { 
                return this.phoneNumber;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Tel name can not be null or empty !");
                }

                if (value !="Not available" && !Regex.IsMatch(value, @"(\+359[0-9]{9})") && !Regex.IsMatch(value, @"(0[0-9]{9})"))
                {
                    throw new ApplicationException("Telephones begin with +359 / 0 followed by 9 digits !");
                }

                this.phoneNumber = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Customer name: {0,-15} \nCustomer Type: {1,-10} \nAdress: {2} \nPhone number: {3}", this.Name,this.CustomerType, this.Address, this.PhoneNumber);
        }
    }
}
