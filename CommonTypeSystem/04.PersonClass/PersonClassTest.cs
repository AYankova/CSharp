namespace _04.PersonClass
{
    using System;

    class PersonClassTest
    {
        static void Main()
        {
            var pesho = new Person("Pesho");
            var gosho = new Person("Gosho", 22);

            Console.WriteLine(pesho);
            Console.WriteLine(gosho);
        }
    }
}
