namespace _01.School
{
    using System;
    using System.Collections.Generic;

    class SchoolTest
    {
        static void Main()
        {
            var students = new List<Student>()
            {
                new Student("Ivan Petrov",5),
                new Student ("Alex Georgiev",1),
                new Student ("Dimo petrov",4)
            };

            var disciplines = new List<Disciplines>()
            {
                new Disciplines("Mathematics",12,14),
                new Disciplines("History", 10, 10),
                new Disciplines("Art",3,5)
            };

            var teachers = new List<Teachers>
            {
                new Teachers("First Teacher"),
                new Teachers("Second Teacher",new Disciplines[]{disciplines[0],disciplines[1]}),
                new Teachers("Third Teacher",new Disciplines[]{new Disciplines("Music",7,12)}),
            };

            var classes = new ClassesOfStudents[]
            {
                new ClassesOfStudents("class 11A",teachers[0]),
                new ClassesOfStudents("class 11B",new Teachers[]{teachers[1],teachers[2],(new Teachers("Fourth teacher",new Disciplines[]{(new Disciplines("Music",3,5))}))})
            };

            School[] schools = new School[]
                {
                    new School("NPMG",classes),
                    new School("Telerik academy",new ClassesOfStudents[]{new ClassesOfStudents("Ninja class",new Teachers[]{new Teachers("Ivo Kenov",new Disciplines[]{new Disciplines("ASP.NET",40,50)}),new Teachers("Niki Kostov",new Disciplines[]{new Disciplines("Quality Programming Code",40,50)}),new Teachers("Doncho Minkov",new Disciplines[]{new Disciplines("CSS",40,60)})})})
                };

            teachers[0].AddComment("Ïs on vacation for the next two weeks");
            teachers[1].AddComment("Very experienced teacher");
            teachers[1].AddComment("PhD in mathematics");

            Console.WriteLine(new string('-', 50));
            Console.WriteLine("All comments about second teacher:");
            Console.WriteLine(teachers[1].GetAllComments());
            Console.WriteLine("All comments about third teacher:");
            Console.WriteLine(teachers[2].GetAllComments());

            Console.WriteLine(new string('-',50));
            teachers[2].AddComment("Good professional");
            foreach (var teacher in teachers)
            {
                Console.WriteLine("Teacher:{0} \nComments:{1}",teacher.Name,teacher.GetAllComments());
            }
            Console.WriteLine(new string('-', 50));

            teachers[0].AddDiscipline(new Disciplines("Programming", 20, 50));
            teachers[2].AddDiscipline(disciplines[2]);
            disciplines[0].AddComment("Studying linear equations");
            disciplines[2].AddComment("Studying Postimpresionism");

            foreach (var dis in disciplines)
            {
                Console.WriteLine(dis);
            }

            Console.WriteLine(new string('-', 50));

            var teacherOneTaughtDisc=teachers[1].AllTaughtDisciplines;
            Console.WriteLine("First teacher teaches in:");
            Console.WriteLine(string.Join(", ",teacherOneTaughtDisc));

            Console.WriteLine(new string('-', 50));

            foreach (var teacher in teachers)
            {
                Console.WriteLine(teacher);
            }

            Console.WriteLine(new string('-', 50));

            foreach (var st in students)
            {
                Console.WriteLine(st);
            }

            Console.WriteLine(new string('-', 50));

            foreach (var cls in classes)
            {
                Console.WriteLine(cls.NameOfCourse);
            }

            Console.WriteLine(new string('-', 50));

            foreach (var school in schools)
            {
                Console.WriteLine(school);
            }

            Console.WriteLine(new string('-', 50));
            Console.WriteLine(schools[0].GetAllTeachers());
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Get all courses in Telerik academy:\n");
            Console.Write(string.Join("\n\n",schools[1].GetAllClasses()));
            Console.WriteLine(new string('-', 50));
        }
    }
}
