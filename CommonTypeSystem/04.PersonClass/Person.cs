namespace _04.PersonClass
{
    using System;

    public class Person
    {
        private string name;
        private int? age;

        public Person(string name):this(name,null)
        {

        }

        public Person(string name, int? age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name can't ne null or empty!");
                }

                if (value.Length < 2 || value.Length > 30)
                {
                    throw new ArgumentException("Name must be between 2 and 30 symbols!");
                }

                this.name = value;
            }
        }

        public int? Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value < 0 || value > 150)
                {
                    throw new ArgumentException("Age must be between 0 and 150!");
                }

                this.age = value;
            }
        }

        public override string ToString()
        {
            return String.Format("Name: {0}\nYears: {1}", this.Name, this.Age != null ? this.Age.ToString() : "Not specified yet!");
        }
    }
}
