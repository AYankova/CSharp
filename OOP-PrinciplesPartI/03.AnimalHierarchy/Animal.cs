namespace _03.AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public abstract class Animal:ISound
    {
        private string name;
        private int age;
        private Gender sex;

        public Animal(string name, int age, Gender sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
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
                    throw new ArgumentException("Name can't be null or empty!");
                }

                this.name = value;
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
                    throw new ArgumentException("Age is in the range 0 to 150 exclusively!");
                }

                this.age=value;
            }
        }

        public Gender Sex
        {
            get
            {
                return this.sex;
            }

            private set
            {
                this.sex = value;
            }
        }

        public virtual string MakeSound()
        {
            return "animal sound";
        }

        public static IEnumerable<Tuple<string,double>> AverageAge(IEnumerable<Animal> animals)
        {
            var average = animals.GroupBy(x => x.GetType())
                 .Select(x => new Tuple<string, double>(x.Key.Name, x.Average(y => y.Age)));
            return average;
        }

        public override string ToString()
        {
            return string.Format("Hi! My name is {0} and I'm {1} years old, {2} and I often say \"{3}\"!", this.Name, this.Age, this.Sex.ToString().ToLower(), this.MakeSound());
        }
    }
}
