namespace _03.AnimalHierarchy
{
    using System;

    public class Frog:Animal
    {
        public Frog(string name, int age, Gender sex):base(name,age,sex)
        {

        }

        public override string MakeSound()
        {
            return "ribbit";
        }
    }
}
