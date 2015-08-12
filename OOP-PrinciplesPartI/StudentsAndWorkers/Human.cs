namespace StudentsAndWorkers
{
    using System;

    public abstract class Human
    {
        private string firstName;
        private string lastName;

        protected Human(string firstName,string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First name can't be null or empty!");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Last name can't be null or empty!");
                }

                this.lastName = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Name: {0} {1}", this.FirstName,this.LastName);
        }
    }
}
