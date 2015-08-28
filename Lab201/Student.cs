using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Student
    {
        private string studentID;
        public string StudentID
        {
            get
            {
                return studentID;
            }
            set
            {
                studentID = value;
            }
        }
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }

        }
        public Student()
        {
            this.name = "John Doe";
            this.studentID = "Unknown";
            year_Birth = 1995;
            IsActive = false;
        }
        public Student(string name, string studentID)
        {
            this.name = name;
            this.studentID = studentID;
            year_Birth = 1995;
            IsActive = true;
        }
        public Student(string name, string studentID, int yearOfBirth)
        {
            this.name = name;
            this.studentID = studentID;
            this.year_Birth = year_Birth;
            IsActive = true;
        }
        public Student(string name, string studentID, int yearOfBirth, bool IsActive)
        {
            this.name = name;
            this.studentID = studentID;
            this.year_Birth = year_Birth;
            this.IsActive = IsActive;
        }

        private int year_Birth;
        public int Year_Birth
        {
            get
            {
                return year_Birth;
            }
            set
            {
                if (year_Birth < 1995 || year_Birth > 2000)
                {
                    Console.WriteLine(studentID + " : error  year-of-birth value");
                }
                year_Birth = Year_Birth;
            }
        }
        public int getAge()
        {
            return DateTime.Now.Year - year_Birth;
        }

        public Boolean isActive
        {
            get
            {
                return IsActive;
            }
            set
            {
                IsActive = value;
            }
        }

        private bool IsActive;
        public override string ToString()
        {
            if (IsActive == true)
            {
                return "[Student " + name + " (" + studentID + ")" + ", age=" + getAge() + " is active student]";
            }

            return "[Student " + name + " (" + studentID + ")" + ", age=" + getAge() + " is not active student]";
        }
    }
}