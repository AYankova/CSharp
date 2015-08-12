namespace Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StudentsTest
    {
        public static List<Student> students = new List<Student>()
        {
            new Student("Andrey", "Slabakov", "PA184021","+359888111222", "andrey@abv.bg",new List<double>{2.5, 6, 3, 4, 6, 2}, 2),
            new Student("Aleksi", "Sokachev", "111558064", "0888222333", "aleksi@abv.bg",new List<double>{2, 3, 4, 2}, 1),
            new Student("Miguel", "DeServantes", "504806622","0288111333", "miguel@abv.bg", new List<double>{6, 6, 6, 6, 6}, 3),
            new Student("Kamelia", "Todorova", "EM1112250","+359888359359", "kamelia@mail.bg",new List<double>{5, 5, 3.5, 4.5, 6}, 2),
            new Student("Sashka", "Vaseva", "111555222","0888888888", "sashka@gbg.bg",new List<double>{2.5, 2, 2, 2, 2},3),
            new Student("Veselin", "Marinov", "MA115533","+359288666541", "vesko@mail.bg", new List<double>{4, 4.2, 5.5, 6, 6, 3.4}, 1),
            new Student("Zlatka", "Dimitrova", "123406789","0888444111", "zlati@abv.bg", new List<double>{2, 3, 3, 3.3, 4, 2}, 2)
        };

        static void Main()
        {
            //task 9-select the students that are from group 2 and order them by first name
            Console.WriteLine("Task 9");
            var resTaskNine = from st in students
                              where st.GroupNumber == 2
                              orderby st.FirstName
                              select st;
            Print(resTaskNine);

            //task 10-the same task as 9 but using extension methods
            Console.WriteLine("Task 10");
            var resTaskTen = students.Where(st => st.GroupNumber == 2).OrderBy(st => st.FirstName);
            Print(resTaskTen);

            //task11-extract students that have email in abv.bg
            Console.WriteLine("Task 11");
            var resTaskEleven = from st in students
                                where st.Email.Contains("@abv.bg")
                                select st;
            Print(resTaskEleven);
            
            //task 12-extract students with phones in Sofia
            Console.WriteLine("Task 12");
            var resTaskTwelve = from st in students
                                where st.Tel.StartsWith("02") || st.Tel.StartsWith("+3592")
                                select st;
            Print(resTaskTwelve);

            //task 13-students with at least one excellent mark
            Console.WriteLine("Task 13");
            var resTaskThirdteen=from st in students
                                where st.Marks.Contains(6)
                                select new 
                                { FullName=st.FirstName+" "+st.LastName,
                                  MarksList=st.Marks
                                };
            foreach (var student in resTaskThirdteen)
            {
                Console.WriteLine("Full name: {0}",student.FullName);
                Console.WriteLine("Marks: {0}",string.Join(", ",student.MarksList));
            }

            Console.WriteLine();

            //task 14-students with exactly two marks 2
            Console.WriteLine("Task 14");
            var resTaskFourthteen = students.Where(st => st.Marks.FindAll(m => m == 2).Count == 2).
                                           Select(st => new
                                           {
                                               FullName = st.FirstName + " " + st.LastName,
                                               MarksList = st.Marks
                                           });

            foreach (var student in resTaskFourthteen)
            {
                Console.WriteLine("Full name: {0}", student.FullName);
                Console.WriteLine("Marks: {0}", string.Join(", ", student.MarksList));
            }

            Console.WriteLine();

            //task 15-students that enrolled in 2006   
            Console.WriteLine("Task 15");
            var resTaskFifteen = students.Where(st => st.FacNumber.ElementAt(4) == '0' && st.FacNumber.ElementAt(5) == '6');
            var allMarksFrom2006 = new List<double>();

            foreach (var student in resTaskFifteen)
            {
                allMarksFrom2006.AddRange(student.Marks);
            }
            Console.WriteLine(string.Join(", ", allMarksFrom2006));

            Console.WriteLine();
            //task 16-extract all students from Mathematics department
            List<Group> groups = new List<Group>()
            {
                new Group(1,"Mathematics"),
                new Group (2, "Physics"),
                new Group(3,"History")
            };
            var resTaskSixteen = students.Join(groups, st => st.GroupNumber, gr => gr.GroupNumber, (st, gr) => new
                   {
                       Student = st.FirstName + " " + st.LastName,
                       Group = gr.GroupNumber,
                   })
                   .Where(x => x.Group.Equals(1));
                ;

            Console.WriteLine("Task 16");
            foreach (var student in resTaskSixteen)
            {
                Console.WriteLine(student);
            }

        }

        public static void Print(IEnumerable<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
