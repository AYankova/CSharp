namespace _01.School
{
    using System;
    using System.Collections.Generic;

    public class Disciplines:ICommentable
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;
        private List<string> comments = new List<string>();

        public Disciplines(string name,int numberOfLectures,int numberOfExercises)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
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
                    throw new ArgumentException("The name of the discipline can't be null or empty!");
                }

                this.name=value;
            }
        }

        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Number of lectures can't be a negative number!");
                }

                this.numberOfLectures = value;
            }
        }

        public int NumberOfExercises
        {
            get
            {
                return this.numberOfExercises;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Number of exercises can't be a negative number!");
                }

                this.numberOfExercises = value;
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
            if (this.Comments.Count==0)
            {
                return "No comments yet"; 
            }
            return string.Join(", ",this.Comments).ToString();
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}", this.Name, this.GetAllComments());
        }
    }
}
