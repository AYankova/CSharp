namespace _01_03.Students
{
    using System;

    class StudentsTest
    {
        static void Main()
        {
            Student pesho = new Student("Pesho", "Peshev", "Peshev", 10025030, "Mladost 1", "+359888777222", "peshev@abv.bg", 2, Specialty.Engineering, University.TU, Faculty.FEn);

            Student gosho = new Student("Gosho", "Goshev", "Goshev", 10030020, "Druzhba 2", "0888500300", "gosho@mail.bg", 3, Specialty.Informatics, University.SofiaUniversity, Faculty.FI);

            Console.WriteLine(new string('-',50));
            Console.WriteLine("Getting hashcodes: ");
            Console.WriteLine(pesho.GetHashCode());
            Console.WriteLine(gosho.GetHashCode());
            Console.WriteLine(new string('-', 50));
            Console.WriteLine(pesho);
            Console.WriteLine(gosho);
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Is pesho equal to gosho?");
            Console.WriteLine(pesho.Equals(gosho));
            Console.WriteLine(pesho==gosho);
            Console.WriteLine("Is pesho different from gosho?");
            Console.WriteLine(pesho!=gosho);
            Console.WriteLine(new string('-', 50));

            Student pesho1 = pesho.Clone() as Student;
            Console.WriteLine(pesho1);
            Console.WriteLine(new string('-', 50));
            Console.WriteLine(pesho.CompareTo(gosho));
            Console.WriteLine(gosho.CompareTo(pesho));
            Console.WriteLine(pesho.CompareTo(pesho1));
        }
    }
}
