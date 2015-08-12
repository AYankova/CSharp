namespace Students
{
    using System;

    public class Group
    {
        public int GroupNumber{get;private set;}
        public string Department{get;private set;}

        public Group (int number, string department)
        {
            this.GroupNumber = number;
            this.Department = department;
        }
    }
}
