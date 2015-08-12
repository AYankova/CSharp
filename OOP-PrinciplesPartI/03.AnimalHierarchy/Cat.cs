namespace _03.AnimalHierarchy
{
    using System;

    public class Cat:Animal
    {
        public Cat(string name, int age, Gender sex):base(name,age,sex)
        {

        }

        public override string MakeSound()
        {
            return "meow";
        }
    }
}
