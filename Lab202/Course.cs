using System;
using Lab202;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab202
{
    class Course
    {
        private string _name;
        private string _courseID;
        private string _lecturer;
        private int _maxstudents;
        private int _numstudents;

        public Course()
        {
            _name = "-----";
            _courseID = "-----";
            _lecturer = "Staff";
            _maxstudents = 30;
            _numstudents = 0;
        }

        public Course(string n1,string c1)
        {
            _name = n1;
            _courseID = c1;
            _lecturer = "Staff";
            _maxstudents = 30;
            _numstudents = 0;
        }

        public Course(string n2, string c2,string l1)
        {
            _name = n2;
            _courseID = c2;
            _lecturer = l1;
            _maxstudents = 30;
            _numstudents = 0;
        }

        public Course(string n3, string c3,string l2,int m1)
        {
            _name = n3;
            _courseID = c3;
            _lecturer = l2;
            _maxstudents = m1;
            _numstudents = 0;
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string CourseID
        {
            get
            {
                return _courseID;
            }
            set
            {
                int n;
                if (value.Length == 6 && int.TryParse(value, out n)) {
                    _courseID = value;
                }                                   
                else
                   {
                    Console.WriteLine(CourseID + ": error try setting invalid CourseID!");
                  }
            }
        }

        public string Lecturer
        {
            get
            {
                return _lecturer;
            }
            set
            {
                _lecturer = value;
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
                if ( value >= 0 && value <= _maxstudents)
                {
                    _numstudents = value;
                }
                else
                { Console.WriteLine(_courseID + ": error try setting invalid No. Students!"); }
            }
        }

        public int MaxStudents
        {
            get
            {
                return _maxstudents;
            }
            set
            {
                if (value >= 0 && value <= 80 && value >= _numstudents)
                {
                    _maxstudents = value;
                }
                else
                { Console.WriteLine(_courseID + ": error try setting invalid Max No. Students!"); }
            }
        }

       
        public override string ToString()
        {
            return string.Format("[Course: {0} ({1}), Lecturer={2}, has {3} students, max={4}]", _name, _courseID, _lecturer, _numstudents, _maxstudents);
        }

}
}
