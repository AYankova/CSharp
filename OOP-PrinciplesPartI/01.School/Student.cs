namespace _01.School
{
    using System;
    using System.Collections.Generic;

    public class Student:People
    {
        private int classNumber;

        public Student(string name, int classNumber):base(name)
        {
            this.ClassNumber = classNumber;
        }

        public int ClassNumber
        {
            get
            {
                return this.classNumber;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Student's class number can't be negative!");
                }

                this.classNumber = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Name: {0}, Number in class: {1}",this.Name, this.ClassNumber);
        }

    }
}
