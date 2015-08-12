namespace _01.School
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class School
    {
        private string name;
        private List<ClassesOfStudents> classesOfStudents;

        public School(string name, params ClassesOfStudents[] classes)
        {
            this.Name = name;
            this.classesOfStudents = new List<ClassesOfStudents>();
            this.classesOfStudents.AddRange(classes);
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("School name can't be null or empty!");
                }

                this.name = value;
            }
        }

        public List<ClassesOfStudents> GetAllClasses()
        {
            return new List<ClassesOfStudents>(this.classesOfStudents);
        }

        public void AddClass(ClassesOfStudents cls)
        {
            this.classesOfStudents.Add(cls);
        }

        public void RemoveClass(ClassesOfStudents cls)
        {
            this.classesOfStudents.Remove(cls);
        }

        public string GetAllTeachers()
        {
            var sb = new StringBuilder(this.Name + "'s teachers:\n\n");

            foreach (var cls in this.classesOfStudents)
            {
                foreach (var teacher in cls.GetAllTeachers())
                {
                    sb.AppendLine(teacher.ToString());
                }
            }

            return sb.ToString().TrimEnd();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("School: " + this.Name);
            sb.AppendLine();

            foreach (var classes in this.classesOfStudents)
            {
                sb.AppendLine(classes.ToString().TrimEnd());
            }

            return sb.ToString();
        }
    }
}
