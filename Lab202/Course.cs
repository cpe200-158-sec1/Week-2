using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab202
{
    class Course
    {
        private String _Name;
        private String _CourseID;
        private String _Lecturer;
        private int _MaxStudents;
        private int _NumStudents;

        public override string ToString()
        {
            String s = "[Course: " + _Name + " (" + _CourseID + "), Lecturer=" + _Lecturer + ", has " + _NumStudents + " students, max=" + _MaxStudents +"]";
            return s;
        }
        public Course()
        {
            _Name = "Unknown";
            _CourseID = "000000";
            _Lecturer = "staff";
            _MaxStudents = 30;
            _NumStudents = 0;
        }
        public Course(String Name)
        {
            _Name = Name;
            _CourseID = "000000";
            _Lecturer = "staff";
            _MaxStudents = 30;
            _NumStudents = 0;
        }
        public Course(String Name, String CourseID)
        {
            _Name = Name;
            _CourseID = CourseID;
            _Lecturer = "staff";
            _MaxStudents = 30;
            _NumStudents = 0;
        }
        public Course(String Name, String CourseID, String Lecturer)
        {
            _Name = Name;
            _CourseID = CourseID;
            _Lecturer = Lecturer;
            _MaxStudents = 30;
            _NumStudents = 0;
        }
        public Course(String Name, String CourseID, String Lecturer, int MaxStudents)
        {
            _Name = Name;
            _CourseID = CourseID;
            _Lecturer = Lecturer;
            _MaxStudents = MaxStudents;
            _NumStudents = 0;
        }
        public String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                    _Name = value;
            }
        }
        public String CourseID
        {
            get
            {
                return _CourseID;
            } 
            set
            {
                if (!ChkCourseID(value))
                    Console.WriteLine(_CourseID + ": error try setting invalid CourseID!");

                else
                    _CourseID = value;
            }
        }
        public String Lecturer
        {
            get
            {
                return _Lecturer;
            }
            set
            {
                _Lecturer = value;
            }
        }
        public int MaxStudents
        {
            get
            {
                return _MaxStudents;
            }
            set
            {
                if (value < _NumStudents || value > 80)
                    Console.WriteLine(_CourseID + ": error try setting invalid Max No. Students!");
                else
                _MaxStudents = value;
            }
        }
        public int NumStudents
        {
            get
            {
                return _NumStudents;
            }
            set
            {
                if (value < 0 || value > _MaxStudents)
                    Console.WriteLine(_CourseID + ": error try setting invalid No. Students!");
                else
                    _NumStudents = value;
            }
        }
        public bool ChkCourseID(String Name)
        {
            for (int i = 0; i != Name.Length; i++)
            {
                int tmp = Name[i];
                if (tmp < 48 || tmp > 57)
                    return false;
            }
            if (Name.Length != 6)
                return false;
            else
                return true;
        }
    }
}
