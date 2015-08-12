namespace _03.AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class AnimalsTest
    {
        static void Main()
        {
            Dog dog = new Dog("Sharo", 2, Gender.Male);
            Console.WriteLine(dog);
            Frog frog = new Frog("Froggy", 1, Gender.Female);
            Console.WriteLine(frog);
            Tomcat tomcat = new Tomcat("Stalin", 5);
            Console.WriteLine(tomcat.Sex);
            Console.WriteLine(tomcat);
            Kitten kitty = new Kitten("Kitty", 3);
            Console.WriteLine(kitty.Sex);
            Console.WriteLine(kitty);

            Animal[] animals = new Animal[]
            {
                new Dog("Balkan",7,Gender.Male),
                new Dog("Ceaser",3,Gender.Male),
                new Dog("Chara",5,Gender.Female),
                new Cat("Lucky",4, Gender.Female),
                new Cat("Rijko",2,Gender.Male),
                new Cat("Sivcho",3,Gender.Male),
                new Frog("Sims",2, Gender.Male),
                new Frog("Jojo",6,Gender.Female),
                new Kitten("Djudji",6),
                new Kitten("Charlie",3),
                new Tomcat("Al Gor",5),
                new Tomcat ("Prince",8)
            };

            Console.WriteLine();
            Console.WriteLine("Average ages:");

            var averageAges=Animal.AverageAge(animals);

            foreach (var animalType in averageAges)
            {
                Console.WriteLine(animalType.Item1 +"-->"+ animalType.Item2);
            }
        }
    }
}
