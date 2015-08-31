using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab202;


namespace Lab202
{
    class Course
    {
        private string _Name;
        private string _CourseID;
        private string _Lecturer;
        private int _MaxStudents;
        private int _NumStudents;


        public Course()
        {
            _Name = "Unknown";
            _CourseID = " xoxoxo ";
            _Lecturer = "Staff";
            _MaxStudents = 30;
            _NumStudents = 0;
        }

        public Course(string name, string CID)
        {
            _Name = name;
            _CourseID = CID;
            _Lecturer = "Staff";
            _MaxStudents = 30;
            _NumStudents = 0;
        }


        public Course(string name, string CID,string lect)
        {
            _Name = name;
            _CourseID = CID;
            _Lecturer = lect;
            _MaxStudents = 30;
            _NumStudents = 0;
        }

        public Course(string name, string CID, string lect,int max)
        {
            _Name = name;
            _CourseID = CID;
            _Lecturer = lect;
            _MaxStudents = max;
            _NumStudents = 0;
        }

        public string Name
        {
            get
            { return _Name; }
            set
            { _Name = value; }
        }

        public string CourseID
        {
            get
            { return _CourseID; }
            set
            {
                int x;
                    if (value.Length == 6 && int.TryParse(value, out x))
                        _CourseID = value;
                    else
                    {
                        Console.WriteLine(CourseID + ": error try setting invalid CourseID!");
                    }
             }
        }

        public string Lecturer
        {
            get
            { return _Lecturer; }
            set
            { _Lecturer = value; }
        }

        public int MaxStudents
        {
            get
            { return _MaxStudents; }
            set
            {
                if (value >= 0 && value <= 80 && value >= _NumStudents )
                {
                    _MaxStudents = value;
                }
                else
                {
                    Console.WriteLine(_CourseID + ": error try setting invalid Max No. Students!");
                }
            }
        }

        public int NumStudents
        {
            get
            { return _NumStudents; }
            set
            {
                if (value >= 0 && value <= _MaxStudents)
                {
                    _NumStudents = value;
                }
                else
                {
                    Console.WriteLine(_CourseID + ":error try setting invalid No.Students!");
                }
            }
        }

        public override string ToString()
        {
            return string.Format("[Course: {0} ({1}), Lecturer={2}, has {3} students, max={4}]", _Name, _CourseID, _Lecturer, _NumStudents, _MaxStudents);
        }

    }
}
