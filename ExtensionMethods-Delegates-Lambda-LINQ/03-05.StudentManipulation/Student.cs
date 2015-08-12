namespace StudentManipulation
{
    using System;
    using System.Linq;

    public class Student
    {
        private string firstName;
        private string lastName;
        private int age;

        public Student(string firstName, string lastName, int age)
        {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
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
        public int Age
        {
            get
            {
                return this.age;
            }

            private set
            {
                if (value < 0 || value > 150)
                {
                    throw new ArgumentException("Incorrect parameter age!");
                }

                this.age = value;
            }
        }

        public override string ToString()
        {
            return string.Format("First name: {0,10}   Last name: {1,11}   Age: {2,3}", this.FirstName, this.LastName, this.Age);
        }
    }
}
