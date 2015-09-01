using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Course
    {
        private string name;
        private string courseID;
        private string lecturer;
        private int maxStudent;
        private int numStudent;


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
        public string CourselD
        {
            get
            {
                return courseID;
            }
            set
            {
                if (value.Length == 6) 
				{
					int x = 0;
					for (int i = 0; i < 6; i++) {
						if (char.IsDigit (value [i])) 
						{
							x = x++;

						}
					}
					if (x == 6) 
					{
						courseID = value;
					} else {
						Console.WriteLine ("{0}: error try setting invalid CourseID!", courseid);
				        	}
				    } 
                    else
                    {
                        Console.WriteLine(courseID + ": error try setting invalid CourseID!");
                    }
                }
            }
        }
    public Course()
        {
            lecturer = "staff";
            numStudent = 0;
            maxStudent = 30;
        }
        public Course(string name, string courseID)
        {
            this.name = name;
            this.courseID = courseID;
            lecturer = "staff";
            numStudent = 0;
            maxStudent = 30;
        }
        public Course(string name, string courseID, string lecturer)
        {
            this.name = name;
            this.courseID = courseID;
            this.lecturer = lecturer;
            numStudent = 0;
            maxStudent = 30;
        }
        public Course(string name, string courseID, string lecturer, int maxStudent)
        {
            this.name = name;
            this.courseID = courseID;
            this.lecturer = lecturer;
            this.maxStudent = maxStudent;
            numStudent = 0;
        }

        public string Lecturer
        {
            get
            {
                return lecturer;
            }
            set
            {
                lecturer = value;
            }
        }
        
        public int NumStudents
        {
            get
            {
                return numStudents;
            }
            set
            {
                if (value > this.maxStudents )
                {
                    Console.WriteLine(this.courseID + ": error try setting invalid No. Students!");
                }
                else
               {
                    numStudents = value;
                }
            }
        }
           
        public int  MaxStudents
        {
           
            get
            {
                return maxStudents;
            }
            set
            {
                if ( value < this.numStudents)
                {
                    Console.WriteLine(this.CourseID + ": error try setting invalid Max No. Students!");
                }
                else
                {
                    maxStudents = value;
                }
           }

        }
        public string Lecturer
       {
            get
            {
                return lecturer;
            }
            set
            {
                lecturer = value;
            }
        }
        
        public override string toString()
        {
             return "Course:"+ Name+  "(" + CourseID + "), Lecturer=" + Lecturer + " , has " + NumStudents + " students, max="+ MaxStudents;
        }
    }
}