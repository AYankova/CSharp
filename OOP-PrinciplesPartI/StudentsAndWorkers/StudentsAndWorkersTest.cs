namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StudentsAndWorkersTest
    {
        static void Main()
        {
            Student[] students = new Student[]
            {
                new Student("Ivan", "Petrov", 5.50),
                new Student("Alex", "Simeonov", 2.75),
                new Student("Iskra", "Radeva", 5.84),
                new Student("Dani", "Kostov", 6.00),
                new Student("Dimo", "Dimov", 2.25),
                new Student("Silviya", "Eneva", 4.33),
                new Student("Oleg", "Harizanov", 3.44),
                new Student("Nikolay", "Tzonkov", 2.87),
                new Student("Viki", "Nikolova", 4.92),
                new Student("Yanko", "Yankov", 5.12)
            };

            Worker[] workers = new Worker[]
           {
               new Worker("Bistra", "Pavlova", 258.25m, 10),
               new Worker("Veni", "Tasheva", 1020.80m, 8),
               new Worker("Daniel", "Elenov", 140.65m, 6),
               new Worker("Angel", "Angelov", 940.48m, 7),
               new Worker("Jivko", "Denchev", 680.58m, 9),
               new Worker("Rosi", "Yankova", 240m, 14),
               new Worker("Rumen", "Zaimov", 315.68m, 18),
               new Worker("Georgi", "Borukov", 110.80m, 2),
               new Worker("Oleg", "Pavlov", 500m, 5),
               new Worker("Vanya", "Vencheva", 190.38m, 12),
           };

            //sorting students by marks ascending using LINQ
            var sortStudents = from st in students
                               orderby st.Grade
                               select st;

            foreach (var st in sortStudents)
            {
                Console.WriteLine(st);
            }

            Console.WriteLine();

            //the same using extension methods
            var sortedStud = students.OrderBy(st => st.Grade);

            foreach (var st in sortedStud)
            {
                Console.WriteLine(st);
            }

            Console.WriteLine();
            //sorting workers by money per hour in descending order
            var sortWorkers = from wks in workers
                              orderby wks.MoneyPerHour() descending
                              select wks;

            foreach (var wrk in sortWorkers)
            {
                Console.WriteLine(wrk);
            }

            Console.WriteLine();
            //the same task using extension methods
            var sortedWorkers = workers.OrderByDescending(wrk => wrk.MoneyPerHour());

            foreach (var worker in sortedWorkers)
            {
                Console.WriteLine(worker);
            }

            Console.WriteLine();
            //merging the lists and sorting them by first name and last name
            var merged = students.Concat<Human>(workers).OrderBy(hm => hm.FirstName).ThenBy(hm => hm.LastName);
            
            foreach (var human in merged)
            {
                Console.WriteLine(human.FirstName +" "+ human.LastName);
            }
        }
    }
}
