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
        private String _Courseid;
        private String _Lecturer;
        private int _MaxStudents;
        private int _NumStudents;

        public bool ChkCourseid(String n)
        {
            for (int i = 0; i != n.Length; i++)
            {
                int tmp = n[i];
                if (tmp < 48 || tmp > 57)
                    return false;
            }
            if (n.Length != 6)
                return false;
            else
                return true;
        }

        public string n
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
        public String Courseid
        {
            get
            {
                return _Courseid;
            }
            set
            {
                if (!ChkCourseid(value))
                {
                    Console.WriteLine(_Courseid + ": error try setting invalid CourseID!");
                }
                else
                    _Courseid = value;
            }


        }
        public String lecturer
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
        public int MaxS
        {
            get
            {
                return _MaxStudents;
            }
            set
            {
                if (value < _NumStudents || value > 80)
                    Console.WriteLine(_Courseid + ": error try setting invalid Max No. Students!");
                else
                    _MaxStudents = value;
            }
        }
        public int NumS
        {
            get
            {
                return _NumStudents;
            }
            set
            {
                if (value < 0 || value > _MaxStudents)
                    Console.WriteLine(_Courseid + ": error try setting invalid No. Students!");
                else
                    _NumStudents = value;
            }
        }
        public override string ToString()
        {
            string s = "[Coruse:" + _Name + "(" + _Courseid + "),Lecturer=" + _Lecturer + ",has" + _NumStudents + " students,Max=" + _MaxStudents + "]";
            return s;
        }

        public Course()
        {
          
            _Name = "Unknown";
            _Courseid = "000000";
            _Lecturer = "staff";
            _MaxStudents = 30;
            _NumStudents = 0;
        }
        public Course(String Name)
        {
            _Name = Name;
            _Courseid = "000000";
            _Lecturer = "staff";
            _MaxStudents = 30;
            _NumStudents = 0;
        }
        public Course(String Name, String CourseID)
        {
            _Name = Name;
            _Courseid = CourseID;
            _Lecturer = "staff";
            _MaxStudents = 30;
            _NumStudents = 0;
        }
        public Course(String Name, String CourseID, String Lecturer)
        {
            _Name = Name;
            _Courseid = CourseID;
            _Lecturer = Lecturer;
            _MaxStudents = 30;
            _NumStudents = 0;
        }
        public Course(String Name, String CourseID, String Lecturer, int MaxStudents)
        {
            _Name = Name;
            _Courseid = CourseID;
            _Lecturer = Lecturer;
            _MaxStudents = MaxStudents;
            _NumStudents = 0;
        }
    }
}

