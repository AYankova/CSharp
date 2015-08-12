namespace _01.School
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ClassesOfStudents:ICommentable
    {
        private string nameOfCourse;
        private List<Teachers> teachers;
        private List<string> comments=new List<string>();

        public ClassesOfStudents(string nameOfCourse, params Teachers[] teachers)
        {
            this.NameOfCourse=nameOfCourse;
            this.teachers=new List<Teachers>();
            this.teachers.AddRange(teachers);
        }

        public string NameOfCourse
        {
            get
            {
                return this.nameOfCourse;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Course name can't be null or empty!");
                }

                this.nameOfCourse = value;
            }
        }

        public List<string> Comments
        {
            get
            {
                return this.comments;
            }

            private set
            {
               this.comments = value;
            }
        }

         public void AddComment(string comment)
        {
            if (this.Comments.Count==0)
            {
                this.Comments = new List<string>();
            }

            this.Comments.Add(comment);
        }

        public void RemoveCommentAtIndex(int index)
        {
            if (index < 0 || index > this.Comments.Count)
            {
                throw new IndexOutOfRangeException("Index is outside the boundaries of the comments list!");
            }

            this.Comments.RemoveAt(index);
        }

        public string GetCommentAtIndex(int index)
        {

            if (index < 0 || index > this.Comments.Count)
            {
                throw new IndexOutOfRangeException("Index is outside the boundaries of the comments list!");
            }

            return this.Comments[index];
        }

        public string GetAllComments()
        {
            if (this.Comments.Count == 0)
            {
                return "No comments yet";
            }

            return string.Join(", ",this.Comments).ToString();
        }

        public void AddTeacher(Teachers teacher)
        {
            this.teachers.Add(teacher);
        }

        public void RemoveTeacher(Teachers teacher)
        {
            this.teachers.Remove(teacher);
        }

        public List<Teachers> GetAllTeachers()
        {
            return new List<Teachers>(this.teachers);
        }

        public string GetTeachersFromCourse()
        {
            StringBuilder  sb=new StringBuilder();
            sb.AppendLine("Teachers:");
            sb.AppendLine(string.Join("\n",this.teachers));

            return sb.ToString();
        }

        public override string ToString()
        {
            return string.Format("Class: {0} \n{1}",this.NameOfCourse,this.GetTeachersFromCourse());
        }
    }
}
