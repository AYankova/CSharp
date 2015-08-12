namespace _18_19.StudentsByGroup
{
    using System;
    using System.Linq;
    using Students;
    using System.Collections.Generic; //from problem 09-16

    class StudentsByGroup
    {
        static void Main()
        {
            //problem 18-grouping students by group number using LINQ
            var groupedByGroupNumber = from st in Students.StudentsTest.students
                                       orderby st.GroupNumber
                                       group st by st.GroupNumber;

            List<string> res = new List<string>();

            foreach (var group in groupedByGroupNumber)
            {
                List<string> temp = new List<string>();
                foreach (var value in group)
                {
                    temp.Add(value.FirstName + " " + value.LastName);
                }

                res.Add("Group: " + group.Key + "\nStudents: " + string.Join(", ", temp));
            }

            Console.WriteLine("Using LINQ:");
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('-',80));
            //problem 19-the same as problem 18 but using extension methods
            var grouped = Students.StudentsTest.students.OrderBy(st=>st.GroupNumber).GroupBy(st => st.GroupNumber);
            List<string> result = new List<string>();

            foreach (var group in grouped)
            {
                List<string> temp = new List<string>();
                foreach (var value in group)
                {
                    temp.Add(value.FirstName + " " + value.LastName);
                }

                result.Add("Group: "+group.Key+"\nStudents: " +string.Join(", ", temp));
            }

            Console.WriteLine("Using extension methods:");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
