namespace _01.School
{
    using System;
    using System.Collections.Generic;

    public abstract class People:ICommentable
    {
        private string name;
        private List<string> comments=new List<string>();

        public People(string name)
        {
            this.Name = name;
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
                   throw new ArgumentException("Name can't be null or empty!");
               }
            
               this.name = value;
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

        public override string ToString()
        {
            return string.Format("{0}", this.Name);
        }
    }
}
