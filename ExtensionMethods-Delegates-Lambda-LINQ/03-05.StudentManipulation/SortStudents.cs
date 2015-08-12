namespace StudentManipulation
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class SortStudents
    {
        static void Main()
        {
            Student[] students=
            {
                 new Student("Ivan","Petrov", 24),
                 new Student("Ivan","Aleksandrow", 19),
                 new Student("Mariya","Petrova", 22),
                 new Student("Georgi","Pavlov", 29),
                 new Student("Valeri","Mihaylov", 17),
                 new Student("Daniel","Vachkov", 24),
            };

            Console.WriteLine("All students:");
            for (int i = 0; i < students.Length; i++)
			{
			 Console.WriteLine(students[i]);
			}

            Console.WriteLine();
            Console.WriteLine("First name before last name:");
            var result = FirstNameBeforeLast(students);

            foreach (var student in result)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();
            Console.WriteLine("Students with age in the range 18-24:");
            var res = AgeRangeBetween18And24(students);

            foreach (var student in res)
            {
                Console.WriteLine(student);
            }

            //Sort descending using OrderBy() and ThenBy()
            Console.WriteLine();
            Console.WriteLine("Sorted descending using Lambda expressions:");
            var sortLambda = students.OrderByDescending(st => st.FirstName).ThenByDescending(st => st.LastName);

            foreach (var student in sortLambda)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();
            Console.WriteLine("Sorted descending using LINQ");
            var sortedLinq = from st in students
                             orderby st.FirstName descending, st.LastName descending
                             select st;

            foreach (var student in sortedLinq)
            {
                Console.WriteLine(student);  
            }
        }

        public static IEnumerable<Student> FirstNameBeforeLast(Student[] students)
        {
            IEnumerable<Student> result = from student in students
                                          where student.FirstName.CompareTo(student.LastName) < 0
                                          select student;
            return result;
        }

        public static IEnumerable<Student> AgeRangeBetween18And24(Student[] students)
        {
            IEnumerable<Student> result = from student in students
                                          where student.Age >= 18 && student.Age <= 24
                                          select student;
            return result;
        }
    }
}
