namespace Students
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class Student
    {
        private string firstName;
        private string lastName;
        private string facNumber;
        private string tel;
        private string email;
        private List<double> marks;
        private int groupNumber;

        public Student(string firstName, string lastName, string facNumber, string tel, string email, List<double> marks, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FacNumber = facNumber;
            this.Tel = tel;
            this.Email = email;
            this.Marks = new List<double>(marks);
            this.GroupNumber=groupNumber;
        }

        public Group Group { get; private set; }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First name can't be null or empty");
                }

                this.firstName = value;
            }
        }
            public string LastName
        {
            get
            {
                return this.lastName;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Last name can't be null or empty");
                }

                this.lastName = value;
            }
        }

            public string FacNumber
            {
                get
                {
                    return this.facNumber;
                }

                private set
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new ArgumentException("Faculty number can't be null or empty");
                    }

                    this.facNumber = value;
                }
            }
    
        public string Tel
            {
                get
                {
                    return this.tel;
                }

                private set
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new ArgumentNullException("Tel name can not be null or empty !");
                    }
                    if (!Regex.IsMatch(value, @"(\+359[0-9]{9})") && !Regex.IsMatch(value, @"(0[0-9]{9})"))
                    {
                        throw new ApplicationException("Telephones begin with +359 / 0 followed by 9 digits !");
                    }

                    this.tel = value;
                }
            }

        public string Email
        {
            get
            {
                return this.email;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Email can't be null or empty !");
                }
                if (!Regex.IsMatch(value, @"[\w., \-]{2,20}@[\w]{2,20}[.]{1}[\w.]{2,6}"))
                {
                    throw new ApplicationException("Not valid email!");
                }

                this.email = value;
            }
        }

         public List<double> Marks
        {
            get
            {
                return this.marks;
            }

            private set
            {
               this.marks = value;
            }
        }
 
            public int GroupNumber
            {
                get
                {
                    return this.groupNumber;
                }

                private set
                {
                    if (value < 0)
	                {
		            throw new ArgumentOutOfRangeException("Invalid group number!");
                    }

                    this.groupNumber=value;
                }
            }

            public override string ToString()
            {
                return string.Format("First name: {0}\nLast name: {1}\nFaculty number: {2}\n" +
                                 "Group number: {3}\nMarks: {4,2}\nPhone: {5}\nEmail: {6}\n",
                                  this.FirstName, this.LastName, this.FacNumber, this.GroupNumber,
                                  string.Join(", ", this.Marks), this.Tel, this.Email);;
            }
    }
}

