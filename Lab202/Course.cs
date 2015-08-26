using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab202
{
    class Course
    {
        private string _name;
        private string _courseId;
        private string _lecturer;
        private long _maxStudent;
        private long _numStudent;

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
                return _courseId;
            }
            set
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (value[i] < '0' || value[i] > '9')
                    {
                        Console.WriteLine("{0}:error try setting invalid CourseID!", this.CourseID);
                        break;
                    }
                }
                if (value.Length != 6)
                {
                    Console.WriteLine("{0}:error try setting invalid CourseID!", this.CourseID);
                }
                else
                {
                    _courseId = value;
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
                return _maxStudent;
            }
            set
            {
                if (value < 0 || value > 80 || value < this.NumStudents)
                {
                    Console.WriteLine("{0}:error try setting invalid Max No.Student!", this.CourseID);
                }
                else
                {
                    _maxStudent = value;
                }
            }
        }

        public long NumStudents
        {
            get
            {
                return _numStudent;
            }
            set
            {
                if (value < 0 || value > this.MaxStudents)
                {
                    Console.WriteLine("{0}:error try setting invalid No.Student!", this.CourseID);
                }
                else
                {
                    _numStudent = value;
                }
            }
        }

        public Course()
        {
            _name = "";
            _courseId = "";
            _lecturer = "staff";
            _maxStudent = 30;
            _numStudent = 0;
        }

        public Course(string name, string courseId)
        {
            _name = name;
            _courseId = courseId;
            _lecturer = "staff";
            _maxStudent = 30;
            _numStudent = 0;
        }

        public Course(string name, string courseId, string lecturer)
        {
            _name = name;
            _courseId = courseId;
            _lecturer = lecturer;
            _maxStudent = 30;
            _numStudent = 0;
        }

        public Course(string name, string courseId, string lecturer, int maxstudent)
        {
            _name = name;
            _courseId = courseId;
            _lecturer = lecturer;
            _maxStudent = maxstudent;
            _numStudent = 0;
        }

        public override string ToString()
        {
            return string.Format("[Course:{0}({1}),Lecturer= {2},has {3} student,max={4}]", _name, _courseId, _lecturer, _numStudent, _maxStudent);
        }
    }
}
