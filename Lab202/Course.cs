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
        private string _courseID;
        private string _lecturer;
        private int _maxStudents;
        private int _numStudents;

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
                int i = 0;
                while (i < value.Length)
                {
                    if (value[i] < 48 || value[i] > 57)
                    {
                        Console.WriteLine("{0}: error try setting invalid CourseID!", this.CourseID);
                        break;
                    }
                    i++;
                }
                if (value.Length != 6)
                {
                    Console.WriteLine("{0}: error try setting invalid CourseID!", this.CourseID);
                }
                else
                {
                    _courseID = value;
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
                return _numStudents;
            }
            set
            {
                if (value < 0 || value > this.MaxStudents)
                {
                    Console.WriteLine("{0}: error try setting invalid No. Students!", this.CourseID);
                }
                else
                {
                    _numStudents = value;
                }
            }
        }
        public int MaxStudents
        {
            get
            {
                return _maxStudents;
            }
            set
            {
                if (value < 0 || value > 80 || value < this.NumStudents)
                {
                    Console.WriteLine("{0}: error try setting invalid Max No. Students!", this.CourseID);
                }
                else
                {
                    _maxStudents = value;
                }
            }
        }

        public Course()
        {
            _name = "";
            _courseID = "";
            _lecturer = "staff";
            _numStudents = 0;
            _maxStudents = 30;
        }
        public Course(string Nameinput, string CourseID)
        {
            _name = Nameinput;
            _courseID = CourseID;
            _lecturer = "staff";
            _numStudents = 0;
            _maxStudents = 30;
        }
        public Course(string Nameinput, string CourseID, string Lecturerinput)
        {
            _name = Nameinput;
            _courseID = CourseID;
            _lecturer = Lecturerinput;
            _numStudents = 0;
            _maxStudents = 30;
        }
        public Course(string Nameinput, string CourseID, string Lecturerinput, int MaxStudentsinput)
        {
            _name = Nameinput;
            _courseID = CourseID;
            _lecturer = Lecturerinput;
            _numStudents = 0;
            _maxStudents = MaxStudentsinput;
        }
        public override string ToString()
        {
            return string.Format("[Course: {0} ({1}), Lecturer={2}, has {3} students, max={4}]", _name, _courseID, _lecturer, _numStudents, _maxStudents);
        }
    }
}
