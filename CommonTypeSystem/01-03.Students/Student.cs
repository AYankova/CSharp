namespace _01_03.Students
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    public class Student : IComparable<Student>, ICloneable
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private uint ssn;
        private string address;
        private string phoneNumber;
        private string email;
        private uint course;
        private Specialty specialty;
        private University university;
        private Faculty faculty;

        public Student(string firstName, string middleName, string lastName, uint ssn, string address, string phoneNumber, string email, uint course, Specialty specialty, University university, Faculty faculty)
        {
            this.FirstName=firstName;
            this.MiddleName=middleName;
            this.LastName=lastName;
            this.SSN=ssn;
            this.Address=address;
            this.PhoneNumber=phoneNumber;
            this.Email=email;
            this.Course=course;
            this.Specialty=specialty;
            this.University=university;
            this.Faculty=faculty;
        }

        public Student(Student student)
        {
            this.FirstName=student.FirstName;
            this.MiddleName=student.MiddleName;
            this.LastName=student.LastName;
            this.SSN=student.SSN;
            this.Address=student.Address;
            this.PhoneNumber=student.PhoneNumber;
            this.Email=student.Email;
            this.Course=student.Course;
            this.Specialty=student.Specialty;
            this.University=student.University;
            this.Faculty=student.Faculty;
        }

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
                    throw new ArgumentNullException("First name can't be null or empty!");
                }

                if (value.Length < 2 || value.Length > 30)
                {
                    throw new ArgumentException("First name length is between 2 and 30 symbols!");
                }

                this.firstName = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return this.middleName;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Middle name can't be null or empty!");
                }

                if (value.Length < 2 || value.Length > 30)
                {
                    throw new ArgumentException("Middle name length is between 2 and 30 symbols!");
                }

                this.middleName = value;
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
                    throw new ArgumentNullException("Last name can't be null or empty!");
                }

                if (value.Length < 2 || value.Length > 30)
                {
                    throw new ArgumentException("Last name length is between 2 and 30 symbols!");
                }

                this.lastName = value;
            }
        }

        public uint SSN
        {
            get { return this.ssn; }
            private set { this.ssn = value; }
        }

        public string Address
        {
            get
            {
                return this.address;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Address field can't be null or empty!");
                }

                this.address = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Phone number cann't be null or empty!");
                }
                if (!Regex.IsMatch(value, @"(\+359[0-9]{9})") && !Regex.IsMatch(value, @"(0[0-9]{9})"))
                {
                    throw new ApplicationException("Telephones begin with +359 / 0 followed by 9 digits !");
                }
                this.phoneNumber = value;
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
                if (!Regex.IsMatch(value, @"\b[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,4}\b", RegexOptions.IgnoreCase))
                {
                    throw new ArgumentException("Invalid email!");
                }

                this.email = value;
            }
        }

        public uint Course
        {
            get
            {
                return this.course;
            }

            private set
            {
                if (value == 0 || value > 5)
                {
                    throw new ArgumentException("Course value is between 1 and 5 inclusively!");
                }

                this.course = value;
            }
        }

        public Specialty Specialty
        {
            get { return this.specialty; }
            private set { this.specialty = value; }
        }

        public University University
        {
            get { return this.university; }
            private set { this.university = value; }
        }

        public Faculty Faculty
        {
            get { return this.faculty; }
            private set { this.faculty = value; }
        }

        public override bool Equals(object obj)
        {
            var otherStudent = obj as Student;

            if (otherStudent == null)
            {
                return false; 
            }

            if (object.Equals(this.FirstName, otherStudent.FirstName) && object.Equals(this.MiddleName, otherStudent.MiddleName) && object.Equals(this.LastName, otherStudent.LastName))
            {
                if (this.SSN == otherStudent.SSN)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator==(Student first, Student second)
        {
            return Student.Equals(first, second);
        }

        public static bool operator!=(Student first, Student second)
        {
            return !(Student.Equals(first, second));
        }

        public override int GetHashCode()
        {
            int result = 0;
            foreach (var ch in this.FirstName + this.MiddleName + this.LastName)
            {
                result += (int)ch * 5 * this.SSN.GetHashCode();
            }

            return result;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Name: {0} {1} {2}\n", this.FirstName, this.MiddleName, this.LastName);
            sb.AppendLine("SSN: " + this.SSN);
            sb.AppendLine("Address: " + this.Address);
            sb.AppendLine("Phone number: " + this.PhoneNumber);
            sb.AppendLine("Email: " + this.Email);
            sb.AppendLine("Course: " + this.Course);
            sb.AppendLine("University: " + this.University);
            sb.AppendLine("Faculty: " + this.Faculty);
            sb.AppendLine("Specialty: " + this.Specialty);

            return sb.ToString();
        }

        public object Clone()
        {
            return new Student(this);
        }

        public int CompareTo(Student otherStudent)
        {
            var nameOfFirst = this.FirstName + this.MiddleName + this.LastName;
            var nameOfSecond = otherStudent.FirstName + otherStudent.MiddleName + otherStudent.LastName;

            if (nameOfFirst == nameOfSecond)
            {
                return this.SSN.CompareTo(otherStudent.SSN);
            }

            else return nameOfFirst.CompareTo(nameOfSecond);
        }
    }
}
