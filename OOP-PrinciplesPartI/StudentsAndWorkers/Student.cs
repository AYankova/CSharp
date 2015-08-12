namespace StudentsAndWorkers
{
    using System;

    public class Student:Human
    {
        private double grade;

        public Student(string firstName, string lastName, double grade):base(firstName,lastName)
        {
            this.Grade = grade;
        }

        public double Grade
        {
            get
            {
                return this.grade;
            }

            private set
            {
                if (value < 2 || value > 6)
                {
                    throw new ArgumentOutOfRangeException("Invalid grade!Possible values are between 2 and 6 exclusive!");
                }

                this.grade=value;
            }
        }

        public override string ToString()
        {
            return string.Format("Name: {0,-10} {1,-10} Grade: {2:F2}",this.FirstName,this.LastName,this.Grade);
        }
    }
}
