using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab202
{
    class Course
    {
        //Name, CourseID, Lecturer, MaxStudents, NumStudents
        private string _name;
        private string _courseid;
        private string _lecturer;
        private long _maxstudents;
        private long _numstudents;

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
                return _courseid;
            }
            set //CourseID(6-digit number only)
            {
                for( int i=0; i < value.Length; i++ )
                {
                    if ( value[i] < '0' || value[i] > '9' )
                    {
                        Console.WriteLine("{0}: error try setting invalid CourseID!",this.CourseID);
                        break;
                    }
                }
                if( value.Length != 6 )
                {
                    Console.WriteLine("{0}: error try setting invalid CourseID!", this.CourseID);
                }
                else
                {
                    _courseid = value;
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
        public long MaxStudents
        {
            get
            {
                return _maxstudents;
            }
            set //MaxStudents(0-80, and >= NumStudents)
            {
                if( value < 0 || value > 80 || value < this.NumStudents)
                {
                    Console.WriteLine("{0}: error try setting invalid Max No. Students!", this.CourseID);
                }
                else
                {
                    _maxstudents = value;
                }
            }
        }
        public long NumStudents
        {
            get
            {
                return _numstudents;
            }
            set //NumStudents(0-MaxStudents)
            {
                if( value < 0 || value > this.MaxStudents)
                {
                    Console.WriteLine("{0}: error try setting invalid No. Students!", this.CourseID);
                }
                else
                {
                    _numstudents = value;
                }
            }
        }

        public Course()
        {
            _name = "";
            _courseid = "";
            _lecturer = "staff";
            _maxstudents = 30;
            _numstudents = 0;
        }
        public Course(string name, string courseid)
        {
            _name = name;
            _courseid = courseid;
            _lecturer = "staff";
            _maxstudents = 30;
            _numstudents = 0;
        }
        public Course(string name, string coursei, string lecturer)
        {
            _name = name;
            _courseid = coursei;
            _lecturer = lecturer;
            _maxstudents = 30;
            _numstudents = 0;
        }
        public Course(string name, string coursei, string lecturer, long maxstudents)
        {
            _name = name;
            _courseid = coursei;
            _lecturer = lecturer;
            _maxstudents = maxstudents;
            _numstudents = 0;
        }

        public override string ToString()
        {
            return string.Format("[Course: {0} ({1}), Lecturer={2}, has {3} students, max={4}]", _name, _courseid, _lecturer, _numstudents, _maxstudents);
        }

    }
}
