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
        private string _Name;
        private string _CourseID;
        private string _Lecturer;
        private int _MaxStd;
        private int _NumStd;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public string CourseID
              {
            get { return _CourseID; }
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
                    Console.WriteLine("{0}: error try setting invalid CourseID!",_CourseID);
                }
                else
                { _CourseID = value; }

            }
        }

        public string Lecturer
        {
            get { return _Lecturer; }
            set { _Lecturer = value; }
        }

        public int MaxStudents
        {
            get { return _MaxStd; }
            set {
                if ( value < 0 || value > 80 || value < this.NumStudents)
                    {
                    Console.WriteLine("{0}: error try setting invalid Max No. Students!", this.CourseID);
                    }
                else
                    {
                    _MaxStd = value;
                    }
                }
        }

        public int NumStudents
        {
            get { return _NumStd; }
            set
            {
                if (value < 0 || value > this.MaxStudents )
                {
                    Console.WriteLine("{0}: error try setting invalid No. Students!", this.CourseID);
                }
                else
                {
                    _NumStd = value;
                }
            }
        }

        public Course()
        {
            _Name = "Emty Class";
            _CourseID = "000000";
            _Lecturer = "staff";
            _MaxStd = 0;
            _NumStd = 30;
        }

        public Course(string inName, string inID)
        {
            _Name = inName;
            _CourseID = inID;
            _Lecturer = "staff";
            _MaxStd = 30;
            _NumStd = 0;
        }

        public Course(string inName, string inID, string inLecturer)
        {
            _Name = inName;
            _CourseID = inID;
            _Lecturer = inLecturer;
            _MaxStd = 30;
            _NumStd = 0;
        }

        public Course(string inName, string inID, string inLecturer, int inMax)
        {
            _Name = inName;
            _CourseID = inID;
            _Lecturer = inLecturer;
            _MaxStd = inMax;
            _NumStd = 0;
        }

        public override string ToString()
        {
            //[Course: Object-Oriented Programming (261300), Lecturer=staff, has 0 students, max=30]
            return string.Format("[Course:{0} ({1}), Lecturer={2}, has {3} student, max={4}]", _Name, _CourseID, _Lecturer,_NumStd, _MaxStd);

        }

    }
}
