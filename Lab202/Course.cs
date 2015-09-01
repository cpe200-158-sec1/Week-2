using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab202
{
    class Course
    {
        // Fields
        private string _name;
        private string _courseid;
        private string _lecturer;
        private int _maxstudents;
        private int _numstudents;

        // Constructors
        public Course()
        {
            Name = "No Name";
            CourseID = "000000";
            Lecturer = "staff";
            NumStudents = 0;
            MaxStudents = 30;
        }
        public Course(string pName, string pCourseID)
        {
            Name = pName;
            CourseID = pCourseID;
            Lecturer = "staff";
            NumStudents = 0;
            MaxStudents = 30;
        }
        public Course(string pName, string pCourseID, string pLecturer)
        {
            Name = pName;
            CourseID = pCourseID;
            Lecturer = pLecturer;
            NumStudents = 0;
            MaxStudents = 30;
        }
        public Course(string pName, string pCourseID, string pLecturer, int pMaxStudents)
        {
            Name = pName;
            CourseID = pCourseID;
            Lecturer = pLecturer;
            NumStudents = 0;
            MaxStudents = pMaxStudents;
        }

        // ToString method
        public override string ToString()
        {
            return string.Format("[Course: {0} ({1}), Lecturer={2}, has {3} students, max={4}]", Name, CourseID, Lecturer, NumStudents, MaxStudents);
        }

        // Properties
        public string Name
        {
            get;
            set;
        }
        public string CourseID
        {
            get
            {
                return _courseid;
            }
            set
            {
                int coursenumber;
                bool isNumeric = int.TryParse(value, out coursenumber);
                if (value.Length != 6 || !isNumeric)
                {
                    Console.WriteLine(CourseID + ": error try setting invalid CourseID!");
                }
                else
                {
                    _courseid = value;
                }
            }
        }
        public string Lecturer
        {
            get;
            set;
        }
        public int MaxStudents
        {
            get
            {
                return _maxstudents;
            }
            set
            {
                if (value < 0 || value > 80 || value < NumStudents)
                {
                    Console.WriteLine(CourseID + ": error try setting invalid Max No. Students!");
                }
                else
                {
                    _maxstudents = value;
                }
            }
        }
        public int NumStudents
        {
            get
            {
                return _numstudents;
            }
            set
            {
                if (value < 0 || value > MaxStudents)
                {
                    Console.WriteLine(CourseID + ": error try setting invalid No. Students!");
                }
                else
                {
                    _numstudents = value;
                }
            }
        }
    }
}
